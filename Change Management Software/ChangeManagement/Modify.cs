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
using System.Globalization;

namespace ApplicationSftwrEngineering
{
    public partial class Modify : Form
    {
        private int sortColumn = -1;
        SqlConnection conn = new SqlConnection("Data Source=krnlslthDatabase.db.10139978.hostedresource.com; Initial Catalog=krnlslthDatabase; User ID=krnlslthDatabase; Password='WiEvShJe#10';");
        SqlCommand cmd;
        public string user;
        bool[] changes = new bool[10];
        string commentation;
        private bool ignoreTextChanged;
        string query = "UPDATE CHANGE SET ";
        string sqlquery;
        public string changeValue = "";
        int totChanges;

        public Modify()
        {
            InitializeComponent();
        }

        private void modify1_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT * from CHANGE ORDER BY Change_ID ASC", conn);

            conn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            lstChangeList.Items.Clear();
            while (dataReader.Read())
            {
                ListViewItem item = new ListViewItem(dataReader["Change_ID"].ToString());
                item.SubItems.Add(dataReader["Username"].ToString());
                item.SubItems.Add(dataReader["Change_Priority"].ToString());
                item.SubItems.Add(dataReader["Disposition"].ToString());
                item.SubItems.Add(dataReader["Impact"].ToString());
                item.SubItems.Add(dataReader["Change_Description"].ToString());
                item.SubItems.Add(dataReader["Comments"].ToString());
                item.SubItems.Add(dataReader["Teams_Impacted"].ToString());
                item.SubItems.Add(dataReader["Actual_Completion_Date"].ToString());
                item.SubItems.Add(dataReader["Estimated_Effort"].ToString());
                item.SubItems.Add(dataReader["Estimated_Completion_Date"].ToString());
                lstChangeList.Items.Add(item);
            }
            conn.Close();
        }

