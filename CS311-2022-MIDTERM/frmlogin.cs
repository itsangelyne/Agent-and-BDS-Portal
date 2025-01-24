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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }
            Class1 login = new Class1("LAPTOP-751I04E4\\SQLEXPRESS", "CS311-2022", "trix", "12345");
            
            private void btnlogin_Click(object sender, EventArgs e)
            {
                try
                {
                    //create a datable containing your SQL SELECT command
                    DataTable dt = login.GetData("SELECT * FROM tblAcccounts WHERE username = '" + txtusername.Text + "' AND password = '" + txtpassword.Text +
                    "' AND status = 'ACTIVE'");
                    //login successful
                    if (dt.Rows.Count > 0)
                    {
                        frmMain main = new frmMain(txtusername.Text, dt.Rows[0].Field<string>("userType"));
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password or account is inactive", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error on login button", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        

            private void txtpassword_TextChanged_2(object sender, EventArgs e)
            {
                if (chkShow.Checked)
                {
                    txtpassword.PasswordChar = '\0';
                }
                else
                {
                    txtpassword.PasswordChar = '*';
                }
            }
            private void chkShow_CheckedChanged_1(object sender, EventArgs e)
            {
                txtpassword_TextChanged_2(sender, e);
           
        }    

            private void btnClear_Click_1(object sender, EventArgs e)
            {
                txtusername.Clear();
                txtpassword.Clear();
                txtusername.Focus();
            }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToChar(e.KeyChar) == 13)
            {
                btnlogin_Click(sender, e);
            }
        }
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        }
    }
 
    
    


