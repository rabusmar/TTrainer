namespace TTrainer
{
    partial class Form1
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
            this.btnExec = new System.Windows.Forms.Button();
            this.txtCmd = new System.Windows.Forms.TextBox();
            this.rbP1 = new System.Windows.Forms.RadioButton();
            this.rbP2 = new System.Windows.Forms.RadioButton();
            this.btnDown = new System.Windows.Forms.Button();
            this.txtFreq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grdCommands = new System.Windows.Forms.DataGridView();
            this.colFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFreq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.chkActivate = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuT7K1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuT7K2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRandomize = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCycle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSame = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRepeat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAppName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.mnuRepeatThrice = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdCommands)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExec
            // 
            this.btnExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExec.Location = new System.Drawing.Point(501, 65);
            this.btnExec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(77, 28);
            this.btnExec.TabIndex = 5;
            this.btnExec.Text = "Execute";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // txtCmd
            // 
            this.txtCmd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCmd.Location = new System.Drawing.Point(107, 37);
            this.txtCmd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCmd.Name = "txtCmd";
            this.txtCmd.Size = new System.Drawing.Size(521, 22);
            this.txtCmd.TabIndex = 0;
            // 
            // rbP1
            // 
            this.rbP1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbP1.AutoSize = true;
            this.rbP1.Location = new System.Drawing.Point(646, 37);
            this.rbP1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbP1.Name = "rbP1";
            this.rbP1.Size = new System.Drawing.Size(44, 20);
            this.rbP1.TabIndex = 1;
            this.rbP1.Text = "P1";
            this.toolTip1.SetToolTip(this.rbP1, "Ctrl+Shift+S to toggle");
            this.rbP1.UseVisualStyleBackColor = true;
            // 
            // rbP2
            // 
            this.rbP2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbP2.AutoSize = true;
            this.rbP2.Checked = true;
            this.rbP2.Location = new System.Drawing.Point(707, 37);
            this.rbP2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbP2.Name = "rbP2";
            this.rbP2.Size = new System.Drawing.Size(44, 20);
            this.rbP2.TabIndex = 2;
            this.rbP2.TabStop = true;
            this.rbP2.Text = "P2";
            this.toolTip1.SetToolTip(this.rbP2, "Ctrl+Shift+S to toggle");
            this.rbP2.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.Location = new System.Drawing.Point(644, 210);
            this.btnDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(105, 26);
            this.btnDown.TabIndex = 13;
            this.btnDown.Text = "Move down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // txtFreq
            // 
            this.txtFreq.Location = new System.Drawing.Point(107, 66);
            this.txtFreq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFreq.Name = "txtFreq";
            this.txtFreq.Size = new System.Drawing.Size(73, 22);
            this.txtFreq.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Command";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Frequency";
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.Location = new System.Drawing.Point(644, 177);
            this.btnUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(105, 30);
            this.btnUp.TabIndex = 12;
            this.btnUp.Text = "Move up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(668, 65);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 28);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(583, 65);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 28);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grdCommands
            // 
            this.grdCommands.AllowUserToAddRows = false;
            this.grdCommands.AllowUserToDeleteRows = false;
            this.grdCommands.AllowUserToResizeRows = false;
            this.grdCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCommands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCommands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFlag,
            this.colIndex,
            this.colText,
            this.colFreq,
            this.colCmd});
            this.grdCommands.Location = new System.Drawing.Point(31, 114);
            this.grdCommands.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdCommands.MultiSelect = false;
            this.grdCommands.Name = "grdCommands";
            this.grdCommands.RowHeadersVisible = false;
            this.grdCommands.RowHeadersWidth = 72;
            this.grdCommands.RowTemplate.Height = 31;
            this.grdCommands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCommands.Size = new System.Drawing.Size(596, 249);
            this.grdCommands.TabIndex = 99;
            this.grdCommands.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCommands_CellContentClick);
            this.grdCommands.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCommands_CellDoubleClick);
            this.grdCommands.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCommands_RowEnter);
            // 
            // colFlag
            // 
            this.colFlag.HeaderText = "";
            this.colFlag.MinimumWidth = 9;
            this.colFlag.Name = "colFlag";
            this.colFlag.Width = 30;
            // 
            // colIndex
            // 
            this.colIndex.HeaderText = "Line";
            this.colIndex.MinimumWidth = 9;
            this.colIndex.Name = "colIndex";
            this.colIndex.ReadOnly = true;
            this.colIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colIndex.Width = 50;
            // 
            // colText
            // 
            this.colText.HeaderText = "Description";
            this.colText.MinimumWidth = 9;
            this.colText.Name = "colText";
            this.colText.ReadOnly = true;
            this.colText.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colText.Width = 290;
            // 
            // colFreq
            // 
            this.colFreq.HeaderText = "Frequency";
            this.colFreq.MinimumWidth = 9;
            this.colFreq.Name = "colFreq";
            this.colFreq.ReadOnly = true;
            this.colFreq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colFreq.Width = 175;
            // 
            // colCmd
            // 
            this.colCmd.HeaderText = "Command";
            this.colCmd.MinimumWidth = 9;
            this.colCmd.Name = "colCmd";
            this.colCmd.ReadOnly = true;
            this.colCmd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCmd.Visible = false;
            this.colCmd.Width = 175;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(279, 66);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(208, 22);
            this.txtDescription.TabIndex = 4;
            // 
            // chkActivate
            // 
            this.chkActivate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkActivate.AutoSize = true;
            this.chkActivate.Location = new System.Drawing.Point(649, 326);
            this.chkActivate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkActivate.Name = "chkActivate";
            this.chkActivate.Size = new System.Drawing.Size(106, 36);
            this.chkActivate.TabIndex = 15;
            this.chkActivate.Text = "Activate auto\r\nexecution";
            this.toolTip1.SetToolTip(this.chkActivate, "Ctrl+Shift+E to toggle");
            this.chkActivate.UseVisualStyleBackColor = true;
            this.chkActivate.CheckedChanged += new System.EventHandler(this.chkActivate_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(645, 114);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 27);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.configurationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(788, 26);
            this.menuStrip1.TabIndex = 100;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFromFileToolStripMenuItem,
            this.saveToFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadFromFileToolStripMenuItem
            // 
            this.loadFromFileToolStripMenuItem.Name = "loadFromFileToolStripMenuItem";
            this.loadFromFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadFromFileToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.loadFromFileToolStripMenuItem.Text = "Load from File";
            this.loadFromFileToolStripMenuItem.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.saveToFileToolStripMenuItem.Text = "Save to File";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem,
            this.executeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.editToolStripMenuItem.Text = "Actions";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.executeToolStripMenuItem.Text = "Execute";
            this.executeToolStripMenuItem.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuT7K1,
            this.mnuT7K2,
            this.toolStripSeparator1,
            this.mnuRandomize,
            this.mnuCycle,
            this.mnuSame,
            this.toolStripSeparator2,
            this.mnuRepeat,
            this.mnuRepeatThrice,
            this.toolStripSeparator3,
            this.mnuAppName});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.configurationToolStripMenuItem.Text = "Config";
            // 
            // mnuT7K1
            // 
            this.mnuT7K1.Name = "mnuT7K1";
            this.mnuT7K1.Size = new System.Drawing.Size(239, 26);
            this.mnuT7K1.Text = "Tekken 7 - Keyboard 1";
            this.mnuT7K1.Click += new System.EventHandler(this.mnuT7K1_Click);
            // 
            // mnuT7K2
            // 
            this.mnuT7K2.Checked = true;
            this.mnuT7K2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuT7K2.Name = "mnuT7K2";
            this.mnuT7K2.Size = new System.Drawing.Size(239, 26);
            this.mnuT7K2.Text = "Tekken 7 - Keyboard 2";
            this.mnuT7K2.Click += new System.EventHandler(this.mnuT7K2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(236, 6);
            // 
            // mnuRandomize
            // 
            this.mnuRandomize.Checked = true;
            this.mnuRandomize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuRandomize.Name = "mnuRandomize";
            this.mnuRandomize.Size = new System.Drawing.Size(239, 26);
            this.mnuRandomize.Text = "Randomize moves";
            this.mnuRandomize.Click += new System.EventHandler(this.mnuRandomize_Click);
            // 
            // mnuCycle
            // 
            this.mnuCycle.Name = "mnuCycle";
            this.mnuCycle.Size = new System.Drawing.Size(239, 26);
            this.mnuCycle.Text = "Cycle through moves";
            this.mnuCycle.Click += new System.EventHandler(this.mnuCycle_Click);
            // 
            // mnuSame
            // 
            this.mnuSame.Name = "mnuSame";
            this.mnuSame.Size = new System.Drawing.Size(239, 26);
            this.mnuSame.Text = "Repeat single move";
            this.mnuSame.Click += new System.EventHandler(this.mnuSame_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(236, 6);
            // 
            // mnuRepeat
            // 
            this.mnuRepeat.Checked = true;
            this.mnuRepeat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuRepeat.Name = "mnuRepeat";
            this.mnuRepeat.Size = new System.Drawing.Size(239, 26);
            this.mnuRepeat.Text = "Repeat move twice";
            this.mnuRepeat.Click += new System.EventHandler(this.mnuRepeat_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(236, 6);
            // 
            // mnuAppName
            // 
            this.mnuAppName.Name = "mnuAppName";
            this.mnuAppName.Size = new System.Drawing.Size(239, 26);
            this.mnuAppName.Text = "Tekken version";
            this.mnuAppName.Click += new System.EventHandler(this.mnuAppName_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(647, 145);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 27);
            this.btnClear.TabIndex = 101;
            this.btnClear.Text = "Clear list";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // mnuRepeatThrice
            // 
            this.mnuRepeatThrice.Name = "mnuRepeatThrice";
            this.mnuRepeatThrice.Size = new System.Drawing.Size(239, 26);
            this.mnuRepeatThrice.Text = "Repeate move thrice";
            this.mnuRepeatThrice.Click += new System.EventHandler(this.mnuRepeatThrice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 390);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.chkActivate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grdCommands);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFreq);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.rbP2);
            this.Controls.Add(this.rbP1);
            this.Controls.Add(this.txtCmd);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(803, 411);
            this.Name = "Form1";
            this.Text = "T7Trainer";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grdCommands)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.TextBox txtCmd;
        private System.Windows.Forms.RadioButton rbP1;
        private System.Windows.Forms.RadioButton rbP2;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.TextBox txtFreq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView grdCommands;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.CheckBox chkActivate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuT7K1;
        private System.Windows.Forms.ToolStripMenuItem mnuT7K2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuRandomize;
        private System.Windows.Forms.ToolStripMenuItem mnuRepeat;
        private System.Windows.Forms.ToolStripMenuItem mnuCycle;
        private System.Windows.Forms.ToolStripMenuItem mnuSame;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFreq;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCmd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuAppName;
        private System.Windows.Forms.ToolStripMenuItem mnuRepeatThrice;
    }
}

