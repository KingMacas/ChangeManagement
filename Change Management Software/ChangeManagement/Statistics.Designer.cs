namespace ApplicationSftwrEngineering
{
    partial class StatisticForm
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
            this.lblTotalChange = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_reject = new System.Windows.Forms.TextBox();
            this.textBox_defer = new System.Windows.Forms.TextBox();
            this.textBox_action = new System.Windows.Forms.TextBox();
            this.textBox_completed = new System.Windows.Forms.TextBox();
            this.textBox_submitted = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_priority = new System.Windows.Forms.GroupBox();
            this.textBox_critical = new System.Windows.Forms.TextBox();
            this.textBox_high = new System.Windows.Forms.TextBox();
            this.textBox_medium = new System.Windows.Forms.TextBox();
            this.textBox_low = new System.Windows.Forms.TextBox();
            this.label_medium = new System.Windows.Forms.Label();
            this.label_critical = new System.Windows.Forms.Label();
            this.label_low = new System.Windows.Forms.Label();
            this.label_high = new System.Windows.Forms.Label();
            this.menuStrip_statistics = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox_priority.SuspendLayout();
            this.menuStrip_statistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalChange
            // 
            this.lblTotalChange.AutoSize = true;
            this.lblTotalChange.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalChange.Location = new System.Drawing.Point(21, 85);
            this.lblTotalChange.Name = "lblTotalChange";
            this.lblTotalChange.Size = new System.Drawing.Size(0, 24);
            this.lblTotalChange.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_reject);
            this.groupBox1.Controls.Add(this.textBox_defer);
            this.groupBox1.Controls.Add(this.textBox_action);
            this.groupBox1.Controls.Add(this.textBox_completed);
            this.groupBox1.Controls.Add(this.textBox_submitted);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(273, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 168);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Number of change dispositions";
            // 
            // textBox_reject
            // 
            this.textBox_reject.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_reject.Enabled = false;
            this.textBox_reject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_reject.Location = new System.Drawing.Point(148, 132);
            this.textBox_reject.Name = "textBox_reject";
            this.textBox_reject.ReadOnly = true;
            this.textBox_reject.Size = new System.Drawing.Size(37, 22);
            this.textBox_reject.TabIndex = 1;
            this.textBox_reject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_defer
            // 
            this.textBox_defer.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_defer.Enabled = false;
            this.textBox_defer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_defer.Location = new System.Drawing.Point(148, 107);
            this.textBox_defer.Name = "textBox_defer";
            this.textBox_defer.ReadOnly = true;
            this.textBox_defer.Size = new System.Drawing.Size(37, 22);
            this.textBox_defer.TabIndex = 1;
            this.textBox_defer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_action
            // 
            this.textBox_action.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_action.Enabled = false;
            this.textBox_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_action.Location = new System.Drawing.Point(148, 80);
            this.textBox_action.Name = "textBox_action";
            this.textBox_action.ReadOnly = true;
            this.textBox_action.Size = new System.Drawing.Size(37, 22);
            this.textBox_action.TabIndex = 1;
            this.textBox_action.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_completed
            // 
            this.textBox_completed.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_completed.Enabled = false;
            this.textBox_completed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_completed.Location = new System.Drawing.Point(148, 53);
            this.textBox_completed.Name = "textBox_completed";
            this.textBox_completed.ReadOnly = true;
            this.textBox_completed.Size = new System.Drawing.Size(37, 22);
            this.textBox_completed.TabIndex = 1;
            this.textBox_completed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_submitted
            // 
            this.textBox_submitted.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_submitted.Enabled = false;
            this.textBox_submitted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_submitted.Location = new System.Drawing.Point(148, 27);
            this.textBox_submitted.Name = "textBox_submitted";
            this.textBox_submitted.ReadOnly = true;
            this.textBox_submitted.Size = new System.Drawing.Size(37, 22);
            this.textBox_submitted.TabIndex = 1;
            this.textBox_submitted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Reject:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Completed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Defer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Submitted:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Action:";
            // 
            // groupBox_priority
            // 
            this.groupBox_priority.Controls.Add(this.textBox_critical);
            this.groupBox_priority.Controls.Add(this.textBox_high);
            this.groupBox_priority.Controls.Add(this.textBox_medium);
            this.groupBox_priority.Controls.Add(this.textBox_low);
            this.groupBox_priority.Controls.Add(this.label_medium);
            this.groupBox_priority.Controls.Add(this.label_critical);
            this.groupBox_priority.Controls.Add(this.label_low);
            this.groupBox_priority.Controls.Add(this.label_high);
            this.groupBox_priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_priority.Location = new System.Drawing.Point(27, 137);
            this.groupBox_priority.Name = "groupBox_priority";
            this.groupBox_priority.Size = new System.Drawing.Size(188, 168);
            this.groupBox_priority.TabIndex = 6;
            this.groupBox_priority.TabStop = false;
            this.groupBox_priority.Text = "Number of change priorities";
            // 
            // textBox_critical
            // 
            this.textBox_critical.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_critical.Enabled = false;
            this.textBox_critical.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_critical.Location = new System.Drawing.Point(123, 121);
            this.textBox_critical.Name = "textBox_critical";
            this.textBox_critical.ReadOnly = true;
            this.textBox_critical.Size = new System.Drawing.Size(37, 22);
            this.textBox_critical.TabIndex = 1;
            this.textBox_critical.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_high
            // 
            this.textBox_high.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_high.Enabled = false;
            this.textBox_high.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_high.Location = new System.Drawing.Point(123, 94);
            this.textBox_high.Name = "textBox_high";
            this.textBox_high.ReadOnly = true;
            this.textBox_high.Size = new System.Drawing.Size(37, 22);
            this.textBox_high.TabIndex = 1;
            this.textBox_high.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_medium
            // 
            this.textBox_medium.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_medium.Enabled = false;
            this.textBox_medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_medium.Location = new System.Drawing.Point(123, 66);
            this.textBox_medium.Name = "textBox_medium";
            this.textBox_medium.ReadOnly = true;
            this.textBox_medium.Size = new System.Drawing.Size(37, 22);
            this.textBox_medium.TabIndex = 1;
            this.textBox_medium.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_low
            // 
            this.textBox_low.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_low.Enabled = false;
            this.textBox_low.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_low.Location = new System.Drawing.Point(123, 39);
            this.textBox_low.Name = "textBox_low";
            this.textBox_low.ReadOnly = true;
            this.textBox_low.Size = new System.Drawing.Size(37, 22);
            this.textBox_low.TabIndex = 1;
            this.textBox_low.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_medium
            // 
            this.label_medium.AutoSize = true;
            this.label_medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_medium.ForeColor = System.Drawing.Color.Gold;
            this.label_medium.Location = new System.Drawing.Point(21, 69);
            this.label_medium.Name = "label_medium";
            this.label_medium.Size = new System.Drawing.Size(54, 13);
            this.label_medium.TabIndex = 0;
            this.label_medium.Text = "Medium:";
            // 
            // label_critical
            // 
            this.label_critical.AutoSize = true;
            this.label_critical.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_critical.Location = new System.Drawing.Point(21, 124);
            this.label_critical.Name = "label_critical";
            this.label_critical.Size = new System.Drawing.Size(50, 13);
            this.label_critical.TabIndex = 0;
            this.label_critical.Text = "Critical:";
            // 
            // label_low
            // 
            this.label_low.AutoSize = true;
            this.label_low.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_low.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_low.Location = new System.Drawing.Point(21, 43);
            this.label_low.Name = "label_low";
            this.label_low.Size = new System.Drawing.Size(34, 13);
            this.label_low.TabIndex = 0;
            this.label_low.Text = "Low:";
            // 
            // label_high
            // 
            this.label_high.AutoSize = true;
            this.label_high.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_high.ForeColor = System.Drawing.Color.Red;
            this.label_high.Location = new System.Drawing.Point(21, 97);
            this.label_high.Name = "label_high";
            this.label_high.Size = new System.Drawing.Size(37, 13);
            this.label_high.TabIndex = 0;
            this.label_high.Text = "High:";
            // 
            // menuStrip_statistics
            // 
            this.menuStrip_statistics.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip_statistics.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_statistics.Name = "menuStrip_statistics";
            this.menuStrip_statistics.Size = new System.Drawing.Size(509, 24);
            this.menuStrip_statistics.TabIndex = 40;
            this.menuStrip_statistics.Text = "menuStrip1";
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
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 487);
            this.Controls.Add(this.menuStrip_statistics);
            this.Controls.Add(this.lblTotalChange);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_priority);
            this.Name = "StatisticForm";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_priority.ResumeLayout(false);
            this.groupBox_priority.PerformLayout();
            this.menuStrip_statistics.ResumeLayout(false);
            this.menuStrip_statistics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalChange;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_reject;
        private System.Windows.Forms.TextBox textBox_defer;
        private System.Windows.Forms.TextBox textBox_action;
        private System.Windows.Forms.TextBox textBox_completed;
        private System.Windows.Forms.TextBox textBox_submitted;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox_priority;
        private System.Windows.Forms.TextBox textBox_critical;
        private System.Windows.Forms.TextBox textBox_high;
        private System.Windows.Forms.TextBox textBox_medium;
        private System.Windows.Forms.TextBox textBox_low;
        private System.Windows.Forms.Label label_medium;
        private System.Windows.Forms.Label label_critical;
        private System.Windows.Forms.Label label_low;
        private System.Windows.Forms.Label label_high;
        private System.Windows.Forms.MenuStrip menuStrip_statistics;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
    }
}