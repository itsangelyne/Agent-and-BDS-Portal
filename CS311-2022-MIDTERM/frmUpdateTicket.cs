using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CS311_2022_MIDTERM
{
    public partial class frmUpdateTicket : Form
    {
        private string TicketNumber, problem, Details, status, lastUpdateDate;
        public static frmUpdateTicket dgvRefresh;

        Class1 UpdateTicket = new Class1("LAPTOP-751I04E4\\SQLEXPRESS", "CS311-2022", "trix", "12345");
        public frmUpdateTicket(string TicketNumber, string problem,  string Details, string status, string lastUpdateDate)
        {
            InitializeComponent();
            this.TicketNumber = TicketNumber;
            this.problem = problem;
            this.Details = Details;
            this.status = status;
            this.lastUpdateDate = lastUpdateDate;
            dgvRefresh = this;

        }
        private void validateTicketNumber()
        {
            if (txtTicketNumber.Text == "")
            {
                errorProvider1.SetError(txtTicketNumber, "Ticket Number is required");
            }

            else
            {
                errorProvider1.SetError(txtTicketNumber, "");
            }
        }
        private void validateProblem()
        {
            if (cmbProblem.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbProblem, "Problem is required");
            }
            else
            {
                errorProvider1.SetError(cmbProblem, "");
            }
        }
        private void validateDetails()
        {
            if (txtDetails.Text == "")
            {
                errorProvider1.SetError(txtDetails, "Details of the ticket is required");
            }

            else
            {
                errorProvider1.SetError(txtDetails, "");
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


        private void frmUpdateTicket_Load(object sender, EventArgs e)
        {
            txtTicketNumber.Text = TicketNumber;
            txtDetails.Text = Details;

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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            validateTicketNumber();
            validateProblem();
            validateDetails();
            countErrors();
            if (errorCount == 0)

            {

                try
                {
                    DialogResult answer = MessageBox.Show("Do you want to update this data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == DialogResult.Yes)
                    {

                        UpdateTicket.executeSQL("UPDATE tblTicket SET  Problem = '" + cmbProblem.Text.ToUpper() + "', Details = '" + txtDetails.Text + "', Date = '" + DateTime.Now.ToString("yyyy-MM-dd")
                        + "', Time = '" + DateTime.Now.ToString("hh:mm:ss") + "', Status = '" + status + "', lastUpdateDate = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' WHERE TicketNumber = '"
                        + txtTicketNumber.Text + "'");

                        if (UpdateTicket.rowAffected > 0)
                        {
                            MessageBox.Show("Ticket Updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            frmTicket.dgvRefresh.btnRefresh_Click(sender, e);
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error on update button", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}