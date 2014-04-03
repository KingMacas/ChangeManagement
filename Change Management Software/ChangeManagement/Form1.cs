using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationSftwrEngineering
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=krnlslthDatabase.db.10139978.hostedresource.com; Initial Catalog=krnlslthDatabase; User ID=krnlslthDatabase; Password='WiEvShJe#10';");
        SqlCommand cmd;
        public string user;
        private Login loginFormInfo;
        bool exit = true;
        int permission;
        // Help strings
        private string help0 = "";
        private string help1 = "";
        private string help2 = "";
        private string help3 = "";
        private string help4 = "";
        private string help5 = "";
        private string help6 = "";
        private string help7 = "";
        private string help8 = "";
        private string help9 = "";
        private string help10 = "";
        private string help11 = "";
        private string help12 = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddChange_Click(object sender, EventArgs e)
        {
            AddChange AForm = new AddChange();
            AForm.user = user;
            AForm.Show();
        }
        private void btnModifyChange_Click(object sender, EventArgs e)
        {
            Modify modifyChange = new Modify();
            modifyChange.user = user;
            modifyChange.Show();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            HistoryLog HistLog = new HistoryLog();
            HistLog.user = user;
            HistLog.permission = permission;
            HistLog.Show();
        }

        private void Statistics_Button_Click(object sender, EventArgs e)
        {
            StatisticForm StatForm = new StatisticForm();
            StatForm.user = user;
            StatForm.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (exit)
                Application.Exit();
        }

        private void Exit_ToolStripOption_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT Permissions FROM LOGINSYSTEM WHERE Username = '" + user + "'", conn);
            SqlDataReader dataReader = cmd.ExecuteReader();
            dataReader.Read();
            // Modify Change Button
            permission = (int)dataReader["Permissions"];
            if (permission >= 1)
                btnModifyChange.Visible = true;
            else
                btnModifyChange.Visible = false;
            // Admin Panel Button
            if (permission >= 2)
                AdminPanel_GroupBox.Visible = true;
            else
                AdminPanel_GroupBox.Visible = false;
            conn.Close();
        }

        private void Logout_ToolStripOption_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
            exit = false;
            this.Close();
            exit = true;
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            SearchWindow SearchForm = new SearchWindow();
            SearchForm.Show();
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            FormAdminCommands adminPanel = new FormAdminCommands();
            adminPanel.Show();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string help = ""
                + "\nClick the add change button to open a window which will allow you to add a change to the database."
                + "\nClick the modify change button to fix or update a change that has already been made."
                + "\n\nNote:"
                + "\nThis button is only available to team leaders and admins."
                + "\n\nclick the search change button to find a specific change that you are looking for."
                + "\nclick the history log button to look up the last changes that were made."
                + "\nclick the Statistics button to view useful information on the changes in the database."
                + "\nclick the admin panel button to add or fix users."
                + "\n\nNote:"
                + "\nThis button is only available to admins."
                + "\n"
                + "\nClicking the menu button lets you log out or exit the program."
                + "\nClicking the help button leads you to this page.";

            MessageBox.Show(help);
        }
    }
}
