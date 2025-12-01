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
            this.tabControlObjects = new System.Windows.Forms.TabControl();
            this.tabPageViewExplorer = new System.Windows.Forms.TabPage();
            this.tabPageTables = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelTables = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelTableSelectors = new System.Windows.Forms.FlowLayoutPanel();
            this.labelTablePrimaryServer = new System.Windows.Forms.Label();
            this.comboBoxTablePrimaryServer = new System.Windows.Forms.ComboBox();
            this.labelTablePrimaryDatabase = new System.Windows.Forms.Label();
            this.comboBoxTablePrimaryDatabase = new System.Windows.Forms.ComboBox();
            this.labelTableCompareServer = new System.Windows.Forms.Label();
            this.comboBoxTableCompareServer = new System.Windows.Forms.ComboBox();
            this.labelTableCompareDatabase = new System.Windows.Forms.Label();
            this.comboBoxTableCompareDatabase = new System.Windows.Forms.ComboBox();
            this.buttonLoadTables = new System.Windows.Forms.Button();
            this.flowLayoutPanelTableSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.labelTableSearch = new System.Windows.Forms.Label();
            this.textBoxTableSearch = new System.Windows.Forms.TextBox();
            this.buttonCompareTable = new System.Windows.Forms.Button();
            this.tableLayoutPanelTableContent = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewTableComparison = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelTableDefinitions = new System.Windows.Forms.TableLayoutPanel();
            this.labelPrimaryTableDefinition = new System.Windows.Forms.Label();
            this.labelCompareTableDefinition = new System.Windows.Forms.Label();
            this.textBoxPrimaryTableDefinition = new System.Windows.Forms.RichTextBox();
            this.textBoxCompareTableDefinition = new System.Windows.Forms.RichTextBox();
            this.tabPageStoredProcedures = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelProcedures = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelProcedureSelectors = new System.Windows.Forms.FlowLayoutPanel();
            this.labelProcedurePrimaryServer = new System.Windows.Forms.Label();
            this.comboBoxProcedurePrimaryServer = new System.Windows.Forms.ComboBox();
            this.labelProcedurePrimaryDatabase = new System.Windows.Forms.Label();
            this.comboBoxProcedurePrimaryDatabase = new System.Windows.Forms.ComboBox();
            this.labelProcedureCompareServer = new System.Windows.Forms.Label();
            this.comboBoxProcedureCompareServer = new System.Windows.Forms.ComboBox();
            this.labelProcedureCompareDatabase = new System.Windows.Forms.Label();
            this.comboBoxProcedureCompareDatabase = new System.Windows.Forms.ComboBox();
            this.buttonLoadProcedures = new System.Windows.Forms.Button();
            this.flowLayoutPanelProcedureSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.labelProcedureSearch = new System.Windows.Forms.Label();
            this.textBoxProcedureSearch = new System.Windows.Forms.TextBox();
            this.buttonCompareProcedure = new System.Windows.Forms.Button();
            this.tableLayoutPanelProcedureContent = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewProcedureComparison = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelProcedureDefinitions = new System.Windows.Forms.TableLayoutPanel();
            this.labelPrimaryProcedureDefinition = new System.Windows.Forms.Label();
            this.labelCompareProcedureDefinition = new System.Windows.Forms.Label();
            this.textBoxPrimaryProcedureDefinition = new System.Windows.Forms.RichTextBox();
            this.textBoxCompareProcedureDefinition = new System.Windows.Forms.RichTextBox();
            this.tabPageFunctions = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelFunctions = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelFunctionSelectors = new System.Windows.Forms.FlowLayoutPanel();
            this.labelFunctionPrimaryServer = new System.Windows.Forms.Label();
            this.comboBoxFunctionPrimaryServer = new System.Windows.Forms.ComboBox();
            this.labelFunctionPrimaryDatabase = new System.Windows.Forms.Label();
            this.comboBoxFunctionPrimaryDatabase = new System.Windows.Forms.ComboBox();
            this.labelFunctionCompareServer = new System.Windows.Forms.Label();
            this.comboBoxFunctionCompareServer = new System.Windows.Forms.ComboBox();
            this.labelFunctionCompareDatabase = new System.Windows.Forms.Label();
            this.comboBoxFunctionCompareDatabase = new System.Windows.Forms.ComboBox();
            this.buttonLoadFunctions = new System.Windows.Forms.Button();
            this.flowLayoutPanelFunctionSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.labelFunctionSearch = new System.Windows.Forms.Label();
            this.textBoxFunctionSearch = new System.Windows.Forms.TextBox();
            this.buttonCompareFunction = new System.Windows.Forms.Button();
            this.tableLayoutPanelFunctionContent = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewFunctionComparison = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelFunctionDefinitions = new System.Windows.Forms.TableLayoutPanel();
            this.labelPrimaryFunctionDefinition = new System.Windows.Forms.Label();
            this.labelCompareFunctionDefinition = new System.Windows.Forms.Label();
            this.textBoxPrimaryFunctionDefinition = new System.Windows.Forms.RichTextBox();
            this.textBoxCompareFunctionDefinition = new System.Windows.Forms.RichTextBox();
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
            this.buttonCompareView = new System.Windows.Forms.Button();
            this.tableLayoutPanelViewContent = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewViewComparison = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelViewDefinitions = new System.Windows.Forms.TableLayoutPanel();
            this.labelPrimaryDefinition = new System.Windows.Forms.Label();
            this.labelCompareDefinition = new System.Windows.Forms.Label();
            this.textBoxPrimaryViewDefinition = new System.Windows.Forms.RichTextBox();
            this.textBoxCompareViewDefinition = new System.Windows.Forms.RichTextBox();
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
            this.tabControlObjects.SuspendLayout();
            this.tabPageViewExplorer.SuspendLayout();
            this.tabPageTables.SuspendLayout();
            this.tabPageStoredProcedures.SuspendLayout();
            this.tabPageFunctions.SuspendLayout();
            this.tabPageViews.SuspendLayout();
            this.tableLayoutPanelViews.SuspendLayout();
            this.tableLayoutPanelViewContent.SuspendLayout();
            this.flowLayoutPanelViewSelectors.SuspendLayout();
            this.flowLayoutPanelViewSearch.SuspendLayout();
            this.tableLayoutPanelViewDefinitions.SuspendLayout();
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
            this.tabPageViews.Controls.Add(this.tabControlObjects);
            this.tabPageViews.Location = new System.Drawing.Point(4, 24);
            this.tabPageViews.Name = "tabPageViews";
            this.tabPageViews.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageViews.Size = new System.Drawing.Size(564, 376);
            this.tabPageViews.TabIndex = 2;
            this.tabPageViews.Text = "Object Explorer";
            this.tabPageViews.UseVisualStyleBackColor = true;
            //
            // tabControlObjects
            //
            this.tabControlObjects.Controls.Add(this.tabPageViewExplorer);
            this.tabControlObjects.Controls.Add(this.tabPageTables);
            this.tabControlObjects.Controls.Add(this.tabPageStoredProcedures);
            this.tabControlObjects.Controls.Add(this.tabPageFunctions);
            this.tabControlObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlObjects.Location = new System.Drawing.Point(3, 3);
            this.tabControlObjects.Name = "tabControlObjects";
            this.tabControlObjects.SelectedIndex = 0;
            this.tabControlObjects.Size = new System.Drawing.Size(558, 370);
            this.tabControlObjects.TabIndex = 0;
            //
            // tabPageViewExplorer
            //
            this.tabPageViewExplorer.Controls.Add(this.tableLayoutPanelViews);
            this.tabPageViewExplorer.Location = new System.Drawing.Point(4, 24);
            this.tabPageViewExplorer.Name = "tabPageViewExplorer";
            this.tabPageViewExplorer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageViewExplorer.Size = new System.Drawing.Size(550, 342);
            this.tabPageViewExplorer.TabIndex = 0;
            this.tabPageViewExplorer.Text = "Views";
            this.tabPageViewExplorer.UseVisualStyleBackColor = true;
            //
            // tabPageTables
            //
            this.tabPageTables.Controls.Add(this.tableLayoutPanelTables);
            this.tabPageTables.Location = new System.Drawing.Point(4, 24);
            this.tabPageTables.Name = "tabPageTables";
            this.tabPageTables.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTables.Size = new System.Drawing.Size(550, 342);
            this.tabPageTables.TabIndex = 1;
            this.tabPageTables.Text = "Tables";
            this.tabPageTables.UseVisualStyleBackColor = true;
            //
            // tabPageStoredProcedures
            //
            this.tabPageStoredProcedures.Controls.Add(this.tableLayoutPanelProcedures);
            this.tabPageStoredProcedures.Location = new System.Drawing.Point(4, 24);
            this.tabPageStoredProcedures.Name = "tabPageStoredProcedures";
            this.tabPageStoredProcedures.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStoredProcedures.Size = new System.Drawing.Size(550, 342);
            this.tabPageStoredProcedures.TabIndex = 2;
            this.tabPageStoredProcedures.Text = "Stored Procedures";
            this.tabPageStoredProcedures.UseVisualStyleBackColor = true;
            //
            // tabPageFunctions
            //
            this.tabPageFunctions.Controls.Add(this.tableLayoutPanelFunctions);
            this.tabPageFunctions.Location = new System.Drawing.Point(4, 24);
            this.tabPageFunctions.Name = "tabPageFunctions";
            this.tabPageFunctions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFunctions.Size = new System.Drawing.Size(550, 342);
            this.tabPageFunctions.TabIndex = 3;
            this.tabPageFunctions.Text = "Functions";
            this.tabPageFunctions.UseVisualStyleBackColor = true;
            //
            //
            // tableLayoutPanelViews
            //
            this.tableLayoutPanelViews.ColumnCount = 1;
            this.tableLayoutPanelViews.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelViews.Controls.Add(this.flowLayoutPanelViewSelectors, 0, 0);
            this.tableLayoutPanelViews.Controls.Add(this.flowLayoutPanelViewSearch, 0, 1);
            this.tableLayoutPanelViews.Controls.Add(this.tableLayoutPanelViewContent, 0, 2);
            this.tableLayoutPanelViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelViews.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelViews.Name = "tableLayoutPanelViews";
            this.tableLayoutPanelViews.RowCount = 3;
            this.tableLayoutPanelViews.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelViews.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelViews.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelViews.Size = new System.Drawing.Size(544, 336);
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
            this.flowLayoutPanelViewSearch.Controls.Add(this.buttonCompareView);
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
            // buttonCompareView
            //
            this.buttonCompareView.AutoSize = true;
            this.buttonCompareView.Location = new System.Drawing.Point(291, 3);
            this.buttonCompareView.Name = "buttonCompareView";
            this.buttonCompareView.Size = new System.Drawing.Size(111, 25);
            this.buttonCompareView.TabIndex = 2;
            this.buttonCompareView.Text = "Compare View";
            this.buttonCompareView.UseVisualStyleBackColor = true;
            //
            // tableLayoutPanelViewContent
            //
            this.tableLayoutPanelViewContent.ColumnCount = 1;
            this.tableLayoutPanelViewContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelViewContent.Controls.Add(this.dataGridViewViewComparison, 0, 0);
            this.tableLayoutPanelViewContent.Controls.Add(this.tableLayoutPanelViewDefinitions, 0, 1);
            this.tableLayoutPanelViewContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelViewContent.Location = new System.Drawing.Point(3, 78);
            this.tableLayoutPanelViewContent.Name = "tableLayoutPanelViewContent";
            this.tableLayoutPanelViewContent.RowCount = 2;
            this.tableLayoutPanelViewContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanelViewContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanelViewContent.Size = new System.Drawing.Size(552, 289);
            this.tableLayoutPanelViewContent.TabIndex = 2;
            //
            // dataGridViewViewComparison
            //
            this.dataGridViewViewComparison.AllowUserToAddRows = false;
            this.dataGridViewViewComparison.AllowUserToDeleteRows = false;
            this.dataGridViewViewComparison.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewViewComparison.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViewComparison.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewViewComparison.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewViewComparison.Name = "dataGridViewViewComparison";
            this.dataGridViewViewComparison.ReadOnly = true;
            this.dataGridViewViewComparison.RowHeadersVisible = false;
            this.dataGridViewViewComparison.RowTemplate.Height = 25;
            this.dataGridViewViewComparison.Size = new System.Drawing.Size(546, 154);
            this.dataGridViewViewComparison.TabIndex = 0;
            //
            // tableLayoutPanelViewDefinitions
            //
            this.tableLayoutPanelViewDefinitions.ColumnCount = 2;
            this.tableLayoutPanelViewDefinitions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelViewDefinitions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelViewDefinitions.Controls.Add(this.labelPrimaryDefinition, 0, 0);
            this.tableLayoutPanelViewDefinitions.Controls.Add(this.labelCompareDefinition, 1, 0);
            this.tableLayoutPanelViewDefinitions.Controls.Add(this.textBoxPrimaryViewDefinition, 0, 1);
            this.tableLayoutPanelViewDefinitions.Controls.Add(this.textBoxCompareViewDefinition, 1, 1);
            this.tableLayoutPanelViewDefinitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelViewDefinitions.Location = new System.Drawing.Point(3, 163);
            this.tableLayoutPanelViewDefinitions.Name = "tableLayoutPanelViewDefinitions";
            this.tableLayoutPanelViewDefinitions.RowCount = 2;
            this.tableLayoutPanelViewDefinitions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelViewDefinitions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelViewDefinitions.Size = new System.Drawing.Size(546, 123);
            this.tableLayoutPanelViewDefinitions.TabIndex = 1;
            //
            // labelPrimaryDefinition
            //
            this.labelPrimaryDefinition.AutoSize = true;
            this.labelPrimaryDefinition.Location = new System.Drawing.Point(3, 0);
            this.labelPrimaryDefinition.Name = "labelPrimaryDefinition";
            this.labelPrimaryDefinition.Size = new System.Drawing.Size(137, 15);
            this.labelPrimaryDefinition.TabIndex = 0;
            this.labelPrimaryDefinition.Text = "Primary view definition";
            //
            // labelCompareDefinition
            //
            this.labelCompareDefinition.AutoSize = true;
            this.labelCompareDefinition.Location = new System.Drawing.Point(276, 0);
            this.labelCompareDefinition.Name = "labelCompareDefinition";
            this.labelCompareDefinition.Size = new System.Drawing.Size(146, 15);
            this.labelCompareDefinition.TabIndex = 1;
            this.labelCompareDefinition.Text = "Comparison view definition";
            //
            // textBoxPrimaryViewDefinition
            //
            this.textBoxPrimaryViewDefinition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPrimaryViewDefinition.DetectUrls = false;
            this.textBoxPrimaryViewDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPrimaryViewDefinition.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPrimaryViewDefinition.Location = new System.Drawing.Point(3, 18);
            this.textBoxPrimaryViewDefinition.Name = "textBoxPrimaryViewDefinition";
            this.textBoxPrimaryViewDefinition.ReadOnly = true;
            this.textBoxPrimaryViewDefinition.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.textBoxPrimaryViewDefinition.Size = new System.Drawing.Size(267, 102);
            this.textBoxPrimaryViewDefinition.TabIndex = 2;
            this.textBoxPrimaryViewDefinition.Text = "";
            this.textBoxPrimaryViewDefinition.WordWrap = false;
            //
            // textBoxCompareViewDefinition
            //
            this.textBoxCompareViewDefinition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCompareViewDefinition.DetectUrls = false;
            this.textBoxCompareViewDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCompareViewDefinition.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCompareViewDefinition.Location = new System.Drawing.Point(276, 18);
            this.textBoxCompareViewDefinition.Name = "textBoxCompareViewDefinition";
            this.textBoxCompareViewDefinition.ReadOnly = true;
            this.textBoxCompareViewDefinition.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.textBoxCompareViewDefinition.Size = new System.Drawing.Size(267, 102);
            this.textBoxCompareViewDefinition.TabIndex = 3;
            this.textBoxCompareViewDefinition.Text = "";
            this.textBoxCompareViewDefinition.WordWrap = false;
            //
            // tableLayoutPanelTables
            //
            this.tableLayoutPanelTables.ColumnCount = 1;
            this.tableLayoutPanelTables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTables.Controls.Add(this.flowLayoutPanelTableSelectors, 0, 0);
            this.tableLayoutPanelTables.Controls.Add(this.flowLayoutPanelTableSearch, 0, 1);
            this.tableLayoutPanelTables.Controls.Add(this.tableLayoutPanelTableContent, 0, 2);
            this.tableLayoutPanelTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTables.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelTables.Name = "tableLayoutPanelTables";
            this.tableLayoutPanelTables.RowCount = 3;
            this.tableLayoutPanelTables.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTables.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTables.Size = new System.Drawing.Size(544, 336);
            this.tableLayoutPanelTables.TabIndex = 0;
            //
            // flowLayoutPanelTableSelectors
            //
            this.flowLayoutPanelTableSelectors.AutoSize = true;
            this.flowLayoutPanelTableSelectors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelTableSelectors.AutoScroll = true;
            this.flowLayoutPanelTableSelectors.Controls.Add(this.labelTablePrimaryServer);
            this.flowLayoutPanelTableSelectors.Controls.Add(this.comboBoxTablePrimaryServer);
            this.flowLayoutPanelTableSelectors.Controls.Add(this.labelTablePrimaryDatabase);
            this.flowLayoutPanelTableSelectors.Controls.Add(this.comboBoxTablePrimaryDatabase);
            this.flowLayoutPanelTableSelectors.Controls.Add(this.labelTableCompareServer);
            this.flowLayoutPanelTableSelectors.Controls.Add(this.comboBoxTableCompareServer);
            this.flowLayoutPanelTableSelectors.Controls.Add(this.labelTableCompareDatabase);
            this.flowLayoutPanelTableSelectors.Controls.Add(this.comboBoxTableCompareDatabase);
            this.flowLayoutPanelTableSelectors.Controls.Add(this.buttonLoadTables);
            this.flowLayoutPanelTableSelectors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTableSelectors.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelTableSelectors.Name = "flowLayoutPanelTableSelectors";
            this.flowLayoutPanelTableSelectors.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanelTableSelectors.Size = new System.Drawing.Size(538, 34);
            this.flowLayoutPanelTableSelectors.TabIndex = 0;
            this.flowLayoutPanelTableSelectors.WrapContents = true;
            //
            // labelTablePrimaryServer
            //
            this.labelTablePrimaryServer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTablePrimaryServer.AutoSize = true;
            this.labelTablePrimaryServer.Location = new System.Drawing.Point(6, 10);
            this.labelTablePrimaryServer.Name = "labelTablePrimaryServer";
            this.labelTablePrimaryServer.Size = new System.Drawing.Size(88, 15);
            this.labelTablePrimaryServer.TabIndex = 0;
            this.labelTablePrimaryServer.Text = "Primary server:";
            //
            // comboBoxTablePrimaryServer
            //
            this.comboBoxTablePrimaryServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTablePrimaryServer.FormattingEnabled = true;
            this.comboBoxTablePrimaryServer.Location = new System.Drawing.Point(100, 6);
            this.comboBoxTablePrimaryServer.Name = "comboBoxTablePrimaryServer";
            this.comboBoxTablePrimaryServer.Size = new System.Drawing.Size(150, 23);
            this.comboBoxTablePrimaryServer.TabIndex = 1;
            //
            // labelTablePrimaryDatabase
            //
            this.labelTablePrimaryDatabase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTablePrimaryDatabase.AutoSize = true;
            this.labelTablePrimaryDatabase.Location = new System.Drawing.Point(256, 10);
            this.labelTablePrimaryDatabase.Name = "labelTablePrimaryDatabase";
            this.labelTablePrimaryDatabase.Size = new System.Drawing.Size(105, 15);
            this.labelTablePrimaryDatabase.TabIndex = 2;
            this.labelTablePrimaryDatabase.Text = "Primary database:";
            //
            // comboBoxTablePrimaryDatabase
            //
            this.comboBoxTablePrimaryDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTablePrimaryDatabase.FormattingEnabled = true;
            this.comboBoxTablePrimaryDatabase.Location = new System.Drawing.Point(367, 6);
            this.comboBoxTablePrimaryDatabase.Name = "comboBoxTablePrimaryDatabase";
            this.comboBoxTablePrimaryDatabase.Size = new System.Drawing.Size(150, 23);
            this.comboBoxTablePrimaryDatabase.TabIndex = 3;
            //
            // labelTableCompareServer
            //
            this.labelTableCompareServer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTableCompareServer.AutoSize = true;
            this.labelTableCompareServer.Location = new System.Drawing.Point(523, 10);
            this.labelTableCompareServer.Name = "labelTableCompareServer";
            this.labelTableCompareServer.Size = new System.Drawing.Size(97, 15);
            this.labelTableCompareServer.TabIndex = 4;
            this.labelTableCompareServer.Text = "Compare server:";
            //
            // comboBoxTableCompareServer
            //
            this.comboBoxTableCompareServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTableCompareServer.FormattingEnabled = true;
            this.comboBoxTableCompareServer.Location = new System.Drawing.Point(626, 6);
            this.comboBoxTableCompareServer.Name = "comboBoxTableCompareServer";
            this.comboBoxTableCompareServer.Size = new System.Drawing.Size(150, 23);
            this.comboBoxTableCompareServer.TabIndex = 5;
            //
            // labelTableCompareDatabase
            //
            this.labelTableCompareDatabase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTableCompareDatabase.AutoSize = true;
            this.labelTableCompareDatabase.Location = new System.Drawing.Point(782, 10);
            this.labelTableCompareDatabase.Name = "labelTableCompareDatabase";
            this.labelTableCompareDatabase.Size = new System.Drawing.Size(114, 15);
            this.labelTableCompareDatabase.TabIndex = 6;
            this.labelTableCompareDatabase.Text = "Compare database:";
            //
            // comboBoxTableCompareDatabase
            //
            this.comboBoxTableCompareDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTableCompareDatabase.FormattingEnabled = true;
            this.comboBoxTableCompareDatabase.Location = new System.Drawing.Point(902, 6);
            this.comboBoxTableCompareDatabase.Name = "comboBoxTableCompareDatabase";
            this.comboBoxTableCompareDatabase.Size = new System.Drawing.Size(150, 23);
            this.comboBoxTableCompareDatabase.TabIndex = 7;
            //
            // buttonLoadTables
            //
            this.buttonLoadTables.AutoSize = true;
            this.buttonLoadTables.Location = new System.Drawing.Point(1058, 6);
            this.buttonLoadTables.Name = "buttonLoadTables";
            this.buttonLoadTables.Size = new System.Drawing.Size(83, 25);
            this.buttonLoadTables.TabIndex = 8;
            this.buttonLoadTables.Text = "Load Tables";
            this.buttonLoadTables.UseVisualStyleBackColor = true;
            //
            // flowLayoutPanelTableSearch
            //
            this.flowLayoutPanelTableSearch.AutoSize = true;
            this.flowLayoutPanelTableSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelTableSearch.Controls.Add(this.labelTableSearch);
            this.flowLayoutPanelTableSearch.Controls.Add(this.textBoxTableSearch);
            this.flowLayoutPanelTableSearch.Controls.Add(this.buttonCompareTable);
            this.flowLayoutPanelTableSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTableSearch.Location = new System.Drawing.Point(3, 43);
            this.flowLayoutPanelTableSearch.Name = "flowLayoutPanelTableSearch";
            this.flowLayoutPanelTableSearch.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.flowLayoutPanelTableSearch.Size = new System.Drawing.Size(538, 29);
            this.flowLayoutPanelTableSearch.TabIndex = 1;
            //
            // labelTableSearch
            //
            this.labelTableSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTableSearch.AutoSize = true;
            this.labelTableSearch.Location = new System.Drawing.Point(6, 5);
            this.labelTableSearch.Name = "labelTableSearch";
            this.labelTableSearch.Size = new System.Drawing.Size(82, 15);
            this.labelTableSearch.TabIndex = 0;
            this.labelTableSearch.Text = "Table search:";
            //
            // textBoxTableSearch
            //
            this.textBoxTableSearch.Location = new System.Drawing.Point(94, 3);
            this.textBoxTableSearch.Name = "textBoxTableSearch";
            this.textBoxTableSearch.Size = new System.Drawing.Size(200, 23);
            this.textBoxTableSearch.TabIndex = 1;
            //
            // buttonCompareTable
            //
            this.buttonCompareTable.AutoSize = true;
            this.buttonCompareTable.Location = new System.Drawing.Point(300, 3);
            this.buttonCompareTable.Name = "buttonCompareTable";
            this.buttonCompareTable.Size = new System.Drawing.Size(114, 25);
            this.buttonCompareTable.TabIndex = 2;
            this.buttonCompareTable.Text = "Compare Table";
            this.buttonCompareTable.UseVisualStyleBackColor = true;
            //
            // tableLayoutPanelTableContent
            //
            this.tableLayoutPanelTableContent.ColumnCount = 1;
            this.tableLayoutPanelTableContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTableContent.Controls.Add(this.dataGridViewTableComparison, 0, 0);
            this.tableLayoutPanelTableContent.Controls.Add(this.tableLayoutPanelTableDefinitions, 0, 1);
            this.tableLayoutPanelTableContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTableContent.Location = new System.Drawing.Point(3, 78);
            this.tableLayoutPanelTableContent.Name = "tableLayoutPanelTableContent";
            this.tableLayoutPanelTableContent.RowCount = 2;
            this.tableLayoutPanelTableContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanelTableContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanelTableContent.Size = new System.Drawing.Size(538, 255);
            this.tableLayoutPanelTableContent.TabIndex = 2;
            //
            // dataGridViewTableComparison
            //
            this.dataGridViewTableComparison.AllowUserToAddRows = false;
            this.dataGridViewTableComparison.AllowUserToDeleteRows = false;
            this.dataGridViewTableComparison.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTableComparison.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTableComparison.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTableComparison.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewTableComparison.Name = "dataGridViewTableComparison";
            this.dataGridViewTableComparison.ReadOnly = true;
            this.dataGridViewTableComparison.RowHeadersVisible = false;
            this.dataGridViewTableComparison.RowTemplate.Height = 25;
            this.dataGridViewTableComparison.Size = new System.Drawing.Size(532, 134);
            this.dataGridViewTableComparison.TabIndex = 0;
            //
            // tableLayoutPanelTableDefinitions
            //
            this.tableLayoutPanelTableDefinitions.ColumnCount = 2;
            this.tableLayoutPanelTableDefinitions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTableDefinitions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTableDefinitions.Controls.Add(this.labelPrimaryTableDefinition, 0, 0);
            this.tableLayoutPanelTableDefinitions.Controls.Add(this.labelCompareTableDefinition, 1, 0);
            this.tableLayoutPanelTableDefinitions.Controls.Add(this.textBoxPrimaryTableDefinition, 0, 1);
            this.tableLayoutPanelTableDefinitions.Controls.Add(this.textBoxCompareTableDefinition, 1, 1);
            this.tableLayoutPanelTableDefinitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTableDefinitions.Location = new System.Drawing.Point(3, 143);
            this.tableLayoutPanelTableDefinitions.Name = "tableLayoutPanelTableDefinitions";
            this.tableLayoutPanelTableDefinitions.RowCount = 2;
            this.tableLayoutPanelTableDefinitions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTableDefinitions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTableDefinitions.Size = new System.Drawing.Size(532, 109);
            this.tableLayoutPanelTableDefinitions.TabIndex = 1;
            //
            // labelPrimaryTableDefinition
            //
            this.labelPrimaryTableDefinition.AutoSize = true;
            this.labelPrimaryTableDefinition.Location = new System.Drawing.Point(3, 0);
            this.labelPrimaryTableDefinition.Name = "labelPrimaryTableDefinition";
            this.labelPrimaryTableDefinition.Size = new System.Drawing.Size(137, 15);
            this.labelPrimaryTableDefinition.TabIndex = 0;
            this.labelPrimaryTableDefinition.Text = "Primary table definition";
            //
            // labelCompareTableDefinition
            //
            this.labelCompareTableDefinition.AutoSize = true;
            this.labelCompareTableDefinition.Location = new System.Drawing.Point(269, 0);
            this.labelCompareTableDefinition.Name = "labelCompareTableDefinition";
            this.labelCompareTableDefinition.Size = new System.Drawing.Size(146, 15);
            this.labelCompareTableDefinition.TabIndex = 1;
            this.labelCompareTableDefinition.Text = "Comparison table definition";
            //
            // textBoxPrimaryTableDefinition
            //
            this.textBoxPrimaryTableDefinition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPrimaryTableDefinition.DetectUrls = false;
            this.textBoxPrimaryTableDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPrimaryTableDefinition.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPrimaryTableDefinition.Location = new System.Drawing.Point(3, 18);
            this.textBoxPrimaryTableDefinition.Name = "textBoxPrimaryTableDefinition";
            this.textBoxPrimaryTableDefinition.ReadOnly = true;
            this.textBoxPrimaryTableDefinition.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.textBoxPrimaryTableDefinition.Size = new System.Drawing.Size(260, 88);
            this.textBoxPrimaryTableDefinition.TabIndex = 2;
            this.textBoxPrimaryTableDefinition.Text = "";
            this.textBoxPrimaryTableDefinition.WordWrap = false;
            //
            // textBoxCompareTableDefinition
            //
            this.textBoxCompareTableDefinition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCompareTableDefinition.DetectUrls = false;
            this.textBoxCompareTableDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCompareTableDefinition.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCompareTableDefinition.Location = new System.Drawing.Point(269, 18);
            this.textBoxCompareTableDefinition.Name = "textBoxCompareTableDefinition";
            this.textBoxCompareTableDefinition.ReadOnly = true;
            this.textBoxCompareTableDefinition.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.textBoxCompareTableDefinition.Size = new System.Drawing.Size(260, 88);
            this.textBoxCompareTableDefinition.TabIndex = 3;
            this.textBoxCompareTableDefinition.Text = "";
            this.textBoxCompareTableDefinition.WordWrap = false;
            //
            // tableLayoutPanelProcedures
            //
            this.tableLayoutPanelProcedures.ColumnCount = 1;
            this.tableLayoutPanelProcedures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelProcedures.Controls.Add(this.flowLayoutPanelProcedureSelectors, 0, 0);
            this.tableLayoutPanelProcedures.Controls.Add(this.flowLayoutPanelProcedureSearch, 0, 1);
            this.tableLayoutPanelProcedures.Controls.Add(this.tableLayoutPanelProcedureContent, 0, 2);
            this.tableLayoutPanelProcedures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelProcedures.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelProcedures.Name = "tableLayoutPanelProcedures";
            this.tableLayoutPanelProcedures.RowCount = 3;
            this.tableLayoutPanelProcedures.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelProcedures.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelProcedures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelProcedures.Size = new System.Drawing.Size(544, 336);
            this.tableLayoutPanelProcedures.TabIndex = 0;
            //
            // flowLayoutPanelProcedureSelectors
            //
            this.flowLayoutPanelProcedureSelectors.AutoSize = true;
            this.flowLayoutPanelProcedureSelectors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelProcedureSelectors.AutoScroll = true;
            this.flowLayoutPanelProcedureSelectors.Controls.Add(this.labelProcedurePrimaryServer);
            this.flowLayoutPanelProcedureSelectors.Controls.Add(this.comboBoxProcedurePrimaryServer);
            this.flowLayoutPanelProcedureSelectors.Controls.Add(this.labelProcedurePrimaryDatabase);
            this.flowLayoutPanelProcedureSelectors.Controls.Add(this.comboBoxProcedurePrimaryDatabase);
            this.flowLayoutPanelProcedureSelectors.Controls.Add(this.labelProcedureCompareServer);
            this.flowLayoutPanelProcedureSelectors.Controls.Add(this.comboBoxProcedureCompareServer);
            this.flowLayoutPanelProcedureSelectors.Controls.Add(this.labelProcedureCompareDatabase);
            this.flowLayoutPanelProcedureSelectors.Controls.Add(this.comboBoxProcedureCompareDatabase);
            this.flowLayoutPanelProcedureSelectors.Controls.Add(this.buttonLoadProcedures);
            this.flowLayoutPanelProcedureSelectors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelProcedureSelectors.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelProcedureSelectors.Name = "flowLayoutPanelProcedureSelectors";
            this.flowLayoutPanelProcedureSelectors.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanelProcedureSelectors.Size = new System.Drawing.Size(538, 34);
            this.flowLayoutPanelProcedureSelectors.TabIndex = 0;
            this.flowLayoutPanelProcedureSelectors.WrapContents = true;
            //
            // labelProcedurePrimaryServer
            //
            this.labelProcedurePrimaryServer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelProcedurePrimaryServer.AutoSize = true;
            this.labelProcedurePrimaryServer.Location = new System.Drawing.Point(6, 10);
            this.labelProcedurePrimaryServer.Name = "labelProcedurePrimaryServer";
            this.labelProcedurePrimaryServer.Size = new System.Drawing.Size(88, 15);
            this.labelProcedurePrimaryServer.TabIndex = 0;
            this.labelProcedurePrimaryServer.Text = "Primary server:";
            //
            // comboBoxProcedurePrimaryServer
            //
            this.comboBoxProcedurePrimaryServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProcedurePrimaryServer.FormattingEnabled = true;
            this.comboBoxProcedurePrimaryServer.Location = new System.Drawing.Point(100, 6);
            this.comboBoxProcedurePrimaryServer.Name = "comboBoxProcedurePrimaryServer";
            this.comboBoxProcedurePrimaryServer.Size = new System.Drawing.Size(150, 23);
            this.comboBoxProcedurePrimaryServer.TabIndex = 1;
            //
            // labelProcedurePrimaryDatabase
            //
            this.labelProcedurePrimaryDatabase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelProcedurePrimaryDatabase.AutoSize = true;
            this.labelProcedurePrimaryDatabase.Location = new System.Drawing.Point(256, 10);
            this.labelProcedurePrimaryDatabase.Name = "labelProcedurePrimaryDatabase";
            this.labelProcedurePrimaryDatabase.Size = new System.Drawing.Size(105, 15);
            this.labelProcedurePrimaryDatabase.TabIndex = 2;
            this.labelProcedurePrimaryDatabase.Text = "Primary database:";
            //
            // comboBoxProcedurePrimaryDatabase
            //
            this.comboBoxProcedurePrimaryDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProcedurePrimaryDatabase.FormattingEnabled = true;
            this.comboBoxProcedurePrimaryDatabase.Location = new System.Drawing.Point(367, 6);
            this.comboBoxProcedurePrimaryDatabase.Name = "comboBoxProcedurePrimaryDatabase";
            this.comboBoxProcedurePrimaryDatabase.Size = new System.Drawing.Size(150, 23);
            this.comboBoxProcedurePrimaryDatabase.TabIndex = 3;
            //
            // labelProcedureCompareServer
            //
            this.labelProcedureCompareServer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelProcedureCompareServer.AutoSize = true;
            this.labelProcedureCompareServer.Location = new System.Drawing.Point(523, 10);
            this.labelProcedureCompareServer.Name = "labelProcedureCompareServer";
            this.labelProcedureCompareServer.Size = new System.Drawing.Size(97, 15);
            this.labelProcedureCompareServer.TabIndex = 4;
            this.labelProcedureCompareServer.Text = "Compare server:";
            //
            // comboBoxProcedureCompareServer
            //
            this.comboBoxProcedureCompareServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProcedureCompareServer.FormattingEnabled = true;
            this.comboBoxProcedureCompareServer.Location = new System.Drawing.Point(626, 6);
            this.comboBoxProcedureCompareServer.Name = "comboBoxProcedureCompareServer";
            this.comboBoxProcedureCompareServer.Size = new System.Drawing.Size(150, 23);
            this.comboBoxProcedureCompareServer.TabIndex = 5;
            //
            // labelProcedureCompareDatabase
            //
            this.labelProcedureCompareDatabase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelProcedureCompareDatabase.AutoSize = true;
            this.labelProcedureCompareDatabase.Location = new System.Drawing.Point(782, 10);
            this.labelProcedureCompareDatabase.Name = "labelProcedureCompareDatabase";
            this.labelProcedureCompareDatabase.Size = new System.Drawing.Size(114, 15);
            this.labelProcedureCompareDatabase.TabIndex = 6;
            this.labelProcedureCompareDatabase.Text = "Compare database:";
            //
            // comboBoxProcedureCompareDatabase
            //
            this.comboBoxProcedureCompareDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProcedureCompareDatabase.FormattingEnabled = true;
            this.comboBoxProcedureCompareDatabase.Location = new System.Drawing.Point(902, 6);
            this.comboBoxProcedureCompareDatabase.Name = "comboBoxProcedureCompareDatabase";
            this.comboBoxProcedureCompareDatabase.Size = new System.Drawing.Size(150, 23);
            this.comboBoxProcedureCompareDatabase.TabIndex = 7;
            //
            // buttonLoadProcedures
            //
            this.buttonLoadProcedures.AutoSize = true;
            this.buttonLoadProcedures.Location = new System.Drawing.Point(1058, 6);
            this.buttonLoadProcedures.Name = "buttonLoadProcedures";
            this.buttonLoadProcedures.Size = new System.Drawing.Size(118, 25);
            this.buttonLoadProcedures.TabIndex = 8;
            this.buttonLoadProcedures.Text = "Load Procedures";
            this.buttonLoadProcedures.UseVisualStyleBackColor = true;
            //
            // flowLayoutPanelProcedureSearch
            //
            this.flowLayoutPanelProcedureSearch.AutoSize = true;
            this.flowLayoutPanelProcedureSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelProcedureSearch.Controls.Add(this.labelProcedureSearch);
            this.flowLayoutPanelProcedureSearch.Controls.Add(this.textBoxProcedureSearch);
            this.flowLayoutPanelProcedureSearch.Controls.Add(this.buttonCompareProcedure);
            this.flowLayoutPanelProcedureSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelProcedureSearch.Location = new System.Drawing.Point(3, 43);
            this.flowLayoutPanelProcedureSearch.Name = "flowLayoutPanelProcedureSearch";
            this.flowLayoutPanelProcedureSearch.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.flowLayoutPanelProcedureSearch.Size = new System.Drawing.Size(538, 29);
            this.flowLayoutPanelProcedureSearch.TabIndex = 1;
            //
            // labelProcedureSearch
            //
            this.labelProcedureSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelProcedureSearch.AutoSize = true;
            this.labelProcedureSearch.Location = new System.Drawing.Point(6, 5);
            this.labelProcedureSearch.Name = "labelProcedureSearch";
            this.labelProcedureSearch.Size = new System.Drawing.Size(104, 15);
            this.labelProcedureSearch.TabIndex = 0;
            this.labelProcedureSearch.Text = "Procedure search:";
            //
            // textBoxProcedureSearch
            //
            this.textBoxProcedureSearch.Location = new System.Drawing.Point(116, 3);
            this.textBoxProcedureSearch.Name = "textBoxProcedureSearch";
            this.textBoxProcedureSearch.Size = new System.Drawing.Size(200, 23);
            this.textBoxProcedureSearch.TabIndex = 1;
            //
            // buttonCompareProcedure
            //
            this.buttonCompareProcedure.AutoSize = true;
            this.buttonCompareProcedure.Location = new System.Drawing.Point(322, 3);
            this.buttonCompareProcedure.Name = "buttonCompareProcedure";
            this.buttonCompareProcedure.Size = new System.Drawing.Size(139, 25);
            this.buttonCompareProcedure.TabIndex = 2;
            this.buttonCompareProcedure.Text = "Compare Procedure";
            this.buttonCompareProcedure.UseVisualStyleBackColor = true;
            //
            // tableLayoutPanelProcedureContent
            //
            this.tableLayoutPanelProcedureContent.ColumnCount = 1;
            this.tableLayoutPanelProcedureContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelProcedureContent.Controls.Add(this.dataGridViewProcedureComparison, 0, 0);
            this.tableLayoutPanelProcedureContent.Controls.Add(this.tableLayoutPanelProcedureDefinitions, 0, 1);
            this.tableLayoutPanelProcedureContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelProcedureContent.Location = new System.Drawing.Point(3, 78);
            this.tableLayoutPanelProcedureContent.Name = "tableLayoutPanelProcedureContent";
            this.tableLayoutPanelProcedureContent.RowCount = 2;
            this.tableLayoutPanelProcedureContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanelProcedureContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanelProcedureContent.Size = new System.Drawing.Size(538, 255);
            this.tableLayoutPanelProcedureContent.TabIndex = 2;
            //
            // dataGridViewProcedureComparison
            //
            this.dataGridViewProcedureComparison.AllowUserToAddRows = false;
            this.dataGridViewProcedureComparison.AllowUserToDeleteRows = false;
            this.dataGridViewProcedureComparison.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProcedureComparison.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcedureComparison.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProcedureComparison.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewProcedureComparison.Name = "dataGridViewProcedureComparison";
            this.dataGridViewProcedureComparison.ReadOnly = true;
            this.dataGridViewProcedureComparison.RowHeadersVisible = false;
            this.dataGridViewProcedureComparison.RowTemplate.Height = 25;
            this.dataGridViewProcedureComparison.Size = new System.Drawing.Size(532, 134);
            this.dataGridViewProcedureComparison.TabIndex = 0;
            //
            // tableLayoutPanelProcedureDefinitions
            //
            this.tableLayoutPanelProcedureDefinitions.ColumnCount = 2;
            this.tableLayoutPanelProcedureDefinitions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelProcedureDefinitions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelProcedureDefinitions.Controls.Add(this.labelPrimaryProcedureDefinition, 0, 0);
            this.tableLayoutPanelProcedureDefinitions.Controls.Add(this.labelCompareProcedureDefinition, 1, 0);
            this.tableLayoutPanelProcedureDefinitions.Controls.Add(this.textBoxPrimaryProcedureDefinition, 0, 1);
            this.tableLayoutPanelProcedureDefinitions.Controls.Add(this.textBoxCompareProcedureDefinition, 1, 1);
            this.tableLayoutPanelProcedureDefinitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelProcedureDefinitions.Location = new System.Drawing.Point(3, 143);
            this.tableLayoutPanelProcedureDefinitions.Name = "tableLayoutPanelProcedureDefinitions";
            this.tableLayoutPanelProcedureDefinitions.RowCount = 2;
            this.tableLayoutPanelProcedureDefinitions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelProcedureDefinitions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelProcedureDefinitions.Size = new System.Drawing.Size(532, 109);
            this.tableLayoutPanelProcedureDefinitions.TabIndex = 1;
            //
            // labelPrimaryProcedureDefinition
            //
            this.labelPrimaryProcedureDefinition.AutoSize = true;
            this.labelPrimaryProcedureDefinition.Location = new System.Drawing.Point(3, 0);
            this.labelPrimaryProcedureDefinition.Name = "labelPrimaryProcedureDefinition";
            this.labelPrimaryProcedureDefinition.Size = new System.Drawing.Size(166, 15);
            this.labelPrimaryProcedureDefinition.TabIndex = 0;
            this.labelPrimaryProcedureDefinition.Text = "Primary procedure definition";
            //
            // labelCompareProcedureDefinition
            //
            this.labelCompareProcedureDefinition.AutoSize = true;
            this.labelCompareProcedureDefinition.Location = new System.Drawing.Point(269, 0);
            this.labelCompareProcedureDefinition.Name = "labelCompareProcedureDefinition";
            this.labelCompareProcedureDefinition.Size = new System.Drawing.Size(175, 15);
            this.labelCompareProcedureDefinition.TabIndex = 1;
            this.labelCompareProcedureDefinition.Text = "Comparison procedure definition";
            //
            // textBoxPrimaryProcedureDefinition
            //
            this.textBoxPrimaryProcedureDefinition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPrimaryProcedureDefinition.DetectUrls = false;
            this.textBoxPrimaryProcedureDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPrimaryProcedureDefinition.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPrimaryProcedureDefinition.Location = new System.Drawing.Point(3, 18);
            this.textBoxPrimaryProcedureDefinition.Name = "textBoxPrimaryProcedureDefinition";
            this.textBoxPrimaryProcedureDefinition.ReadOnly = true;
            this.textBoxPrimaryProcedureDefinition.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.textBoxPrimaryProcedureDefinition.Size = new System.Drawing.Size(260, 88);
            this.textBoxPrimaryProcedureDefinition.TabIndex = 2;
            this.textBoxPrimaryProcedureDefinition.Text = "";
            this.textBoxPrimaryProcedureDefinition.WordWrap = false;
            //
            // textBoxCompareProcedureDefinition
            //
            this.textBoxCompareProcedureDefinition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCompareProcedureDefinition.DetectUrls = false;
            this.textBoxCompareProcedureDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCompareProcedureDefinition.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCompareProcedureDefinition.Location = new System.Drawing.Point(269, 18);
            this.textBoxCompareProcedureDefinition.Name = "textBoxCompareProcedureDefinition";
            this.textBoxCompareProcedureDefinition.ReadOnly = true;
            this.textBoxCompareProcedureDefinition.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.textBoxCompareProcedureDefinition.Size = new System.Drawing.Size(260, 88);
            this.textBoxCompareProcedureDefinition.TabIndex = 3;
            this.textBoxCompareProcedureDefinition.Text = "";
            this.textBoxCompareProcedureDefinition.WordWrap = false;
            //
            // tableLayoutPanelFunctions
            //
            this.tableLayoutPanelFunctions.ColumnCount = 1;
            this.tableLayoutPanelFunctions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFunctions.Controls.Add(this.flowLayoutPanelFunctionSelectors, 0, 0);
            this.tableLayoutPanelFunctions.Controls.Add(this.flowLayoutPanelFunctionSearch, 0, 1);
            this.tableLayoutPanelFunctions.Controls.Add(this.tableLayoutPanelFunctionContent, 0, 2);
            this.tableLayoutPanelFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFunctions.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelFunctions.Name = "tableLayoutPanelFunctions";
            this.tableLayoutPanelFunctions.RowCount = 3;
            this.tableLayoutPanelFunctions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelFunctions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelFunctions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFunctions.Size = new System.Drawing.Size(544, 336);
            this.tableLayoutPanelFunctions.TabIndex = 0;
            //
            // flowLayoutPanelFunctionSelectors
            //
            this.flowLayoutPanelFunctionSelectors.AutoSize = true;
            this.flowLayoutPanelFunctionSelectors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelFunctionSelectors.AutoScroll = true;
            this.flowLayoutPanelFunctionSelectors.Controls.Add(this.labelFunctionPrimaryServer);
            this.flowLayoutPanelFunctionSelectors.Controls.Add(this.comboBoxFunctionPrimaryServer);
            this.flowLayoutPanelFunctionSelectors.Controls.Add(this.labelFunctionPrimaryDatabase);
            this.flowLayoutPanelFunctionSelectors.Controls.Add(this.comboBoxFunctionPrimaryDatabase);
            this.flowLayoutPanelFunctionSelectors.Controls.Add(this.labelFunctionCompareServer);
            this.flowLayoutPanelFunctionSelectors.Controls.Add(this.comboBoxFunctionCompareServer);
            this.flowLayoutPanelFunctionSelectors.Controls.Add(this.labelFunctionCompareDatabase);
            this.flowLayoutPanelFunctionSelectors.Controls.Add(this.comboBoxFunctionCompareDatabase);
            this.flowLayoutPanelFunctionSelectors.Controls.Add(this.buttonLoadFunctions);
            this.flowLayoutPanelFunctionSelectors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelFunctionSelectors.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelFunctionSelectors.Name = "flowLayoutPanelFunctionSelectors";
            this.flowLayoutPanelFunctionSelectors.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanelFunctionSelectors.Size = new System.Drawing.Size(538, 34);
            this.flowLayoutPanelFunctionSelectors.TabIndex = 0;
            this.flowLayoutPanelFunctionSelectors.WrapContents = true;
            //
            // labelFunctionPrimaryServer
            //
            this.labelFunctionPrimaryServer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFunctionPrimaryServer.AutoSize = true;
            this.labelFunctionPrimaryServer.Location = new System.Drawing.Point(6, 10);
            this.labelFunctionPrimaryServer.Name = "labelFunctionPrimaryServer";
            this.labelFunctionPrimaryServer.Size = new System.Drawing.Size(88, 15);
            this.labelFunctionPrimaryServer.TabIndex = 0;
            this.labelFunctionPrimaryServer.Text = "Primary server:";
            //
            // comboBoxFunctionPrimaryServer
            //
            this.comboBoxFunctionPrimaryServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFunctionPrimaryServer.FormattingEnabled = true;
            this.comboBoxFunctionPrimaryServer.Location = new System.Drawing.Point(100, 6);
            this.comboBoxFunctionPrimaryServer.Name = "comboBoxFunctionPrimaryServer";
            this.comboBoxFunctionPrimaryServer.Size = new System.Drawing.Size(150, 23);
            this.comboBoxFunctionPrimaryServer.TabIndex = 1;
            //
            // labelFunctionPrimaryDatabase
            //
            this.labelFunctionPrimaryDatabase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFunctionPrimaryDatabase.AutoSize = true;
            this.labelFunctionPrimaryDatabase.Location = new System.Drawing.Point(256, 10);
            this.labelFunctionPrimaryDatabase.Name = "labelFunctionPrimaryDatabase";
            this.labelFunctionPrimaryDatabase.Size = new System.Drawing.Size(105, 15);
            this.labelFunctionPrimaryDatabase.TabIndex = 2;
            this.labelFunctionPrimaryDatabase.Text = "Primary database:";
            //
            // comboBoxFunctionPrimaryDatabase
            //
            this.comboBoxFunctionPrimaryDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFunctionPrimaryDatabase.FormattingEnabled = true;
            this.comboBoxFunctionPrimaryDatabase.Location = new System.Drawing.Point(367, 6);
            this.comboBoxFunctionPrimaryDatabase.Name = "comboBoxFunctionPrimaryDatabase";
            this.comboBoxFunctionPrimaryDatabase.Size = new System.Drawing.Size(150, 23);
            this.comboBoxFunctionPrimaryDatabase.TabIndex = 3;
            //
            // labelFunctionCompareServer
            //
            this.labelFunctionCompareServer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFunctionCompareServer.AutoSize = true;
            this.labelFunctionCompareServer.Location = new System.Drawing.Point(523, 10);
            this.labelFunctionCompareServer.Name = "labelFunctionCompareServer";
            this.labelFunctionCompareServer.Size = new System.Drawing.Size(97, 15);
            this.labelFunctionCompareServer.TabIndex = 4;
            this.labelFunctionCompareServer.Text = "Compare server:";
            //
            // comboBoxFunctionCompareServer
            //
            this.comboBoxFunctionCompareServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFunctionCompareServer.FormattingEnabled = true;
            this.comboBoxFunctionCompareServer.Location = new System.Drawing.Point(626, 6);
            this.comboBoxFunctionCompareServer.Name = "comboBoxFunctionCompareServer";
            this.comboBoxFunctionCompareServer.Size = new System.Drawing.Size(150, 23);
            this.comboBoxFunctionCompareServer.TabIndex = 5;
            //
            // labelFunctionCompareDatabase
            //
            this.labelFunctionCompareDatabase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFunctionCompareDatabase.AutoSize = true;
            this.labelFunctionCompareDatabase.Location = new System.Drawing.Point(782, 10);
            this.labelFunctionCompareDatabase.Name = "labelFunctionCompareDatabase";
            this.labelFunctionCompareDatabase.Size = new System.Drawing.Size(114, 15);
            this.labelFunctionCompareDatabase.TabIndex = 6;
            this.labelFunctionCompareDatabase.Text = "Compare database:";
            //
            // comboBoxFunctionCompareDatabase
            //
            this.comboBoxFunctionCompareDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFunctionCompareDatabase.FormattingEnabled = true;
            this.comboBoxFunctionCompareDatabase.Location = new System.Drawing.Point(902, 6);
            this.comboBoxFunctionCompareDatabase.Name = "comboBoxFunctionCompareDatabase";
            this.comboBoxFunctionCompareDatabase.Size = new System.Drawing.Size(150, 23);
            this.comboBoxFunctionCompareDatabase.TabIndex = 7;
            //
            // buttonLoadFunctions
            //
            this.buttonLoadFunctions.AutoSize = true;
            this.buttonLoadFunctions.Location = new System.Drawing.Point(1058, 6);
            this.buttonLoadFunctions.Name = "buttonLoadFunctions";
            this.buttonLoadFunctions.Size = new System.Drawing.Size(104, 25);
            this.buttonLoadFunctions.TabIndex = 8;
            this.buttonLoadFunctions.Text = "Load Functions";
            this.buttonLoadFunctions.UseVisualStyleBackColor = true;
            //
            // flowLayoutPanelFunctionSearch
            //
            this.flowLayoutPanelFunctionSearch.AutoSize = true;
            this.flowLayoutPanelFunctionSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelFunctionSearch.Controls.Add(this.labelFunctionSearch);
            this.flowLayoutPanelFunctionSearch.Controls.Add(this.textBoxFunctionSearch);
            this.flowLayoutPanelFunctionSearch.Controls.Add(this.buttonCompareFunction);
            this.flowLayoutPanelFunctionSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelFunctionSearch.Location = new System.Drawing.Point(3, 43);
            this.flowLayoutPanelFunctionSearch.Name = "flowLayoutPanelFunctionSearch";
            this.flowLayoutPanelFunctionSearch.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.flowLayoutPanelFunctionSearch.Size = new System.Drawing.Size(538, 29);
            this.flowLayoutPanelFunctionSearch.TabIndex = 1;
            //
            // labelFunctionSearch
            //
            this.labelFunctionSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFunctionSearch.AutoSize = true;
            this.labelFunctionSearch.Location = new System.Drawing.Point(6, 5);
            this.labelFunctionSearch.Name = "labelFunctionSearch";
            this.labelFunctionSearch.Size = new System.Drawing.Size(97, 15);
            this.labelFunctionSearch.TabIndex = 0;
            this.labelFunctionSearch.Text = "Function search:";
            //
            // textBoxFunctionSearch
            //
            this.textBoxFunctionSearch.Location = new System.Drawing.Point(109, 3);
            this.textBoxFunctionSearch.Name = "textBoxFunctionSearch";
            this.textBoxFunctionSearch.Size = new System.Drawing.Size(200, 23);
            this.textBoxFunctionSearch.TabIndex = 1;
            //
            // buttonCompareFunction
            //
            this.buttonCompareFunction.AutoSize = true;
            this.buttonCompareFunction.Location = new System.Drawing.Point(315, 3);
            this.buttonCompareFunction.Name = "buttonCompareFunction";
            this.buttonCompareFunction.Size = new System.Drawing.Size(131, 25);
            this.buttonCompareFunction.TabIndex = 2;
            this.buttonCompareFunction.Text = "Compare Function";
            this.buttonCompareFunction.UseVisualStyleBackColor = true;
            //
            // tableLayoutPanelFunctionContent
            //
            this.tableLayoutPanelFunctionContent.ColumnCount = 1;
            this.tableLayoutPanelFunctionContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFunctionContent.Controls.Add(this.dataGridViewFunctionComparison, 0, 0);
            this.tableLayoutPanelFunctionContent.Controls.Add(this.tableLayoutPanelFunctionDefinitions, 0, 1);
            this.tableLayoutPanelFunctionContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFunctionContent.Location = new System.Drawing.Point(3, 78);
            this.tableLayoutPanelFunctionContent.Name = "tableLayoutPanelFunctionContent";
            this.tableLayoutPanelFunctionContent.RowCount = 2;
            this.tableLayoutPanelFunctionContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanelFunctionContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanelFunctionContent.Size = new System.Drawing.Size(538, 255);
            this.tableLayoutPanelFunctionContent.TabIndex = 2;
            //
            // dataGridViewFunctionComparison
            //
            this.dataGridViewFunctionComparison.AllowUserToAddRows = false;
            this.dataGridViewFunctionComparison.AllowUserToDeleteRows = false;
            this.dataGridViewFunctionComparison.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFunctionComparison.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunctionComparison.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFunctionComparison.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewFunctionComparison.Name = "dataGridViewFunctionComparison";
            this.dataGridViewFunctionComparison.ReadOnly = true;
            this.dataGridViewFunctionComparison.RowHeadersVisible = false;
            this.dataGridViewFunctionComparison.RowTemplate.Height = 25;
            this.dataGridViewFunctionComparison.Size = new System.Drawing.Size(532, 134);
            this.dataGridViewFunctionComparison.TabIndex = 0;
            //
            // tableLayoutPanelFunctionDefinitions
            //
            this.tableLayoutPanelFunctionDefinitions.ColumnCount = 2;
            this.tableLayoutPanelFunctionDefinitions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFunctionDefinitions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFunctionDefinitions.Controls.Add(this.labelPrimaryFunctionDefinition, 0, 0);
            this.tableLayoutPanelFunctionDefinitions.Controls.Add(this.labelCompareFunctionDefinition, 1, 0);
            this.tableLayoutPanelFunctionDefinitions.Controls.Add(this.textBoxPrimaryFunctionDefinition, 0, 1);
            this.tableLayoutPanelFunctionDefinitions.Controls.Add(this.textBoxCompareFunctionDefinition, 1, 1);
            this.tableLayoutPanelFunctionDefinitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFunctionDefinitions.Location = new System.Drawing.Point(3, 143);
            this.tableLayoutPanelFunctionDefinitions.Name = "tableLayoutPanelFunctionDefinitions";
            this.tableLayoutPanelFunctionDefinitions.RowCount = 2;
            this.tableLayoutPanelFunctionDefinitions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelFunctionDefinitions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFunctionDefinitions.Size = new System.Drawing.Size(532, 109);
            this.tableLayoutPanelFunctionDefinitions.TabIndex = 1;
            //
            // labelPrimaryFunctionDefinition
            //
            this.labelPrimaryFunctionDefinition.AutoSize = true;
            this.labelPrimaryFunctionDefinition.Location = new System.Drawing.Point(3, 0);
            this.labelPrimaryFunctionDefinition.Name = "labelPrimaryFunctionDefinition";
            this.labelPrimaryFunctionDefinition.Size = new System.Drawing.Size(145, 15);
            this.labelPrimaryFunctionDefinition.TabIndex = 0;
            this.labelPrimaryFunctionDefinition.Text = "Primary function definition";
            //
            // labelCompareFunctionDefinition
            //
            this.labelCompareFunctionDefinition.AutoSize = true;
            this.labelCompareFunctionDefinition.Location = new System.Drawing.Point(269, 0);
            this.labelCompareFunctionDefinition.Name = "labelCompareFunctionDefinition";
            this.labelCompareFunctionDefinition.Size = new System.Drawing.Size(154, 15);
            this.labelCompareFunctionDefinition.TabIndex = 1;
            this.labelCompareFunctionDefinition.Text = "Comparison function definition";
            //
            // textBoxPrimaryFunctionDefinition
            //
            this.textBoxPrimaryFunctionDefinition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPrimaryFunctionDefinition.DetectUrls = false;
            this.textBoxPrimaryFunctionDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPrimaryFunctionDefinition.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPrimaryFunctionDefinition.Location = new System.Drawing.Point(3, 18);
            this.textBoxPrimaryFunctionDefinition.Name = "textBoxPrimaryFunctionDefinition";
            this.textBoxPrimaryFunctionDefinition.ReadOnly = true;
            this.textBoxPrimaryFunctionDefinition.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.textBoxPrimaryFunctionDefinition.Size = new System.Drawing.Size(260, 88);
            this.textBoxPrimaryFunctionDefinition.TabIndex = 2;
            this.textBoxPrimaryFunctionDefinition.Text = "";
            this.textBoxPrimaryFunctionDefinition.WordWrap = false;
            //
            // textBoxCompareFunctionDefinition
            //
            this.textBoxCompareFunctionDefinition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCompareFunctionDefinition.DetectUrls = false;
            this.textBoxCompareFunctionDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCompareFunctionDefinition.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCompareFunctionDefinition.Location = new System.Drawing.Point(269, 18);
            this.textBoxCompareFunctionDefinition.Name = "textBoxCompareFunctionDefinition";
            this.textBoxCompareFunctionDefinition.ReadOnly = true;
            this.textBoxCompareFunctionDefinition.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.textBoxCompareFunctionDefinition.Size = new System.Drawing.Size(260, 88);
            this.textBoxCompareFunctionDefinition.TabIndex = 3;
            this.textBoxCompareFunctionDefinition.Text = "";
            this.textBoxCompareFunctionDefinition.WordWrap = false;
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
            this.tabControlObjects.ResumeLayout(false);
            this.tabPageViewExplorer.ResumeLayout(false);
            this.tabPageTables.ResumeLayout(false);
            this.tableLayoutPanelTables.ResumeLayout(false);
            this.tableLayoutPanelTables.PerformLayout();
            this.flowLayoutPanelTableSelectors.ResumeLayout(false);
            this.flowLayoutPanelTableSelectors.PerformLayout();
            this.flowLayoutPanelTableSearch.ResumeLayout(false);
            this.flowLayoutPanelTableSearch.PerformLayout();
            this.tableLayoutPanelTableContent.ResumeLayout(false);
            this.tableLayoutPanelTableDefinitions.ResumeLayout(false);
            this.tableLayoutPanelTableDefinitions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableComparison)).EndInit();
            this.tabPageStoredProcedures.ResumeLayout(false);
            this.tableLayoutPanelProcedures.ResumeLayout(false);
            this.tableLayoutPanelProcedures.PerformLayout();
            this.flowLayoutPanelProcedureSelectors.ResumeLayout(false);
            this.flowLayoutPanelProcedureSelectors.PerformLayout();
            this.flowLayoutPanelProcedureSearch.ResumeLayout(false);
            this.flowLayoutPanelProcedureSearch.PerformLayout();
            this.tableLayoutPanelProcedureContent.ResumeLayout(false);
            this.tableLayoutPanelProcedureDefinitions.ResumeLayout(false);
            this.tableLayoutPanelProcedureDefinitions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcedureComparison)).EndInit();
            this.tabPageFunctions.ResumeLayout(false);
            this.tableLayoutPanelFunctions.ResumeLayout(false);
            this.tableLayoutPanelFunctions.PerformLayout();
            this.flowLayoutPanelFunctionSelectors.ResumeLayout(false);
            this.flowLayoutPanelFunctionSelectors.PerformLayout();
            this.flowLayoutPanelFunctionSearch.ResumeLayout(false);
            this.flowLayoutPanelFunctionSearch.PerformLayout();
            this.tableLayoutPanelFunctionContent.ResumeLayout(false);
            this.tableLayoutPanelFunctionDefinitions.ResumeLayout(false);
            this.tableLayoutPanelFunctionDefinitions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunctionComparison)).EndInit();
            this.tabPageViews.ResumeLayout(false);
            this.tableLayoutPanelViews.ResumeLayout(false);
            this.tableLayoutPanelViews.PerformLayout();
            this.tableLayoutPanelViewContent.ResumeLayout(false);
            this.flowLayoutPanelViewSelectors.ResumeLayout(false);
            this.flowLayoutPanelViewSelectors.PerformLayout();
            this.flowLayoutPanelViewSearch.ResumeLayout(false);
            this.flowLayoutPanelViewSearch.PerformLayout();
            this.tableLayoutPanelViewDefinitions.ResumeLayout(false);
            this.tableLayoutPanelViewDefinitions.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControlObjects;
        private System.Windows.Forms.TabPage tabPageViewExplorer;
        private System.Windows.Forms.TabPage tabPageTables;
        private System.Windows.Forms.TabPage tabPageStoredProcedures;
        private System.Windows.Forms.TabPage tabPageFunctions;
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
        private System.Windows.Forms.Button buttonCompareView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelViewContent;
        private System.Windows.Forms.DataGridView dataGridViewViewComparison;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelViewDefinitions;
        private System.Windows.Forms.Label labelPrimaryDefinition;
        private System.Windows.Forms.Label labelCompareDefinition;
        private System.Windows.Forms.RichTextBox textBoxPrimaryViewDefinition;
        private System.Windows.Forms.RichTextBox textBoxCompareViewDefinition;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelViewSearch;
        private System.Windows.Forms.Label labelViewSearch;
        private System.Windows.Forms.TextBox textBoxViewSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTables;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTableSelectors;
        private System.Windows.Forms.Label labelTablePrimaryServer;
        private System.Windows.Forms.ComboBox comboBoxTablePrimaryServer;
        private System.Windows.Forms.Label labelTablePrimaryDatabase;
        private System.Windows.Forms.ComboBox comboBoxTablePrimaryDatabase;
        private System.Windows.Forms.Label labelTableCompareServer;
        private System.Windows.Forms.ComboBox comboBoxTableCompareServer;
        private System.Windows.Forms.Label labelTableCompareDatabase;
        private System.Windows.Forms.ComboBox comboBoxTableCompareDatabase;
        private System.Windows.Forms.Button buttonLoadTables;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTableSearch;
        private System.Windows.Forms.Label labelTableSearch;
        private System.Windows.Forms.TextBox textBoxTableSearch;
        private System.Windows.Forms.Button buttonCompareTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTableContent;
        private System.Windows.Forms.DataGridView dataGridViewTableComparison;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTableDefinitions;
        private System.Windows.Forms.Label labelPrimaryTableDefinition;
        private System.Windows.Forms.Label labelCompareTableDefinition;
        private System.Windows.Forms.RichTextBox textBoxPrimaryTableDefinition;
        private System.Windows.Forms.RichTextBox textBoxCompareTableDefinition;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelProcedures;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProcedureSelectors;
        private System.Windows.Forms.Label labelProcedurePrimaryServer;
        private System.Windows.Forms.ComboBox comboBoxProcedurePrimaryServer;
        private System.Windows.Forms.Label labelProcedurePrimaryDatabase;
        private System.Windows.Forms.ComboBox comboBoxProcedurePrimaryDatabase;
        private System.Windows.Forms.Label labelProcedureCompareServer;
        private System.Windows.Forms.ComboBox comboBoxProcedureCompareServer;
        private System.Windows.Forms.Label labelProcedureCompareDatabase;
        private System.Windows.Forms.ComboBox comboBoxProcedureCompareDatabase;
        private System.Windows.Forms.Button buttonLoadProcedures;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProcedureSearch;
        private System.Windows.Forms.Label labelProcedureSearch;
        private System.Windows.Forms.TextBox textBoxProcedureSearch;
        private System.Windows.Forms.Button buttonCompareProcedure;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelProcedureContent;
        private System.Windows.Forms.DataGridView dataGridViewProcedureComparison;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelProcedureDefinitions;
        private System.Windows.Forms.Label labelPrimaryProcedureDefinition;
        private System.Windows.Forms.Label labelCompareProcedureDefinition;
        private System.Windows.Forms.RichTextBox textBoxPrimaryProcedureDefinition;
        private System.Windows.Forms.RichTextBox textBoxCompareProcedureDefinition;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFunctions;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFunctionSelectors;
        private System.Windows.Forms.Label labelFunctionPrimaryServer;
        private System.Windows.Forms.ComboBox comboBoxFunctionPrimaryServer;
        private System.Windows.Forms.Label labelFunctionPrimaryDatabase;
        private System.Windows.Forms.ComboBox comboBoxFunctionPrimaryDatabase;
        private System.Windows.Forms.Label labelFunctionCompareServer;
        private System.Windows.Forms.ComboBox comboBoxFunctionCompareServer;
        private System.Windows.Forms.Label labelFunctionCompareDatabase;
        private System.Windows.Forms.ComboBox comboBoxFunctionCompareDatabase;
        private System.Windows.Forms.Button buttonLoadFunctions;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFunctionSearch;
        private System.Windows.Forms.Label labelFunctionSearch;
        private System.Windows.Forms.TextBox textBoxFunctionSearch;
        private System.Windows.Forms.Button buttonCompareFunction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFunctionContent;
        private System.Windows.Forms.DataGridView dataGridViewFunctionComparison;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFunctionDefinitions;
        private System.Windows.Forms.Label labelPrimaryFunctionDefinition;
        private System.Windows.Forms.Label labelCompareFunctionDefinition;
        private System.Windows.Forms.RichTextBox textBoxPrimaryFunctionDefinition;
        private System.Windows.Forms.RichTextBox textBoxCompareFunctionDefinition;
    }
}
