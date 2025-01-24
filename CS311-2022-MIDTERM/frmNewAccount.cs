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

    public partial class frmNewAccount : Form
    {
        private string createdBy;
        public static frmNewAccount dgvRefresh;
        public frmNewAccount(string createdBy)
        {
            InitializeComponent();
            this.createdBy = createdBy;
            dgvRefresh = this;
           
        }
        Class1 NewAccounts = new Class1("LAPTOP-751I04E4\\SQLEXPRESS", "CS311-2022", "trix", "12345");

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }

        }
        private void chkShow_CheckedChanged(object sender, EventArgs e)
            
        {
            txtPassword_TextChanged(sender, e);
        }

        private void validateUsername()
        {
            DataTable dt = NewAccounts.GetData("SELECT * FROM tblAcccounts WHERE username = '" + txtUsername.Text + "'");
            if (txtUsername.Text == "")
            {
                errorProvider1.SetError(txtUsername, "Username is empty");
            }
            else if (txtUsername.TextLength < 4)
            {
                errorProvider1.SetError(txtUsername, "Username should be atleast 6 characters");
            }
            else if (dt.Rows.Count > 0)
            {
                errorProvider1.SetError(txtUsername, "Username already in use");
            }
            else
            {
                errorProvider1.SetError(txtUsername, "");
            }
        }
        private void validatePassword()
        {
            if (txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword, "Password is empty");
            }
            else if (txtPassword.TextLength < 6)
            {
                errorProvider1.SetError(txtPassword, "Password should be atleast 6 characters");
            }

            else
            {
                errorProvider1.SetError(txtPassword, "");
            }
        }
        private void validateUserType()
        {
            if (cmbUserType.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbUserType, "Select Usertype");
            }
            else
            {
                errorProvider1.SetError(cmbUserType, "");
            }
        }
        private int errorCount;

        public void countErrors()
        {
            errorCount = 0;
            foreach (Control c in errorProvider1.ContainerControl.Controls)
            {
                if (errorProvider1.GetError(c) != "")
                {
                    errorCount++;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            validateUsername();
            validatePassword();
            validateUserType();
            countErrors();
            if (errorCount == 0)
            {
                try
                {
                    DialogResult answer = MessageBox.Show("Are you sure you want to save this data?", " Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    NewAccounts.executeSQL("INSERT INTO tblAcccounts (userName, passWord, userType, Status, CreatedBy, dateCreated) VALUES('" + txtUsername.Text +
                        "', '" + txtPassword.Text + "', '" + cmbUserType.Text.ToUpper() + "', 'ACTIVE', '" + createdBy + "', '" + DateTime.Now.ToString
                        ("dd-MM-yy") + "')");
                    if (NewAccounts.rowAffected > 0)
                    {
                        MessageBox.Show("New Account Added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        frmAccounts.dgvRefresh.btnRefresh_Click(sender, e);
                    }
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error on Add new account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                   
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


    



