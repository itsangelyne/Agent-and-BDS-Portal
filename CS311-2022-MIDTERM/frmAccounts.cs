using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS311_2022_MIDTERM
{
    public partial class frmAccounts : Form
    {
        private string username;
        public static frmAccounts dgvRefresh;
        public frmAccounts(string username)
        {
            InitializeComponent();
            this.username = username;
            dgvRefresh = this;

        }

        Class1 accounts = new Class1("LAPTOP-751I04E4\\SQLEXPRESS", "CS311-2022", "trix", "12345");

        private void frmAccounts_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.RowHeadersVisible = false;
                DataTable dt = accounts.GetData("SELECT userName,  passWord, userType, status, createdBy FROM tblAcccounts WHERE username <> '" + username + "' ORDER BY username DESC ");
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[1].Visible = false;


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on accounts load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = accounts.GetData("SELECT userName, passWord, userType, status, createdBy FROM tblAcccounts WHERE username <> '" + username +
                    "' AND (username LIKE '%" + txtsearch.Text + "%' OR userType LIKE '%" + txtsearch.Text + "%') ORDER BY userName ");
                dataGridView1.DataSource = dt;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on search", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewAccount newAccount = new frmNewAccount(username);
            newAccount.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string editUsername, editPassword, editUserType, editStatus;
            editUsername = dataGridView1.Rows[rowSelected].Cells[0].Value.ToString();
            editPassword = dataGridView1.Rows[rowSelected].Cells[1].Value.ToString();
            editUserType = dataGridView1.Rows[rowSelected].Cells[2].Value.ToString();
            editStatus = dataGridView1.Rows[rowSelected].Cells[3].Value.ToString();
            frmUpdateAccount updateAccount = new frmUpdateAccount(editUsername, editPassword, editUserType, editStatus, username);
            updateAccount.Show();

        }

        private int rowSelected;

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            rowSelected = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Columns[1].Visible = false;


        }
       

            public void btnRefresh_Click(object sender, EventArgs e)
        {
            frmAccounts_Load(sender, e);
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("Are you sure you want to delete this data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    accounts.executeSQL("DELETE FROM tblAcccounts WHERE userName = '" + dataGridView1.Rows[rowSelected].Cells[0].Value.ToString() + "'");
                    if (accounts.rowAffected > 0)
                    {
                        MessageBox.Show("Account deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        accounts.executeSQL("INSERT INTO tblAcctDeletelogs VALUES('" + DateTime.Now.ToString("dd-MM-yyyy") + "', '" + DateTime.Now.ToLongTimeString() +
                            "', 'Accounts Management' , '" + dataGridView1.Rows[rowSelected].Cells[0].Value.ToString() + "','" + username + "')");
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
