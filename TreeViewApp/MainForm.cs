using System;
using System.Collections.Generic;
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
            buttonSelectAll.Click += (_, _) => SetAllNodesChecked(true);
            buttonDeselectAll.Click += (_, _) => SetAllNodesChecked(false);
            buttonSelectServer.Click += (_, _) => SetSelectedServerChecked(true);
            buttonDeselectServer.Click += (_, _) => SetSelectedServerChecked(false);
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
            var serverNode = GetServerNode(treeViewCategories.SelectedNode);
            if (serverNode is null)
            {
                return;
            }

            _isUpdatingChecks = true;
            try
            {
                serverNode.Checked = isChecked;
                SetChildrenChecked(serverNode, isChecked);
                UpdateParentCheckState(serverNode.Parent);
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

        private void SetChildrenChecked(TreeNode parent, bool isChecked)
        {
            foreach (TreeNode child in parent.Nodes)
            {
                child.Checked = isChecked;
                SetChildrenChecked(child, isChecked);
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

        private static TreeNode? GetServerNode(TreeNode? node)
        {
            return node switch
            {
                null => null,
                { Level: 0 } => node,
                _ => node.Parent
            };
        }

        private sealed record SqlServerNode(string ServerName, IEnumerable<string> Databases);
    }
}
