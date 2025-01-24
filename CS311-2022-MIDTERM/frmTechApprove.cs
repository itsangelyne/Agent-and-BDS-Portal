using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CS311_2022_MIDTERM
{
    public partial class frmTechApprove : Form
    {
        private string TicketNumber, problem, Date, details, status, CompletedBy, ApprovedBy, dateCompleted;
        public static frmTechApprove dgvRefresh;
        public frmTechApprove(string TicketNumber, string problem, string Date, string details, string status, string CompletedBy, string ApprovedBy, string dateCompleted)
        {
            InitializeComponent();
            this.TicketNumber = TicketNumber;
            this.problem = problem;
            this.Date = Date;
            this.details = details;
            this.status = status;
            this.CompletedBy = CompletedBy;
            this.ApprovedBy = ApprovedBy;
            this.dateCompleted = dateCompleted;
            dgvRefresh = this;
        }
        Class1 TechApprove = new Class1("LAPTOP-751I04E4\\SQLEXPRESS", "CS311-2022", "trix", "12345");
       
        private void validateCOMPLETE()
        {
            if (txtCompletedBy.Text == "")
            {
                errorProvider1.SetError(txtCompletedBy, "CompletedBy is required");
            }

            else
            {
                errorProvider1.SetError(txtCompletedBy, "");
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

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            validateCOMPLETE();
            countErrors();
            if (errorCount == 0)

            {

                try
                {
                    TechApprove.executeSQL("Assign tblTicket SET  Problem = '" + cmbProblem.Text.ToUpper() + "', Details = '" + txtDetails.Text + "',createdBy = '" + txtCompletedBy.Text + "', DateApproved = '" + DateTime.Now.ToString("dd-MM-yyyy") + "', " +
                        "CompletedBy, 'TECHNICAL', ApprovedBy, 'ADMINISTRATOR', Status= 'APPROVED',  WHERE TicketNumber = '" + txtTicketNumber.Text + "'");

                    if (TechApprove.rowAffected > 0)
                    {
                        MessageBox.Show("Approved Ticket!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        frmTicket.dgvRefresh.btnRefresh_Click(sender, e);
                    }
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error on Approve Ticket", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();

                }

            }
        }

        private void frmTechApprove_Load(object sender, EventArgs e)
        {
            txtTicketNumber.Text = TicketNumber;


            if (problem == "HARDWARE")
            {
                cmbProblem.SelectedIndex = 0;
            }
            else if (problem == "SOFTWARE")
            {
                cmbProblem.SelectedIndex = 1;
            }
            else if (problem == "CONNECTION")
            {
                cmbProblem.SelectedIndex = 2;
            }
            else
            {
                cmbProblem.SelectedIndex = 1;
            }
            txtDetails.Text = details;
            txtDateComplete.Text = Date;
            txtCompletedBy.Text = CompletedBy;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.txtDateComplete.Text = datetime.ToString("yyyy-MM-dd  hh:mm:ss");
        }
    } 
}
