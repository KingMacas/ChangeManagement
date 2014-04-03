namespace ApplicationSftwrEngineering
{
    partial class ModifyChange
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
            this.txtImpacted = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtImpact = new System.Windows.Forms.TextBox();
            this.boxDisposition = new System.Windows.Forms.ComboBox();
            this.boxPriority = new System.Windows.Forms.ComboBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtChangeID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtImpacted
            // 
            this.txtImpacted.Location = new System.Drawing.Point(119, 197);
            this.txtImpacted.Name = "txtImpacted";
            this.txtImpacted.Size = new System.Drawing.Size(100, 20);
            this.txtImpacted.TabIndex = 40;
            this.txtImpacted.TextChanged += new System.EventHandler(this.txtImpacted_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(92, 167);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 38;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // txtImpact
            // 
            this.txtImpact.Location = new System.Drawing.Point(75, 141);
            this.txtImpact.Name = "txtImpact";
            this.txtImpact.Size = new System.Drawing.Size(100, 20);
            this.txtImpact.TabIndex = 37;
            this.txtImpact.TextChanged += new System.EventHandler(this.txtImpact_TextChanged);
            // 
            // boxDisposition
            // 
            this.boxDisposition.FormattingEnabled = true;
            this.boxDisposition.Items.AddRange(new object[] {
            "Submitted",
            "Completed",
            "Action",
            "Defer",
            "Reject"});
            this.boxDisposition.Location = new System.Drawing.Point(87, 113);
            this.boxDisposition.Name = "boxDisposition";
            this.boxDisposition.Size = new System.Drawing.Size(121, 21);
            this.boxDisposition.TabIndex = 36;
            this.boxDisposition.SelectedIndexChanged += new System.EventHandler(this.boxDisposition_TextUpdate);
            this.boxDisposition.TextUpdate += new System.EventHandler(this.boxDisposition_TextUpdate);
            // 
            // boxPriority
            // 
            this.boxPriority.FormattingEnabled = true;
            this.boxPriority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Critical"});
            this.boxPriority.Location = new System.Drawing.Point(72, 82);
            this.boxPriority.Name = "boxPriority";
            this.boxPriority.Size = new System.Drawing.Size(121, 21);
            this.boxPriority.TabIndex = 35;
            this.boxPriority.SelectedIndexChanged += new System.EventHandler(this.boxPriority_TextUpdate);
            this.boxPriority.TextUpdate += new System.EventHandler(this.boxPriority_TextUpdate);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(87, 56);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(57, 20);
            this.txtUsername.TabIndex = 34;
            // 
            // txtChangeID
            // 
            this.txtChangeID.Location = new System.Drawing.Point(90, 33);
            this.txtChangeID.Name = "txtChangeID";
            this.txtChangeID.ReadOnly = true;
            this.txtChangeID.Size = new System.Drawing.Size(31, 20);
            this.txtChangeID.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Teams Impacted";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Impact:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Disposition:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Priority:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Change ID";
            // 
            // ModifyChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 448);
            this.Controls.Add(this.txtImpacted);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtImpact);
            this.Controls.Add(this.boxDisposition);
            this.Controls.Add(this.boxPriority);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtChangeID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModifyChange";
            this.Text = "ModifyChange";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModifyChange_FormClosed);
            this.Load += new System.EventHandler(this.ModifyChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImpacted;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtImpact;
        private System.Windows.Forms.ComboBox boxDisposition;
        private System.Windows.Forms.ComboBox boxPriority;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtChangeID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}