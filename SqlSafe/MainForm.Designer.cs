namespace SqlSafe
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelEnvironment = new System.Windows.Forms.FlowLayoutPanel();
            this.labelEnvironment = new System.Windows.Forms.Label();
            this.comboBoxEnvironment = new System.Windows.Forms.ComboBox();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.buttonDeselectAll = new System.Windows.Forms.Button();
            this.labelWarning = new System.Windows.Forms.Label();
            this.treeViewCategories = new System.Windows.Forms.TreeView();
            this.tabControlRight = new System.Windows.Forms.TabControl();
            this.tabPageSql = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelSqlEditor = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelSqlActions = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxSql = new System.Windows.Forms.TextBox();
            this.tabPageLogs = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelLogs = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLogFilters = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLogFiltersLeft = new System.Windows.Forms.TableLayoutPanel();
            this.labelBatch = new System.Windows.Forms.Label();
            this.comboBoxBatchSelect = new System.Windows.Forms.ComboBox();
            this.labelDatabaseFilter = new System.Windows.Forms.Label();
            this.comboBoxDatabaseFilter = new System.Windows.Forms.ComboBox();
            this.labelEnvironmentFilter = new System.Windows.Forms.Label();
            this.comboBoxEnvironmentFilter = new System.Windows.Forms.ComboBox();
            this.labelUserFilter = new System.Windows.Forms.Label();
            this.comboBoxUserFilter = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelLogBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.labelCreatedFrom = new System.Windows.Forms.Label();
            this.dateTimePickerCreatedFrom = new System.Windows.Forms.DateTimePicker();
            this.labelCreatedTo = new System.Windows.Forms.Label();
            this.dateTimePickerCreatedTo = new System.Windows.Forms.DateTimePicker();
            this.labelScriptSearch = new System.Windows.Forms.Label();
            this.textBoxScriptSearch = new System.Windows.Forms.TextBox();
            this.buttonApplyFilters = new System.Windows.Forms.Button();
            this.dataGridViewLogs = new System.Windows.Forms.DataGridView();
            this.contextMenuLogs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemCopyScript = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCopyError = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRetry = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageViews = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelViews = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelViewSelectors = new System.Windows.Forms.FlowLayoutPanel();
            this.labelPrimaryServer = new System.Windows.Forms.Label();
            this.comboBoxViewPrimaryServer = new System.Windows.Forms.ComboBox();
            this.labelPrimaryDatabase = new System.Windows.Forms.Label();
            this.comboBoxViewPrimaryDatabase = new System.Windows.Forms.ComboBox();
            this.labelCompareServer = new System.Windows.Forms.Label();
            this.comboBoxViewCompareServer = new System.Windows.Forms.ComboBox();
            this.labelCompareDatabase = new System.Windows.Forms.Label();
            this.comboBoxViewCompareDatabase = new System.Windows.Forms.ComboBox();
            this.buttonLoadViews = new System.Windows.Forms.Button();
            this.flowLayoutPanelViewSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.labelViewSearch = new System.Windows.Forms.Label();
            this.textBoxViewSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewViewComparison = new System.Windows.Forms.DataGridView();
            this.contextMenuTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemSelectServer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeselectServer = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.flowLayoutPanelEnvironment.SuspendLayout();
            this.tabControlRight.SuspendLayout();
            this.tabPageSql.SuspendLayout();
            this.tabPageLogs.SuspendLayout();
            this.tableLayoutPanelLogs.SuspendLayout();
            this.tableLayoutPanelLogFilters.SuspendLayout();
            this.tableLayoutPanelLogFiltersLeft.SuspendLayout();
            this.flowLayoutPanelLogBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).BeginInit();
            this.contextMenuLogs.SuspendLayout();
            this.tabPageViews.SuspendLayout();
            this.tableLayoutPanelViews.SuspendLayout();
            this.flowLayoutPanelViewSelectors.SuspendLayout();
            this.flowLayoutPanelViewSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewComparison)).BeginInit();
            this.contextMenuTree.SuspendLayout();
            this.SuspendLayout();
            //
            // tableLayoutPanelMain
            //
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.flowLayoutPanelEnvironment, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.splitContainerMain, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(860, 469);
            this.tableLayoutPanelMain.TabIndex = 0;
            //
            // splitContainerMain
            //
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(3, 44);
            this.splitContainerMain.Name = "splitContainerMain";
            //
            // splitContainerMain.Panel1
            //
            this.splitContainerMain.Panel1.Controls.Add(this.treeViewCategories);
            //
            // splitContainerMain.Panel2
            //
            this.splitContainerMain.Panel2.Controls.Add(this.tabControlRight);
            this.splitContainerMain.Size = new System.Drawing.Size(854, 404);
            this.splitContainerMain.SplitterDistance = 278;
            this.splitContainerMain.TabIndex = 2;
            //
            // flowLayoutPanelEnvironment
            //
            this.flowLayoutPanelEnvironment.AutoSize = true;
            this.flowLayoutPanelEnvironment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelEnvironment.Controls.Add(this.labelEnvironment);
            this.flowLayoutPanelEnvironment.Controls.Add(this.comboBoxEnvironment);
            this.flowLayoutPanelEnvironment.Controls.Add(this.buttonSelectAll);
            this.flowLayoutPanelEnvironment.Controls.Add(this.buttonDeselectAll);
            this.flowLayoutPanelEnvironment.Controls.Add(this.labelWarning);
            this.flowLayoutPanelEnvironment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelEnvironment.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelEnvironment.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.flowLayoutPanelEnvironment.Name = "flowLayoutPanelEnvironment";
            this.flowLayoutPanelEnvironment.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.flowLayoutPanelEnvironment.Size = new System.Drawing.Size(854, 35);
            this.flowLayoutPanelEnvironment.TabIndex = 1;
            //
            // labelEnvironment
            //
            this.labelEnvironment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelEnvironment.AutoSize = true;
            this.labelEnvironment.Location = new System.Drawing.Point(9, 10);
            this.labelEnvironment.Name = "labelEnvironment";
            this.labelEnvironment.Size = new System.Drawing.Size(75, 15);
            this.labelEnvironment.TabIndex = 0;
            this.labelEnvironment.Text = "Environment:";
            //
            // comboBoxEnvironment
            //
            this.comboBoxEnvironment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEnvironment.FormattingEnabled = true;
            this.comboBoxEnvironment.Items.AddRange(new object[] {
            "UAT",
            "Production"});
            this.comboBoxEnvironment.Location = new System.Drawing.Point(90, 6);
            this.comboBoxEnvironment.Name = "comboBoxEnvironment";
            this.comboBoxEnvironment.Size = new System.Drawing.Size(150, 23);
            this.comboBoxEnvironment.TabIndex = 1;
            //
            // buttonSelectAll
            //
            this.buttonSelectAll.AutoSize = true;
            this.buttonSelectAll.Location = new System.Drawing.Point(246, 6);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(98, 25);
            this.buttonSelectAll.TabIndex = 2;
            this.buttonSelectAll.Text = "Select All";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            //
            // buttonDeselectAll
            //
            this.buttonDeselectAll.AutoSize = true;
            this.buttonDeselectAll.Location = new System.Drawing.Point(350, 6);
            this.buttonDeselectAll.Name = "buttonDeselectAll";
            this.buttonDeselectAll.Size = new System.Drawing.Size(98, 25);
            this.buttonDeselectAll.TabIndex = 3;
            this.buttonDeselectAll.Text = "Deselect All";
            this.buttonDeselectAll.UseVisualStyleBackColor = true;
            //
            // labelWarning
            //
            this.labelWarning.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelWarning.AutoSize = true;
            this.labelWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.labelWarning.Location = new System.Drawing.Point(454, 10);
            this.labelWarning.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(0, 15);
            this.labelWarning.TabIndex = 2;
            this.labelWarning.Visible = false;
            //
            // treeViewCategories
            //
            this.treeViewCategories.CheckBoxes = true;
            this.treeViewCategories.ContextMenuStrip = this.contextMenuTree;
            this.treeViewCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewCategories.Location = new System.Drawing.Point(0, 0);
            this.treeViewCategories.Name = "treeViewCategories";
            this.treeViewCategories.Size = new System.Drawing.Size(278, 404);
            this.treeViewCategories.TabIndex = 0;
            //
            // tabControlRight
            //
            this.tabControlRight.Controls.Add(this.tabPageSql);
            this.tabControlRight.Controls.Add(this.tabPageLogs);
            this.tabControlRight.Controls.Add(this.tabPageViews);
            this.tabControlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlRight.Location = new System.Drawing.Point(0, 0);
            this.tabControlRight.Name = "tabControlRight";
            this.tabControlRight.SelectedIndex = 0;
            this.tabControlRight.Size = new System.Drawing.Size(572, 404);
            this.tabControlRight.TabIndex = 4;
            //
            // tabPageSql
            //
            this.tabPageSql.Controls.Add(this.tableLayoutPanelSqlEditor);
            this.tabPageSql.Location = new System.Drawing.Point(4, 24);
            this.tabPageSql.Name = "tabPageSql";
            this.tabPageSql.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSql.Size = new System.Drawing.Size(564, 376);
            this.tabPageSql.TabIndex = 0;
            this.tabPageSql.Text = "SQL Editor";
            this.tabPageSql.UseVisualStyleBackColor = true;
            //
            // tableLayoutPanelSqlEditor
            //
            this.tableLayoutPanelSqlEditor.ColumnCount = 1;
            this.tableLayoutPanelSqlEditor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSqlEditor.Controls.Add(this.flowLayoutPanelSqlActions, 0, 0);
            this.tableLayoutPanelSqlEditor.Controls.Add(this.textBoxSql, 0, 1);
            this.tableLayoutPanelSqlEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSqlEditor.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelSqlEditor.Name = "tableLayoutPanelSqlEditor";
            this.tableLayoutPanelSqlEditor.RowCount = 2;
            this.tableLayoutPanelSqlEditor.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelSqlEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSqlEditor.Size = new System.Drawing.Size(558, 370);
            this.tableLayoutPanelSqlEditor.TabIndex = 0;
            //
            // flowLayoutPanelSqlActions
            //
            this.flowLayoutPanelSqlActions.AutoSize = true;
            this.flowLayoutPanelSqlActions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelSqlActions.Controls.Add(this.buttonRun);
            this.flowLayoutPanelSqlActions.Controls.Add(this.buttonClear);
            this.flowLayoutPanelSqlActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelSqlActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelSqlActions.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelSqlActions.Name = "flowLayoutPanelSqlActions";
            this.flowLayoutPanelSqlActions.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.flowLayoutPanelSqlActions.Size = new System.Drawing.Size(552, 31);
            this.flowLayoutPanelSqlActions.TabIndex = 0;
            this.flowLayoutPanelSqlActions.WrapContents = false;
            //
            // buttonRun
            //
            this.buttonRun.AutoSize = true;
            this.buttonRun.Location = new System.Drawing.Point(479, 3);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(70, 25);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            //
            // buttonClear
            //
            this.buttonClear.AutoSize = true;
            this.buttonClear.Location = new System.Drawing.Point(403, 3);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(70, 25);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            //
            // textBoxSql
            //
            this.textBoxSql.AcceptsReturn = true;
            this.textBoxSql.AcceptsTab = true;
            this.textBoxSql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSql.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSql.Location = new System.Drawing.Point(3, 40);
            this.textBoxSql.Multiline = true;
            this.textBoxSql.Name = "textBoxSql";
            this.textBoxSql.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSql.Size = new System.Drawing.Size(552, 327);
            this.textBoxSql.TabIndex = 3;
            this.textBoxSql.WordWrap = false;
            //
            // tabPageLogs
            //
            this.tabPageLogs.Controls.Add(this.tableLayoutPanelLogs);
            this.tabPageLogs.Location = new System.Drawing.Point(4, 24);
            this.tabPageLogs.Name = "tabPageLogs";
            this.tabPageLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogs.Size = new System.Drawing.Size(564, 376);
            this.tabPageLogs.TabIndex = 1;
            this.tabPageLogs.Text = "Execution Logs";
            this.tabPageLogs.UseVisualStyleBackColor = true;
            //
            // tableLayoutPanelLogs
            //
            this.tableLayoutPanelLogs.ColumnCount = 1;
            this.tableLayoutPanelLogs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLogs.Controls.Add(this.tableLayoutPanelLogFilters, 0, 0);
            this.tableLayoutPanelLogs.Controls.Add(this.dataGridViewLogs, 0, 1);
            this.tableLayoutPanelLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLogs.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelLogs.Name = "tableLayoutPanelLogs";
            this.tableLayoutPanelLogs.RowCount = 2;
            this.tableLayoutPanelLogs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLogs.Size = new System.Drawing.Size(558, 370);
            this.tableLayoutPanelLogs.TabIndex = 0;
            //
            // tableLayoutPanelLogFilters
            //
            this.tableLayoutPanelLogFilters.AutoSize = true;
            this.tableLayoutPanelLogFilters.ColumnCount = 2;
            this.tableLayoutPanelLogFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelLogFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLogFilters.Controls.Add(this.tableLayoutPanelLogFiltersLeft, 0, 0);
            this.tableLayoutPanelLogFilters.Controls.Add(this.flowLayoutPanelLogBottom, 1, 0);
            this.tableLayoutPanelLogFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLogFilters.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelLogFilters.Name = "tableLayoutPanelLogFilters";
            this.tableLayoutPanelLogFilters.RowCount = 1;
            this.tableLayoutPanelLogFilters.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLogFilters.Size = new System.Drawing.Size(552, 98);
            this.tableLayoutPanelLogFilters.TabIndex = 0;
            //
            // tableLayoutPanelLogFiltersLeft
            //
            this.tableLayoutPanelLogFiltersLeft.AutoSize = true;
            this.tableLayoutPanelLogFiltersLeft.ColumnCount = 2;
            this.tableLayoutPanelLogFiltersLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelLogFiltersLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelLogFiltersLeft.Controls.Add(this.labelBatch, 0, 0);
            this.tableLayoutPanelLogFiltersLeft.Controls.Add(this.comboBoxBatchSelect, 1, 0);
            this.tableLayoutPanelLogFiltersLeft.Controls.Add(this.labelDatabaseFilter, 0, 1);
            this.tableLayoutPanelLogFiltersLeft.Controls.Add(this.comboBoxDatabaseFilter, 1, 1);
            this.tableLayoutPanelLogFiltersLeft.Controls.Add(this.labelEnvironmentFilter, 0, 2);
            this.tableLayoutPanelLogFiltersLeft.Controls.Add(this.comboBoxEnvironmentFilter, 1, 2);
            this.tableLayoutPanelLogFiltersLeft.Controls.Add(this.labelUserFilter, 0, 3);
            this.tableLayoutPanelLogFiltersLeft.Controls.Add(this.comboBoxUserFilter, 1, 3);
            this.tableLayoutPanelLogFiltersLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLogFiltersLeft.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelLogFiltersLeft.Name = "tableLayoutPanelLogFiltersLeft";
            this.tableLayoutPanelLogFiltersLeft.RowCount = 4;
            this.tableLayoutPanelLogFiltersLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLogFiltersLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLogFiltersLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLogFiltersLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLogFiltersLeft.Size = new System.Drawing.Size(260, 92);
            this.tableLayoutPanelLogFiltersLeft.TabIndex = 2;
            //
            // labelBatch
            //
            this.labelBatch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelBatch.AutoSize = true;
            this.labelBatch.Location = new System.Drawing.Point(6, 10);
            this.labelBatch.Name = "labelBatch";
            this.labelBatch.Size = new System.Drawing.Size(45, 15);
            this.labelBatch.TabIndex = 0;
            this.labelBatch.Text = "Batch:";
            //
            // comboBoxBatchSelect
            //
            this.comboBoxBatchSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBatchSelect.FormattingEnabled = true;
            this.comboBoxBatchSelect.Location = new System.Drawing.Point(57, 3);
            this.comboBoxBatchSelect.Name = "comboBoxBatchSelect";
            this.comboBoxBatchSelect.Size = new System.Drawing.Size(180, 23);
            this.comboBoxBatchSelect.TabIndex = 1;
            //
            // labelDatabaseFilter
            //
            this.labelDatabaseFilter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDatabaseFilter.AutoSize = true;
            this.labelDatabaseFilter.Location = new System.Drawing.Point(6, 27);
            this.labelDatabaseFilter.Name = "labelDatabaseFilter";
            this.labelDatabaseFilter.Size = new System.Drawing.Size(61, 15);
            this.labelDatabaseFilter.TabIndex = 3;
            this.labelDatabaseFilter.Text = "Database:";
            //
            // comboBoxDatabaseFilter
            //
            this.comboBoxDatabaseFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDatabaseFilter.FormattingEnabled = true;
            this.comboBoxDatabaseFilter.Location = new System.Drawing.Point(73, 23);
            this.comboBoxDatabaseFilter.Name = "comboBoxDatabaseFilter";
            this.comboBoxDatabaseFilter.Size = new System.Drawing.Size(180, 23);
            this.comboBoxDatabaseFilter.TabIndex = 4;
            //
            // labelEnvironmentFilter
            //
            this.labelEnvironmentFilter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelEnvironmentFilter.AutoSize = true;
            this.labelEnvironmentFilter.Location = new System.Drawing.Point(6, 50);
            this.labelEnvironmentFilter.Name = "labelEnvironmentFilter";
            this.labelEnvironmentFilter.Size = new System.Drawing.Size(77, 15);
            this.labelEnvironmentFilter.TabIndex = 5;
            this.labelEnvironmentFilter.Text = "Environment:";
            //
            // comboBoxEnvironmentFilter
            //
            this.comboBoxEnvironmentFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEnvironmentFilter.FormattingEnabled = true;
            this.comboBoxEnvironmentFilter.Location = new System.Drawing.Point(89, 46);
            this.comboBoxEnvironmentFilter.Name = "comboBoxEnvironmentFilter";
            this.comboBoxEnvironmentFilter.Size = new System.Drawing.Size(180, 23);
            this.comboBoxEnvironmentFilter.TabIndex = 6;
            //
            // labelUserFilter
            //
            this.labelUserFilter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelUserFilter.AutoSize = true;
            this.labelUserFilter.Location = new System.Drawing.Point(6, 73);
            this.labelUserFilter.Name = "labelUserFilter";
            this.labelUserFilter.Size = new System.Drawing.Size(33, 15);
            this.labelUserFilter.TabIndex = 7;
            this.labelUserFilter.Text = "User:";
            //
            // comboBoxUserFilter
            //
            this.comboBoxUserFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserFilter.FormattingEnabled = true;
            this.comboBoxUserFilter.Location = new System.Drawing.Point(45, 69);
            this.comboBoxUserFilter.Name = "comboBoxUserFilter";
            this.comboBoxUserFilter.Size = new System.Drawing.Size(180, 23);
            this.comboBoxUserFilter.TabIndex = 8;
            //
            // flowLayoutPanelLogBottom
            //
            this.flowLayoutPanelLogBottom.AutoSize = true;
            this.flowLayoutPanelLogBottom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelLogBottom.Controls.Add(this.labelCreatedFrom);
            this.flowLayoutPanelLogBottom.Controls.Add(this.dateTimePickerCreatedFrom);
            this.flowLayoutPanelLogBottom.Controls.Add(this.labelCreatedTo);
            this.flowLayoutPanelLogBottom.Controls.Add(this.dateTimePickerCreatedTo);
            this.flowLayoutPanelLogBottom.Controls.Add(this.labelScriptSearch);
            this.flowLayoutPanelLogBottom.Controls.Add(this.textBoxScriptSearch);
            this.flowLayoutPanelLogBottom.Controls.Add(this.buttonApplyFilters);
            this.flowLayoutPanelLogBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelLogBottom.Location = new System.Drawing.Point(282, 3);
            this.flowLayoutPanelLogBottom.Name = "flowLayoutPanelLogBottom";
            this.flowLayoutPanelLogBottom.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanelLogBottom.Size = new System.Drawing.Size(267, 44);
            this.flowLayoutPanelLogBottom.TabIndex = 1;
            //
            // labelCreatedFrom
            //
            this.labelCreatedFrom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCreatedFrom.AutoSize = true;
            this.labelCreatedFrom.Location = new System.Drawing.Point(6, 10);
            this.labelCreatedFrom.Name = "labelCreatedFrom";
            this.labelCreatedFrom.Size = new System.Drawing.Size(77, 15);
            this.labelCreatedFrom.TabIndex = 9;
            this.labelCreatedFrom.Text = "Created from:";
            //
            // dateTimePickerCreatedFrom
            //
            this.dateTimePickerCreatedFrom.Checked = false;
            this.dateTimePickerCreatedFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCreatedFrom.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePickerCreatedFrom.Location = new System.Drawing.Point(89, 6);
            this.dateTimePickerCreatedFrom.Name = "dateTimePickerCreatedFrom";
            this.dateTimePickerCreatedFrom.ShowCheckBox = true;
            this.dateTimePickerCreatedFrom.Size = new System.Drawing.Size(160, 23);
            this.dateTimePickerCreatedFrom.TabIndex = 10;
            //
            // labelCreatedTo
            //
            this.labelCreatedTo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCreatedTo.AutoSize = true;
            this.labelCreatedTo.Location = new System.Drawing.Point(255, 10);
            this.labelCreatedTo.Name = "labelCreatedTo";
            this.labelCreatedTo.Size = new System.Drawing.Size(20, 15);
            this.labelCreatedTo.TabIndex = 11;
            this.labelCreatedTo.Text = "to";
            //
            // dateTimePickerCreatedTo
            //
            this.dateTimePickerCreatedTo.Checked = false;
            this.dateTimePickerCreatedTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCreatedTo.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePickerCreatedTo.Location = new System.Drawing.Point(281, 6);
            this.dateTimePickerCreatedTo.Name = "dateTimePickerCreatedTo";
            this.dateTimePickerCreatedTo.ShowCheckBox = true;
            this.dateTimePickerCreatedTo.Size = new System.Drawing.Size(160, 23);
            this.dateTimePickerCreatedTo.TabIndex = 12;
            //
            // labelScriptSearch
            //
            this.labelScriptSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelScriptSearch.AutoSize = true;
            this.labelScriptSearch.Location = new System.Drawing.Point(447, 10);
            this.labelScriptSearch.Name = "labelScriptSearch";
            this.labelScriptSearch.Size = new System.Drawing.Size(86, 15);
            this.labelScriptSearch.TabIndex = 13;
            this.labelScriptSearch.Text = "Script search:";
            //
            // textBoxScriptSearch
            //
            this.textBoxScriptSearch.Location = new System.Drawing.Point(539, 6);
            this.textBoxScriptSearch.Name = "textBoxScriptSearch";
            this.textBoxScriptSearch.Size = new System.Drawing.Size(200, 23);
            this.textBoxScriptSearch.TabIndex = 14;
            //
            // buttonApplyFilters
            //
            this.buttonApplyFilters.AutoSize = true;
            this.buttonApplyFilters.Location = new System.Drawing.Point(745, 6);
            this.buttonApplyFilters.Name = "buttonApplyFilters";
            this.buttonApplyFilters.Size = new System.Drawing.Size(85, 25);
            this.buttonApplyFilters.TabIndex = 15;
            this.buttonApplyFilters.Text = "Apply Filters";
            this.buttonApplyFilters.UseVisualStyleBackColor = true;
            //
            // dataGridViewLogs
            //
            this.dataGridViewLogs.AllowUserToAddRows = false;
            this.dataGridViewLogs.AllowUserToDeleteRows = false;
            this.dataGridViewLogs.AllowUserToResizeRows = false;
            this.dataGridViewLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLogs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.None;
            this.dataGridViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLogs.ContextMenuStrip = this.contextMenuLogs;
            this.dataGridViewLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLogs.Location = new System.Drawing.Point(3, 77);
            this.dataGridViewLogs.Name = "dataGridViewLogs";
            this.dataGridViewLogs.ReadOnly = true;
            this.dataGridViewLogs.RowTemplate.Height = 25;
            this.dataGridViewLogs.Size = new System.Drawing.Size(552, 290);
            this.dataGridViewLogs.TabIndex = 1;
            //
            // contextMenuLogs
            //
            this.contextMenuLogs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCopyScript,
            this.toolStripMenuItemCopyError,
            this.toolStripMenuItemRetry});
            this.contextMenuLogs.Name = "contextMenuLogs";
            this.contextMenuLogs.Size = new System.Drawing.Size(140, 70);
            //
            // toolStripMenuItemCopyScript
            //
            this.toolStripMenuItemCopyScript.Name = "toolStripMenuItemCopyScript";
            this.toolStripMenuItemCopyScript.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItemCopyScript.Text = "Copy Script";
            //
            // toolStripMenuItemCopyError
            //
            this.toolStripMenuItemCopyError.Name = "toolStripMenuItemCopyError";
            this.toolStripMenuItemCopyError.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItemCopyError.Text = "Copy Error";
            //
            // toolStripMenuItemRetry
            //
            this.toolStripMenuItemRetry.Name = "toolStripMenuItemRetry";
            this.toolStripMenuItemRetry.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItemRetry.Text = "Retry";
            //
            // tabPageViews
            //
            this.tabPageViews.Controls.Add(this.tableLayoutPanelViews);
            this.tabPageViews.Location = new System.Drawing.Point(4, 24);
            this.tabPageViews.Name = "tabPageViews";
            this.tabPageViews.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageViews.Size = new System.Drawing.Size(564, 376);
            this.tabPageViews.TabIndex = 2;
            this.tabPageViews.Text = "View Explorer";
            this.tabPageViews.UseVisualStyleBackColor = true;
            //
            // tableLayoutPanelViews
            //
            this.tableLayoutPanelViews.ColumnCount = 1;
            this.tableLayoutPanelViews.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelViews.Controls.Add(this.flowLayoutPanelViewSelectors, 0, 0);
            this.tableLayoutPanelViews.Controls.Add(this.flowLayoutPanelViewSearch, 0, 1);
            this.tableLayoutPanelViews.Controls.Add(this.dataGridViewViewComparison, 0, 2);
            this.tableLayoutPanelViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelViews.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelViews.Name = "tableLayoutPanelViews";
            this.tableLayoutPanelViews.RowCount = 3;
            this.tableLayoutPanelViews.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelViews.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelViews.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelViews.Size = new System.Drawing.Size(558, 370);
            this.tableLayoutPanelViews.TabIndex = 0;
            //
            // flowLayoutPanelViewSelectors
            //
            this.flowLayoutPanelViewSelectors.AutoSize = true;
            this.flowLayoutPanelViewSelectors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelViewSelectors.Controls.Add(this.labelPrimaryServer);
            this.flowLayoutPanelViewSelectors.Controls.Add(this.comboBoxViewPrimaryServer);
            this.flowLayoutPanelViewSelectors.Controls.Add(this.labelPrimaryDatabase);
            this.flowLayoutPanelViewSelectors.Controls.Add(this.comboBoxViewPrimaryDatabase);
            this.flowLayoutPanelViewSelectors.Controls.Add(this.labelCompareServer);
            this.flowLayoutPanelViewSelectors.Controls.Add(this.comboBoxViewCompareServer);
            this.flowLayoutPanelViewSelectors.Controls.Add(this.labelCompareDatabase);
            this.flowLayoutPanelViewSelectors.Controls.Add(this.comboBoxViewCompareDatabase);
            this.flowLayoutPanelViewSelectors.Controls.Add(this.buttonLoadViews);
            this.flowLayoutPanelViewSelectors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelViewSelectors.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelViewSelectors.Name = "flowLayoutPanelViewSelectors";
            this.flowLayoutPanelViewSelectors.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanelViewSelectors.Size = new System.Drawing.Size(552, 34);
            this.flowLayoutPanelViewSelectors.TabIndex = 0;
            this.flowLayoutPanelViewSelectors.WrapContents = true;
            this.flowLayoutPanelViewSelectors.AutoScroll = true;
            //
            // labelPrimaryServer
            //
            this.labelPrimaryServer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPrimaryServer.AutoSize = true;
            this.labelPrimaryServer.Location = new System.Drawing.Point(6, 10);
            this.labelPrimaryServer.Name = "labelPrimaryServer";
            this.labelPrimaryServer.Size = new System.Drawing.Size(88, 15);
            this.labelPrimaryServer.TabIndex = 0;
            this.labelPrimaryServer.Text = "Primary server:";
            //
            // comboBoxViewPrimaryServer
            //
            this.comboBoxViewPrimaryServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxViewPrimaryServer.FormattingEnabled = true;
            this.comboBoxViewPrimaryServer.Location = new System.Drawing.Point(100, 6);
            this.comboBoxViewPrimaryServer.Name = "comboBoxViewPrimaryServer";
            this.comboBoxViewPrimaryServer.Size = new System.Drawing.Size(150, 23);
            this.comboBoxViewPrimaryServer.TabIndex = 1;
            //
            // labelPrimaryDatabase
            //
            this.labelPrimaryDatabase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPrimaryDatabase.AutoSize = true;
            this.labelPrimaryDatabase.Location = new System.Drawing.Point(256, 10);
            this.labelPrimaryDatabase.Name = "labelPrimaryDatabase";
            this.labelPrimaryDatabase.Size = new System.Drawing.Size(105, 15);
            this.labelPrimaryDatabase.TabIndex = 2;
            this.labelPrimaryDatabase.Text = "Primary database:";
            //
            // comboBoxViewPrimaryDatabase
            //
            this.comboBoxViewPrimaryDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxViewPrimaryDatabase.FormattingEnabled = true;
            this.comboBoxViewPrimaryDatabase.Location = new System.Drawing.Point(367, 6);
            this.comboBoxViewPrimaryDatabase.Name = "comboBoxViewPrimaryDatabase";
            this.comboBoxViewPrimaryDatabase.Size = new System.Drawing.Size(150, 23);
            this.comboBoxViewPrimaryDatabase.TabIndex = 3;
            //
            // labelCompareServer
            //
            this.labelCompareServer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCompareServer.AutoSize = true;
            this.labelCompareServer.Location = new System.Drawing.Point(523, 10);
            this.labelCompareServer.Name = "labelCompareServer";
            this.labelCompareServer.Size = new System.Drawing.Size(97, 15);
            this.labelCompareServer.TabIndex = 4;
            this.labelCompareServer.Text = "Compare server:";
            //
            // comboBoxViewCompareServer
            //
            this.comboBoxViewCompareServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxViewCompareServer.FormattingEnabled = true;
            this.comboBoxViewCompareServer.Location = new System.Drawing.Point(626, 6);
            this.comboBoxViewCompareServer.Name = "comboBoxViewCompareServer";
            this.comboBoxViewCompareServer.Size = new System.Drawing.Size(150, 23);
            this.comboBoxViewCompareServer.TabIndex = 5;
            //
            // labelCompareDatabase
            //
            this.labelCompareDatabase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCompareDatabase.AutoSize = true;
            this.labelCompareDatabase.Location = new System.Drawing.Point(782, 10);
            this.labelCompareDatabase.Name = "labelCompareDatabase";
            this.labelCompareDatabase.Size = new System.Drawing.Size(114, 15);
            this.labelCompareDatabase.TabIndex = 6;
            this.labelCompareDatabase.Text = "Compare database:";
            //
            // comboBoxViewCompareDatabase
            //
            this.comboBoxViewCompareDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxViewCompareDatabase.FormattingEnabled = true;
            this.comboBoxViewCompareDatabase.Location = new System.Drawing.Point(902, 6);
            this.comboBoxViewCompareDatabase.Name = "comboBoxViewCompareDatabase";
            this.comboBoxViewCompareDatabase.Size = new System.Drawing.Size(150, 23);
            this.comboBoxViewCompareDatabase.TabIndex = 7;
            //
            // buttonLoadViews
            //
            this.buttonLoadViews.AutoSize = true;
            this.buttonLoadViews.Location = new System.Drawing.Point(1058, 6);
            this.buttonLoadViews.Name = "buttonLoadViews";
            this.buttonLoadViews.Size = new System.Drawing.Size(81, 25);
            this.buttonLoadViews.TabIndex = 8;
            this.buttonLoadViews.Text = "Load Views";
            this.buttonLoadViews.UseVisualStyleBackColor = true;
            //
            // flowLayoutPanelViewSearch
            //
            this.flowLayoutPanelViewSearch.AutoSize = true;
            this.flowLayoutPanelViewSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelViewSearch.Controls.Add(this.labelViewSearch);
            this.flowLayoutPanelViewSearch.Controls.Add(this.textBoxViewSearch);
            this.flowLayoutPanelViewSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelViewSearch.Location = new System.Drawing.Point(3, 43);
            this.flowLayoutPanelViewSearch.Name = "flowLayoutPanelViewSearch";
            this.flowLayoutPanelViewSearch.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.flowLayoutPanelViewSearch.Size = new System.Drawing.Size(552, 29);
            this.flowLayoutPanelViewSearch.TabIndex = 1;
            //
            // labelViewSearch
            //
            this.labelViewSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelViewSearch.AutoSize = true;
            this.labelViewSearch.Location = new System.Drawing.Point(6, 5);
            this.labelViewSearch.Name = "labelViewSearch";
            this.labelViewSearch.Size = new System.Drawing.Size(73, 15);
            this.labelViewSearch.TabIndex = 0;
            this.labelViewSearch.Text = "View search:";
            //
            // textBoxViewSearch
            //
            this.textBoxViewSearch.Location = new System.Drawing.Point(85, 3);
            this.textBoxViewSearch.Name = "textBoxViewSearch";
            this.textBoxViewSearch.Size = new System.Drawing.Size(200, 23);
            this.textBoxViewSearch.TabIndex = 1;
            //
            // dataGridViewViewComparison
            //
            this.dataGridViewViewComparison.AllowUserToAddRows = false;
            this.dataGridViewViewComparison.AllowUserToDeleteRows = false;
            this.dataGridViewViewComparison.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewViewComparison.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViewComparison.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewViewComparison.Location = new System.Drawing.Point(3, 78);
            this.dataGridViewViewComparison.Name = "dataGridViewViewComparison";
            this.dataGridViewViewComparison.ReadOnly = true;
            this.dataGridViewViewComparison.RowHeadersVisible = false;
            this.dataGridViewViewComparison.RowTemplate.Height = 25;
            this.dataGridViewViewComparison.Size = new System.Drawing.Size(552, 289);
            this.dataGridViewViewComparison.TabIndex = 2;
            //
            // contextMenuTree
            //
            this.contextMenuTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSelectServer,
            this.toolStripMenuItemDeselectServer});
            this.contextMenuTree.Name = "contextMenuTree";
            this.contextMenuTree.Size = new System.Drawing.Size(176, 48);
            //
            // toolStripMenuItemSelectServer
            //
            this.toolStripMenuItemSelectServer.Name = "toolStripMenuItemSelectServer";
            this.toolStripMenuItemSelectServer.Size = new System.Drawing.Size(175, 22);
            this.toolStripMenuItemSelectServer.Text = "Select Server";
            //
            // toolStripMenuItemDeselectServer
            //
            this.toolStripMenuItemDeselectServer.Name = "toolStripMenuItemDeselectServer";
            this.toolStripMenuItemDeselectServer.Size = new System.Drawing.Size(175, 22);
            this.toolStripMenuItemDeselectServer.Text = "Deselect Server";
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 493);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Name = "MainForm";
            this.Text = "Sql Safe";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.flowLayoutPanelEnvironment.ResumeLayout(false);
            this.flowLayoutPanelEnvironment.PerformLayout();
            this.tabControlRight.ResumeLayout(false);
            this.tabPageSql.ResumeLayout(false);
            this.tabPageSql.PerformLayout();
            this.tabPageLogs.ResumeLayout(false);
            this.tableLayoutPanelLogs.ResumeLayout(false);
            this.tableLayoutPanelLogFilters.ResumeLayout(false);
            this.tableLayoutPanelLogFilters.PerformLayout();
            this.tableLayoutPanelLogFiltersLeft.ResumeLayout(false);
            this.tableLayoutPanelLogFiltersLeft.PerformLayout();
            this.flowLayoutPanelLogBottom.ResumeLayout(false);
            this.flowLayoutPanelLogBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).EndInit();
            this.contextMenuLogs.ResumeLayout(false);
            this.tabPageViews.ResumeLayout(false);
            this.tableLayoutPanelViews.ResumeLayout(false);
            this.tableLayoutPanelViews.PerformLayout();
            this.flowLayoutPanelViewSelectors.ResumeLayout(false);
            this.flowLayoutPanelViewSelectors.PerformLayout();
            this.flowLayoutPanelViewSearch.ResumeLayout(false);
            this.flowLayoutPanelViewSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewComparison)).EndInit();
            this.contextMenuTree.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TreeView treeViewCategories;
        private System.Windows.Forms.TabControl tabControlRight;
        private System.Windows.Forms.TabPage tabPageSql;
        private System.Windows.Forms.TabPage tabPageLogs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLogs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLogFilters;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLogFiltersLeft;
        private System.Windows.Forms.Label labelBatch;
        private System.Windows.Forms.ComboBox comboBoxBatchSelect;
        private System.Windows.Forms.Label labelDatabaseFilter;
        private System.Windows.Forms.ComboBox comboBoxDatabaseFilter;
        private System.Windows.Forms.Label labelEnvironmentFilter;
        private System.Windows.Forms.ComboBox comboBoxEnvironmentFilter;
        private System.Windows.Forms.Label labelUserFilter;
        private System.Windows.Forms.ComboBox comboBoxUserFilter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLogBottom;
        private System.Windows.Forms.Label labelCreatedFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreatedFrom;
        private System.Windows.Forms.Label labelCreatedTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreatedTo;
        private System.Windows.Forms.Label labelScriptSearch;
        private System.Windows.Forms.TextBox textBoxScriptSearch;
        private System.Windows.Forms.Button buttonApplyFilters;
        private System.Windows.Forms.DataGridView dataGridViewLogs;
        private System.Windows.Forms.ContextMenuStrip contextMenuLogs;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyScript;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyError;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRetry;
        private System.Windows.Forms.TextBox textBoxSql;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEnvironment;
        private System.Windows.Forms.Label labelEnvironment;
        private System.Windows.Forms.ComboBox comboBoxEnvironment;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.Button buttonDeselectAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSqlEditor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSqlActions;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ContextMenuStrip contextMenuTree;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSelectServer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeselectServer;
        private System.Windows.Forms.TabPage tabPageViews;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelViews;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelViewSelectors;
        private System.Windows.Forms.Label labelPrimaryServer;
        private System.Windows.Forms.ComboBox comboBoxViewPrimaryServer;
        private System.Windows.Forms.Label labelPrimaryDatabase;
        private System.Windows.Forms.ComboBox comboBoxViewPrimaryDatabase;
        private System.Windows.Forms.Label labelCompareServer;
        private System.Windows.Forms.ComboBox comboBoxViewCompareServer;
        private System.Windows.Forms.Label labelCompareDatabase;
        private System.Windows.Forms.ComboBox comboBoxViewCompareDatabase;
        private System.Windows.Forms.Button buttonLoadViews;
        private System.Windows.Forms.DataGridView dataGridViewViewComparison;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelViewSearch;
        private System.Windows.Forms.Label labelViewSearch;
        private System.Windows.Forms.TextBox textBoxViewSearch;
    }
}
