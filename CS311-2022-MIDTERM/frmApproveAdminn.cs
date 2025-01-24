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
    public partial class frmApproveAdminn : Form
    {

        private string username, TicketNumber, Problem, Details, CompletedBy, dateCompleted;
        public static frmApproveAdminn dgvRefresh;

        public frmApproveAdminn(string TicketNumber, string Problem, string Details, string CompletedBy, string dateCompleted)
        {
            InitializeComponent();
            this.TicketNumber = TicketNumber;
            this.Problem = Problem;
            this.Details = Details;
            this.CompletedBy = CompletedBy;
            this.dateCompleted = dateCompleted;
            this.username = username;
            dgvRefresh = this;
        }
       
        private void frmApproveAdminn_Load(object sender, EventArgs e)
        {
            txtTicketNumber.Text = TicketNumber;
            cmbProblem.Text = Problem;
            txtDetails.Text = Details;
            txtCompletedBy.Text = CompletedBy;
            txtdateCompleted.Text = dateCompleted;
            timer1.Start();
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.txtdateCompleted.Text = datetime.ToString("yyyy-MM-dd");
        }

        Class1 ApproveAdminn = new Class1("LAPTOP-751I04E4\\SQLEXPRESS", "CS311-2022", "trix", "12345");
        private void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                ApproveAdminn.executeSQL("UPDATE tblTicket SET Status = 'APPROVED', CompletedBy = '" + username + "', dateCompleted = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', ApprovedBy = '" + username + "', dateApproved ='"
                        + DateTime.Now.ToString("yyyy-MM-dd") + "' WHERE TicketNumber = '" + txtTicketNumber.Text + "'");


                if (ApproveAdminn.rowAffected > 0)
                {
                    MessageBox.Show("Approve Ticket!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmApproveAdminn newFrm = (frmApproveAdminn)Application.OpenForms["frmApproveTech"];
                    frmAdminTicket.dgvRefresh.btnRefreshAdmin_Click(sender, e);
                    this.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on Approve Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtdateCompleted_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbProblem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
        private void txtCompletedBy_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTicketNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
