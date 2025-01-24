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
    public partial class frmCreateTicket : Form
    {
        private string createdBy;
        public static frmCreateTicket dgvRefresh;
        public frmCreateTicket(string createdBy)
        {
            InitializeComponent();
            this.createdBy = createdBy;
            dgvRefresh = this;

        }
        Class1 CreateTicket = new Class1("LAPTOP-751I04E4\\SQLEXPRESS", "CS311-2022", "trix", "12345");



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
                    DialogResult answer = MessageBox.Show("Are you sure you want to save this data?", " Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    CreateTicket.executeSQL("INSERT INTO tblTicket (TicketNumber, Problem, Details, Date, Time, status, createdBy, dateCompleted, dateAssigned, dateApproved ) VALUES ('" + 
                        txtTicketNumber.Text + "', '" + cmbProblem.Text.ToUpper() + "', '" + txtDetails.Text + "', '" + DateTime.Now.ToString("yy-MM-dd") + "', '" + DateTime.Now.ToString("hh:mm:ss")
                        + "', 'PENDING','" + createdBy +"','" + DateTime.Now.ToString("yy-MM-dd") + "','" + DateTime.Now.ToString("yy-MM-dd") 
                        + "', '" + DateTime.Now.ToString("yy-MM-dd")+ "')");


                    if (CreateTicket.rowAffected > 0)
                    {
                        MessageBox.Show("New Ticket Added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        frmTicket.dgvRefresh.btnRefresh_Click(sender, e);
                    }
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error on Create Ticket", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                   
                }

            }
        }

        private void frmCreateTicket_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.txtTicketNumber.Text = datetime.ToString("yyyy-MM-dd  hh:mm:ss");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void txtDetails_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


       
    
   

