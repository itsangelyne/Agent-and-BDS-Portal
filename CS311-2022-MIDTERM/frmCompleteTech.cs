using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace CS311_2022_MIDTERM
{
    public partial class frmCompleteTech : Form
    {
        private string username, TicketNumber, Problem, Details, Date, createdBy;
        public static frmCompleteTech dgvRefresh;

        public frmCompleteTech(string TicketNumber, string Problem, string Details, string Date, string createdBy)
        {
            InitializeComponent();
            this.username = username;
            this.TicketNumber = TicketNumber;
            this.Problem = Problem;
            this.Details = Details;
            this.Date = Date;
            this.createdBy = createdBy;
            dgvRefresh = this;
        }
        Class1 CompleteTech = new Class1("LAPTOP-751I04E4\\SQLEXPRESS", "CS311-2022", "trix", "12345");
        private void frmCompleteTech_Load(object sender, EventArgs e)
        {
            txtTicketNumber.Text = TicketNumber;
            cmbProblem.Text = Problem;
            txtDetails.Text = Details;
            txtDate.Text = Date;
            txtCreatedBy.Text = createdBy;
          

        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            try
            {
                CompleteTech.executeSQL("UPDATE tblTicket SET Status = 'WAITING FOR APPROVAL', completedBy  = '" + username + "', dateCompleted  = '" + DateTime.Now.ToString("dd-MM-yyyy") +
                    "' WHERE TicketNumber = '" + txtTicketNumber.Text + "'");


                if (CompleteTech.rowAffected > 0)
                {
                    MessageBox.Show("Complete Ticket!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmCompleteTech newFrm = (frmCompleteTech)Application.OpenForms["frmtech"];
                    frmCompleteTable.dgvRefresh.btnRefreshAdmin_Click(sender, e);
                    this.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on Complete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
