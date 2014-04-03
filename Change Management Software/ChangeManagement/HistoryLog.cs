using System;
using System.Collections;
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
    public partial class HistoryLog : Form
    {
        private int sortColumn = -1;
        SqlCommand cmd;
        SqlConnection conn = new SqlConnection("Data Source=krnlslthDatabase.db.10139978.hostedresource.com; Initial Catalog=krnlslthDatabase; User ID=krnlslthDatabase; Password='WiEvShJe#10';");
        public int permission;
        public string user;
        public HistoryLog()
        {
            InitializeComponent();
        }

        private void HistoryLog_Load(object sender, EventArgs e)
        {
            conn.Open();
            if (permission <= 1)
            {
                label1.Visible = false;
                txtUserSearch.Visible = false;
                btnSearch.Visible = false;
                cmd = new SqlCommand("SELECT * FROM HISTORYLOG WHERE Username = '" + user + "' ORDER BY HL_ID ASC", conn);

                SqlDataReader dataReader = cmd.ExecuteReader();
                lstHistoryLog.Items.Clear();
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(dataReader["HL_ID"].ToString());
                    item.SubItems.Add(dataReader["Username"].ToString());
                    item.SubItems.Add(dataReader["What_Changed"].ToString());
                    item.SubItems.Add(dataReader["When_Changed"].ToString());
                    lstHistoryLog.Items.Add(item);
                }
            }
            else if (permission >= 2)
            {
                cmd = new SqlCommand("SELECT * FROM HISTORYLOG ORDER BY HL_ID ASC", conn);

                SqlDataReader dataReader = cmd.ExecuteReader();
                lstHistoryLog.Items.Clear();
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(dataReader["HL_ID"].ToString());
                    item.SubItems.Add(dataReader["Username"].ToString());
                    item.SubItems.Add(dataReader["What_Changed"].ToString());
                    item.SubItems.Add(dataReader["When_Changed"].ToString());
                    lstHistoryLog.Items.Add(item);
                }
            }
            conn.Close();
        }

        private void HistoryLog_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM HISTORYLOG WHERE Username = '" + txtUserSearch.Text + "' ORDER BY HL_ID ASC", conn);

            SqlDataReader dataReader = cmd.ExecuteReader();
            lstHistoryLog.Items.Clear();
            while (dataReader.Read())
            {
                ListViewItem item = new ListViewItem(dataReader["HL_ID"].ToString());
                item.SubItems.Add(dataReader["Username"].ToString());
                item.SubItems.Add(dataReader["What_Changed"].ToString());
                item.SubItems.Add(dataReader["When_Changed"].ToString());
                lstHistoryLog.Items.Add(item);
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (txtDate1.MaskCompleted && txtDate2.MaskCompleted)
            {
                cmd = new SqlCommand("SELECT * FROM HISTORYLOG WHERE (When_Changed > '" + txtDate1.Text + "' AND When_Changed < '" + txtDate2.Text + "') ORDER BY HL_ID ASC", conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                lstHistoryLog.Items.Clear();
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(dataReader["HL_ID"].ToString());
                    item.SubItems.Add(dataReader["Username"].ToString());
                    item.SubItems.Add(dataReader["What_Changed"].ToString());
                    item.SubItems.Add(dataReader["When_Changed"].ToString());
                    lstHistoryLog.Items.Add(item);
                }
            }
            else
                MessageBox.Show("Please enter two valid dates!");
            conn.Close();
        }

        private void txtDate1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Please enter two valid dates.");
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
                + "\nThe first box is for typing in the username of the person whose change you wish to search for."
                + "\nThe search usernames button will search through the database to find your change, and display them below."
                + "\nThe boxes below this are for typing two dates you wish to search between to find the change you are looking for."
                + "\nThe search dates button will search through the database to find the changes between the dates you entered."
                + "\n\nNote:"
                + "\nThe date must be in mm/dd/yyyy format."
                + "\n"
                + "\nClicking the menu button lets you exit the program."
                + "\nClicking the help button leads you to this page."
                + "\n\nNote:"
                + "\nWhile an admin and developers can see any changes, a client can only see the changes they added.";

            MessageBox.Show(help);
        }

        private void lstHistoryLog_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine whether the column is the same as the last column clicked.
            if (e.Column != sortColumn)
            {
                // Set the sort column to the new column.
                sortColumn = e.Column;
                // Set the sort order to ascending by default.
                lstHistoryLog.Sorting = System.Windows.Forms.SortOrder.Ascending;
            }
            else
            {
                // Determine what the last sort order was and change it.
                if (lstHistoryLog.Sorting == System.Windows.Forms.SortOrder.Ascending)
                    lstHistoryLog.Sorting = System.Windows.Forms.SortOrder.Descending;
                else
                    lstHistoryLog.Sorting = System.Windows.Forms.SortOrder.Ascending;
            }

            // Call the sort method to manually sort.
            lstHistoryLog.Sort();
            // Set the ListViewItemSorter property to a new ListViewItemComparer
            // object.
            this.lstHistoryLog.ListViewItemSorter = new ListViewItemComparer(e.Column, lstHistoryLog.Sorting);
        }

        class ListViewItemComparer : IComparer
        {
            private int col;
            private System.Windows.Forms.SortOrder order;
            public ListViewItemComparer()
            {
                col = 0;
                order = System.Windows.Forms.SortOrder.Ascending;
            }
            public ListViewItemComparer(int column, System.Windows.Forms.SortOrder order)
            {
                col = column;
                this.order = order;
            }
            public int Compare(object x, object y)
            {
                int returnVal;
                // Determine whether the type being compared is a date type.
                try
                {
                    // Parse the two objects passed as a parameter as a DateTime.
                    System.DateTime firstDate = DateTime.Parse(((ListViewItem)x).SubItems[col].Text);
                    System.DateTime secondDate = DateTime.Parse(((ListViewItem)y).SubItems[col].Text);
                    // Compare the two dates.
                    returnVal = DateTime.Compare(firstDate, secondDate);
                }
                // If neither compared object has a valid date format, compare
                // as a string.
                catch
                {
                    // Compare the two items as a string.
                    returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
                }
                // Determine whether the sort order is descending.
                if (order == System.Windows.Forms.SortOrder.Descending)
                    // Invert the value returned by String.Compare.
                    returnVal *= -1;
                return returnVal;
            }
        }
    }
}
