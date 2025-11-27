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
            this.textBoxSql = new System.Windows.Forms.TextBox();
            this.tabPageLogs = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelLogs = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelLogControls = new System.Windows.Forms.FlowLayoutPanel();
            this.labelBatch = new System.Windows.Forms.Label();
            this.comboBoxBatchSelect = new System.Windows.Forms.ComboBox();
            this.buttonRefreshBatches = new System.Windows.Forms.Button();
            this.dataGridViewLogs = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanelActions = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
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
            this.flowLayoutPanelLogControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).BeginInit();
            this.flowLayoutPanelActions.SuspendLayout();
            this.contextMenuTree.SuspendLayout();
            this.SuspendLayout();
            //
            // tableLayoutPanelMain
            //
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.flowLayoutPanelEnvironment, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.splitContainerMain, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.flowLayoutPanelActions, 0, 2);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(860, 487);
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
            this.tabControlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlRight.Location = new System.Drawing.Point(0, 0);
            this.tabControlRight.Name = "tabControlRight";
            this.tabControlRight.SelectedIndex = 0;
            this.tabControlRight.Size = new System.Drawing.Size(572, 404);
            this.tabControlRight.TabIndex = 4;
            //
            // tabPageSql
            //
            this.tabPageSql.Controls.Add(this.textBoxSql);
            this.tabPageSql.Location = new System.Drawing.Point(4, 24);
            this.tabPageSql.Name = "tabPageSql";
            this.tabPageSql.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSql.Size = new System.Drawing.Size(564, 376);
            this.tabPageSql.TabIndex = 0;
            this.tabPageSql.Text = "SQL Editor";
            this.tabPageSql.UseVisualStyleBackColor = true;
            //
            // textBoxSql
            //
            this.textBoxSql.AcceptsReturn = true;
            this.textBoxSql.AcceptsTab = true;
            this.textBoxSql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSql.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSql.Location = new System.Drawing.Point(3, 3);
            this.textBoxSql.Multiline = true;
            this.textBoxSql.Name = "textBoxSql";
            this.textBoxSql.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSql.Size = new System.Drawing.Size(558, 370);
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
            this.tableLayoutPanelLogs.Controls.Add(this.flowLayoutPanelLogControls, 0, 0);
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
            // flowLayoutPanelLogControls
            //
            this.flowLayoutPanelLogControls.AutoSize = true;
            this.flowLayoutPanelLogControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelLogControls.Controls.Add(this.labelBatch);
            this.flowLayoutPanelLogControls.Controls.Add(this.comboBoxBatchSelect);
            this.flowLayoutPanelLogControls.Controls.Add(this.buttonRefreshBatches);
            this.flowLayoutPanelLogControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelLogControls.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelLogControls.Name = "flowLayoutPanelLogControls";
            this.flowLayoutPanelLogControls.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanelLogControls.Size = new System.Drawing.Size(552, 35);
            this.flowLayoutPanelLogControls.TabIndex = 0;
            //
            // labelBatch
            //
            this.labelBatch.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.comboBoxBatchSelect.Location = new System.Drawing.Point(57, 6);
            this.comboBoxBatchSelect.Name = "comboBoxBatchSelect";
            this.comboBoxBatchSelect.Size = new System.Drawing.Size(121, 23);
            this.comboBoxBatchSelect.TabIndex = 1;
            //
            // buttonRefreshBatches
            //
            this.buttonRefreshBatches.AutoSize = true;
            this.buttonRefreshBatches.Location = new System.Drawing.Point(184, 6);
            this.buttonRefreshBatches.Name = "buttonRefreshBatches";
            this.buttonRefreshBatches.Size = new System.Drawing.Size(99, 25);
            this.buttonRefreshBatches.TabIndex = 2;
            this.buttonRefreshBatches.Text = "Refresh Batches";
            this.buttonRefreshBatches.UseVisualStyleBackColor = true;
            //
            // dataGridViewLogs
            //
            this.dataGridViewLogs.AllowUserToAddRows = false;
            this.dataGridViewLogs.AllowUserToDeleteRows = false;
            this.dataGridViewLogs.AllowUserToResizeRows = false;
            this.dataGridViewLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLogs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLogs.Location = new System.Drawing.Point(3, 44);
            this.dataGridViewLogs.Name = "dataGridViewLogs";
            this.dataGridViewLogs.ReadOnly = true;
            this.dataGridViewLogs.RowTemplate.Height = 25;
            this.dataGridViewLogs.Size = new System.Drawing.Size(552, 323);
            this.dataGridViewLogs.TabIndex = 1;
            //
            // flowLayoutPanelActions
            //
            this.flowLayoutPanelActions.AutoSize = true;
            this.flowLayoutPanelActions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelActions.Controls.Add(this.buttonRun);
            this.flowLayoutPanelActions.Controls.Add(this.buttonClear);
            this.flowLayoutPanelActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelActions.Location = new System.Drawing.Point(3, 454);
            this.flowLayoutPanelActions.Name = "flowLayoutPanelActions";
            this.flowLayoutPanelActions.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.flowLayoutPanelActions.Size = new System.Drawing.Size(854, 30);
            this.flowLayoutPanelActions.TabIndex = 3;
            this.flowLayoutPanelActions.WrapContents = false;
            //
            // buttonRun
            //
            this.buttonRun.AutoSize = true;
            this.buttonRun.Location = new System.Drawing.Point(781, 9);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(70, 25);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            //
            // buttonClear
            //
            this.buttonClear.AutoSize = true;
            this.buttonClear.Location = new System.Drawing.Point(705, 9);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(70, 25);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
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
            this.ClientSize = new System.Drawing.Size(884, 511);
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
            this.tableLayoutPanelLogs.PerformLayout();
            this.flowLayoutPanelLogControls.ResumeLayout(false);
            this.flowLayoutPanelLogControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).EndInit();
            this.flowLayoutPanelActions.ResumeLayout(false);
            this.flowLayoutPanelActions.PerformLayout();
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLogControls;
        private System.Windows.Forms.Label labelBatch;
        private System.Windows.Forms.ComboBox comboBoxBatchSelect;
        private System.Windows.Forms.Button buttonRefreshBatches;
        private System.Windows.Forms.DataGridView dataGridViewLogs;
        private System.Windows.Forms.TextBox textBoxSql;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEnvironment;
        private System.Windows.Forms.Label labelEnvironment;
        private System.Windows.Forms.ComboBox comboBoxEnvironment;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.Button buttonDeselectAll;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelActions;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ContextMenuStrip contextMenuTree;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSelectServer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeselectServer;
    }
}
