namespace ApplicationSftwrEngineering
{
    partial class FormAdminCommands
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
            this.listViewLogin = new System.Windows.Forms.ListView();
            this.columnUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPermission = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonRefreshValues = new System.Windows.Forms.Button();
            this.labelUsername1 = new System.Windows.Forms.Label();
            this.labelPassword1 = new System.Windows.Forms.Label();
            this.labelPermission1 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.groupBoxModifyUser = new System.Windows.Forms.GroupBox();
            this.buttonSelectUser = new System.Windows.Forms.Button();
            this.textBoxPermission1 = new System.Windows.Forms.TextBox();
            this.textBoxPassword1 = new System.Windows.Forms.TextBox();
            this.textBoxUsername1 = new System.Windows.Forms.TextBox();
            this.groupBoxAddUser = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelPermission2 = new System.Windows.Forms.Label();
            this.labelPassword2 = new System.Windows.Forms.Label();
            this.labelUsername2 = new System.Windows.Forms.Label();
            this.textBoxPermission2 = new System.Windows.Forms.TextBox();
            this.textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.textBoxUsername2 = new System.Windows.Forms.TextBox();
            this.menuStrip_adminControls = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxModifyUser.SuspendLayout();
            this.groupBoxAddUser.SuspendLayout();
            this.menuStrip_adminControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewLogin
            // 
            this.listViewLogin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnUsername,
            this.columnPassword,
            this.columnPermission});
            this.listViewLogin.FullRowSelect = true;
            this.listViewLogin.GridLines = true;
            this.listViewLogin.Location = new System.Drawing.Point(29, 96);
            this.listViewLogin.Name = "listViewLogin";
            this.listViewLogin.Size = new System.Drawing.Size(297, 275);
            this.listViewLogin.TabIndex = 0;
            this.listViewLogin.UseCompatibleStateImageBehavior = false;
            this.listViewLogin.View = System.Windows.Forms.View.Details;
            // 
            // columnUsername
            // 
            this.columnUsername.Text = "Username";
            this.columnUsername.Width = 114;
            // 
            // columnPassword
            // 
            this.columnPassword.Text = "Password";
            this.columnPassword.Width = 118;
            // 
            // columnPermission
            // 
            this.columnPermission.Text = "Permission";
            this.columnPermission.Width = 132;
            // 
            // buttonRefreshValues
            // 
            this.buttonRefreshValues.Location = new System.Drawing.Point(29, 67);
            this.buttonRefreshValues.Name = "buttonRefreshValues";
            this.buttonRefreshValues.Size = new System.Drawing.Size(297, 23);
            this.buttonRefreshValues.TabIndex = 1;
            this.buttonRefreshValues.Text = "Refresh Values";
            this.buttonRefreshValues.UseVisualStyleBackColor = true;
            this.buttonRefreshValues.Click += new System.EventHandler(this.buttonRefreshValues_Click);
            // 
            // labelUsername1
            // 
            this.labelUsername1.AutoSize = true;
            this.labelUsername1.Location = new System.Drawing.Point(18, 54);
            this.labelUsername1.Name = "labelUsername1";
            this.labelUsername1.Size = new System.Drawing.Size(55, 13);
            this.labelUsername1.TabIndex = 4;
            this.labelUsername1.Text = "Username";
            // 
            // labelPassword1
            // 
            this.labelPassword1.AutoSize = true;
            this.labelPassword1.Location = new System.Drawing.Point(20, 80);
            this.labelPassword1.Name = "labelPassword1";
            this.labelPassword1.Size = new System.Drawing.Size(53, 13);
            this.labelPassword1.TabIndex = 5;
            this.labelPassword1.Text = "Password";
            // 
            // labelPermission1
            // 
            this.labelPermission1.AutoSize = true;
            this.labelPermission1.Location = new System.Drawing.Point(16, 106);
            this.labelPermission1.Name = "labelPermission1";
            this.labelPermission1.Size = new System.Drawing.Size(57, 13);
            this.labelPermission1.TabIndex = 6;
            this.labelPermission1.Text = "Permission";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(79, 129);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 23);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // groupBoxModifyUser
            // 
            this.groupBoxModifyUser.Controls.Add(this.buttonSelectUser);
            this.groupBoxModifyUser.Controls.Add(this.textBoxPermission1);
            this.groupBoxModifyUser.Controls.Add(this.textBoxPassword1);
            this.groupBoxModifyUser.Controls.Add(this.textBoxUsername1);
            this.groupBoxModifyUser.Controls.Add(this.labelPermission1);
            this.groupBoxModifyUser.Controls.Add(this.buttonUpdate);
            this.groupBoxModifyUser.Controls.Add(this.labelPassword1);
            this.groupBoxModifyUser.Controls.Add(this.labelUsername1);
            this.groupBoxModifyUser.Location = new System.Drawing.Point(342, 67);
            this.groupBoxModifyUser.Name = "groupBoxModifyUser";
            this.groupBoxModifyUser.Size = new System.Drawing.Size(198, 165);
            this.groupBoxModifyUser.TabIndex = 9;
            this.groupBoxModifyUser.TabStop = false;
            this.groupBoxModifyUser.Text = "Modify User";
            // 
            // buttonSelectUser
            // 
            this.buttonSelectUser.Location = new System.Drawing.Point(79, 19);
            this.buttonSelectUser.Name = "buttonSelectUser";
            this.buttonSelectUser.Size = new System.Drawing.Size(100, 23);
            this.buttonSelectUser.TabIndex = 12;
            this.buttonSelectUser.Text = "Select User";
            this.buttonSelectUser.UseVisualStyleBackColor = true;
            this.buttonSelectUser.Click += new System.EventHandler(this.buttonSelectUser_Click);
            // 
            // textBoxPermission1
            // 
            this.textBoxPermission1.Location = new System.Drawing.Point(79, 103);
            this.textBoxPermission1.Name = "textBoxPermission1";
            this.textBoxPermission1.Size = new System.Drawing.Size(100, 20);
            this.textBoxPermission1.TabIndex = 11;
            // 
            // textBoxPassword1
            // 
            this.textBoxPassword1.Location = new System.Drawing.Point(79, 77);
            this.textBoxPassword1.Name = "textBoxPassword1";
            this.textBoxPassword1.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword1.TabIndex = 10;
            // 
            // textBoxUsername1
            // 
            this.textBoxUsername1.Location = new System.Drawing.Point(79, 51);
            this.textBoxUsername1.Name = "textBoxUsername1";
            this.textBoxUsername1.ReadOnly = true;
            this.textBoxUsername1.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsername1.TabIndex = 9;
            // 
            // groupBoxAddUser
            // 
            this.groupBoxAddUser.Controls.Add(this.buttonAdd);
            this.groupBoxAddUser.Controls.Add(this.labelPermission2);
            this.groupBoxAddUser.Controls.Add(this.labelPassword2);
            this.groupBoxAddUser.Controls.Add(this.labelUsername2);
            this.groupBoxAddUser.Controls.Add(this.textBoxPermission2);
            this.groupBoxAddUser.Controls.Add(this.textBoxPassword2);
            this.groupBoxAddUser.Controls.Add(this.textBoxUsername2);
            this.groupBoxAddUser.Location = new System.Drawing.Point(342, 245);
            this.groupBoxAddUser.Name = "groupBoxAddUser";
            this.groupBoxAddUser.Size = new System.Drawing.Size(198, 126);
            this.groupBoxAddUser.TabIndex = 10;
            this.groupBoxAddUser.TabStop = false;
            this.groupBoxAddUser.Text = "Add User";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(79, 97);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelPermission2
            // 
            this.labelPermission2.AutoSize = true;
            this.labelPermission2.Location = new System.Drawing.Point(16, 74);
            this.labelPermission2.Name = "labelPermission2";
            this.labelPermission2.Size = new System.Drawing.Size(57, 13);
            this.labelPermission2.TabIndex = 5;
            this.labelPermission2.Text = "Permission";
            // 
            // labelPassword2
            // 
            this.labelPassword2.AutoSize = true;
            this.labelPassword2.Location = new System.Drawing.Point(20, 48);
            this.labelPassword2.Name = "labelPassword2";
            this.labelPassword2.Size = new System.Drawing.Size(53, 13);
            this.labelPassword2.TabIndex = 4;
            this.labelPassword2.Text = "Password";
            // 
            // labelUsername2
            // 
            this.labelUsername2.AutoSize = true;
            this.labelUsername2.Location = new System.Drawing.Point(18, 22);
            this.labelUsername2.Name = "labelUsername2";
            this.labelUsername2.Size = new System.Drawing.Size(55, 13);
            this.labelUsername2.TabIndex = 3;
            this.labelUsername2.Text = "Username";
            // 
            // textBoxPermission2
            // 
            this.textBoxPermission2.Location = new System.Drawing.Point(79, 71);
            this.textBoxPermission2.Name = "textBoxPermission2";
            this.textBoxPermission2.Size = new System.Drawing.Size(100, 20);
            this.textBoxPermission2.TabIndex = 2;
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.Location = new System.Drawing.Point(79, 45);
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword2.TabIndex = 1;
            // 
            // textBoxUsername2
            // 
            this.textBoxUsername2.Location = new System.Drawing.Point(79, 19);
            this.textBoxUsername2.Name = "textBoxUsername2";
            this.textBoxUsername2.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsername2.TabIndex = 0;
            // 
            // menuStrip_adminControls
            // 
            this.menuStrip_adminControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip_adminControls.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_adminControls.Name = "menuStrip_adminControls";
            this.menuStrip_adminControls.Size = new System.Drawing.Size(580, 24);
            this.menuStrip_adminControls.TabIndex = 41;
            this.menuStrip_adminControls.Text = "menuStrip1";
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
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
            // FormAdminCommands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 394);
            this.Controls.Add(this.menuStrip_adminControls);
            this.Controls.Add(this.groupBoxAddUser);
            this.Controls.Add(this.groupBoxModifyUser);
            this.Controls.Add(this.buttonRefreshValues);
            this.Controls.Add(this.listViewLogin);
            this.Name = "FormAdminCommands";
            this.Text = "Admin Commands";
            this.groupBoxModifyUser.ResumeLayout(false);
            this.groupBoxModifyUser.PerformLayout();
            this.groupBoxAddUser.ResumeLayout(false);
            this.groupBoxAddUser.PerformLayout();
            this.menuStrip_adminControls.ResumeLayout(false);
            this.menuStrip_adminControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewLogin;
        private System.Windows.Forms.ColumnHeader columnUsername;
        private System.Windows.Forms.ColumnHeader columnPassword;
        private System.Windows.Forms.ColumnHeader columnPermission;
        private System.Windows.Forms.Button buttonRefreshValues;
        private System.Windows.Forms.Label labelUsername1;
        private System.Windows.Forms.Label labelPassword1;
        private System.Windows.Forms.Label labelPermission1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.GroupBox groupBoxModifyUser;
        private System.Windows.Forms.TextBox textBoxPermission1;
        private System.Windows.Forms.TextBox textBoxPassword1;
        private System.Windows.Forms.TextBox textBoxUsername1;
        private System.Windows.Forms.GroupBox groupBoxAddUser;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelPermission2;
        private System.Windows.Forms.Label labelPassword2;
        private System.Windows.Forms.Label labelUsername2;
        private System.Windows.Forms.TextBox textBoxPermission2;
        private System.Windows.Forms.TextBox textBoxPassword2;
        private System.Windows.Forms.TextBox textBoxUsername2;
        private System.Windows.Forms.Button buttonSelectUser;
        private System.Windows.Forms.MenuStrip menuStrip_adminControls;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;

    }
}

