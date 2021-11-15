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
            this.colIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFreq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.chkActivate = new System.Windows.Forms.CheckBox();
            this.chkRandom = new System.Windows.Forms.CheckBox();
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdCommands)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExec
            // 
            this.btnExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExec.Location = new System.Drawing.Point(689, 98);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(106, 43);
            this.btnExec.TabIndex = 5;
            this.btnExec.Text = "Execute";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // txtCmd
            // 
            this.txtCmd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCmd.Location = new System.Drawing.Point(147, 55);
            this.txtCmd.Name = "txtCmd";
            this.txtCmd.Size = new System.Drawing.Size(715, 29);
            this.txtCmd.TabIndex = 0;
            // 
            // rbP1
            // 
            this.rbP1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbP1.AutoSize = true;
            this.rbP1.Location = new System.Drawing.Point(888, 56);
            this.rbP1.Name = "rbP1";
            this.rbP1.Size = new System.Drawing.Size(61, 29);
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
            this.rbP2.Location = new System.Drawing.Point(971, 56);
            this.rbP2.Name = "rbP2";
            this.rbP2.Size = new System.Drawing.Size(61, 29);
            this.rbP2.TabIndex = 2;
            this.rbP2.TabStop = true;
            this.rbP2.Text = "P2";
            this.toolTip1.SetToolTip(this.rbP2, "Ctrl+Shift+S to toggle");
            this.rbP2.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.Location = new System.Drawing.Point(888, 269);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(144, 39);
            this.btnDown.TabIndex = 13;
            this.btnDown.Text = "Move down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // txtFreq
            // 
            this.txtFreq.Location = new System.Drawing.Point(147, 100);
            this.txtFreq.Name = "txtFreq";
            this.txtFreq.Size = new System.Drawing.Size(100, 29);
            this.txtFreq.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Command";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Frequency";
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.Location = new System.Drawing.Point(888, 218);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(145, 45);
            this.btnUp.TabIndex = 12;
            this.btnUp.Text = "Move up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(919, 98);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 43);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(801, 98);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 43);
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
            this.colIndex,
            this.colText,
            this.colFreq,
            this.colCmd});
            this.grdCommands.Location = new System.Drawing.Point(43, 171);
            this.grdCommands.MultiSelect = false;
            this.grdCommands.Name = "grdCommands";
            this.grdCommands.ReadOnly = true;
            this.grdCommands.RowHeadersVisible = false;
            this.grdCommands.RowHeadersWidth = 72;
            this.grdCommands.RowTemplate.Height = 31;
            this.grdCommands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCommands.Size = new System.Drawing.Size(819, 373);
            this.grdCommands.TabIndex = 99;
            this.grdCommands.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCommands_CellDoubleClick);
            this.grdCommands.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCommands_RowEnter);
            // 
            // colIndex
            // 
            this.colIndex.HeaderText = "Line";
            this.colIndex.MinimumWidth = 9;
            this.colIndex.Name = "colIndex";
            this.colIndex.ReadOnly = true;
            this.colIndex.Width = 50;
            // 
            // colText
            // 
            this.colText.HeaderText = "Description";
            this.colText.MinimumWidth = 9;
            this.colText.Name = "colText";
            this.colText.ReadOnly = true;
            this.colText.Width = 290;
            // 
            // colFreq
            // 
            this.colFreq.HeaderText = "Frequency";
            this.colFreq.MinimumWidth = 9;
            this.colFreq.Name = "colFreq";
            this.colFreq.ReadOnly = true;
            this.colFreq.Width = 175;
            // 
            // colCmd
            // 
            this.colCmd.HeaderText = "Command";
            this.colCmd.MinimumWidth = 9;
            this.colCmd.Name = "colCmd";
            this.colCmd.ReadOnly = true;
            this.colCmd.Visible = false;
            this.colCmd.Width = 175;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(383, 100);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(285, 29);
            this.txtDescription.TabIndex = 4;
            // 
            // chkActivate
            // 
            this.chkActivate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkActivate.AutoSize = true;
            this.chkActivate.Location = new System.Drawing.Point(888, 490);
            this.chkActivate.Name = "chkActivate";
            this.chkActivate.Size = new System.Drawing.Size(151, 54);
            this.chkActivate.TabIndex = 15;
            this.chkActivate.Text = "Activate auto\r\nexecution";
            this.toolTip1.SetToolTip(this.chkActivate, "Ctrl+Shift+E to toggle");
            this.chkActivate.UseVisualStyleBackColor = true;
            this.chkActivate.CheckedChanged += new System.EventHandler(this.chkActivate_CheckedChanged);
            // 
            // chkRandom
            // 
            this.chkRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRandom.AutoSize = true;
            this.chkRandom.Checked = true;
            this.chkRandom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandom.Location = new System.Drawing.Point(902, 330);
            this.chkRandom.Name = "chkRandom";
            this.chkRandom.Size = new System.Drawing.Size(111, 29);
            this.chkRandom.TabIndex = 14;
            this.chkRandom.Text = "Random";
            this.chkRandom.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(888, 171);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 41);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.configurationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1079, 38);
            this.menuStrip1.TabIndex = 100;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFromFileToolStripMenuItem,
            this.saveToFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadFromFileToolStripMenuItem
            // 
            this.loadFromFileToolStripMenuItem.Name = "loadFromFileToolStripMenuItem";
            this.loadFromFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadFromFileToolStripMenuItem.Size = new System.Drawing.Size(338, 40);
            this.loadFromFileToolStripMenuItem.Text = "Load from File";
            this.loadFromFileToolStripMenuItem.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(338, 40);
            this.saveToFileToolStripMenuItem.Text = "Save to File";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem,
            this.executeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(100, 34);
            this.editToolStripMenuItem.Text = "Actions";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(273, 40);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(273, 40);
            this.executeToolStripMenuItem.Text = "Execute";
            this.executeToolStripMenuItem.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuT7K1,
            this.mnuT7K2});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(92, 34);
            this.configurationToolStripMenuItem.Text = "Config";
            // 
            // mnuT7K1
            // 
            this.mnuT7K1.Name = "mnuT7K1";
            this.mnuT7K1.Size = new System.Drawing.Size(335, 40);
            this.mnuT7K1.Text = "Tekken 7 - Keyboard 1";
            this.mnuT7K1.Click += new System.EventHandler(this.mnuT7K1_Click);
            // 
            // mnuT7K2
            // 
            this.mnuT7K2.Checked = true;
            this.mnuT7K2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuT7K2.Name = "mnuT7K2";
            this.mnuT7K2.Size = new System.Drawing.Size(335, 40);
            this.mnuT7K2.Text = "Tekken 7 - Keyboard 2";
            this.mnuT7K2.Click += new System.EventHandler(this.mnuT7K2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 586);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.chkRandom);
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
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "Form1";
            this.Text = "T7Trainer";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFreq;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCmd;
        private System.Windows.Forms.CheckBox chkRandom;
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
    }
}