        private void btnModifyChange_Click(object sender, EventArgs e)
        {
            ignoreTextChanged = true;
            conn.Open();
            changeValue = lstChangeList.SelectedItems[0].Text;
            cmd = new SqlCommand("SELECT * from CHANGE WHERE Change_ID =" + changeValue + "", conn);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                txtChangeID.Text = dataReader["Change_Id"].ToString();
                txtUsername.Text = dataReader["username"].ToString();
                boxPriority.Text = dataReader["Change_Priority"].ToString();
                boxDisposition.Text = dataReader["Disposition"].ToString();
                txtImpact.Text = dataReader["Impact"].ToString();
                txtDescription.Text = dataReader["Change_Description"].ToString();
                txtImpacted.Text = dataReader["Teams_Impacted"].ToString();
                txtCompletionDate.Text = dataReader["Actual_Completion_Date"].ToString();
                txtEffort.Text = dataReader["Estimated_Effort"].ToString();
                txtEstCompDate.Text = dataReader["Estimated_Completion_Date"].ToString();
                txtComments.Text = dataReader["Comments"].ToString();
            }
            dataReader.Close();
            ignoreTextChanged = false;
            conn.Close();
        }
        private void lstChangeList_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {
            // Determine whether the column is the same as the last column clicked.
            if (e.Column != sortColumn)
            {
                // Set the sort column to the new column.
                sortColumn = e.Column;
                // Set the sort order to ascending by default.
                lstChangeList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            }
            else
            {
                // Determine what the last sort order was and change it.
                if (lstChangeList.Sorting == System.Windows.Forms.SortOrder.Ascending)
                    lstChangeList.Sorting = System.Windows.Forms.SortOrder.Descending;
                else
                    lstChangeList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            }

            // Call the sort method to manually sort.
            lstChangeList.Sort();
            // Set the ListViewItemSorter property to a new ListViewItemComparer
            // object.
            this.lstChangeList.ListViewItemSorter = new ListViewItemComparer(e.Column, lstChangeList.Sorting);
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

        private void button_modifyRefresh_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT * FROM CHANGE ORDER BY Change_ID ASC", conn);

            conn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            lstChangeList.Items.Clear();
            while (dataReader.Read())
            {
                ListViewItem item = new ListViewItem(dataReader["Change_ID"].ToString());
                item.SubItems.Add(dataReader["Username"].ToString());
                item.SubItems.Add(dataReader["Change_Priority"].ToString());
                item.SubItems.Add(dataReader["Disposition"].ToString());
                item.SubItems.Add(dataReader["Impact"].ToString());
                item.SubItems.Add(dataReader["Change_Description"].ToString());
                item.SubItems.Add(dataReader["Comments"].ToString());
                item.SubItems.Add(dataReader["Teams_Impacted"].ToString());
                item.SubItems.Add(dataReader["Actual_Completion_Date"].ToString());
                item.SubItems.Add(dataReader["Estimated_Effort"].ToString());
                item.SubItems.Add(dataReader["Estimated_Completion_Date"].ToString());
                lstChangeList.Items.Add(item);
            }
            conn.Close();
        }

        private void boxPriority_TextUpdate(object sender, EventArgs e)
        {
            if (!ignoreTextChanged) changes[0] = true;
        }

        private void boxDisposition_TextUpdate(object sender, EventArgs e)
        {
            if (!ignoreTextChanged) changes[1] = true;
        }

        private void txtImpact_TextChanged(object sender, EventArgs e)
        {
            if (!ignoreTextChanged) changes[2] = true;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (!ignoreTextChanged) changes[3] = true;
        }

        private void txtImpacted_TextChanged(object sender, EventArgs e)
        {
            if (!ignoreTextChanged) changes[5] = true;
        }

        private void txtCompletionDate_TextChanged(object sender, EventArgs e)
        {
            if (!ignoreTextChanged) changes[6] = true;
        }

        private void txtEffort_TextChanged(object sender, EventArgs e)
        {
            if (!ignoreTextChanged) changes[7] = true;
        }

        private void txtEstCompDate_TextChanged(object sender, EventArgs e)
        {
            if (!ignoreTextChanged) changes[8] = true;
        }

        private void txtComments_TextChanged(object sender, EventArgs e)
        {
            if (!ignoreTextChanged) changes[4] = true;
        }

        private void determineChanges(bool[] changes, ref string commentation, ref int totChanges)
        {
            totChanges = 0;
            if (changes[0] == true)
            {
                commentation = commentation + "Priority ";
                query = query + "Change_Priority = '" + boxPriority.Text + "',";
                totChanges++;
            }
            if (changes[1] == true)
            {
                if (boxDisposition.Text == "Completed")
                {
                    cmd = new SqlCommand("UPDATE CHANGE SET Actual_Completion_Date = '" + DateTime.Now + "' WHERE Change_ID = " + txtChangeID.Text + "", conn);
                    cmd.ExecuteNonQuery();
                }
                commentation = commentation + "Disposition ";
                query = query + "Disposition = '" + boxDisposition.Text + "',";
                totChanges++;
            }
            if (changes[2] == true)
            {
                commentation = commentation + "Impact ";
                query = query + "Impact = '" + txtImpact.Text + "',";
                totChanges++;
            }
            if (changes[3] == true)
            {
                commentation = commentation + "Description ";
                query = query + "Change_Description = '" + txtDescription.Text + "',";
                totChanges++;
            }
            if (changes[4] == true)
            {
                commentation = commentation + "Comments ";
                query = query + "Comments = '" + txtComments.Text + "',";
                totChanges++;
            }
            if (changes[5] == true)
            {
                commentation = commentation + "Impacted Teams ";
                query = query + "Teams_Impacted = '" + txtImpacted.Text + "',";
                totChanges++;
            }
            if (changes[6] == true)
            {
                commentation = commentation + "Actual Completion Date ";
                query = query + "Actual_Completion_Date = '" + txtCompletionDate.Text + "',";
                totChanges++;
            }
            if (changes[7] == true)
            {
                commentation = commentation + "Estimated Effort ";
                query = query + "Estimated_Effort = '" + txtEffort.Text + "',";
                totChanges++;
            }
            if (changes[8] == true)
            {
                commentation = commentation + "Estimated Completion Date ";
                query = query + "Estimated_Completion_Date = '" + txtEstCompDate.Text + "',";
                totChanges++;
            }
        }

        private void initializeArray(ref bool[] changes)
        {
            for (int i = 0; i < 9; i++)
            {
                changes[i] = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            determineChanges(changes, ref commentation, ref totChanges);
            if (lstChangeList.SelectedItems.Count == 1)
            {

                if (txtChangeID.TextLength > 0)
                {
                    if (totChanges > 0)
                    {
                        conn.Open();
                        int ID;
                        sqlquery = query;
                        sqlquery = sqlquery + " Modified_By = '" + user + "' WHERE CHANGE.Change_ID = " + txtChangeID.Text + "";
                        // "UPDATE CHANGE SET "
                        cmd = new SqlCommand("" + sqlquery + "", conn);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand("SELECT COUNT(HL_ID) FROM HISTORYLOG", conn);
                        ID = (int)cmd.ExecuteScalar() + 1;
                        DateTime toDate = DateTime.Now;
                        cmd = new SqlCommand("INSERT INTO HISTORYLOG(HL_ID, Username, What_Changed, When_Changed) values ('" + ID + "','" + user + "','" + commentation + " has been updated for change with ID: " + txtChangeID.Text + "','" + toDate + "')", conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Change has been modified.");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Please modify Something or select another change.");
                }
                else
                    MessageBox.Show("You must select a change!");
            }
            else
                MessageBox.Show("Please pick only one item.");
        }

        private void modify1_FormClosed(object sender, FormClosedEventArgs e)
        {

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

        private void txtEstCompDate_TextChanged_1(object sender, EventArgs e)
        {
            if (!ignoreTextChanged) changes[8] = true;
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string help = ""
                + "\nThe change window displays all the changes, allowing you to select the one you want."
                + "\nThe refresh button will update the window if a change was made."
                + "\nThe change ID is not changable; the id will appear here when you select a change."
                + "\nThe username is also not changable; the name will appear here when you select a change."
                + "\nThe priority box will open when you click the down arrow, allowing you to change how important your change is."
                + "\nThe disposition box will open when you click the down arrow, allowing you to change the status of the change."
                + "\nThe impact is a short description that lets you write what will explain what would happen if it is not changed."
                + "\nThe description lets your write a description of the change that needs to be made."
                + "\nThe teams impacted box lets you write which teams will be impacted by this change."
                + "\nthe actual completion date is not changable; the date will appear if there is one."
                + "\nthe estimated effort lets you write how easy or hard it will be, or give a number of hours you think it will take."
                + "\nThe comments lets you make additional comments on the change you want to make."
                + "\nThe estimated completion date lets you put in a date that you think the change should be done by."
                + "\n\nNote:"
                + "\nThe date must be in mm/dd/yyyy format."
                + "\n\nClicking the modify selection button will modify the change you selected with what you entered in the boxes."
                + "\nClicking the menu button lets you exit the program."
                + "\nClicking the help button leads you to this page.";
            MessageBox.Show(help);
        }
    }
}
