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
    public partial class StatisticForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=krnlslthDatabase.db.10139978.hostedresource.com; Initial Catalog=krnlslthDatabase; User ID=krnlslthDatabase; Password='WiEvShJe#10';");
        SqlCommand cmd;
        int count;
        public string user;

        public StatisticForm()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT COUNT(Change_ID) FROM CHANGE", conn);
            count = (int)cmd.ExecuteScalar();
            if (count == 1)
                lblTotalChange.Text = "There are a total of " + count + " change in the database.";
            else
                lblTotalChange.Text = "There are a total of " + count + " changes in the database.";
            cmd = new SqlCommand("SELECT COUNT(Change_Priority) FROM CHANGE WHERE Change_Priority = 'Low'", conn);
            count = (int)cmd.ExecuteScalar(); textBox_low.Text = count.ToString();
            cmd = new SqlCommand("SELECT COUNT(Change_Priority) FROM CHANGE WHERE Change_Priority = 'Medium'", conn);
            count = (int)cmd.ExecuteScalar(); textBox_medium.Text = count.ToString();
            cmd = new SqlCommand("SELECT COUNT(Change_Priority) FROM CHANGE WHERE Change_Priority = 'High'", conn);
            count = (int)cmd.ExecuteScalar(); textBox_high.Text = count.ToString();
            cmd = new SqlCommand("SELECT COUNT(Change_Priority) FROM CHANGE WHERE Change_Priority = 'Critical'", conn);
            count = (int)cmd.ExecuteScalar(); textBox_critical.Text = count.ToString();
            cmd = new SqlCommand("SELECT COUNT(Disposition) FROM CHANGE WHERE Disposition = 'Submitted'", conn);
            count = (int)cmd.ExecuteScalar(); textBox_submitted.Text = count.ToString();
            cmd = new SqlCommand("SELECT COUNT(Disposition) FROM CHANGE WHERE Disposition = 'Completed'", conn);
            count = (int)cmd.ExecuteScalar(); textBox_completed.Text = count.ToString();
            cmd = new SqlCommand("SELECT COUNT(Disposition) FROM CHANGE WHERE Disposition = 'Action'", conn);
            count = (int)cmd.ExecuteScalar(); textBox_action.Text = count.ToString();
            cmd = new SqlCommand("SELECT COUNT(Disposition) FROM CHANGE WHERE Disposition = 'Defer'", conn);
            count = (int)cmd.ExecuteScalar(); textBox_defer.Text = count.ToString();
            cmd = new SqlCommand("SELECT COUNT(Disposition) FROM CHANGE WHERE Disposition = 'Reject'", conn);
            count = (int)cmd.ExecuteScalar(); textBox_reject.Text = count.ToString();
            conn.Close();
        }

        private void closeForm()
        {
            foreach (Form f in Application.OpenForms)
                f.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            closeForm();
            Login login = new Login();
            login.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string help = ""
                + "\nThe top line will tell you how many total changes there are in the database."
                + "\nThe left box displays how many of each priority there are in the database. by catagory."
                + "\nThe right box displays all the statuses of the changes in the database by catagory."
                + "\nClicking the menu button lets you exit the program."
                + "\nClicking the help button leads you to this page.";

            MessageBox.Show(help);
        }
    }
}
