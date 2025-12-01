using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WinFormsSortOrder = System.Windows.Forms.SortOrder;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SqlSafe
{
    public partial class MainForm : Form
    {
        private readonly string _companyConnectionString;
        private readonly bool _allowProductionRun;
        private IReadOnlyList<Company> _companies = Array.Empty<Company>();
        private IReadOnlyList<SqlServerNode> _environmentServers = Array.Empty<SqlServerNode>();
        private Dictionary<string, Dictionary<string, string>> _connectionLookup = new(StringComparer.OrdinalIgnoreCase);
        private List<ViewComparisonRow> _viewComparisons = new();
        private Dictionary<string, string> _primaryViewDefinitions = new(StringComparer.OrdinalIgnoreCase);
        private Dictionary<string, string> _compareViewDefinitions = new(StringComparer.OrdinalIgnoreCase);
        private List<TableComparisonRow> _tableComparisons = new();
        private Dictionary<string, string> _primaryTableDefinitions = new(StringComparer.OrdinalIgnoreCase);
        private Dictionary<string, string> _compareTableDefinitions = new(StringComparer.OrdinalIgnoreCase);
        private List<ProcedureComparisonRow> _procedureComparisons = new();
        private Dictionary<string, string> _primaryProcedureDefinitions = new(StringComparer.OrdinalIgnoreCase);
        private Dictionary<string, string> _compareProcedureDefinitions = new(StringComparer.OrdinalIgnoreCase);
        private List<FunctionComparisonRow> _functionComparisons = new();
        private Dictionary<string, string> _primaryFunctionDefinitions = new(StringComparer.OrdinalIgnoreCase);
        private Dictionary<string, string> _compareFunctionDefinitions = new(StringComparer.OrdinalIgnoreCase);

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
            buttonApplyFilters.Click += async (_, _) => await LoadLogsWithFiltersAsync();
            dataGridViewLogs.DataBindingComplete += DataGridViewLogs_DataBindingComplete;
            dataGridViewLogs.CellMouseDown += DataGridViewLogs_CellMouseDown;
            dataGridViewLogs.ColumnHeaderMouseClick += DataGridViewLogs_ColumnHeaderMouseClick;
            contextMenuLogs.Opening += ContextMenuLogs_Opening;
            toolStripMenuItemCopyScript.Click += ToolStripMenuItemCopyScript_Click;
            toolStripMenuItemCopyError.Click += ToolStripMenuItemCopyError_Click;
            toolStripMenuItemRetry.Click += ToolStripMenuItemRetry_Click;
            comboBoxViewPrimaryServer.SelectedIndexChanged += (_, _) => UpdateDatabaseCombo(comboBoxViewPrimaryServer, comboBoxViewPrimaryDatabase);
            comboBoxViewCompareServer.SelectedIndexChanged += (_, _) => UpdateDatabaseCombo(comboBoxViewCompareServer, comboBoxViewCompareDatabase);
            buttonLoadViews.Click += async (_, _) => await LoadViewsAsync();
            buttonCompareView.Click += async (_, _) => await CompareSelectedViewAsync();
            textBoxViewSearch.TextChanged += (_, _) => ApplyViewFilter();
            dataGridViewViewComparison.CellDoubleClick += async (_, _) => await CompareSelectedViewAsync();
            dataGridViewViewComparison.CellFormatting += DataGridViewViewComparison_CellFormatting;
            comboBoxTablePrimaryServer.SelectedIndexChanged += (_, _) => UpdateDatabaseCombo(comboBoxTablePrimaryServer, comboBoxTablePrimaryDatabase);
            comboBoxTableCompareServer.SelectedIndexChanged += (_, _) => UpdateDatabaseCombo(comboBoxTableCompareServer, comboBoxTableCompareDatabase);
            buttonLoadTables.Click += async (_, _) => await LoadTablesAsync();
            buttonCompareTable.Click += async (_, _) => await CompareSelectedTableAsync();
            textBoxTableSearch.TextChanged += (_, _) => ApplyTableFilter();
            dataGridViewTableComparison.CellDoubleClick += async (_, _) => await CompareSelectedTableAsync();
            dataGridViewTableComparison.CellFormatting += DataGridViewTableComparison_CellFormatting;
            comboBoxProcedurePrimaryServer.SelectedIndexChanged += (_, _) => UpdateDatabaseCombo(comboBoxProcedurePrimaryServer, comboBoxProcedurePrimaryDatabase);
            comboBoxProcedureCompareServer.SelectedIndexChanged += (_, _) => UpdateDatabaseCombo(comboBoxProcedureCompareServer, comboBoxProcedureCompareDatabase);
            buttonLoadProcedures.Click += async (_, _) => await LoadProceduresAsync();
            buttonCompareProcedure.Click += async (_, _) => await CompareSelectedProcedureAsync();
            textBoxProcedureSearch.TextChanged += (_, _) => ApplyProcedureFilter();
            dataGridViewProcedureComparison.CellDoubleClick += async (_, _) => await CompareSelectedProcedureAsync();
            dataGridViewProcedureComparison.CellFormatting += DataGridViewProcedureComparison_CellFormatting;
            comboBoxFunctionPrimaryServer.SelectedIndexChanged += (_, _) => UpdateDatabaseCombo(comboBoxFunctionPrimaryServer, comboBoxFunctionPrimaryDatabase);
            comboBoxFunctionCompareServer.SelectedIndexChanged += (_, _) => UpdateDatabaseCombo(comboBoxFunctionCompareServer, comboBoxFunctionCompareDatabase);
            buttonLoadFunctions.Click += async (_, _) => await LoadFunctionsAsync();
            buttonCompareFunction.Click += async (_, _) => await CompareSelectedFunctionAsync();
            textBoxFunctionSearch.TextChanged += (_, _) => ApplyFunctionFilter();
            dataGridViewFunctionComparison.CellDoubleClick += async (_, _) => await CompareSelectedFunctionAsync();
            dataGridViewFunctionComparison.CellFormatting += DataGridViewFunctionComparison_CellFormatting;
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
        private const string AllFilterOption = "All";
        private const string AllBatchesOption = "All Batches";
        private List<LogEntry> _currentLogs = new();
        private string? _currentSortColumn;
        private bool _sortAscending = true;

        /// <summary>
        /// Populates the tree view with SQL servers and databases derived from loaded companies.
        /// </summary>
        private void PopulateTreeView()
        {
            treeViewCategories.BeginUpdate();
            treeViewCategories.Nodes.Clear();

            _environmentServers = GetEnvironmentServers();

            foreach (var server in _environmentServers)
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
            UpdateViewSelectors(_environmentServers);
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

            await LoadLogsWithFiltersAsync().ConfigureAwait(false);
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

        private async Task RefreshBatchesAsync(int? selectBatchNumber = null)
        {
            _isLoadingBatches = true;
            try
            {
                var batches = (await LogEntry.GetBatchNumbersAsync()).ToList();
                var batchOptions = new List<object> { AllBatchesOption };
                batchOptions.AddRange(batches.Cast<object>());

                comboBoxBatchSelect.DataSource = batchOptions;
                if (selectBatchNumber.HasValue && batches.Contains(selectBatchNumber.Value))
                {
                    comboBoxBatchSelect.SelectedItem = selectBatchNumber.Value;
                }
                else
                {
                    comboBoxBatchSelect.SelectedItem = AllBatchesOption;
                }
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

            await LoadFilterOptionsAsync();
            await LoadLogsWithFiltersAsync();
        }

        private async Task LoadLogsWithFiltersAsync()
        {
            try
            {
                var entries = (await LogEntry.GetByBatchAsync(
                    GetSelectedBatchNumber(),
                    GetSelectedFilterValue(comboBoxDatabaseFilter),
                    GetSelectedFilterValue(comboBoxEnvironmentFilter),
                    dateTimePickerCreatedFrom.Checked ? dateTimePickerCreatedFrom.Value : null,
                    dateTimePickerCreatedTo.Checked ? dateTimePickerCreatedTo.Value : null,
                    GetSelectedFilterValue(comboBoxUserFilter),
                    GetScriptSearchText())).ToList();
                BindLogs(entries);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load logs: {ex.Message}", "Logs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadFilterOptionsAsync()
        {
            try
            {
                var options = await LogEntry.GetFilterOptionsAsync();
                PopulateFilterCombo(comboBoxDatabaseFilter, options.DatabaseNames);
                PopulateFilterCombo(comboBoxEnvironmentFilter, options.Environments, new[] { "UAT", "Production" });
                PopulateFilterCombo(comboBoxUserFilter, options.Users);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load filter options: {ex.Message}", "Logs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateFilterCombo(ComboBox comboBox, IEnumerable<string> values, IEnumerable<string>? extras = null)
        {
            var options = new List<string> { AllFilterOption };
            var seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            if (extras is not null)
            {
                foreach (var extra in extras)
                {
                    if (string.IsNullOrWhiteSpace(extra) || !seen.Add(extra))
                    {
                        continue;
                    }

                    options.Add(extra);
                }
            }

            foreach (var value in values)
            {
                if (string.IsNullOrWhiteSpace(value) || !seen.Add(value))
                {
                    continue;
                }

                options.Add(value);
            }

            comboBox.DataSource = options;
            comboBox.SelectedItem = AllFilterOption;
        }

        private static string? GetSelectedFilterValue(ComboBox comboBox)
        {
            return comboBox.SelectedItem is string selected && !string.Equals(selected, AllFilterOption, StringComparison.OrdinalIgnoreCase)
                ? selected
                : null;
        }

        private string? GetScriptSearchText()
        {
            var text = textBoxScriptSearch.Text?.Trim();
            return string.IsNullOrWhiteSpace(text) ? null : text;
        }

        private int? GetSelectedBatchNumber()
        {
            return comboBoxBatchSelect.SelectedItem is int batch
                ? batch
                : null;
        }

        private void BindLogs(IReadOnlyList<LogEntry> entries)
        {
            if (dataGridViewLogs.InvokeRequired)
            {
                dataGridViewLogs.Invoke(new Action(() => BindLogs(entries)));
                return;
            }

            _currentLogs = entries.ToList();
            dataGridViewLogs.DataSource = new BindingList<LogEntry>(_currentLogs);
            _currentSortColumn = null;
            _sortAscending = true;
            ClearSortIndicators();
            ConfigureLogGridColumns();
            ApplyLogRowStyles();
        }

        private void ClearSortIndicators()
        {
            foreach (DataGridViewColumn column in dataGridViewLogs.Columns)
            {
                column.HeaderCell.SortGlyphDirection = WinFormsSortOrder.None;
            }
        }

        private void DataGridViewLogs_ColumnHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0 || _currentLogs.Count == 0)
            {
                return;
            }

            var column = dataGridViewLogs.Columns[e.ColumnIndex];
            var propertyName = column.DataPropertyName;
            if (string.IsNullOrWhiteSpace(propertyName))
            {
                return;
            }

            SortLogs(propertyName);
        }

        private void SortLogs(string propertyName)
        {
            IEnumerable<LogEntry> ordered = _currentLogs;

            if (string.Equals(_currentSortColumn, propertyName, StringComparison.OrdinalIgnoreCase))
            {
                _sortAscending = !_sortAscending;
            }
            else
            {
                _currentSortColumn = propertyName;
                _sortAscending = true;
            }

            ordered = propertyName switch
            {
                nameof(LogEntry.Id) => _sortAscending ? _currentLogs.OrderBy(x => x.Id) : _currentLogs.OrderByDescending(x => x.Id),
                nameof(LogEntry.BatchNumber) => _sortAscending ? _currentLogs.OrderBy(x => x.BatchNumber) : _currentLogs.OrderByDescending(x => x.BatchNumber),
                nameof(LogEntry.Environment) => _sortAscending ? _currentLogs.OrderBy(x => x.Environment) : _currentLogs.OrderByDescending(x => x.Environment),
                nameof(LogEntry.SqlServer) => _sortAscending ? _currentLogs.OrderBy(x => x.SqlServer) : _currentLogs.OrderByDescending(x => x.SqlServer),
                nameof(LogEntry.DatabaseName) => _sortAscending ? _currentLogs.OrderBy(x => x.DatabaseName) : _currentLogs.OrderByDescending(x => x.DatabaseName),
                nameof(LogEntry.User) => _sortAscending ? _currentLogs.OrderBy(x => x.User) : _currentLogs.OrderByDescending(x => x.User),
                nameof(LogEntry.Success) => _sortAscending ? _currentLogs.OrderBy(x => x.Success) : _currentLogs.OrderByDescending(x => x.Success),
                nameof(LogEntry.ScriptRan) => _sortAscending ? _currentLogs.OrderBy(x => x.ScriptRan) : _currentLogs.OrderByDescending(x => x.ScriptRan),
                nameof(LogEntry.ErrorMessage) => _sortAscending ? _currentLogs.OrderBy(x => x.ErrorMessage) : _currentLogs.OrderByDescending(x => x.ErrorMessage),
                nameof(LogEntry.CreatedDate) => _sortAscending ? _currentLogs.OrderBy(x => x.CreatedDate) : _currentLogs.OrderByDescending(x => x.CreatedDate),
                _ => ordered
            };

            _currentLogs = ordered.ToList();
            dataGridViewLogs.DataSource = new BindingList<LogEntry>(_currentLogs);

            foreach (DataGridViewColumn column in dataGridViewLogs.Columns)
            {
                column.HeaderCell.SortGlyphDirection = column.DataPropertyName == _currentSortColumn
                    ? (_sortAscending ? WinFormsSortOrder.Ascending : WinFormsSortOrder.Descending)
                    : WinFormsSortOrder.None;
            }

            ConfigureLogGridColumns();
            ApplyLogRowStyles();
        }

        private void DataGridViewLogs_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dataGridViewLogs.ClearSelection();
                var row = dataGridViewLogs.Rows[e.RowIndex];
                row.Selected = true;
                if (e.ColumnIndex >= 0)
                {
                    dataGridViewLogs.CurrentCell = row.Cells[e.ColumnIndex];
                }
            }
        }

        private void ContextMenuLogs_Opening(object sender, CancelEventArgs e)
        {
            var entry = GetSelectedLogEntry();
            if (entry is null)
            {
                e.Cancel = true;
                return;
            }

            toolStripMenuItemCopyScript.Enabled = !string.IsNullOrEmpty(entry.ScriptRan);
            toolStripMenuItemCopyError.Enabled = !string.IsNullOrEmpty(entry.ErrorMessage);
            toolStripMenuItemRetry.Enabled = true;
        }

        private LogEntry? GetSelectedLogEntry()
        {
            if (dataGridViewLogs.SelectedRows.Count == 0)
            {
                return null;
            }

            return dataGridViewLogs.SelectedRows[0].DataBoundItem as LogEntry;
        }

        private void ToolStripMenuItemCopyScript_Click(object? sender, EventArgs e)
        {
            var entry = GetSelectedLogEntry();
            if (entry is null || string.IsNullOrEmpty(entry.ScriptRan))
            {
                return;
            }

            Clipboard.SetText(entry.ScriptRan);
        }

        private void ToolStripMenuItemCopyError_Click(object? sender, EventArgs e)
        {
            var entry = GetSelectedLogEntry();
            if (entry is null || string.IsNullOrEmpty(entry.ErrorMessage))
            {
                return;
            }

            Clipboard.SetText(entry.ErrorMessage);
        }

        private void ToolStripMenuItemRetry_Click(object? sender, EventArgs e)
        {
            var entry = GetSelectedLogEntry();
            if (entry is null)
            {
                return;
            }

            var databaseName = string.IsNullOrWhiteSpace(entry.DatabaseName) ? "database" : entry.DatabaseName;
            var saveResult = MessageBox.Show(
                $"Do you want to save your current SQL before retrying for {databaseName}?",
                "Retry",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (saveResult == DialogResult.Yes)
            {
                SaveScriptToFile();
            }

            tabControlRight.SelectedTab = tabPageSql;
            textBoxSql.Text = entry.ScriptRan ?? string.Empty;
            EnsureEnvironmentSelected(entry.Environment);

            if (!TrySelectDatabaseNode(entry.SqlServer, entry.DatabaseName))
            {
                MessageBox.Show(
                    $"Could not find {entry.SqlServer}/{entry.DatabaseName} in the current environment tree.",
                    "Retry",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private IReadOnlyList<SqlServerNode> GetEnvironmentServers()
        {
            var environment = comboBoxEnvironment.SelectedItem as string ?? "UAT";

            return BuildServersFromCompanies(_companies, environment).ToList();
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

        private void UpdateViewSelectors(IReadOnlyList<SqlServerNode> servers)
        {
            _connectionLookup = BuildConnectionLookup(servers);
            PopulateServerCombo(comboBoxViewPrimaryServer, servers.Select(s => s.ServerName));
            PopulateServerCombo(comboBoxViewCompareServer, servers.Select(s => s.ServerName));
            UpdateDatabaseCombo(comboBoxViewPrimaryServer, comboBoxViewPrimaryDatabase);
            UpdateDatabaseCombo(comboBoxViewCompareServer, comboBoxViewCompareDatabase);
            _viewComparisons.Clear();
            dataGridViewViewComparison.DataSource = null;
            ClearViewDefinitionText();

            PopulateServerCombo(comboBoxTablePrimaryServer, servers.Select(s => s.ServerName));
            PopulateServerCombo(comboBoxTableCompareServer, servers.Select(s => s.ServerName));
            UpdateDatabaseCombo(comboBoxTablePrimaryServer, comboBoxTablePrimaryDatabase);
            UpdateDatabaseCombo(comboBoxTableCompareServer, comboBoxTableCompareDatabase);
            _tableComparisons.Clear();
            dataGridViewTableComparison.DataSource = null;
            ClearTableDefinitionText();

            PopulateServerCombo(comboBoxProcedurePrimaryServer, servers.Select(s => s.ServerName));
            PopulateServerCombo(comboBoxProcedureCompareServer, servers.Select(s => s.ServerName));
            UpdateDatabaseCombo(comboBoxProcedurePrimaryServer, comboBoxProcedurePrimaryDatabase);
            UpdateDatabaseCombo(comboBoxProcedureCompareServer, comboBoxProcedureCompareDatabase);
            _procedureComparisons.Clear();
            dataGridViewProcedureComparison.DataSource = null;
            ClearProcedureDefinitionText();

            PopulateServerCombo(comboBoxFunctionPrimaryServer, servers.Select(s => s.ServerName));
            PopulateServerCombo(comboBoxFunctionCompareServer, servers.Select(s => s.ServerName));
            UpdateDatabaseCombo(comboBoxFunctionPrimaryServer, comboBoxFunctionPrimaryDatabase);
            UpdateDatabaseCombo(comboBoxFunctionCompareServer, comboBoxFunctionCompareDatabase);
            _functionComparisons.Clear();
            dataGridViewFunctionComparison.DataSource = null;
            ClearFunctionDefinitionText();
        }

        private static Dictionary<string, Dictionary<string, string>> BuildConnectionLookup(IEnumerable<SqlServerNode> servers)
        {
            var lookup = new Dictionary<string, Dictionary<string, string>>(StringComparer.OrdinalIgnoreCase);

            foreach (var server in servers)
            {
                if (!lookup.TryGetValue(server.ServerName, out var databases))
                {
                    databases = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                    lookup[server.ServerName] = databases;
                }

                foreach (var database in server.Databases)
                {
                    if (!databases.ContainsKey(database.Name))
                    {
                        databases[database.Name] = database.ConnectionString;
                    }
                }
            }

            return lookup;
        }

        private void PopulateServerCombo(ComboBox comboBox, IEnumerable<string> serverNames)
        {
            var previousSelection = comboBox.SelectedItem as string;
            var options = serverNames.OrderBy(x => x, StringComparer.OrdinalIgnoreCase).ToList();

            comboBox.DataSource = options;

            if (comboBox.SelectedIndex < 0 && options.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }

            if (previousSelection is not null)
            {
                var match = options.FirstOrDefault(x => x.Equals(previousSelection, StringComparison.OrdinalIgnoreCase));
                if (match is not null)
                {
                    comboBox.SelectedItem = match;
                }
            }
        }

        private void UpdateDatabaseCombo(ComboBox serverCombo, ComboBox databaseCombo)
        {
            var server = serverCombo.SelectedItem as string;
            if (server is null || !_connectionLookup.TryGetValue(server, out var databases))
            {
                databaseCombo.DataSource = null;
                return;
            }

            var previousSelection = databaseCombo.SelectedItem as string;
            var options = databases.Keys.OrderBy(x => x, StringComparer.OrdinalIgnoreCase).ToList();
            databaseCombo.DataSource = options;

            if (databaseCombo.SelectedIndex < 0 && options.Count > 0)
            {
                databaseCombo.SelectedIndex = 0;
            }

            if (previousSelection is not null)
            {
                var match = options.FirstOrDefault(x => x.Equals(previousSelection, StringComparison.OrdinalIgnoreCase));
                if (match is not null)
                {
                    databaseCombo.SelectedItem = match;
                }
            }
        }

        private string? GetSelectedConnectionString(ComboBox serverCombo, ComboBox databaseCombo)
        {
            var server = serverCombo.SelectedItem as string;
            var database = databaseCombo.SelectedItem as string;

            if (server is null || database is null)
            {
                return null;
            }

            return _connectionLookup.TryGetValue(server, out var databases) && databases.TryGetValue(database, out var connectionString)
                ? connectionString
                : null;
        }

        private async Task LoadViewsAsync()
        {
            var primaryConnection = GetSelectedConnectionString(comboBoxViewPrimaryServer, comboBoxViewPrimaryDatabase);
            var compareConnection = GetSelectedConnectionString(comboBoxViewCompareServer, comboBoxViewCompareDatabase);

            if (primaryConnection is null)
            {
                MessageBox.Show("Select a primary server and database.", "View Explorer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (compareConnection is null)
            {
                MessageBox.Show("Select a comparison server and database.", "View Explorer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _primaryViewDefinitions = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            _compareViewDefinitions = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            try
            {
                HashSet<string> primaryViews;
                HashSet<string> compareViews;

                using (new CursorScope(Cursors.WaitCursor))
                {
                    var primaryViewsTask = GetViewsAsync(primaryConnection);
                    var compareViewsTask = GetViewsAsync(compareConnection);
                    var primaryDefinitionsTask = GetViewDefinitionsAsync(primaryConnection);
                    var compareDefinitionsTask = GetViewDefinitionsAsync(compareConnection);

                    await Task.WhenAll(primaryViewsTask, compareViewsTask, primaryDefinitionsTask, compareDefinitionsTask);

                    primaryViews = await primaryViewsTask;
                    compareViews = await compareViewsTask;
                    _primaryViewDefinitions = await primaryDefinitionsTask;
                    _compareViewDefinitions = await compareDefinitionsTask;
                }

                var comparisons = BuildViewComparisons(primaryViews, compareViews, _primaryViewDefinitions, _compareViewDefinitions).ToList();
                BindViewComparison(comparisons);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load views: {ex.Message}", "View Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CompareSelectedViewAsync()
        {
            if (dataGridViewViewComparison.CurrentRow?.DataBoundItem is not ViewComparisonRow selected)
            {
                MessageBox.Show("Select a view to compare.", "View Explorer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var primaryConnection = GetSelectedConnectionString(comboBoxViewPrimaryServer, comboBoxViewPrimaryDatabase);
            var compareConnection = GetSelectedConnectionString(comboBoxViewCompareServer, comboBoxViewCompareDatabase);

            if (primaryConnection is null && compareConnection is null)
            {
                MessageBox.Show("Select valid server and database targets for comparison.", "View Explorer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var primaryLabel = comboBoxViewPrimaryDatabase.SelectedItem as string ?? "Primary";
            var compareLabel = comboBoxViewCompareDatabase.SelectedItem as string ?? "Comparison";
            labelPrimaryDefinition.Text = $"Primary view definition ({primaryLabel})";
            labelCompareDefinition.Text = $"Comparison view definition ({compareLabel})";
            textBoxPrimaryViewDefinition.Text = selected.InPrimary ? "Loading..." : "View not available in primary selection.";
            textBoxCompareViewDefinition.Text = selected.InComparison ? "Loading..." : "View not available in comparison selection.";

            try
            {
                var primaryDefinitionTask = selected.InPrimary
                    ? GetDefinitionWithFallbackAsync(primaryConnection, selected.ViewName, _primaryViewDefinitions, GetViewDefinitionAsync)
                    : Task.FromResult<string?>(null);

                var compareDefinitionTask = selected.InComparison
                    ? GetDefinitionWithFallbackAsync(compareConnection, selected.ViewName, _compareViewDefinitions, GetViewDefinitionAsync)
                    : Task.FromResult<string?>(null);

                var primaryDefinition = await primaryDefinitionTask.ConfigureAwait(true);
                var compareDefinition = await compareDefinitionTask.ConfigureAwait(true);

                var primaryText = selected.InPrimary
                    ? primaryDefinition ?? "Definition not found."
                    : "View not available in primary selection.";

                var compareText = selected.InComparison
                    ? compareDefinition ?? "Definition not found."
                    : "View not available in comparison selection.";

                RenderDefinitionDiff(primaryText, compareText);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load view definitions: {ex.Message}", "View Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CompareSelectedTableAsync()
        {
            if (dataGridViewTableComparison.CurrentRow?.DataBoundItem is not TableComparisonRow selected)
            {
                MessageBox.Show("Select a table to compare.", "Table Explorer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var primaryConnection = GetSelectedConnectionString(comboBoxTablePrimaryServer, comboBoxTablePrimaryDatabase);
            var compareConnection = GetSelectedConnectionString(comboBoxTableCompareServer, comboBoxTableCompareDatabase);

            if (primaryConnection is null && compareConnection is null)
            {
                MessageBox.Show("Select valid server and database targets for comparison.", "Table Explorer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var primaryLabel = comboBoxTablePrimaryDatabase.SelectedItem as string ?? "Primary";
            var compareLabel = comboBoxTableCompareDatabase.SelectedItem as string ?? "Comparison";
            labelPrimaryTableDefinition.Text = $"Primary table definition ({primaryLabel})";
            labelCompareTableDefinition.Text = $"Comparison table definition ({compareLabel})";
            textBoxPrimaryTableDefinition.Text = selected.InPrimary ? "Loading..." : "Table not available in primary selection.";
            textBoxCompareTableDefinition.Text = selected.InComparison ? "Loading..." : "Table not available in comparison selection.";

            try
            {
                var primaryDefinition = await GetDefinitionWithFallbackAsync(primaryConnection, selected.TableName, _primaryTableDefinitions, GetTableDefinitionAsync).ConfigureAwait(false);
                var compareDefinition = await GetDefinitionWithFallbackAsync(compareConnection, selected.TableName, _compareTableDefinitions, GetTableDefinitionAsync).ConfigureAwait(false);

                var primaryText = selected.InPrimary
                    ? primaryDefinition ?? "Definition not found."
                    : "Table not available in primary selection.";

                var compareText = selected.InComparison
                    ? compareDefinition ?? "Definition not found."
                    : "Table not available in comparison selection.";

                RenderDefinitionDiff(primaryText, compareText);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load table definitions: {ex.Message}", "Table Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CompareSelectedProcedureAsync()
        {
            if (dataGridViewProcedureComparison.CurrentRow?.DataBoundItem is not ProcedureComparisonRow selected)
            {
                MessageBox.Show("Select a stored procedure to compare.", "Stored Procedure Explorer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var primaryConnection = GetSelectedConnectionString(comboBoxProcedurePrimaryServer, comboBoxProcedurePrimaryDatabase);
            var compareConnection = GetSelectedConnectionString(comboBoxProcedureCompareServer, comboBoxProcedureCompareDatabase);

            if (primaryConnection is null && compareConnection is null)
            {
                MessageBox.Show("Select valid server and database targets for comparison.", "Stored Procedure Explorer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var primaryLabel = comboBoxProcedurePrimaryDatabase.SelectedItem as string ?? "Primary";
            var compareLabel = comboBoxProcedureCompareDatabase.SelectedItem as string ?? "Comparison";
            labelPrimaryProcedureDefinition.Text = $"Primary stored procedure definition ({primaryLabel})";
            labelCompareProcedureDefinition.Text = $"Comparison stored procedure definition ({compareLabel})";
            textBoxPrimaryProcedureDefinition.Text = selected.InPrimary ? "Loading..." : "Stored procedure not available in primary selection.";
            textBoxCompareProcedureDefinition.Text = selected.InComparison ? "Loading..." : "Stored procedure not available in comparison selection.";

            try
            {
                var primaryDefinition = await GetDefinitionWithFallbackAsync(primaryConnection, selected.ProcedureName, _primaryProcedureDefinitions, GetStoredProcedureDefinitionAsync).ConfigureAwait(false);
                var compareDefinition = await GetDefinitionWithFallbackAsync(compareConnection, selected.ProcedureName, _compareProcedureDefinitions, GetStoredProcedureDefinitionAsync).ConfigureAwait(false);

                var primaryText = selected.InPrimary
                    ? primaryDefinition ?? "Definition not found."
                    : "Stored procedure not available in primary selection.";

                var compareText = selected.InComparison
                    ? compareDefinition ?? "Definition not found."
                    : "Stored procedure not available in comparison selection.";

                RenderDefinitionDiff(primaryText, compareText);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load stored procedure definitions: {ex.Message}", "Stored Procedure Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CompareSelectedFunctionAsync()
        {
            if (dataGridViewFunctionComparison.CurrentRow?.DataBoundItem is not FunctionComparisonRow selected)
            {
                MessageBox.Show("Select a function to compare.", "Function Explorer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var primaryConnection = GetSelectedConnectionString(comboBoxFunctionPrimaryServer, comboBoxFunctionPrimaryDatabase);
            var compareConnection = GetSelectedConnectionString(comboBoxFunctionCompareServer, comboBoxFunctionCompareDatabase);

            if (primaryConnection is null && compareConnection is null)
            {
                MessageBox.Show("Select valid server and database targets for comparison.", "Function Explorer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var primaryLabel = comboBoxFunctionPrimaryDatabase.SelectedItem as string ?? "Primary";
            var compareLabel = comboBoxFunctionCompareDatabase.SelectedItem as string ?? "Comparison";
            labelPrimaryFunctionDefinition.Text = $"Primary function definition ({primaryLabel})";
            labelCompareFunctionDefinition.Text = $"Comparison function definition ({compareLabel})";
            textBoxPrimaryFunctionDefinition.Text = selected.InPrimary ? "Loading..." : "Function not available in primary selection.";
            textBoxCompareFunctionDefinition.Text = selected.InComparison ? "Loading..." : "Function not available in comparison selection.";

            try
            {
                var primaryDefinition = await GetDefinitionWithFallbackAsync(primaryConnection, selected.FunctionName, _primaryFunctionDefinitions, GetFunctionDefinitionAsync).ConfigureAwait(false);
                var compareDefinition = await GetDefinitionWithFallbackAsync(compareConnection, selected.FunctionName, _compareFunctionDefinitions, GetFunctionDefinitionAsync).ConfigureAwait(false);

                var primaryText = selected.InPrimary
                    ? primaryDefinition ?? "Definition not found."
                    : "Function not available in primary selection.";

                var compareText = selected.InComparison
                    ? compareDefinition ?? "Definition not found."
                    : "Function not available in comparison selection.";

                RenderDefinitionDiff(primaryText, compareText);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load function definitions: {ex.Message}", "Function Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private IEnumerable<ViewComparisonRow> BuildViewComparisons(
            IReadOnlyCollection<string> primaryViews,
            IReadOnlyCollection<string> compareViews,
            IReadOnlyDictionary<string, string> primaryDefinitions,
            IReadOnlyDictionary<string, string> compareDefinitions)
        {
            var allViewNames = primaryViews
                .Union(compareViews, StringComparer.OrdinalIgnoreCase)
                .OrderBy(name => name, StringComparer.OrdinalIgnoreCase);

            foreach (var viewName in allViewNames)
            {
                var inPrimary = primaryViews.Contains(viewName);
                var inComparison = compareViews.Contains(viewName);

                yield return new ViewComparisonRow
                {
                    ViewName = viewName,
                    InPrimary = inPrimary,
                    InComparison = inComparison,
                    Summary = GetComparisonSummary(viewName, inPrimary, inComparison, primaryDefinitions, compareDefinitions)
                };
            }
        }

        private static string GetComparisonSummary(
            string objectName,
            bool inPrimary,
            bool inComparison,
            IReadOnlyDictionary<string, string> primaryDefinitions,
            IReadOnlyDictionary<string, string> compareDefinitions)
        {
            if (inPrimary && inComparison)
            {
                var hasPrimary = primaryDefinitions.TryGetValue(objectName, out var primaryDefinition);
                var hasComparison = compareDefinitions.TryGetValue(objectName, out var comparisonDefinition);

                if (hasPrimary && hasComparison)
                {
                    return string.Equals(
                        NormalizeDefinition(primaryDefinition),
                        NormalizeDefinition(comparisonDefinition),
                        StringComparison.Ordinal)
                        ? "Definitions match"
                        : "Definitions differ";
                }

                return "Definitions unavailable";
            }

            if (inPrimary)
            {
                return "Only in primary";
            }

            if (inComparison)
            {
                return "Only in comparison";
            }

            return "Unavailable";
        }

        private static string NormalizeDefinition(string? definition)
        {
            return (definition ?? string.Empty)
                .Replace("\r\n", "\n", StringComparison.Ordinal)
                .Replace('\r', '\n')
                .Trim();
        }

        private static async Task<HashSet<string>> GetViewsAsync(string connectionString)
        {
            const string sql = @"SELECT QUOTENAME(s.name) + '.' + QUOTENAME(v.name) AS ViewName
FROM sys.views v WITH (NOLOCK)
INNER JOIN sys.schemas s ON v.schema_id = s.schema_id";

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(sql, connection)
            {
                CommandType = CommandType.Text
            };

            await connection.OpenAsync().ConfigureAwait(false);

            var results = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            using var reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection).ConfigureAwait(false);
            while (await reader.ReadAsync().ConfigureAwait(false))
            {
                results.Add(reader.GetString(reader.GetOrdinal("ViewName")));
            }

            return results;
        }

        private static async Task<Dictionary<string, string>> GetViewDefinitionsAsync(string connectionString)
        {
            const string sql = @"SELECT QUOTENAME(s.name) + '.' + QUOTENAME(v.name) AS ViewName, sm.[definition]
FROM sys.views v WITH (NOLOCK)
INNER JOIN sys.schemas s ON v.schema_id = s.schema_id
INNER JOIN sys.sql_modules sm ON sm.object_id = v.object_id";

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(sql, connection)
            {
                CommandType = CommandType.Text
            };

            await connection.OpenAsync().ConfigureAwait(false);

            var results = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            using var reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection).ConfigureAwait(false);
            while (await reader.ReadAsync().ConfigureAwait(false))
            {
                var name = reader.GetString(reader.GetOrdinal("ViewName"));
                var definition = reader.IsDBNull(reader.GetOrdinal("definition")) ? string.Empty : reader.GetString(reader.GetOrdinal("definition"));
                results[name] = definition;
            }

            return results;
        }

        private static async Task<HashSet<string>> GetTablesAsync(string connectionString)
        {
            const string sql = @"SELECT QUOTENAME(s.name) + '.' + QUOTENAME(t.name) AS TableName
FROM sys.tables t WITH (NOLOCK)
INNER JOIN sys.schemas s ON t.schema_id = s.schema_id";

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(sql, connection)
            {
                CommandType = CommandType.Text
            };

            await connection.OpenAsync().ConfigureAwait(false);

            var results = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            using var reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection).ConfigureAwait(false);
            while (await reader.ReadAsync().ConfigureAwait(false))
            {
                results.Add(reader.GetString(reader.GetOrdinal("TableName")));
            }

            return results;
        }

        private static async Task<Dictionary<string, string>> GetTableDefinitionsAsync(string connectionString)
        {
            const string sql = @"WITH ColumnInfo AS (
    SELECT
        QUOTENAME(s.name) + '.' + QUOTENAME(t.name) AS TableName,
        c.column_id,
        QUOTENAME(c.name) AS ColumnName,
        TYPE_NAME(c.user_type_id) AS DataType,
        c.max_length,
        c.is_nullable
    FROM sys.tables t WITH (NOLOCK)
    INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
    INNER JOIN sys.columns c ON c.object_id = t.object_id
)
SELECT
    TableName,
    STRING_AGG(
        ColumnName + ' ' + DataType +
        CASE WHEN DataType IN ('varchar','nvarchar','char','nchar','varbinary')
            THEN '(' + CASE WHEN max_length = -1 THEN 'max' ELSE CAST(CASE WHEN DataType LIKE 'n%' THEN max_length/2 ELSE max_length END AS varchar(10)) END + ')'
            ELSE '' END +
        CASE WHEN is_nullable = 1 THEN ' NULL' ELSE ' NOT NULL' END,
        CHAR(10)
    ) WITHIN GROUP (ORDER BY column_id) AS Definition
FROM ColumnInfo
GROUP BY TableName";

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(sql, connection)
            {
                CommandType = CommandType.Text
            };

            await connection.OpenAsync().ConfigureAwait(false);

            var results = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            using var reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection).ConfigureAwait(false);
            while (await reader.ReadAsync().ConfigureAwait(false))
            {
                var name = reader.GetString(reader.GetOrdinal("TableName"));
                var definition = reader.IsDBNull(reader.GetOrdinal("Definition")) ? string.Empty : reader.GetString(reader.GetOrdinal("Definition"));
                results[name] = definition;
            }

            return results;
        }

        private static async Task<string?> GetTableDefinitionAsync(string connectionString, string tableName)
        {
            const string sql = @"WITH ColumnInfo AS (
    SELECT
        QUOTENAME(s.name) + '.' + QUOTENAME(t.name) AS TableName,
        c.column_id,
        QUOTENAME(c.name) AS ColumnName,
        TYPE_NAME(c.user_type_id) AS DataType,
        c.max_length,
        c.is_nullable
    FROM sys.tables t WITH (NOLOCK)
    INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
    INNER JOIN sys.columns c ON c.object_id = t.object_id
    WHERE QUOTENAME(s.name) + '.' + QUOTENAME(t.name) = @TableName
)
SELECT
    STRING_AGG(
        ColumnName + ' ' + DataType +
        CASE WHEN DataType IN ('varchar','nvarchar','char','nchar','varbinary')
            THEN '(' + CASE WHEN max_length = -1 THEN 'max' ELSE CAST(CASE WHEN DataType LIKE 'n%' THEN max_length/2 ELSE max_length END AS varchar(10)) END + ')'
            ELSE '' END +
        CASE WHEN is_nullable = 1 THEN ' NULL' ELSE ' NOT NULL' END,
        CHAR(10)
    ) WITHIN GROUP (ORDER BY column_id) AS Definition
FROM ColumnInfo";

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(sql, connection)
            {
                CommandType = CommandType.Text
            };

            command.Parameters.Add(new SqlParameter("@TableName", SqlDbType.NVarChar, 258)
            {
                Value = tableName
            });

            await connection.OpenAsync().ConfigureAwait(false);
            var result = await command.ExecuteScalarAsync().ConfigureAwait(false);
            return result as string;
        }

        private static async Task<HashSet<string>> GetStoredProceduresAsync(string connectionString)
        {
            const string sql = @"SELECT QUOTENAME(s.name) + '.' + QUOTENAME(p.name) AS ProcedureName
FROM sys.procedures p WITH (NOLOCK)
INNER JOIN sys.schemas s ON p.schema_id = s.schema_id";

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(sql, connection)
            {
                CommandType = CommandType.Text
            };

            await connection.OpenAsync().ConfigureAwait(false);

            var results = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            using var reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection).ConfigureAwait(false);
            while (await reader.ReadAsync().ConfigureAwait(false))
            {
                results.Add(reader.GetString(reader.GetOrdinal("ProcedureName")));
            }

            return results;
        }

        private static async Task<Dictionary<string, string>> GetStoredProcedureDefinitionsAsync(string connectionString)
        {
            const string sql = @"SELECT QUOTENAME(s.name) + '.' + QUOTENAME(p.name) AS ProcedureName, sm.[definition]
FROM sys.procedures p WITH (NOLOCK)
INNER JOIN sys.schemas s ON p.schema_id = s.schema_id
INNER JOIN sys.sql_modules sm ON sm.object_id = p.object_id";

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(sql, connection)
            {
                CommandType = CommandType.Text
            };

            await connection.OpenAsync().ConfigureAwait(false);

            var results = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            using var reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection).ConfigureAwait(false);
            while (await reader.ReadAsync().ConfigureAwait(false))
            {
                var name = reader.GetString(reader.GetOrdinal("ProcedureName"));
                var definition = reader.IsDBNull(reader.GetOrdinal("definition")) ? string.Empty : reader.GetString(reader.GetOrdinal("definition"));
                results[name] = definition;
            }

            return results;
        }

        private static async Task<string?> GetStoredProcedureDefinitionAsync(string connectionString, string procedureName)
        {
            const string sql = @"SELECT sm.[definition]
FROM sys.sql_modules sm WITH (NOLOCK)
INNER JOIN sys.procedures p ON sm.object_id = p.object_id
INNER JOIN sys.schemas s ON p.schema_id = s.schema_id
WHERE QUOTENAME(s.name) + '.' + QUOTENAME(p.name) = @ProcedureName";

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(sql, connection)
            {
                CommandType = CommandType.Text
            };

            command.Parameters.Add(new SqlParameter("@ProcedureName", SqlDbType.NVarChar, 258)
            {
                Value = procedureName
            });

            await connection.OpenAsync().ConfigureAwait(false);
            var result = await command.ExecuteScalarAsync().ConfigureAwait(false);
            return result as string;
        }

        private static async Task<HashSet<string>> GetFunctionsAsync(string connectionString)
        {
            const string sql = @"SELECT QUOTENAME(s.name) + '.' + QUOTENAME(o.name) AS FunctionName
FROM sys.objects o WITH (NOLOCK)
INNER JOIN sys.schemas s ON o.schema_id = s.schema_id
WHERE o.[type] IN ('FN', 'IF', 'TF')";

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(sql, connection)
            {
                CommandType = CommandType.Text
            };

            await connection.OpenAsync().ConfigureAwait(false);

            var results = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            using var reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection).ConfigureAwait(false);
            while (await reader.ReadAsync().ConfigureAwait(false))
            {
                results.Add(reader.GetString(reader.GetOrdinal("FunctionName")));
            }

            return results;
        }

        private static async Task<Dictionary<string, string>> GetFunctionDefinitionsAsync(string connectionString)
        {
            const string sql = @"SELECT QUOTENAME(s.name) + '.' + QUOTENAME(o.name) AS FunctionName, sm.[definition]
FROM sys.objects o WITH (NOLOCK)
INNER JOIN sys.schemas s ON o.schema_id = s.schema_id
INNER JOIN sys.sql_modules sm ON sm.object_id = o.object_id
WHERE o.[type] IN ('FN', 'IF', 'TF')";

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(sql, connection)
            {
                CommandType = CommandType.Text
            };

            await connection.OpenAsync().ConfigureAwait(false);

            var results = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            using var reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection).ConfigureAwait(false);
            while (await reader.ReadAsync().ConfigureAwait(false))
            {
                var name = reader.GetString(reader.GetOrdinal("FunctionName"));
                var definition = reader.IsDBNull(reader.GetOrdinal("definition")) ? string.Empty : reader.GetString(reader.GetOrdinal("definition"));
                results[name] = definition;
            }

            return results;
        }

        private static async Task<string?> GetFunctionDefinitionAsync(string connectionString, string functionName)
        {
            const string sql = @"SELECT sm.[definition]
FROM sys.sql_modules sm WITH (NOLOCK)
INNER JOIN sys.objects o ON sm.object_id = o.object_id
INNER JOIN sys.schemas s ON o.schema_id = s.schema_id
WHERE o.[type] IN ('FN', 'IF', 'TF')
  AND QUOTENAME(s.name) + '.' + QUOTENAME(o.name) = @FunctionName";

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(sql, connection)
            {
                CommandType = CommandType.Text
            };

            command.Parameters.Add(new SqlParameter("@FunctionName", SqlDbType.NVarChar, 258)
            {
                Value = functionName
            });

            await connection.OpenAsync().ConfigureAwait(false);
            var result = await command.ExecuteScalarAsync().ConfigureAwait(false);
            return result as string;
        }

        private static async Task<string?> GetViewDefinitionAsync(string connectionString, string viewName)
        {
            const string sql = @"SELECT sm.[definition]
FROM sys.sql_modules sm WITH (NOLOCK)
INNER JOIN sys.views v ON sm.object_id = v.object_id
INNER JOIN sys.schemas s ON v.schema_id = s.schema_id
WHERE QUOTENAME(s.name) + '.' + QUOTENAME(v.name) = @ViewName";

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(sql, connection)
            {
                CommandType = CommandType.Text
            };

            command.Parameters.Add(new SqlParameter("@ViewName", SqlDbType.NVarChar, 258)
            {
                Value = viewName
            });

            await connection.OpenAsync().ConfigureAwait(false);
            var result = await command.ExecuteScalarAsync().ConfigureAwait(false);
            return result as string;
        }

        private static async Task<string?> GetDefinitionWithFallbackAsync(
            string? connectionString,
            string objectName,
            IReadOnlyDictionary<string, string> cache,
            Func<string, string, Task<string?>> fetchDefinition)
        {
            if (cache.TryGetValue(objectName, out var cached))
            {
                return cached;
            }

            if (connectionString is null)
            {
                return null;
            }

            return await fetchDefinition(connectionString, objectName).ConfigureAwait(false);
        }

        private void BindViewComparison(IEnumerable<ViewComparisonRow> rows)
        {
            _viewComparisons = rows.ToList();
            ApplyViewFilter();
        }

        private void BindTableComparison(IEnumerable<TableComparisonRow> rows)
        {
            _tableComparisons = rows.ToList();
            ApplyTableFilter();
        }

        private void BindProcedureComparison(IEnumerable<ProcedureComparisonRow> rows)
        {
            _procedureComparisons = rows.ToList();
            ApplyProcedureFilter();
        }

        private void BindFunctionComparison(IEnumerable<FunctionComparisonRow> rows)
        {
            _functionComparisons = rows.ToList();
            ApplyFunctionFilter();
        }

        private void ConfigureViewComparisonGrid()
        {
            if (dataGridViewViewComparison.Columns.Count == 0)
            {
                return;
            }

            dataGridViewViewComparison.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewViewComparison.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridViewViewComparison.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            if (dataGridViewViewComparison.Columns[nameof(ViewComparisonRow.ViewName)] is DataGridViewColumn viewColumn)
            {
                viewColumn.HeaderText = "View";
                viewColumn.FillWeight = 200;
                viewColumn.MinimumWidth = 150;
            }

            if (dataGridViewViewComparison.Columns[nameof(ViewComparisonRow.PrimaryStatus)] is DataGridViewColumn primaryColumn)
            {
                primaryColumn.HeaderText = "Primary";
                primaryColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                primaryColumn.FillWeight = 80;
                primaryColumn.MinimumWidth = 80;
            }

            if (dataGridViewViewComparison.Columns[nameof(ViewComparisonRow.ComparisonStatus)] is DataGridViewColumn compareColumn)
            {
                compareColumn.HeaderText = "Comparison";
                compareColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                compareColumn.FillWeight = 100;
                compareColumn.MinimumWidth = 100;
            }

            if (dataGridViewViewComparison.Columns[nameof(ViewComparisonRow.Summary)] is DataGridViewColumn summaryColumn)
            {
                summaryColumn.HeaderText = "Difference summary";
                summaryColumn.FillWeight = 140;
                summaryColumn.MinimumWidth = 140;
            }

            var columnOrder = new[]
            {
                nameof(ViewComparisonRow.ViewName),
                nameof(ViewComparisonRow.PrimaryStatus),
                nameof(ViewComparisonRow.ComparisonStatus),
                nameof(ViewComparisonRow.Summary)
            };

            var index = 0;
            foreach (var name in columnOrder)
            {
                if (dataGridViewViewComparison.Columns[name] is { } column)
                {
                    column.DisplayIndex = index++;
                }
            }
        }

        private void DataGridViewViewComparison_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var columnName = dataGridViewViewComparison.Columns[e.ColumnIndex].Name;
            if (columnName is not (nameof(ViewComparisonRow.PrimaryStatus) or nameof(ViewComparisonRow.ComparisonStatus)))
            {
                return;
            }

            var text = e.Value as string;
            if (string.Equals(text, "✔", StringComparison.Ordinal))
            {
                e.CellStyle.ForeColor = Color.ForestGreen;
                e.Value = "✔";
            }
            else
            {
                e.CellStyle.ForeColor = Color.Firebrick;
                e.Value = "✖";
            }

            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            e.FormattingApplied = true;
        }

        private void DataGridViewTableComparison_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            FormatComparisonIconCell(dataGridViewTableComparison, e);
        }

        private void DataGridViewProcedureComparison_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            FormatComparisonIconCell(dataGridViewProcedureComparison, e);
        }

        private void DataGridViewFunctionComparison_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            FormatComparisonIconCell(dataGridViewFunctionComparison, e);
        }

        private static void FormatComparisonIconCell(DataGridView grid, DataGridViewCellFormattingEventArgs e)
        {
            if (grid.Columns[e.ColumnIndex].Name is not ("PrimaryStatus" or "ComparisonStatus"))
            {
                return;
            }

            var text = e.Value as string;
            if (string.Equals(text, "✔", StringComparison.Ordinal))
            {
                e.CellStyle.ForeColor = Color.ForestGreen;
                e.Value = "✔";
            }
            else
            {
                e.CellStyle.ForeColor = Color.Firebrick;
                e.Value = "✖";
            }

            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            e.FormattingApplied = true;
        }

        private void ApplyViewFilter()
        {
            IEnumerable<ViewComparisonRow> filtered = _viewComparisons;
            var filter = textBoxViewSearch.Text?.Trim();
            if (!string.IsNullOrWhiteSpace(filter))
            {
                filtered = filtered.Where(row => row.ViewName.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            dataGridViewViewComparison.DataSource = new BindingList<ViewComparisonRow>(filtered.ToList());
            ConfigureViewComparisonGrid();
            ClearViewDefinitionText();
        }

        private void ApplyTableFilter()
        {
            IEnumerable<TableComparisonRow> filtered = _tableComparisons;
            var filter = textBoxTableSearch.Text?.Trim();
            if (!string.IsNullOrWhiteSpace(filter))
            {
                filtered = filtered.Where(row => row.TableName.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            dataGridViewTableComparison.DataSource = new BindingList<TableComparisonRow>(filtered.ToList());
            ConfigureTableComparisonGrid();
            ClearTableDefinitionText();
        }

        private void ApplyProcedureFilter()
        {
            IEnumerable<ProcedureComparisonRow> filtered = _procedureComparisons;
            var filter = textBoxProcedureSearch.Text?.Trim();
            if (!string.IsNullOrWhiteSpace(filter))
            {
                filtered = filtered.Where(row => row.ProcedureName.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            dataGridViewProcedureComparison.DataSource = new BindingList<ProcedureComparisonRow>(filtered.ToList());
            ConfigureProcedureComparisonGrid();
            ClearProcedureDefinitionText();
        }

        private void ApplyFunctionFilter()
        {
            IEnumerable<FunctionComparisonRow> filtered = _functionComparisons;
            var filter = textBoxFunctionSearch.Text?.Trim();
            if (!string.IsNullOrWhiteSpace(filter))
            {
                filtered = filtered.Where(row => row.FunctionName.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            dataGridViewFunctionComparison.DataSource = new BindingList<FunctionComparisonRow>(filtered.ToList());
            ConfigureFunctionComparisonGrid();
            ClearFunctionDefinitionText();
        }

        private void ConfigureTableComparisonGrid()
        {
            if (dataGridViewTableComparison.Columns.Count == 0)
            {
                return;
            }

            dataGridViewTableComparison.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTableComparison.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridViewTableComparison.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            if (dataGridViewTableComparison.Columns[nameof(TableComparisonRow.TableName)] is DataGridViewColumn nameColumn)
            {
                nameColumn.HeaderText = "Table";
                nameColumn.FillWeight = 40;
                nameColumn.MinimumWidth = 150;
            }

            if (dataGridViewTableComparison.Columns[nameof(TableComparisonRow.PrimaryStatus)] is DataGridViewColumn primaryColumn)
            {
                primaryColumn.HeaderText = "Primary";
                primaryColumn.FillWeight = 10;
                primaryColumn.MinimumWidth = 60;
                primaryColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dataGridViewTableComparison.Columns[nameof(TableComparisonRow.ComparisonStatus)] is DataGridViewColumn compareColumn)
            {
                compareColumn.HeaderText = "Comparison";
                compareColumn.FillWeight = 10;
                compareColumn.MinimumWidth = 80;
                compareColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dataGridViewTableComparison.Columns[nameof(TableComparisonRow.Summary)] is DataGridViewColumn summaryColumn)
            {
                summaryColumn.HeaderText = "Difference Summary";
                summaryColumn.FillWeight = 40;
                summaryColumn.MinimumWidth = 150;
            }

            foreach (var name in new[]
                     {
                         nameof(TableComparisonRow.TableName),
                         nameof(TableComparisonRow.PrimaryStatus),
                         nameof(TableComparisonRow.ComparisonStatus),
                         nameof(TableComparisonRow.Summary)
                     })
            {
                if (dataGridViewTableComparison.Columns[name] is { } column)
                {
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
            }
        }

        private void ConfigureProcedureComparisonGrid()
        {
            if (dataGridViewProcedureComparison.Columns.Count == 0)
            {
                return;
            }

            dataGridViewProcedureComparison.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProcedureComparison.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridViewProcedureComparison.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            if (dataGridViewProcedureComparison.Columns[nameof(ProcedureComparisonRow.ProcedureName)] is DataGridViewColumn nameColumn)
            {
                nameColumn.HeaderText = "Stored Procedure";
                nameColumn.FillWeight = 40;
                nameColumn.MinimumWidth = 200;
            }

            if (dataGridViewProcedureComparison.Columns[nameof(ProcedureComparisonRow.PrimaryStatus)] is DataGridViewColumn primaryColumn)
            {
                primaryColumn.HeaderText = "Primary";
                primaryColumn.FillWeight = 10;
                primaryColumn.MinimumWidth = 80;
                primaryColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dataGridViewProcedureComparison.Columns[nameof(ProcedureComparisonRow.ComparisonStatus)] is DataGridViewColumn compareColumn)
            {
                compareColumn.HeaderText = "Comparison";
                compareColumn.FillWeight = 10;
                compareColumn.MinimumWidth = 100;
                compareColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dataGridViewProcedureComparison.Columns[nameof(ProcedureComparisonRow.Summary)] is DataGridViewColumn summaryColumn)
            {
                summaryColumn.HeaderText = "Difference Summary";
                summaryColumn.FillWeight = 40;
                summaryColumn.MinimumWidth = 200;
            }

            foreach (var name in new[]
                     {
                         nameof(ProcedureComparisonRow.ProcedureName),
                         nameof(ProcedureComparisonRow.PrimaryStatus),
                         nameof(ProcedureComparisonRow.ComparisonStatus),
                         nameof(ProcedureComparisonRow.Summary)
                     })
            {
                if (dataGridViewProcedureComparison.Columns[name] is { } column)
                {
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
            }
        }

        private void ConfigureFunctionComparisonGrid()
        {
            if (dataGridViewFunctionComparison.Columns.Count == 0)
            {
                return;
            }

            dataGridViewFunctionComparison.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFunctionComparison.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridViewFunctionComparison.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            if (dataGridViewFunctionComparison.Columns[nameof(FunctionComparisonRow.FunctionName)] is DataGridViewColumn nameColumn)
            {
                nameColumn.HeaderText = "Function";
                nameColumn.FillWeight = 40;
                nameColumn.MinimumWidth = 200;
            }

            if (dataGridViewFunctionComparison.Columns[nameof(FunctionComparisonRow.PrimaryStatus)] is DataGridViewColumn primaryColumn)
            {
                primaryColumn.HeaderText = "Primary";
                primaryColumn.FillWeight = 10;
                primaryColumn.MinimumWidth = 80;
                primaryColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dataGridViewFunctionComparison.Columns[nameof(FunctionComparisonRow.ComparisonStatus)] is DataGridViewColumn compareColumn)
            {
                compareColumn.HeaderText = "Comparison";
                compareColumn.FillWeight = 10;
                compareColumn.MinimumWidth = 100;
                compareColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dataGridViewFunctionComparison.Columns[nameof(FunctionComparisonRow.Summary)] is DataGridViewColumn summaryColumn)
            {
                summaryColumn.HeaderText = "Difference Summary";
                summaryColumn.FillWeight = 40;
                summaryColumn.MinimumWidth = 200;
            }

            foreach (var name in new[]
                     {
                         nameof(FunctionComparisonRow.FunctionName),
                         nameof(FunctionComparisonRow.PrimaryStatus),
                         nameof(FunctionComparisonRow.ComparisonStatus),
                         nameof(FunctionComparisonRow.Summary)
                     })
            {
                if (dataGridViewFunctionComparison.Columns[name] is { } column)
                {
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
            }
        }

        private IEnumerable<TableComparisonRow> BuildTableComparisons(
            IReadOnlyCollection<string> primaryTables,
            IReadOnlyCollection<string> compareTables,
            IReadOnlyDictionary<string, string> primaryDefinitions,
            IReadOnlyDictionary<string, string> compareDefinitions)
        {
            var allTableNames = primaryTables
                .Union(compareTables, StringComparer.OrdinalIgnoreCase)
                .OrderBy(name => name, StringComparer.OrdinalIgnoreCase);

            foreach (var tableName in allTableNames)
            {
                var inPrimary = primaryTables.Contains(tableName);
                var inComparison = compareTables.Contains(tableName);

                yield return new TableComparisonRow
                {
                    TableName = tableName,
                    InPrimary = inPrimary,
                    InComparison = inComparison,
                    Summary = GetComparisonSummary(tableName, inPrimary, inComparison, primaryDefinitions, compareDefinitions)
                };
            }
        }

        private IEnumerable<ProcedureComparisonRow> BuildProcedureComparisons(
            IReadOnlyCollection<string> primaryProcedures,
            IReadOnlyCollection<string> compareProcedures,
            IReadOnlyDictionary<string, string> primaryDefinitions,
            IReadOnlyDictionary<string, string> compareDefinitions)
        {
            var allNames = primaryProcedures
                .Union(compareProcedures, StringComparer.OrdinalIgnoreCase)
                .OrderBy(name => name, StringComparer.OrdinalIgnoreCase);

            foreach (var name in allNames)
            {
                var inPrimary = primaryProcedures.Contains(name);
                var inComparison = compareProcedures.Contains(name);

                yield return new ProcedureComparisonRow
                {
                    ProcedureName = name,
                    InPrimary = inPrimary,
                    InComparison = inComparison,
                    Summary = GetComparisonSummary(name, inPrimary, inComparison, primaryDefinitions, compareDefinitions)
                };
            }
        }

        private IEnumerable<FunctionComparisonRow> BuildFunctionComparisons(
            IReadOnlyCollection<string> primaryFunctions,
            IReadOnlyCollection<string> compareFunctions,
            IReadOnlyDictionary<string, string> primaryDefinitions,
            IReadOnlyDictionary<string, string> compareDefinitions)
        {
            var allNames = primaryFunctions
                .Union(compareFunctions, StringComparer.OrdinalIgnoreCase)
                .OrderBy(name => name, StringComparer.OrdinalIgnoreCase);

            foreach (var name in allNames)
            {
                var inPrimary = primaryFunctions.Contains(name);
                var inComparison = compareFunctions.Contains(name);

                yield return new FunctionComparisonRow
                {
                    FunctionName = name,
                    InPrimary = inPrimary,
                    InComparison = inComparison,
                    Summary = GetComparisonSummary(name, inPrimary, inComparison, primaryDefinitions, compareDefinitions)
                };
            }
        }

        private void ClearViewDefinitionText()
        {
            textBoxPrimaryViewDefinition.Clear();
            textBoxCompareViewDefinition.Clear();
            labelPrimaryDefinition.Text = "Primary view definition";
            labelCompareDefinition.Text = "Comparison view definition";
        }

        private void ClearTableDefinitionText()
        {
            textBoxPrimaryTableDefinition.Clear();
            textBoxCompareTableDefinition.Clear();
            labelPrimaryTableDefinition.Text = "Primary table definition";
            labelCompareTableDefinition.Text = "Comparison table definition";
        }

        private void ClearProcedureDefinitionText()
        {
            textBoxPrimaryProcedureDefinition.Clear();
            textBoxCompareProcedureDefinition.Clear();
            labelPrimaryProcedureDefinition.Text = "Primary stored procedure definition";
            labelCompareProcedureDefinition.Text = "Comparison stored procedure definition";
        }

        private void ClearFunctionDefinitionText()
        {
            textBoxPrimaryFunctionDefinition.Clear();
            textBoxCompareFunctionDefinition.Clear();
            labelPrimaryFunctionDefinition.Text = "Primary function definition";
            labelCompareFunctionDefinition.Text = "Comparison function definition";
        }

        private async Task LoadTablesAsync()
        {
            var primaryConnection = GetSelectedConnectionString(comboBoxTablePrimaryServer, comboBoxTablePrimaryDatabase);
            var compareConnection = GetSelectedConnectionString(comboBoxTableCompareServer, comboBoxTableCompareDatabase);

            if (primaryConnection is null)
            {
                MessageBox.Show("Select a primary server and database.", "Table Explorer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (compareConnection is null)
            {
                MessageBox.Show("Select a comparison server and database.", "Table Explorer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _primaryTableDefinitions = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            _compareTableDefinitions = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            try
            {
                HashSet<string> primaryTables;
                HashSet<string> compareTables;

                using (new CursorScope(Cursors.WaitCursor))
                {
                    var primaryTablesTask = GetTablesAsync(primaryConnection);
                    var compareTablesTask = GetTablesAsync(compareConnection);
                    var primaryDefinitionsTask = GetTableDefinitionsAsync(primaryConnection);
                    var compareDefinitionsTask = GetTableDefinitionsAsync(compareConnection);

                    await Task.WhenAll(primaryTablesTask, compareTablesTask, primaryDefinitionsTask, compareDefinitionsTask);

                    primaryTables = await primaryTablesTask;
                    compareTables = await compareTablesTask;
                    _primaryTableDefinitions = await primaryDefinitionsTask;
                    _compareTableDefinitions = await compareDefinitionsTask;
                }

                var comparisons = BuildTableComparisons(primaryTables, compareTables, _primaryTableDefinitions, _compareTableDefinitions).ToList();
                BindTableComparison(comparisons);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load tables: {ex.Message}", "Table Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadProceduresAsync()
        {
            var primaryConnection = GetSelectedConnectionString(comboBoxProcedurePrimaryServer, comboBoxProcedurePrimaryDatabase);
            var compareConnection = GetSelectedConnectionString(comboBoxProcedureCompareServer, comboBoxProcedureCompareDatabase);

            if (primaryConnection is null)
            {
                MessageBox.Show("Select a primary server and database.", "Stored Procedure Explorer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (compareConnection is null)
            {
                MessageBox.Show("Select a comparison server and database.", "Stored Procedure Explorer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _primaryProcedureDefinitions = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            _compareProcedureDefinitions = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            try
            {
                HashSet<string> primaryProcedures;
                HashSet<string> compareProcedures;

                using (new CursorScope(Cursors.WaitCursor))
                {
                    var primaryProceduresTask = GetStoredProceduresAsync(primaryConnection);
                    var compareProceduresTask = GetStoredProceduresAsync(compareConnection);
                    var primaryDefinitionsTask = GetStoredProcedureDefinitionsAsync(primaryConnection);
                    var compareDefinitionsTask = GetStoredProcedureDefinitionsAsync(compareConnection);

                    await Task.WhenAll(primaryProceduresTask, compareProceduresTask, primaryDefinitionsTask, compareDefinitionsTask);

                    primaryProcedures = await primaryProceduresTask;
                    compareProcedures = await compareProceduresTask;
                    _primaryProcedureDefinitions = await primaryDefinitionsTask;
                    _compareProcedureDefinitions = await compareDefinitionsTask;
                }

                var comparisons = BuildProcedureComparisons(primaryProcedures, compareProcedures, _primaryProcedureDefinitions, _compareProcedureDefinitions).ToList();
                BindProcedureComparison(comparisons);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load stored procedures: {ex.Message}", "Stored Procedure Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadFunctionsAsync()
        {
            var primaryConnection = GetSelectedConnectionString(comboBoxFunctionPrimaryServer, comboBoxFunctionPrimaryDatabase);
            var compareConnection = GetSelectedConnectionString(comboBoxFunctionCompareServer, comboBoxFunctionCompareDatabase);

            if (primaryConnection is null)
            {
                MessageBox.Show("Select a primary server and database.", "Function Explorer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (compareConnection is null)
            {
                MessageBox.Show("Select a comparison server and database.", "Function Explorer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _primaryFunctionDefinitions = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            _compareFunctionDefinitions = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            try
            {
                HashSet<string> primaryFunctions;
                HashSet<string> compareFunctions;

                using (new CursorScope(Cursors.WaitCursor))
                {
                    var primaryFunctionsTask = GetFunctionsAsync(primaryConnection);
                    var compareFunctionsTask = GetFunctionsAsync(compareConnection);
                    var primaryDefinitionsTask = GetFunctionDefinitionsAsync(primaryConnection);
                    var compareDefinitionsTask = GetFunctionDefinitionsAsync(compareConnection);

                    await Task.WhenAll(primaryFunctionsTask, compareFunctionsTask, primaryDefinitionsTask, compareDefinitionsTask);

                    primaryFunctions = await primaryFunctionsTask;
                    compareFunctions = await compareFunctionsTask;
                    _primaryFunctionDefinitions = await primaryDefinitionsTask;
                    _compareFunctionDefinitions = await compareDefinitionsTask;
                }

                var comparisons = BuildFunctionComparisons(primaryFunctions, compareFunctions, _primaryFunctionDefinitions, _compareFunctionDefinitions).ToList();
                BindFunctionComparison(comparisons);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load functions: {ex.Message}", "Function Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private enum DiffKind
        {
            Unchanged,
            Added,
            Removed
        }

        private sealed record DiffLine(string? Primary, string? Comparison, DiffKind Kind);

        private void RenderDefinitionDiff(string primaryDefinition, string comparisonDefinition)
        {
            var diffLines = BuildLineDiff(primaryDefinition, comparisonDefinition);

            RenderDiffToBox(textBoxPrimaryViewDefinition, diffLines, isPrimary: true);
            RenderDiffToBox(textBoxCompareViewDefinition, diffLines, isPrimary: false);
        }

        private static List<DiffLine> BuildLineDiff(string primaryDefinition, string comparisonDefinition)
        {
            var primaryLines = SplitLines(primaryDefinition);
            var compareLines = SplitLines(comparisonDefinition);

            var m = primaryLines.Length;
            var n = compareLines.Length;
            var lcs = new int[m + 1, n + 1];

            for (var i = m - 1; i >= 0; i--)
            {
                for (var j = n - 1; j >= 0; j--)
                {
                    if (string.Equals(primaryLines[i], compareLines[j], StringComparison.Ordinal))
                    {
                        lcs[i, j] = lcs[i + 1, j + 1] + 1;
                    }
                    else
                    {
                        lcs[i, j] = Math.Max(lcs[i + 1, j], lcs[i, j + 1]);
                    }
                }
            }

            var results = new List<DiffLine>();
            var x = 0;
            var y = 0;

            while (x < m && y < n)
            {
                if (string.Equals(primaryLines[x], compareLines[y], StringComparison.Ordinal))
                {
                    results.Add(new DiffLine(primaryLines[x], compareLines[y], DiffKind.Unchanged));
                    x++;
                    y++;
                }
                else if (lcs[x + 1, y] >= lcs[x, y + 1])
                {
                    results.Add(new DiffLine(primaryLines[x], null, DiffKind.Removed));
                    x++;
                }
                else
                {
                    results.Add(new DiffLine(null, compareLines[y], DiffKind.Added));
                    y++;
                }
            }

            while (x < m)
            {
                results.Add(new DiffLine(primaryLines[x], null, DiffKind.Removed));
                x++;
            }

            while (y < n)
            {
                results.Add(new DiffLine(null, compareLines[y], DiffKind.Added));
                y++;
            }

            return results;
        }

        private static string[] SplitLines(string text)
        {
            return text.Replace("\r\n", "\n", StringComparison.Ordinal)
                .Replace('\r', '\n')
                .Split('\n');
        }

        private static void RenderDiffToBox(RichTextBox box, IEnumerable<DiffLine> lines, bool isPrimary)
        {
            box.SuspendLayout();
            box.Clear();

            foreach (var line in lines)
            {
                var content = isPrimary ? line.Primary : line.Comparison;
                var prefix = line.Kind switch
                {
                    DiffKind.Added => "+ ",
                    DiffKind.Removed => "- ",
                    _ => "  "
                };

                var text = (content ?? string.Empty).Length == 0 ? string.Empty : content;
                var color = Color.Black;
                Color? backColor = null;

                if (line.Kind == DiffKind.Added && !isPrimary)
                {
                    backColor = Color.FromArgb(214, 241, 214);
                    color = Color.FromArgb(0, 102, 0);
                }
                else if (line.Kind == DiffKind.Removed && isPrimary)
                {
                    backColor = Color.FromArgb(250, 220, 220);
                    color = Color.FromArgb(153, 0, 0);
                }

                AppendLine(box, prefix + text, color, backColor);
            }

            box.ResumeLayout();
        }

        private static void AppendLine(RichTextBox box, string text, Color foreColor, Color? backColor)
        {
            var start = box.TextLength;
            box.AppendText(text + Environment.NewLine);
            box.Select(start, text.Length);
            box.SelectionColor = foreColor;
            if (backColor.HasValue)
            {
                box.SelectionBackColor = backColor.Value;
            }
            else
            {
                box.SelectionBackColor = box.BackColor;
            }

            box.SelectionLength = 0;
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
                batchNumber = await LogEntry.GetNextBatchNumberAsync();
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

                        await connection.OpenAsync();
                        await command.ExecuteNonQueryAsync();

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
                            });
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
                            });
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

            await RefreshBatchesAsync(batchNumber);
            ShowLogsTabForBatch(batchNumber);
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

        private void DataGridViewLogs_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            ConfigureLogGridColumns();
            ApplyLogRowStyles();
        }

        private void ConfigureLogGridColumns()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(ConfigureLogGridColumns));
                return;
            }

            if (dataGridViewLogs.IsDisposed || !dataGridViewLogs.IsHandleCreated || dataGridViewLogs.Columns.Count == 0)
            {
                return;
            }

            dataGridViewLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridViewLogs.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            var headers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                [nameof(LogEntry.Id)] = "ID",
                [nameof(LogEntry.BatchNumber)] = "Batch #",
                [nameof(LogEntry.Environment)] = "Environment",
                [nameof(LogEntry.SqlServer)] = "SQL Server",
                [nameof(LogEntry.DatabaseName)] = "Database",
                [nameof(LogEntry.User)] = "User",
                [nameof(LogEntry.Success)] = "Success",
                [nameof(LogEntry.CreatedDate)] = "Created",
                [nameof(LogEntry.ScriptRan)] = "Script Ran",
                [nameof(LogEntry.ErrorMessage)] = "Error"
            };

            void SetColumnWeight(string name, float weight, int minimumWidth = 70)
            {
                if (dataGridViewLogs.IsDisposed || dataGridViewLogs.Columns[name] is not DataGridViewColumn column)
                {
                    return;
                }

                // If the grid is currently rebuilding or disposing, the column may temporarily lose
                // its DataGridView reference, which can surface as a NullReferenceException when
                // setting sizing properties. Guard against that state and skip sizing until the
                // next binding pass.
                if (column.DataGridView is null || column.DataGridView.IsDisposed || !column.DataGridView.IsHandleCreated)
                {
                    return;
                }

                try
                {
                    column.FillWeight = weight;
                    column.SortMode = DataGridViewColumnSortMode.Programmatic;
                    if (minimumWidth > 0)
                    {
                        column.MinimumWidth = minimumWidth;
                    }
                    column.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

                    if (headers.TryGetValue(name, out var header))
                    {
                        column.HeaderText = header;
                    }
                }
                catch (NullReferenceException)
                {
                    return;
                }
                catch (InvalidOperationException)
                {
                    return;
                }
            }

            SetColumnWeight(nameof(LogEntry.Id), 50, 50);
            SetColumnWeight(nameof(LogEntry.BatchNumber), 90, 90);
            SetColumnWeight(nameof(LogEntry.Environment), 90);
            SetColumnWeight(nameof(LogEntry.SqlServer), 120);
            SetColumnWeight(nameof(LogEntry.DatabaseName), 120);
            SetColumnWeight(nameof(LogEntry.User), 100);
            SetColumnWeight(nameof(LogEntry.Success), 70, 60);
            SetColumnWeight(nameof(LogEntry.CreatedDate), 180, 160);
            SetColumnWeight(nameof(LogEntry.ScriptRan), 200);
            SetColumnWeight(nameof(LogEntry.ErrorMessage), 180);

            int displayIndex = 0;
            void SetDisplayIndex(string name)
            {
                if (dataGridViewLogs.Columns[name] is DataGridViewColumn column)
                {
                    column.DisplayIndex = displayIndex++;
                }
            }

            SetDisplayIndex(nameof(LogEntry.BatchNumber));
            SetDisplayIndex(nameof(LogEntry.Environment));
            SetDisplayIndex(nameof(LogEntry.SqlServer));
            SetDisplayIndex(nameof(LogEntry.DatabaseName));
            SetDisplayIndex(nameof(LogEntry.CreatedDate));
            SetDisplayIndex(nameof(LogEntry.User));
            SetDisplayIndex(nameof(LogEntry.Success));
            SetDisplayIndex(nameof(LogEntry.ScriptRan));
            SetDisplayIndex(nameof(LogEntry.ErrorMessage));
            SetDisplayIndex(nameof(LogEntry.Id));

            if (dataGridViewLogs.Columns[nameof(LogEntry.CreatedDate)] is DataGridViewColumn createdDateColumn)
            {
                createdDateColumn.DefaultCellStyle.Format = "G";
            }

            if (dataGridViewLogs.Columns[nameof(LogEntry.Success)] is DataGridViewColumn successColumn)
            {
                successColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                successColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void ApplyLogRowStyles()
        {
            foreach (DataGridViewRow row in dataGridViewLogs.Rows)
            {
                if (row.DataBoundItem is not LogEntry entry)
                {
                    continue;
                }

                var successBackColor = Color.FromArgb(214, 241, 214);
                var successSelectColor = Color.FromArgb(173, 217, 173);
                var failureBackColor = Color.FromArgb(250, 220, 220);
                var failureSelectColor = Color.FromArgb(235, 184, 184);

                row.DefaultCellStyle.BackColor = entry.Success ? successBackColor : failureBackColor;
                row.DefaultCellStyle.SelectionBackColor = entry.Success ? successSelectColor : failureSelectColor;
            }
        }

        private void ShowLogsTabForBatch(int batchNumber)
        {
            tabControlRight.SelectedTab = tabPageLogs;
            if (comboBoxBatchSelect.Items.Contains(batchNumber))
            {
                comboBoxBatchSelect.SelectedItem = batchNumber;
            }
        }

        private void EnsureEnvironmentSelected(string? environment)
        {
            if (string.IsNullOrWhiteSpace(environment))
            {
                return;
            }

            foreach (var item in comboBoxEnvironment.Items)
            {
                if (string.Equals(item?.ToString(), environment, StringComparison.OrdinalIgnoreCase))
                {
                    comboBoxEnvironment.SelectedItem = item;
                    break;
                }
            }
        }

        private bool TrySelectDatabaseNode(string? server, string? database)
        {
            if (string.IsNullOrWhiteSpace(server) || string.IsNullOrWhiteSpace(database))
            {
                return false;
            }

            foreach (TreeNode serverNode in treeViewCategories.Nodes)
            {
                if (!string.Equals(serverNode.Text, server, StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                serverNode.Expand();

                foreach (TreeNode databaseNode in serverNode.Nodes)
                {
                    if (!string.Equals(databaseNode.Text, database, StringComparison.OrdinalIgnoreCase))
                    {
                        continue;
                    }

                    treeViewCategories.SelectedNode = databaseNode;
                    databaseNode.Checked = true;
                    databaseNode.EnsureVisible();
                    return true;
                }
            }

            return false;
        }

        private sealed record SqlServerNode(string ServerName, IReadOnlyList<DatabaseNode> Databases);
        private sealed record DatabaseNode(string Name, string ConnectionString);
        private sealed record ViewComparisonRow
        {
            public string ViewName { get; init; } = string.Empty;
            [Browsable(false)]
            public bool InPrimary { get; init; }

            [Browsable(false)]
            public bool InComparison { get; init; }

            public string PrimaryStatus => InPrimary ? "✔" : "✖";

            public string ComparisonStatus => InComparison ? "✔" : "✖";

            public string Summary { get; init; } = string.Empty;
        }

        private sealed record TableComparisonRow
        {
            public string TableName { get; init; } = string.Empty;
            [Browsable(false)]
            public bool InPrimary { get; init; }

            [Browsable(false)]
            public bool InComparison { get; init; }

            public string PrimaryStatus => InPrimary ? "✔" : "✖";

            public string ComparisonStatus => InComparison ? "✔" : "✖";

            public string Summary { get; init; } = string.Empty;
        }

        private sealed record ProcedureComparisonRow
        {
            public string ProcedureName { get; init; } = string.Empty;
            [Browsable(false)]
            public bool InPrimary { get; init; }

            [Browsable(false)]
            public bool InComparison { get; init; }

            public string PrimaryStatus => InPrimary ? "✔" : "✖";

            public string ComparisonStatus => InComparison ? "✔" : "✖";

            public string Summary { get; init; } = string.Empty;
        }

        private sealed record FunctionComparisonRow
        {
            public string FunctionName { get; init; } = string.Empty;
            [Browsable(false)]
            public bool InPrimary { get; init; }

            [Browsable(false)]
            public bool InComparison { get; init; }

            public string PrimaryStatus => InPrimary ? "✔" : "✖";

            public string ComparisonStatus => InComparison ? "✔" : "✖";

            public string Summary { get; init; } = string.Empty;
        }

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
