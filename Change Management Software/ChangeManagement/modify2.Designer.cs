namespace ApplicationSftwrEngineering
{
    partial class modify1
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
            this.lstChangeList = new System.Windows.Forms.ListView();
            this.changeIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usernameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priorityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dispositionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.impactColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.commentsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tImpactedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aCompletionDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.estimatedEffortColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EstimatedCompletionDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnModifyChange = new System.Windows.Forms.Button();
            this.button_modifyRefresh = new System.Windows.Forms.Button();
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtEstCompDate = new System.Windows.Forms.TextBox();
            this.txtEffort = new System.Windows.Forms.TextBox();
            this.txtCompletionDate = new System.Windows.Forms.TextBox();
            this.txtComments = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstChangeList
            // 
            this.lstChangeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.changeIDColumn,
            this.usernameColumn,
            this.priorityColumn,
            this.dispositionColumn,
            this.impactColumn,
            this.descriptionColumn,
            this.commentsColumn,
            this.tImpactedColumn,
            this.aCompletionDate,
            this.estimatedEffortColumn,
            this.EstimatedCompletionDateColumn});
            this.lstChangeList.FullRowSelect = true;
            this.lstChangeList.GridLines = true;
            this.lstChangeList.Location = new System.Drawing.Point(13, 13);
            this.lstChangeList.Name = "lstChangeList";
            this.lstChangeList.Size = new System.Drawing.Size(806, 285);
            this.lstChangeList.TabIndex = 0;
            this.lstChangeList.UseCompatibleStateImageBehavior = false;
            this.lstChangeList.View = System.Windows.Forms.View.Details;
            this.lstChangeList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstChangeList_ColumnClick);
            // 
            // changeIDColumn
            // 
            this.changeIDColumn.Text = "ID";
            this.changeIDColumn.Width = 40;
            // 
            // usernameColumn
            // 
            this.usernameColumn.Text = "Username";
            // 
            // priorityColumn
            // 
            this.priorityColumn.Text = "Priority";
            // 
            // dispositionColumn
            // 
            this.dispositionColumn.Text = "Disposition";
            // 
            // impactColumn
            // 
            this.impactColumn.Text = "Impact";
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.Text = "Description";
            // 
            // commentsColumn
            // 
            this.commentsColumn.Text = "Comments";
            // 
            // tImpactedColumn
            // 
            this.tImpactedColumn.Text = "Teams Impacted";
            // 
            // aCompletionDate
            // 
            this.aCompletionDate.Text = "Actual Completion Date";
            // 
            // estimatedEffortColumn
            // 
            this.estimatedEffortColumn.Text = "Effort Estimate";
            this.estimatedEffortColumn.Width = 84;
            // 
            // EstimatedCompletionDateColumn
            // 
            this.EstimatedCompletionDateColumn.Text = "Estimated Completion Date";
            // 
            // btnModifyChange
            // 
            this.btnModifyChange.Location = new System.Drawing.Point(13, 346);
            this.btnModifyChange.Name = "btnModifyChange";
            this.btnModifyChange.Size = new System.Drawing.Size(144, 63);
            this.btnModifyChange.TabIndex = 1;
            this.btnModifyChange.Text = "Modify Selection";
            this.btnModifyChange.UseVisualStyleBackColor = true;
            this.btnModifyChange.Click += new System.EventHandler(this.btnModifyChange_Click);
            // 
            // button_modifyRefresh
            // 
            this.button_modifyRefresh.Location = new System.Drawing.Point(13, 317);
            this.button_modifyRefresh.Name = "button_modifyRefresh";
            this.button_modifyRefresh.Size = new System.Drawing.Size(144, 23);
            this.button_modifyRefresh.TabIndex = 2;
            this.button_modifyRefresh.Text = "Refresh";
            this.button_modifyRefresh.UseVisualStyleBackColor = true;
            this.button_modifyRefresh.Click += new System.EventHandler(this.button_modifyRefresh_Click);
            // 
            // txtImpacted
            // 
            this.txtImpacted.Location = new System.Drawing.Point(353, 504);
            this.txtImpacted.Name = "txtImpacted";
            this.txtImpacted.Size = new System.Drawing.Size(96, 20);
            this.txtImpacted.TabIndex = 54;
            this.txtImpacted.TextChanged += new System.EventHandler(this.txtImpacted_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(326, 475);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(123, 20);
            this.txtDescription.TabIndex = 53;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // txtImpact
            // 
            this.txtImpact.Location = new System.Drawing.Point(326, 446);
            this.txtImpact.Name = "txtImpact";
            this.txtImpact.Size = new System.Drawing.Size(123, 20);
            this.txtImpact.TabIndex = 52;
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
            this.boxDisposition.Location = new System.Drawing.Point(326, 417);
            this.boxDisposition.Name = "boxDisposition";
            this.boxDisposition.Size = new System.Drawing.Size(123, 21);
            this.boxDisposition.TabIndex = 51;
            this.boxDisposition.SelectedIndexChanged += new System.EventHandler(this.boxDisposition_TextUpdate);
            // 
            // boxPriority
            // 
            this.boxPriority.FormattingEnabled = true;
            this.boxPriority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Critical"});
            this.boxPriority.Location = new System.Drawing.Point(326, 388);
            this.boxPriority.Name = "boxPriority";
            this.boxPriority.Size = new System.Drawing.Size(123, 21);
            this.boxPriority.TabIndex = 50;
            this.boxPriority.SelectedIndexChanged += new System.EventHandler(this.boxPriority_TextUpdate);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(326, 362);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(123, 20);
            this.txtUsername.TabIndex = 49;
            // 
            // txtChangeID
            // 
            this.txtChangeID.Location = new System.Drawing.Point(326, 336);
            this.txtChangeID.Name = "txtChangeID";
            this.txtChangeID.ReadOnly = true;
            this.txtChangeID.Size = new System.Drawing.Size(31, 20);
            this.txtChangeID.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 507);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Teams Impacted:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Impact:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Disposition:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Priority:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Change ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 63;
            this.button1.Text = "Modify Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEstCompDate
            // 
            this.txtEstCompDate.Location = new System.Drawing.Point(617, 390);
            this.txtEstCompDate.Name = "txtEstCompDate";
            this.txtEstCompDate.Size = new System.Drawing.Size(119, 20);
            this.txtEstCompDate.TabIndex = 62;
            this.txtEstCompDate.TextChanged += new System.EventHandler(this.txtEstCompDate_TextChanged);
            // 
            // txtEffort
            // 
            this.txtEffort.Location = new System.Drawing.Point(601, 362);
            this.txtEffort.Name = "txtEffort";
            this.txtEffort.Size = new System.Drawing.Size(135, 20);
            this.txtEffort.TabIndex = 61;
            this.txtEffort.TextChanged += new System.EventHandler(this.txtEffort_TextChanged);
            // 
            // txtCompletionDate
            // 
            this.txtCompletionDate.Location = new System.Drawing.Point(601, 335);
            this.txtCompletionDate.Name = "txtCompletionDate";
            this.txtCompletionDate.ReadOnly = true;
            this.txtCompletionDate.Size = new System.Drawing.Size(135, 20);
            this.txtCompletionDate.TabIndex = 60;
            this.txtCompletionDate.TextChanged += new System.EventHandler(this.txtCompletionDate_TextChanged);
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(538, 431);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(198, 96);
            this.txtComments.TabIndex = 59;
            this.txtComments.Text = "";
            this.txtComments.TextChanged += new System.EventHandler(this.txtComments_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(474, 392);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "Estimated Completion Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(474, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Estimated Effort:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(474, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Actual Completion Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(474, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Comments:";
            // 
            // modify1
            // 
            this.ClientSize = new System.Drawing.Size(834, 579);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEstCompDate);
            this.Controls.Add(this.txtEffort);
            this.Controls.Add(this.txtCompletionDate);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
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
            this.Controls.Add(this.button_modifyRefresh);
            this.Controls.Add(this.btnModifyChange);
            this.Controls.Add(this.lstChangeList);
            this.Name = "modify1";
            this.Text = "Change Select";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.modify1_FormClosed);
            this.Load += new System.EventHandler(this.modify1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        

        private System.Windows.Forms.ListView lstChangeList;
        private System.Windows.Forms.ColumnHeader changeIDColumn;
        private System.Windows.Forms.ColumnHeader usernameColumn;
        private System.Windows.Forms.ColumnHeader priorityColumn;
        private System.Windows.Forms.ColumnHeader dispositionColumn;
        private System.Windows.Forms.ColumnHeader impactColumn;
        private System.Windows.Forms.ColumnHeader descriptionColumn;
        private System.Windows.Forms.ColumnHeader commentsColumn;
        private System.Windows.Forms.ColumnHeader tImpactedColumn;
        private System.Windows.Forms.ColumnHeader aCompletionDate;
        private System.Windows.Forms.ColumnHeader estimatedEffortColumn;
        private System.Windows.Forms.ColumnHeader EstimatedCompletionDateColumn;
        private System.Windows.Forms.Button btnModifyChange;
        private System.Windows.Forms.Button button_modifyRefresh;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEstCompDate;
        private System.Windows.Forms.TextBox txtEffort;
        private System.Windows.Forms.TextBox txtCompletionDate;
        private System.Windows.Forms.RichTextBox txtComments;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
    }
}