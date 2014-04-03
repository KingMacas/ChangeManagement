using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ApplicationSftwrEngineering
{
    public partial class FormAdminCommands : Form
    {
        SqlConnection sqlConn = new SqlConnection("Data Source=krnlslthDatabase.db.10139978.hostedresource.com; Initial Catalog=krnlslthDatabase; User ID=krnlslthDatabase; Password='WiEvShJe#10';");
        SqlCommand sqlCmd;
        SqlCommand sqlCmd1;

        public FormAdminCommands()
        {
            InitializeComponent();
        }

        private void buttonRefreshValues_Click(object sender, EventArgs e)
        {
            SqlCommand sqlComm = new SqlCommand("SELECT * from LOGINSYSTEM", sqlConn);
            try
            {
                sqlConn.Open();
                SqlDataReader dataReader = sqlComm.ExecuteReader();
                listViewLogin.Items.Clear();
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(dataReader["Username"].ToString());
                    item.SubItems.Add(dataReader["Password"].ToString());
                    item.SubItems.Add(dataReader["Permissions"].ToString());
                    listViewLogin.Items.Add(item);
                }
                dataReader.Close();
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
            if (listViewLogin.SelectedItems.Count == 1)
            {
                if (textBoxPassword1.TextLength > 0 && textBoxPermission1.TextLength > 0)
                {
                    int numPermission = Int32.Parse(textBoxPermission1.Text);
                    if (textBoxPermission1.Text == "-1" || textBoxPermission1.Text == "0" || textBoxPermission1.Text == "1" || textBoxPermission1.Text == "2")
                    {
                        sqlCmd = new SqlCommand("UPDATE LOGINSYSTEM SET Password = '" + textBoxPassword1.Text +
                            "', Permissions = '" + textBoxPermission1.Text +
                            "' WHERE Username = '" + textBoxUsername1.Text + "'", sqlConn);
                        sqlCmd.ExecuteNonQuery();
                        sqlConn.Close();
                        MessageBox.Show("The change has been updated.");
                    }
                    else
                    {
                        MessageBox.Show("Permission must be between -1 and 2 inclusive!");
                    }
                }
            }
            else
            {
                MessageBox.Show("You must select a user!");
            }
            sqlConn.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
            bool userFound = false;
            sqlCmd = new SqlCommand("INSERT INTO LOGINSYSTEM(Username, Password, Permissions) VALUES('" + textBoxUsername2.Text + "','" + textBoxPassword2.Text + "','" + textBoxPermission2.Text + "')", sqlConn);
            sqlCmd1 = new SqlCommand("SELECT Username FROM LOGINSYSTEM", sqlConn);
            SqlDataReader dataReader1 = sqlCmd1.ExecuteReader();
            while (dataReader1.Read())
            {
                if (textBoxUsername2.Text == dataReader1["Username"].ToString())
                {
                    userFound = true;
                    break;
                }
            }
            if (textBoxUsername2.TextLength > 0 && textBoxPassword2.TextLength > 0 && textBoxPermission2.TextLength > 0)
            {
                int numPermission = Int32.Parse(textBoxPermission2.Text);
                if (userFound == true)
                {
                    MessageBox.Show("Username already exists!");
                }
                else if (textBoxPermission2.Text == "-1" || textBoxPermission2.Text == "0" || textBoxPermission2.Text == "1" || textBoxPermission2.Text == "2")
                {
                    MessageBox.Show("Permission must be between -1 and 2 inclusive!");
                }
                else
                {
                    dataReader1.Close();
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("User added to database.");
                }
            }
            else
                MessageBox.Show("Leave no empty fields!");
            sqlConn.Close();
        }

        private void buttonSelectUser_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
            if (listViewLogin.SelectedItems.Count == 1)
            {
                ListViewItem item = listViewLogin.SelectedItems[0];
                /* Username */
                textBoxUsername1.Text = item.SubItems[0].Text;
                /* Password */
                textBoxPassword1.Text = item.SubItems[1].Text;
                /* Permission */
                textBoxPermission1.Text = item.SubItems[2].Text;
            }
            else
            {
                MessageBox.Show("You must select only one change!");
            }
            sqlConn.Close();
        }

        private void formAdminCommands_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void closeForm()
        {
            foreach (Form f in Application.OpenForms)
                f.Hide();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            closeForm();
            Login login = new Login();
            login.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string help = ""
                + "\nThe refresh values button will display all the users and their information in the box below, when clicked."
                + "\nTo add a user, follow these steps:"
                + "\n      *Type the username of the person you want to add into the username box under add user."
                + "\n      *Type the password of the person you want to add into the password box under add user."
                + "\n      *Type the permission level of the person you want to add into the permission box under add user."
                + "\n       -permission level -1 is a blocked user."
                + "\n       -permission level  0 is a client."
                + "\n       -permission level  1 is a developer."
                + "\n       -permission level  2 is an admin."
                + "\nTo modify a user, follow these steps:"
                + "\n      *First click the refresh values button."
                + "\n      *Click the user on the list that you want to modify."
                + "\n      *Click the selct user button under modify user."
                + "\n      *The username is not changable; it will display the selected user's name."
                + "\n      *the password box can be typed in to give them a new password, as long as it is not blank."
                + "\n      *the permission box can be typed in to give them a new permission level, as long as it a number between -1 and 2."
                + "\n      *Click the update button to send the updates to the database, it will give you a window saying if it has succeeded."
                + "\nClicking the menu button lets you exit the program."
                + "\nClicking the help button leads you to this page.";

            MessageBox.Show(help);
        }
    }
}