using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TreeViewApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            comboBoxEnvironment.SelectedIndexChanged += ComboBoxEnvironment_SelectedIndexChanged;
            textBoxSql.TextChanged += TextBoxSql_TextChanged;
            treeViewCategories.AfterCheck += TreeViewCategories_AfterCheck;
            treeViewCategories.NodeMouseClick += TreeViewCategories_NodeMouseClick;
            buttonSelectAll.Click += (_, _) => SetAllNodesChecked(true);
            buttonDeselectAll.Click += (_, _) => SetAllNodesChecked(false);
            buttonRun.Click += (_, _) => HandleRunClick();
            buttonClear.Click += (_, _) => HandleClearClick();
            contextMenuTree.Opening += ContextMenuTree_Opening;
            toolStripMenuItemSelectServer.Click += (_, _) => SetSelectedServerChecked(true);
            toolStripMenuItemDeselectServer.Click += (_, _) => SetSelectedServerChecked(false);
            comboBoxEnvironment.SelectedIndex = 0;
        }

        private static readonly string[] BannedWords = new[] { "drop", "truncate", "delete", "alter", "update", "insert" };
        private bool _isUpdatingChecks;

        /// <summary>
        /// Populates the tree view with sample SQL servers and databases.
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
                    serverNode.Nodes.Add(database);
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

        private IEnumerable<SqlServerNode> GetEnvironmentServers()
        {
            var servers = new Dictionary<string, List<SqlServerNode>>(StringComparer.OrdinalIgnoreCase)
            {
                ["UAT"] = new List<SqlServerNode>
                {
                    new SqlServerNode("uat-sql-01", new[] { "SalesDb_UAT", "Reporting_UAT", "Archive_UAT" }),
                    new SqlServerNode("uat-sql-02", new[] { "Inventory_UAT", "Operations_UAT" })
                },
                ["Production"] = new List<SqlServerNode>
                {
                    new SqlServerNode("prod-sql-01", new[] { "SalesDb", "Reporting", "Compliance" }),
                    new SqlServerNode("prod-sql-02", new[] { "Inventory", "Operations", "Telemetry" })
                }
            };

            var environment = comboBoxEnvironment.SelectedItem as string ?? "UAT";

            return servers.TryGetValue(environment, out var nodes)
                ? nodes
                : Array.Empty<SqlServerNode>();
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

        private void HandleRunClick()
        {
            var selectedCount = CountCheckedDatabases();

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
                MessageBox.Show("Run confirmed.", "Run", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private int CountCheckedDatabases()
        {
            var count = 0;
            foreach (TreeNode serverNode in treeViewCategories.Nodes)
            {
                foreach (TreeNode databaseNode in serverNode.Nodes)
                {
                    if (databaseNode.Checked)
                    {
                        count++;
                    }
                }
            }

            return count;
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

        private sealed record SqlServerNode(string ServerName, IEnumerable<string> Databases);
    }
}
