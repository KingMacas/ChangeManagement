using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ApplicationSftwrEngineering
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=krnlslthDatabase.db.10139978.hostedresource.com; Initial Catalog=krnlslthDatabase; User ID=krnlslthDatabase; Password='WiEvShJe#10';");
        SqlCommand cmd;
        SqlCommand cmd1;
        public string user;
        public bool secondTime = false;

        public Login()
        {
            InitializeComponent();
        }
       
        private void textBoxInputUsername_TextChanged(object sender, EventArgs e)
        {
            // Text Box - User enters username
        }

        private void labelUsername_Click(object sender, EventArgs e)
        {
            // Label - "Username"
        }

        private void labelPassword_Click(object sender, EventArgs e)
        {
            // Label - "Password"
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            conn.Open();
            bool found = false;
            user = textBoxInputUsername.Text;
            cmd = new SqlCommand("SELECT Password FROM LOGINSYSTEM WHERE Username = '" + user + "'", conn);
            cmd1 = new SqlCommand("SELECT Permissions FROM LOGINSYSTEM WHERE Username = '" + user + "'", conn);
            SqlDataReader dataReader1 = cmd1.ExecuteReader();
            try
            {
                dataReader1.Read();
                if (dataReader1["Permissions"].ToString() != "-1")
                {
                    dataReader1.Close();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    dataReader.Read();
                    if (textBoxInputPassword.Text == dataReader["Password"].ToString())
                    {
                        this.Hide();
                        foreach (Form f in Application.OpenForms)
                        {
                            if (f.Name == "Form1")
                            {
                                secondTime = true;
                                //f.Activate();
                                f.Show();
                                found = true;
                                break;
                            }
                        }
                        if (found == false)
                        {
                            Form1 MainMenu = new Form1();
                            MainMenu.user = textBoxInputUsername.Text;
                            MainMenu.Show();
                        }
                    }
                    else
                        MessageBox.Show("failed");
                }
                else
                    MessageBox.Show("Username does not exist");


                conn.Close();
            }
            catch
            {
                MessageBox.Show("Username does not exist");
                conn.Close();
            }
        }

        private void textBoxInputPassword_TextChanged(object sender, EventArgs e)
        {
            // Text Box - User enters password
        }

        private void Login_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
