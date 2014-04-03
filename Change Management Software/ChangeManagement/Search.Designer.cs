namespace ApplicationSftwrEngineering
{
    partial class SearchWindow
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
            this.button_Search = new System.Windows.Forms.Button();
            this.comboBox_fields = new System.Windows.Forms.ComboBox();
            this.textBoxSearchKeyword = new System.Windows.Forms.TextBox();
            this.listView_search = new System.Windows.Forms.ListView();
            this.changeIDCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Change_Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Disposition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Teams_Impacted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estimated_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Actual_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estimated_Effort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Modified_by = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkBox_wildcard = new System.Windows.Forms.CheckBox();
            this.menuStrip_search = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(702, 73);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(136, 23);
            this.button_Search.TabIndex = 0;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // comboBox_fields
            // 
            this.comboBox_fields.FormattingEnabled = true;
            this.comboBox_fields.Items.AddRange(new object[] {
            "Change_ID",
            "Username",
            "Change_Priority",
            "Disposition",
            "Teams_Impacted",
            "Estimated_Completion_Date",
            "Actual_Completion_Date",
            "Estimated_Effort",
            "Modified_By"});
            this.comboBox_fields.Location = new System.Drawing.Point(238, 75);
            this.comboBox_fields.MaxDropDownItems = 9;
            this.comboBox_fields.Name = "comboBox_fields";
            this.comboBox_fields.Size = new System.Drawing.Size(121, 21);
            this.comboBox_fields.TabIndex = 1;
            this.comboBox_fields.Text = "Select specific field";
            // 
            // textBoxSearchKeyword
            // 
            this.textBoxSearchKeyword.Location = new System.Drawing.Point(12, 75);
            this.textBoxSearchKeyword.Name = "textBoxSearchKeyword";
            this.textBoxSearchKeyword.Size = new System.Drawing.Size(209, 20);
            this.textBoxSearchKeyword.TabIndex = 2;
            this.textBoxSearchKeyword.Text = "Searching for...";
            this.textBoxSearchKeyword.Enter += new System.EventHandler(this.textBoxSearchKeyword_Enter);
            // 
            // listView_search
            // 
            this.listView_search.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.changeIDCol,
            this.UserName,
            this.Change_Priority,
            this.Disposition,
            this.Teams_Impacted,
            this.Estimated_Date,
            this.Actual_Date,
            this.Estimated_Effort,
            this.Modified_by});
            this.listView_search.FullRowSelect = true;
            this.listView_search.GridLines = true;
            this.listView_search.Location = new System.Drawing.Point(12, 105);
            this.listView_search.Name = "listView_search";
            this.listView_search.Size = new System.Drawing.Size(826, 313);
            this.listView_search.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView_search.TabIndex = 5;
            this.listView_search.UseCompatibleStateImageBehavior = false;
            this.listView_search.View = System.Windows.Forms.View.Details;
            this.listView_search.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_search_ColumnClick);
            // 
            // changeIDCol
            // 
            this.changeIDCol.Text = "Change ID";
            // 
            // UserName
            // 
            this.UserName.Text = "Username";
            this.UserName.Width = 66;
            // 
            // Change_Priority
            // 
            this.Change_Priority.Text = "Change Priority";
            this.Change_Priority.Width = 88;
            // 
            // Disposition
            // 
            this.Disposition.Text = "Disposition";
            this.Disposition.Width = 70;
            // 
            // Teams_Impacted
            // 
            this.Teams_Impacted.Text = "Teams Impacted";
            this.Teams_Impacted.Width = 94;
            // 
            // Estimated_Date
            // 
            this.Estimated_Date.Text = "Estimated Completion_Date";
            this.Estimated_Date.Width = 112;
            // 
            // Actual_Date
            // 
            this.Actual_Date.Text = "Actual Completion Date";
            this.Actual_Date.Width = 128;
            // 
            // Estimated_Effort
            // 
            this.Estimated_Effort.Text = "Estimated Effort";
            this.Estimated_Effort.Width = 89;
            // 
            // Modified_by
            // 
            this.Modified_by.Text = "Modified By";
            this.Modified_by.Width = 233;
            // 
            // checkBox_wildcard
            // 
            this.checkBox_wildcard.AutoSize = true;
            this.checkBox_wildcard.Location = new System.Drawing.Point(377, 78);
            this.checkBox_wildcard.Name = "checkBox_wildcard";
            this.checkBox_wildcard.Size = new System.Drawing.Size(68, 17);
            this.checkBox_wildcard.TabIndex = 6;
            this.checkBox_wildcard.Text = "Wildcard";
            this.checkBox_wildcard.UseVisualStyleBackColor = true;
            this.checkBox_wildcard.CheckedChanged += new System.EventHandler(this.checkBox_wildcard_CheckedChanged);
            // 
            // menuStrip_search
            // 
            this.menuStrip_search.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip_search.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_search.Name = "menuStrip_search";
            this.menuStrip_search.Size = new System.Drawing.Size(850, 24);
            this.menuStrip_search.TabIndex = 40;
            this.menuStrip_search.Text = "menuStrip1";
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 20);
            this.dateTimePicker1.TabIndex = 41;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // SearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 436);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip_search);
            this.Controls.Add(this.checkBox_wildcard);
            this.Controls.Add(this.listView_search);
            this.Controls.Add(this.textBoxSearchKeyword);
            this.Controls.Add(this.comboBox_fields);
            this.Controls.Add(this.button_Search);
            this.Name = "SearchWindow";
            this.Text = "Search Window";
            this.menuStrip_search.ResumeLayout(false);
            this.menuStrip_search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.ComboBox comboBox_fields;
        private System.Windows.Forms.TextBox textBoxSearchKeyword;
        private System.Windows.Forms.ListView listView_search;
        private System.Windows.Forms.ColumnHeader UserName;
        private System.Windows.Forms.ColumnHeader Change_Priority;
        private System.Windows.Forms.ColumnHeader Disposition;
        private System.Windows.Forms.ColumnHeader Teams_Impacted;
        private System.Windows.Forms.ColumnHeader Estimated_Date;
        private System.Windows.Forms.ColumnHeader Actual_Date;
        private System.Windows.Forms.ColumnHeader Estimated_Effort;
        private System.Windows.Forms.ColumnHeader Modified_by;
        private System.Windows.Forms.ColumnHeader changeIDCol;
        private System.Windows.Forms.CheckBox checkBox_wildcard;
        private System.Windows.Forms.MenuStrip menuStrip_search;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

