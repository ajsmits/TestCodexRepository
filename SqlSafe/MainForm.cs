using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SqlSafe
{
    public partial class MainForm : Form
    {
        private readonly string _companyConnectionString;
        private readonly bool _allowProductionRun;
        private IReadOnlyList<Company> _companies = Array.Empty<Company>();

        public MainForm(string companyConnectionString)
        {
            _companyConnectionString = companyConnectionString;
            _allowProductionRun = ReadAllowProductionRunSetting();
            InitializeComponent();
            comboBoxEnvironment.SelectedIndexChanged += ComboBoxEnvironment_SelectedIndexChanged;
            textBoxSql.TextChanged += TextBoxSql_TextChanged;
            treeViewCategories.AfterCheck += TreeViewCategories_AfterCheck;
            treeViewCategories.NodeMouseClick += TreeViewCategories_NodeMouseClick;
            buttonSelectAll.Click += (_, _) => SetAllNodesChecked(true);
            buttonDeselectAll.Click += (_, _) => SetAllNodesChecked(false);
            buttonRun.Click += async (_, _) => await HandleRunClickAsync();
            buttonClear.Click += (_, _) => HandleClearClick();
            contextMenuTree.Opening += ContextMenuTree_Opening;
            toolStripMenuItemSelectServer.Click += (_, _) => SetSelectedServerChecked(true);
            toolStripMenuItemDeselectServer.Click += (_, _) => SetSelectedServerChecked(false);
            comboBoxBatchSelect.SelectedIndexChanged += ComboBoxBatchSelect_SelectedIndexChanged;
            buttonRefreshBatches.Click += async (_, _) => await RefreshBatchesAsync();
            Load += async (_, _) => await InitializeDataAsync();
            comboBoxEnvironment.SelectedIndex = 0;
            UpdateRunButtonState();
        }

        private static bool ReadAllowProductionRunSetting()
        {
            var settingValue = ConfigurationManager.AppSettings["AllowProductionRun"];
            return bool.TryParse(settingValue, out var allowProduction) && allowProduction;
        }

        private static readonly string[] BannedWords = new[] { "drop", "truncate", "delete", "alter", "update", "insert" };
        private bool _isUpdatingChecks;
        private bool _isLoadingBatches;

        /// <summary>
        /// Populates the tree view with SQL servers and databases derived from loaded companies.
        /// </summary>
        private void PopulateTreeView()
        {
            treeViewCategories.BeginUpdate();
            treeViewCategories.Nodes.Clear();

            foreach (var server in GetEnvironmentServers())
            {
                var serverNode = new TreeNode(server.ServerName);
                foreach (var database in server.Databases)
                {
                    var databaseNode = new TreeNode(database.Name)
                    {
                        Tag = database.ConnectionString
                    };

                    serverNode.Nodes.Add(databaseNode);
                }

                treeViewCategories.Nodes.Add(serverNode);
            }

            treeViewCategories.ExpandAll();
            treeViewCategories.EndUpdate();
        }

        private void TreeViewCategories_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (_isUpdatingChecks)
            {
                return;
            }

            _isUpdatingChecks = true;
            try
            {
                SetChildrenChecked(e.Node, e.Node.Checked);
                UpdateParentCheckState(e.Node.Parent);
            }
            finally
            {
                _isUpdatingChecks = false;
            }
        }

        private void ComboBoxEnvironment_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateTreeView();
            UpdateRunButtonState();
        }

        private void TextBoxSql_TextChanged(object sender, EventArgs e)
        {
            var bannedWord = FindBannedWord(textBoxSql.Text);
            if (bannedWord is not null)
            {
                labelWarning.Text = $"Banned word detected: {bannedWord.ToUpperInvariant()}";
                labelWarning.Visible = true;
            }
            else
            {
                labelWarning.Visible = false;
                labelWarning.Text = string.Empty;
            }
        }

        private async void ComboBoxBatchSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoadingBatches)
            {
                return;
            }

            if (comboBoxBatchSelect.SelectedItem is int batchNumber)
            {
                await LoadLogsForBatchAsync(batchNumber).ConfigureAwait(false);
            }
            else
            {
                dataGridViewLogs.DataSource = null;
            }
        }

        private async Task LoadCompaniesAsync()
        {
            try
            {
                _companies = await Company.GetCompaniesAsync(_companyConnectionString);
                PopulateTreeView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load companies: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task InitializeDataAsync()
        {
            await LoadCompaniesAsync();
            await RefreshBatchesAsync();
        }

        private async Task RefreshBatchesAsync()
        {
            _isLoadingBatches = true;
            try
            {
                var batches = (await LogEntry.GetBatchNumbersAsync().ConfigureAwait(false)).ToList();
                comboBoxBatchSelect.DataSource = batches;
            }
            catch (Exception ex)
            {
                comboBoxBatchSelect.DataSource = null;
                dataGridViewLogs.DataSource = null;
                MessageBox.Show($"Failed to load batches: {ex.Message}", "Logs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                _isLoadingBatches = false;
            }

            if (comboBoxBatchSelect.SelectedItem is int batchNumber)
            {
                await LoadLogsForBatchAsync(batchNumber).ConfigureAwait(false);
            }
            else
            {
                dataGridViewLogs.DataSource = null;
            }
        }

        private async Task LoadLogsForBatchAsync(int batchNumber)
        {
            try
            {
                var entries = (await LogEntry.GetByBatchAsync(batchNumber).ConfigureAwait(false)).ToList();
                if (dataGridViewLogs.InvokeRequired)
                {
                    dataGridViewLogs.Invoke(new Action(() => dataGridViewLogs.DataSource = entries));
                }
                else
                {
                    dataGridViewLogs.DataSource = entries;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load logs for batch {batchNumber}: {ex.Message}", "Logs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private IEnumerable<SqlServerNode> GetEnvironmentServers()
        {
            var environment = comboBoxEnvironment.SelectedItem as string ?? "UAT";

            return BuildServersFromCompanies(_companies, environment).ToArray();
        }

        private static IEnumerable<SqlServerNode> BuildServersFromCompanies(IEnumerable<Company> companies, string environment)
        {
            var isUat = environment.Equals("UAT", StringComparison.OrdinalIgnoreCase);
            var serverLookup = new Dictionary<string, Dictionary<string, string>>(StringComparer.OrdinalIgnoreCase);

            foreach (var company in companies)
            {
                var connectionString = isUat ? company.ConnectionString_UAT : company.ConnectionString_Live;
                if (string.IsNullOrWhiteSpace(connectionString))
                {
                    continue;
                }

                try
                {
                    var builder = new SqlConnectionStringBuilder(connectionString);
                    var server = builder.DataSource;
                    var database = builder.InitialCatalog;

                    if (string.IsNullOrWhiteSpace(server) || string.IsNullOrWhiteSpace(database))
                    {
                        continue;
                    }

                    if (!serverLookup.TryGetValue(server, out var databases))
                    {
                        databases = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                        serverLookup[server] = databases;
                    }

                    if (!databases.ContainsKey(database))
                    {
                        databases[database] = builder.ConnectionString;
                    }
                }
                catch (ArgumentException)
                {
                    // Ignore invalid connection strings while compiling tree nodes.
                }
            }

            foreach (var kvp in serverLookup.OrderBy(pair => pair.Key, StringComparer.OrdinalIgnoreCase))
            {
                var databases = kvp.Value
                    .OrderBy(pair => pair.Key, StringComparer.OrdinalIgnoreCase)
                    .Select(pair => new DatabaseNode(pair.Key, pair.Value))
                    .ToList();

                yield return new SqlServerNode(kvp.Key, databases);
            }
        }

        private static string? FindBannedWord(string text)
        {
            foreach (var word in BannedWords)
            {
                if (Regex.IsMatch(text, $"\\b{Regex.Escape(word)}\\b", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant))
                {
                    return word;
                }
            }

            return null;
        }

        private void SetAllNodesChecked(bool isChecked)
        {
            _isUpdatingChecks = true;
            try
            {
                SetNodesChecked(treeViewCategories.Nodes, isChecked);
            }
            finally
            {
                _isUpdatingChecks = false;
            }
        }

        private void SetSelectedServerChecked(bool isChecked)
        {
            if (treeViewCategories.SelectedNode is null || treeViewCategories.SelectedNode.Parent is not null)
            {
                return;
            }

            _isUpdatingChecks = true;
            try
            {
                treeViewCategories.SelectedNode.Checked = isChecked;
                SetChildrenChecked(treeViewCategories.SelectedNode, isChecked);
            }
            finally
            {
                _isUpdatingChecks = false;
            }
        }

        private void SetNodesChecked(TreeNodeCollection nodes, bool isChecked)
        {
            foreach (TreeNode node in nodes)
            {
                node.Checked = isChecked;
                SetChildrenChecked(node, isChecked);
            }
        }

        private async Task HandleRunClickAsync()
        {
            var environment = comboBoxEnvironment.SelectedItem as string ?? "UAT";
            if (environment.Equals("Production", StringComparison.OrdinalIgnoreCase) && !_allowProductionRun)
            {
                MessageBox.Show("Running against Production is disabled by configuration.", "Run", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var script = textBoxSql.Text;
            if (string.IsNullOrWhiteSpace(script))
            {
                MessageBox.Show("SQL script is empty.", "Run", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var targets = GetSelectedDatabaseTargets();
            var selectedCount = targets.Count;

            if (selectedCount == 0)
            {
                MessageBox.Show("No databases are selected.", "Run", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmResult = MessageBox.Show(
                $"Run against {selectedCount} selected database(s)?",
                "Confirm Run",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                await ExecuteAgainstTargetsAsync(script, targets);
            }
        }

        private void HandleClearClick()
        {
            var clearResult = MessageBox.Show("Do you want to clear selections and the current script?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (clearResult != DialogResult.Yes)
            {
                return;
            }

            var saveResult = MessageBox.Show("Do you want to save your script before clearing?", "Save Script", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (saveResult == DialogResult.Yes)
            {
                SaveScriptToFile();
            }

            SetAllNodesChecked(false);
            textBoxSql.Clear();
        }

        private void SaveScriptToFile()
        {
            using var saveFileDialog = new SaveFileDialog
            {
                Filter = "SQL files (*.sql)|*.sql|All files (*.*)|*.*",
                DefaultExt = "sql",
                FileName = "script.sql"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, textBoxSql.Text);
            }
        }

        private IReadOnlyList<DatabaseTarget> GetSelectedDatabaseTargets()
        {
            var environment = comboBoxEnvironment.SelectedItem as string ?? "UAT";
            var targets = new List<DatabaseTarget>();

            foreach (TreeNode serverNode in treeViewCategories.Nodes)
            {
                foreach (TreeNode databaseNode in serverNode.Nodes)
                {
                    if (databaseNode.Checked && databaseNode.Tag is string connectionString && !string.IsNullOrWhiteSpace(connectionString))
                    {
                        targets.Add(new DatabaseTarget(serverNode.Text, databaseNode.Text, connectionString, environment));
                    }
                }
            }

            return targets;
        }

        private async Task ExecuteAgainstTargetsAsync(string script, IReadOnlyList<DatabaseTarget> targets)
        {
            int successCount = 0;
            var failures = new List<string>();
            int batchNumber;

            try
            {
                batchNumber = await LogEntry.GetNextBatchNumberAsync().ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to retrieve the next batch number for logging: {ex.Message}", "Run", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (new CursorScope(Cursors.WaitCursor))
            {
                foreach (var target in targets)
                {
                    try
                    {
                        using var connection = new SqlConnection(target.ConnectionString);
                        using var command = new SqlCommand(script, connection)
                        {
                            CommandType = CommandType.Text
                        };

                        await connection.OpenAsync().ConfigureAwait(false);
                        await command.ExecuteNonQueryAsync().ConfigureAwait(false);

                        successCount++;

                        try
                        {
                            await LogEntry.InsertAsync(new LogEntry
                            {
                                Environment = target.Environment,
                                SqlServer = target.Server,
                                DatabaseName = target.Database,
                                BatchNumber = batchNumber,
                                Success = true,
                                ScriptRan = script
                            }).ConfigureAwait(false);
                        }
                        catch
                        {
                            // Ignore logging failures when execution succeeds.
                        }
                    }
                    catch (Exception ex)
                    {
                        failures.Add($"{target.Server}/{target.Database}: {ex.Message}");

                        try
                        {
                            await LogEntry.InsertAsync(new LogEntry
                            {
                                Environment = target.Environment,
                                SqlServer = target.Server,
                                DatabaseName = target.Database,
                                BatchNumber = batchNumber,
                                Success = false,
                                ScriptRan = script,
                                ErrorMessage = ex.Message
                            }).ConfigureAwait(false);
                        }
                        catch
                        {
                            // Swallow logging failures to avoid masking the original execution error.
                        }
                    }
                }
            }

            var message = $"Completed run. Success: {successCount}. Failures: {failures.Count}.";
            if (failures.Count > 0)
            {
                message += "\n\nFailures:\n" + string.Join("\n", failures);
            }

            MessageBox.Show(message, "Run Results", MessageBoxButtons.OK, failures.Count == 0 ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        }

        private void SetChildrenChecked(TreeNode parent, bool isChecked)
        {
            foreach (TreeNode child in parent.Nodes)
            {
                child.Checked = isChecked;
                SetChildrenChecked(child, isChecked);
            }
        }

        private void TreeViewCategories_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeViewCategories.SelectedNode = e.Node;
        }

        private void ContextMenuTree_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool isServerNode = treeViewCategories.SelectedNode is { Parent: null };
            toolStripMenuItemSelectServer.Enabled = isServerNode;
            toolStripMenuItemDeselectServer.Enabled = isServerNode;
            if (!isServerNode)
            {
                e.Cancel = true;
            }
        }

        private void UpdateRunButtonState()
        {
            var environment = comboBoxEnvironment.SelectedItem as string ?? "UAT";
            var enabled = _allowProductionRun || !environment.Equals("Production", StringComparison.OrdinalIgnoreCase);
            buttonRun.Enabled = enabled;
        }

        private void UpdateParentCheckState(TreeNode? node)
        {
            if (node is null)
            {
                return;
            }

            bool allChecked = true;
            foreach (TreeNode child in node.Nodes)
            {
                if (!child.Checked)
                {
                    allChecked = false;
                    break;
                }
            }

            node.Checked = allChecked;
            UpdateParentCheckState(node.Parent);
        }

        private sealed record SqlServerNode(string ServerName, IReadOnlyList<DatabaseNode> Databases);
        private sealed record DatabaseNode(string Name, string ConnectionString);
        private sealed record DatabaseTarget(string Server, string Database, string ConnectionString, string Environment);

        private sealed class CursorScope : IDisposable
        {
            private readonly Cursor _previous;

            public CursorScope(Cursor cursor)
            {
                _previous = Cursor.Current;
                Cursor.Current = cursor;
            }

            public void Dispose()
            {
                Cursor.Current = _previous;
            }
        }
    }
}
