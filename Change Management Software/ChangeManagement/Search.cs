using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ApplicationSftwrEngineering
{
    public partial class SearchWindow : Form
    {
        private int sortColumn = -1;
        SqlConnection sqlConn = new SqlConnection("Data Source=krnlslthDatabase.db.10139978.hostedresource.com; Initial Catalog=krnlslthDatabase; User ID=krnlslthDatabase; Password='WiEvShJe#10';");
        SqlCommand sqlCmd;

        public SearchWindow()
        {
            InitializeComponent();
        }

        public bool isNumeric(string s)
        {
            try
            {
                double.Parse(s);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
            if (comboBox_fields.SelectedIndex >= 0)
            {
                if (comboBox_fields.SelectedItem == "Change_ID" )//|| comboBox_fields.SelectedItem == "Estimated_Completion_Date" || comboBox_fields.SelectedItem == "Actual_Date_Completion_Date")
                {
                    if (isNumeric(textBoxSearchKeyword.Text) == false)
                    {
                        MessageBox.Show("You can only input numbers if you are searching this field.");
                    }
                    else
                    {
                        if (checkBox_wildcard.Checked == true)
                            sqlCmd = new SqlCommand("SELECT * FROM CHANGE WHERE " + comboBox_fields.SelectedItem + " LIKE '%" + textBoxSearchKeyword.Text + "%'", sqlConn);
                        else
                            sqlCmd = new SqlCommand("SELECT * FROM CHANGE WHERE " + comboBox_fields.SelectedItem + " = '" + textBoxSearchKeyword.Text + "'", sqlConn);
                        SqlDataReader dataReader = sqlCmd.ExecuteReader();
                        listView_search.Items.Clear();
                        while (dataReader.Read())
                        {
                            ListViewItem item = new ListViewItem(dataReader["Change_ID"].ToString());
                            item.SubItems.Add(dataReader["Username"].ToString());
                            item.SubItems.Add(dataReader["Change_Priority"].ToString());
                            item.SubItems.Add(dataReader["Disposition"].ToString());
                            item.SubItems.Add(dataReader["Teams_Impacted"].ToString());
                            item.SubItems.Add(dataReader["Estimated_Completion_Date"].ToString());
                            item.SubItems.Add(dataReader["Actual_Completion_Date"].ToString());
                            item.SubItems.Add(dataReader["Estimated_Effort"].ToString());
                            item.SubItems.Add(dataReader["Modified_By"].ToString());
                            listView_search.Items.Add(item);
                        }
                    }
                }
                else if (comboBox_fields.SelectedItem == "Estimated_Completion_Date" || comboBox_fields.SelectedItem == "Actual_Completion_Date")
                {
                    if (checkBox_wildcard.Checked == true)
                        sqlCmd = new SqlCommand("SELECT * FROM CHANGE WHERE " + comboBox_fields.SelectedItem + " LIKE '%" + dateTimePicker1.Value.Date + "%'", sqlConn);
                    else
                        sqlCmd = new SqlCommand("SELECT * FROM CHANGE WHERE " + comboBox_fields.SelectedItem + " = '" + dateTimePicker1.Value.Date + "'", sqlConn);
                    SqlDataReader dataReader = sqlCmd.ExecuteReader();
                    listView_search.Items.Clear();
                    while (dataReader.Read())
                    {
                        ListViewItem item = new ListViewItem(dataReader["Change_ID"].ToString());
                        item.SubItems.Add(dataReader["Username"].ToString());
                        item.SubItems.Add(dataReader["Change_Priority"].ToString());
                        item.SubItems.Add(dataReader["Disposition"].ToString());
                        item.SubItems.Add(dataReader["Teams_Impacted"].ToString());
                        item.SubItems.Add(dataReader["Estimated_Completion_Date"].ToString());
                        item.SubItems.Add(dataReader["Actual_Completion_Date"].ToString());
                        item.SubItems.Add(dataReader["Estimated_Effort"].ToString());
                        item.SubItems.Add(dataReader["Modified_By"].ToString());
                        listView_search.Items.Add(item);
                    }
                }
                else
                {
                    if (checkBox_wildcard.Checked == true)
                        sqlCmd = new SqlCommand("SELECT * FROM CHANGE WHERE " + comboBox_fields.SelectedItem + " LIKE '%" + textBoxSearchKeyword.Text + "%'", sqlConn);
                    else
                        sqlCmd = new SqlCommand("SELECT * FROM CHANGE WHERE " + comboBox_fields.SelectedItem + " = '" + textBoxSearchKeyword.Text + "'", sqlConn);
                    SqlDataReader dataReader1 = sqlCmd.ExecuteReader();
                    listView_search.Items.Clear();
                    while (dataReader1.Read())
                    {
                        ListViewItem item = new ListViewItem(dataReader1["Change_ID"].ToString());
                        item.SubItems.Add(dataReader1["Username"].ToString());
                        item.SubItems.Add(dataReader1["Change_Priority"].ToString());
                        item.SubItems.Add(dataReader1["Disposition"].ToString());
                        item.SubItems.Add(dataReader1["Teams_Impacted"].ToString());
                        item.SubItems.Add(dataReader1["Estimated_Completion_Date"].ToString());
                        item.SubItems.Add(dataReader1["Actual_Completion_Date"].ToString());
                        item.SubItems.Add(dataReader1["Estimated_Effort"].ToString());
                        item.SubItems.Add(dataReader1["Modified_By"].ToString());
                        listView_search.Items.Add(item);
                    }
                }
            }
            sqlConn.Close();
        }

        private void textBoxSearchKeyword_Enter(object sender, EventArgs e)
        {
            textBoxSearchKeyword.Clear();
        }

        private void checkBox_wildcard_CheckedChanged(object sender, EventArgs e)
        {
            sqlCmd = new SqlCommand("SELECT * FROM CHANGE WHERE " + comboBox_fields.SelectedItem + " LIKE '$" + textBoxSearchKeyword.Text + "$'", sqlConn);
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string help = ""
                + "\nThe box that says 'Searching for...' allows you to type in what you wish to search for."
                + "\n\nNote:"
                + "\nEstimated completion date and actual completion date must be selected using the DateTimePicker (above the text input field)."
                + "\n\nThe specific field box will open when you click the down arrow, allowing you to select what database field you want."
                + "\nThe wildcard box will allow you to search for partial words, if you select it."
                + "\nThe search button will start a search."
                + "\nthe columned box will display the search results, if any."
                + "\nClicking the menu button lets you exit the program."
                + "\nClicking the help button leads you to this page.";
            MessageBox.Show(help);
        }

        private void listView_search_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine whether the column is the same as the last column clicked.
            if (e.Column != sortColumn)
            {
                // Set the sort column to the new column.
                sortColumn = e.Column;
                // Set the sort order to ascending by default.
                listView_search.Sorting = System.Windows.Forms.SortOrder.Ascending;
            }
            else
            {
                // Determine what the last sort order was and change it.
                if (listView_search.Sorting == System.Windows.Forms.SortOrder.Ascending)
                    listView_search.Sorting = System.Windows.Forms.SortOrder.Descending;
                else
                    listView_search.Sorting = System.Windows.Forms.SortOrder.Ascending;
            }

            // Call the sort method to manually sort.
            listView_search.Sort();
            // Set the ListViewItemSorter property to a new ListViewItemComparer
            // object.
            this.listView_search.ListViewItemSorter = new ListViewItemComparer(e.Column, listView_search.Sorting);
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

