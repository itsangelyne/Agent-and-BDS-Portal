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
    public partial class frmUpdateAccount : Form
    {
        private string username, password, usertype, status, editBy;
        public static frmUpdateAccount dgvRefresh;
        public frmUpdateAccount(string username, string password, string usertype, string status, string editBy)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.usertype = usertype;
            this.status = status;
            this.editBy = editBy;
            dgvRefresh = this;
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
                errorProvider1.SetError(cmbUserType, "Select user type");
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
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword_TextChanged(sender, e);
        }

      

        private void frmUpdateAccount_Load(object sender, EventArgs e)
        {
            txtUsername.Text = username;
            txtPassword.Text = password;
            if (usertype == "ADMINISTRATOR")
            {
                cmbUserType.SelectedIndex = 0;
            }
            else if (usertype == "TECHNICAL")
            {
                cmbUserType.SelectedIndex = 1;
            }
            else
            {
                cmbUserType.SelectedIndex = 2;
            }
            if (status == "ACTIVE")
            {
                rbActive.Checked = true;
            }
            else
            {
                rbInactive.Checked = true;
            }
        }
        Class1 UpdateAccount = new Class1("LAPTOP-751I04E4\\SQLEXPRESS", "CS311-2022", "trix", "12345");
        private void btnSave_Click(object sender, EventArgs e)
        {
            validatePassword();
            validateUserType();
            countErrors();
            if (errorCount == 0)
            {
                string newStatus;
                if (rbActive.Checked)
                {
                    newStatus = rbActive.Text.ToUpper();
                }
                else
                {
                    newStatus = rbInactive.Text.ToUpper();
                }
                try
                {
                    UpdateAccount.executeSQL("UPDATE tblAcccounts SET password = '" + txtPassword.Text + "' , userType = '" + cmbUserType.Text.ToUpper() +
                        "', status = '" + newStatus + "', lastUpdateBy = '" + editBy + "', dateUpdated = '" + DateTime.Now.ToString("dd-MM-yyyy") +
                        "' WHERE username = '" + txtUsername.Text + "'");
                    if (UpdateAccount.rowAffected > 0)
                    {
                        MessageBox.Show("Account Updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        frmAccounts.dgvRefresh.btnRefresh_Click(sender, e);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error on update button", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
    }


       
        

       
        






