namespace ApplicationSftwrEngineering
{
    partial class HistoryLog
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
            this.lstHistoryLog = new System.Windows.Forms.ListView();
            this.IDCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UsernameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WhatChangedCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WhenChangedCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtUserSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDate1 = new System.Windows.Forms.MaskedTextBox();
            this.txtDate2 = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip_historyLog = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_historyLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstHistoryLog
            // 
            this.lstHistoryLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDCol,
            this.UsernameCol,
            this.WhatChangedCol,
            this.WhenChangedCol});
            this.lstHistoryLog.FullRowSelect = true;
            this.lstHistoryLog.GridLines = true;
            this.lstHistoryLog.Location = new System.Drawing.Point(12, 103);
            this.lstHistoryLog.Name = "lstHistoryLog";
            this.lstHistoryLog.Size = new System.Drawing.Size(624, 283);
            this.lstHistoryLog.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstHistoryLog.TabIndex = 0;
            this.lstHistoryLog.UseCompatibleStateImageBehavior = false;
            this.lstHistoryLog.View = System.Windows.Forms.View.Details;
            this.lstHistoryLog.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstHistoryLog_ColumnClick);
            // 
            // IDCol
            // 
            this.IDCol.Text = "ID";
            this.IDCol.Width = 35;
            // 
            // UsernameCol
            // 
            this.UsernameCol.Text = "Username";
            this.UsernameCol.Width = 72;
            // 
            // WhatChangedCol
            // 
            this.WhatChangedCol.Text = "What Changed";
            this.WhatChangedCol.Width = 365;
            // 
            // WhenChangedCol
            // 
            this.WhenChangedCol.Text = "When Changed";
            this.WhenChangedCol.Width = 130;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(514, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search Usernames";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtUserSearch
            // 
            this.txtUserSearch.Location = new System.Drawing.Point(362, 36);
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.Size = new System.Drawing.Size(92, 20);
            this.txtUserSearch.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please enter a username of a person whose changes you want to view:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Please enter two dates to find Changes made between:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "and";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Search Dates";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDate1
            // 
            this.txtDate1.Location = new System.Drawing.Point(288, 65);
            this.txtDate1.Mask = "00/00/0000";
            this.txtDate1.Name = "txtDate1";
            this.txtDate1.Size = new System.Drawing.Size(66, 20);
            this.txtDate1.TabIndex = 12;
            this.txtDate1.ValidatingType = typeof(System.DateTime);
            this.txtDate1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtDate1_MaskInputRejected);
            // 
            // txtDate2
            // 
            this.txtDate2.Location = new System.Drawing.Point(388, 65);
            this.txtDate2.Mask = "00/00/0000";
            this.txtDate2.Name = "txtDate2";
            this.txtDate2.Size = new System.Drawing.Size(66, 20);
            this.txtDate2.TabIndex = 13;
            this.txtDate2.ValidatingType = typeof(System.DateTime);
            this.txtDate2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtDate1_MaskInputRejected);
            // 
            // menuStrip_historyLog
            // 
            this.menuStrip_historyLog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip_historyLog.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_historyLog.Name = "menuStrip_historyLog";
            this.menuStrip_historyLog.Size = new System.Drawing.Size(646, 24);
            this.menuStrip_historyLog.TabIndex = 40;
            this.menuStrip_historyLog.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // HistoryLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 398);
            this.Controls.Add(this.menuStrip_historyLog);
            this.Controls.Add(this.txtDate2);
            this.Controls.Add(this.txtDate1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtUserSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstHistoryLog);
            this.Name = "HistoryLog";
            this.Text = "HistoryLog";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HistoryLog_FormClosed);
            this.Load += new System.EventHandler(this.HistoryLog_Load);
            this.menuStrip_historyLog.ResumeLayout(false);
            this.menuStrip_historyLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstHistoryLog;
        private System.Windows.Forms.ColumnHeader IDCol;
        private System.Windows.Forms.ColumnHeader UsernameCol;
        private System.Windows.Forms.ColumnHeader WhatChangedCol;
        private System.Windows.Forms.ColumnHeader WhenChangedCol;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtUserSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtDate1;
        private System.Windows.Forms.MaskedTextBox txtDate2;
        private System.Windows.Forms.MenuStrip menuStrip_historyLog;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
    }
}