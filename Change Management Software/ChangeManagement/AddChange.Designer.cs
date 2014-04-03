namespace ApplicationSftwrEngineering
{
    partial class AddChange
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtComments = new System.Windows.Forms.RichTextBox();
            this.txtImpact = new System.Windows.Forms.TextBox();
            this.boxPriority = new System.Windows.Forms.ComboBox();
            this.txtChangeID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.menuStrip_addChange = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_addChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(205, 349);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(87, 23);
            this.btnSubmit.TabIndex = 38;
            this.btnSubmit.Text = "Submit Change";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(130, 260);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(162, 73);
            this.txtComments.TabIndex = 37;
            this.txtComments.Text = "";
            // 
            // txtImpact
            // 
            this.txtImpact.Location = new System.Drawing.Point(130, 147);
            this.txtImpact.Name = "txtImpact";
            this.txtImpact.Size = new System.Drawing.Size(121, 20);
            this.txtImpact.TabIndex = 35;
            // 
            // boxPriority
            // 
            this.boxPriority.FormattingEnabled = true;
            this.boxPriority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Critical"});
            this.boxPriority.Location = new System.Drawing.Point(130, 119);
            this.boxPriority.Name = "boxPriority";
            this.boxPriority.Size = new System.Drawing.Size(121, 21);
            this.boxPriority.TabIndex = 34;
            this.boxPriority.Text = "Low";
            // 
            // txtChangeID
            // 
            this.txtChangeID.Location = new System.Drawing.Point(130, 91);
            this.txtChangeID.Name = "txtChangeID";
            this.txtChangeID.ReadOnly = true;
            this.txtChangeID.Size = new System.Drawing.Size(44, 20);
            this.txtChangeID.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Comments:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Impact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Priority:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "New Change ID:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(130, 178);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(162, 66);
            this.txtDescription.TabIndex = 36;
            this.txtDescription.Text = "";
            // 
            // menuStrip_addChange
            // 
            this.menuStrip_addChange.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip_addChange.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_addChange.Name = "menuStrip_addChange";
            this.menuStrip_addChange.Size = new System.Drawing.Size(352, 24);
            this.menuStrip_addChange.TabIndex = 39;
            this.menuStrip_addChange.Text = "menuStrip1";
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // AddChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 415);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.txtImpact);
            this.Controls.Add(this.boxPriority);
            this.Controls.Add(this.txtChangeID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip_addChange);
            this.MainMenuStrip = this.menuStrip_addChange;
            this.Name = "AddChange";
            this.Text = "Add Change";
            this.Load += new System.EventHandler(this.AddChange_Load);
            this.menuStrip_addChange.ResumeLayout(false);
            this.menuStrip_addChange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RichTextBox txtComments;
        private System.Windows.Forms.TextBox txtImpact;
        private System.Windows.Forms.ComboBox boxPriority;
        private System.Windows.Forms.TextBox txtChangeID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.MenuStrip menuStrip_addChange;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
    }
}