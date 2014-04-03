namespace ApplicationSftwrEngineering
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AdminPanel_GroupBox = new System.Windows.Forms.GroupBox();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.Others_GroupBox = new System.Windows.Forms.GroupBox();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.FindChange_GroupBox = new System.Windows.Forms.GroupBox();
            this.Search_Button = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.AddModChange_GroupBox = new System.Windows.Forms.GroupBox();
            this.btnAddChange = new System.Windows.Forms.Button();
            this.btnModifyChange = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Logout_ToolStripOption = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_ToolStripOption = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminPanel_GroupBox.SuspendLayout();
            this.Others_GroupBox.SuspendLayout();
            this.FindChange_GroupBox.SuspendLayout();
            this.AddModChange_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminPanel_GroupBox
            // 
            this.AdminPanel_GroupBox.Controls.Add(this.btnAdminPanel);
            this.AdminPanel_GroupBox.Location = new System.Drawing.Point(221, 417);
            this.AdminPanel_GroupBox.Name = "AdminPanel_GroupBox";
            this.AdminPanel_GroupBox.Size = new System.Drawing.Size(202, 100);
            this.AdminPanel_GroupBox.TabIndex = 9;
            this.AdminPanel_GroupBox.TabStop = false;
            this.AdminPanel_GroupBox.Text = "Admin Panel";
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.Location = new System.Drawing.Point(20, 30);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(157, 47);
            this.btnAdminPanel.TabIndex = 0;
            this.btnAdminPanel.Text = "Admin Panel";
            this.btnAdminPanel.UseVisualStyleBackColor = true;
            this.btnAdminPanel.Click += new System.EventHandler(this.btnAdminPanel_Click);
            // 
            // Others_GroupBox
            // 
            this.Others_GroupBox.Controls.Add(this.btnStatistics);
            this.Others_GroupBox.Location = new System.Drawing.Point(16, 417);
            this.Others_GroupBox.Name = "Others_GroupBox";
            this.Others_GroupBox.Size = new System.Drawing.Size(203, 100);
            this.Others_GroupBox.TabIndex = 10;
            this.Others_GroupBox.TabStop = false;
            this.Others_GroupBox.Text = "Other";
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(27, 30);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(157, 47);
            this.btnStatistics.TabIndex = 0;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.Statistics_Button_Click);
            // 
            // FindChange_GroupBox
            // 
            this.FindChange_GroupBox.Controls.Add(this.Search_Button);
            this.FindChange_GroupBox.Controls.Add(this.btnLog);
            this.FindChange_GroupBox.Location = new System.Drawing.Point(15, 310);
            this.FindChange_GroupBox.Name = "FindChange_GroupBox";
            this.FindChange_GroupBox.Size = new System.Drawing.Size(408, 100);
            this.FindChange_GroupBox.TabIndex = 8;
            this.FindChange_GroupBox.TabStop = false;
            this.FindChange_GroupBox.Text = "Find Change";
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(28, 31);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(157, 47);
            this.Search_Button.TabIndex = 0;
            this.Search_Button.Text = "Search Change";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(226, 31);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(157, 47);
            this.btnLog.TabIndex = 0;
            this.btnLog.Text = "History Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // AddModChange_GroupBox
            // 
            this.AddModChange_GroupBox.Controls.Add(this.btnAddChange);
            this.AddModChange_GroupBox.Controls.Add(this.btnModifyChange);
            this.AddModChange_GroupBox.Location = new System.Drawing.Point(16, 204);
            this.AddModChange_GroupBox.Name = "AddModChange_GroupBox";
            this.AddModChange_GroupBox.Size = new System.Drawing.Size(407, 100);
            this.AddModChange_GroupBox.TabIndex = 7;
            this.AddModChange_GroupBox.TabStop = false;
            this.AddModChange_GroupBox.Text = "Add/Modify Change";
            // 
            // btnAddChange
            // 
            this.btnAddChange.Location = new System.Drawing.Point(27, 33);
            this.btnAddChange.Name = "btnAddChange";
            this.btnAddChange.Size = new System.Drawing.Size(157, 47);
            this.btnAddChange.TabIndex = 0;
            this.btnAddChange.Text = "Add Change";
            this.btnAddChange.UseVisualStyleBackColor = true;
            this.btnAddChange.Click += new System.EventHandler(this.btnAddChange_Click);
            // 
            // btnModifyChange
            // 
            this.btnModifyChange.Location = new System.Drawing.Point(225, 33);
            this.btnModifyChange.Name = "btnModifyChange";
            this.btnModifyChange.Size = new System.Drawing.Size(157, 47);
            this.btnModifyChange.TabIndex = 0;
            this.btnModifyChange.Text = "Modify Change";
            this.btnModifyChange.UseVisualStyleBackColor = true;
            this.btnModifyChange.Click += new System.EventHandler(this.btnModifyChange_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 159);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_ToolStrip,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(459, 27);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_ToolStrip
            // 
            this.Menu_ToolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.Menu_ToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Logout_ToolStripOption,
            this.Exit_ToolStripOption});
            this.Menu_ToolStrip.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.Menu_ToolStrip.Name = "Menu_ToolStrip";
            this.Menu_ToolStrip.Size = new System.Drawing.Size(50, 19);
            this.Menu_ToolStrip.Text = "Menu";
            // 
            // Logout_ToolStripOption
            // 
            this.Logout_ToolStripOption.Name = "Logout_ToolStripOption";
            this.Logout_ToolStripOption.Size = new System.Drawing.Size(152, 22);
            this.Logout_ToolStripOption.Text = "Logout";
            this.Logout_ToolStripOption.Click += new System.EventHandler(this.Logout_ToolStripOption_Click);
            // 
            // Exit_ToolStripOption
            // 
            this.Exit_ToolStripOption.Name = "Exit_ToolStripOption";
            this.Exit_ToolStripOption.Size = new System.Drawing.Size(152, 22);
            this.Exit_ToolStripOption.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 543);
            this.Controls.Add(this.AdminPanel_GroupBox);
            this.Controls.Add(this.Others_GroupBox);
            this.Controls.Add(this.FindChange_GroupBox);
            this.Controls.Add(this.AddModChange_GroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Main Form";
            //this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.AdminPanel_GroupBox.ResumeLayout(false);
            this.Others_GroupBox.ResumeLayout(false);
            this.FindChange_GroupBox.ResumeLayout(false);
            this.AddModChange_GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox AdminPanel_GroupBox;
        private System.Windows.Forms.Button btnAdminPanel;
        private System.Windows.Forms.GroupBox Others_GroupBox;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.GroupBox FindChange_GroupBox;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.GroupBox AddModChange_GroupBox;
        private System.Windows.Forms.Button btnAddChange;
        private System.Windows.Forms.Button btnModifyChange;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem Logout_ToolStripOption;
        private System.Windows.Forms.ToolStripMenuItem Exit_ToolStripOption;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;

    }
}

