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
    public partial class AddChange : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=krnlslthDatabase.db.10139978.hostedresource.com; Initial Catalog=krnlslthDatabase; User ID=krnlslthDatabase; Password='WiEvShJe#10';");
        SqlCommand cmd;
        public string user;

        public AddChange()
        {
            InitializeComponent();
        }
        private void AddChange_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT COUNT(Change_ID) FROM CHANGE", conn);
            txtChangeID.Text = ((int)cmd.ExecuteScalar() + 1).ToString();
            txtComments.Text = "Change request submitted by " + user + " at " + System.DateTime.Now.ToString("MM/dd/yyyy");
            conn.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("INSERT INTO CHANGE(Change_ID, Username, Change_Priority, Disposition, Impact, Change_Description, Comments) VALUES(" + txtChangeID.Text + ",'" + user + "','" + boxPriority.Text + "','Submitted','" + txtImpact.Text + "','" + txtDescription.Text + "','" + txtComments.Text + "')", conn);
            cmd.ExecuteNonQuery();
            int ID;
            cmd = new SqlCommand("SELECT COUNT(HL_ID) FROM HISTORYLOG", conn);
            ID = (int)cmd.ExecuteScalar() + 1;
            DateTime toDate = DateTime.Now;
            cmd = new SqlCommand("INSERT INTO HISTORYLOG(HL_ID, Username, What_Changed, When_Changed) values ('" + ID + "','" + user + "','" + "Change with ID: " + txtChangeID.Text + " has been added to the database" + "','" + toDate + "')", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully added to the Database!");
            conn.Close();
            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            closeForm();
            Login login = new Login();
            login.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeForm()
        {
            foreach (Form f in Application.OpenForms)
                f.Hide();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string help = ""
                + "\nThe new change ID is not changable."
                + "\nThe priority box will open when you click the down arrow, allowing you to change how important your change is."
                + "\nThe description lets your write a description of the change that needs to be made."
                + "\nThe comments lets you make additional comments on the change you want to make."
                + "\nClicking the submit change button, adds your change to the database."
                + "\nClicking the menu button lets you exit the program."
                + "\nClicking the help button leads you to this page.";
            MessageBox.Show(help);
        }
    }
}
