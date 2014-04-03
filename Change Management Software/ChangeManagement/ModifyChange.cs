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
    public partial class ModifyChange : Form
    {
        private bool ignoreTextChanged;
        SqlConnection conn = new SqlConnection("Data Source=krnlslthDatabase.db.10139978.hostedresource.com; Initial Catalog=krnlslthDatabase; User ID=krnlslthDatabase; Password='WiEvShJe#10';");
        SqlCommand cmd;
        bool[] changes = new bool[10];
        string commentation;
        public string user;
        string query = "UPDATE CHANGE SET ";
        string sqlquery;
        public string changeValue = "";
        // [Priority, Disposition, Impact, Description, Comments, Teams_Impacted, Actual_Completion_Date, Estimated_Efforts, Estimated_Completion_Date]
        public ModifyChange()
        {
            InitializeComponent();
        }

        private void ModifyChange_Load(object sender, EventArgs e)
        {
            modify1 ModifyForm = new modify1();
            user = ModifyForm.user;
            ignoreTextChanged = true;
            conn.Open();
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
                //txtCompletionDate.Text = dataReader["Actual_Completion_Date"].ToString();
                //txtEffort.Text = dataReader["Estimated_Effort"].ToString();
                //txtEstCompDate.Text = dataReader["Estimated_Completion_Date"].ToString();
                //txtComments.Text = dataReader["Comments"].ToString();
            }
            dataReader.Close();
            ignoreTextChanged = false;
        }

        private void btnModifyChange_Click(object sender, EventArgs e)
        {
            int ID;
            determineChanges(changes, ref commentation);
            sqlquery = query.Substring(0, query.Length - 1);;
            sqlquery = sqlquery + "WHERE CHANGE.Change_ID = '" + txtChangeID.Text + "'";
            cmd = new SqlCommand(""+ sqlquery + "", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("SELECT COUNT(HL_ID) FROM HISTORYLOG", conn);
            ID = (int)cmd.ExecuteScalar() + 1;
            DateTime toDate = DateTime.Now;
            cmd = new SqlCommand("INSERT INTO HISTORYLOG(HL_ID, Username, What_Changed, When_Changed) values ('" + ID + "','" + user + "','" + commentation + " has been updated for change with ID: " + txtChangeID.Text + "','" + toDate + "')", conn);
            cmd.ExecuteNonQuery();
            this.Close();
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

        private void txtComments_TextChanged(object sender, EventArgs e)
        {
            if (!ignoreTextChanged) changes[4] = true;
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

        private void determineChanges(bool[] changes, ref string commentation)
        {
            if (changes[0] == true)
            {
                commentation = commentation + "Priority ";
                query = query + "Change_Priority = '" + boxPriority.Text + "',";
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
            }
            if (changes[2] == true)
            {
                commentation = commentation + "Impact ";
                query = query + "Impact = '" + txtImpact.Text + "',";
            }
            if (changes[3] == true)
            {
                commentation = commentation + "Description ";
                query = query + "Change_Description = '" + txtDescription.Text + "',";
            }
            if (changes[4] == true)
            {
                commentation = commentation + "Comments ";
                //query = query + "Comments = '" + txtComments.Text + "',";
            }
            if (changes[5] == true)
            {
                commentation = commentation + "Impacted Teams ";
                query = query + "Teams_Impacted = '" + txtImpacted.Text + "',";
            }
            if (changes[6] == true)
            {
                commentation = commentation + "Actual Completion Date ";
                //query = query + "Actual_Completion_Date = '" + txtCompletionDate.Text + "',";
            }
            if (changes[7] == true)
            {
                commentation = commentation + "Estimated Effort ";
                //query = query + "Estimated_Effort = '" + txtEffort.Text + "',";
            }
            if (changes[8] == true)
            {
                commentation = commentation + "Estimated Completion Date ";
                //query = query + "Estimated_Completion_Date = '" + txtEstCompDate.Text + "',";
            }
        }
        private void initializeArray(ref bool[] changes)
        {
            for (int i = 0; i < 9; i++)
            {
                changes[i] = false;
            }
        }

        private void ModifyChange_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 MainForm = new Form1();
            MainForm.user = user;
            MainForm.Show();
        }
    }
}
