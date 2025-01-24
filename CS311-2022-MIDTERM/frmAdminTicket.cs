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
    public partial class frmAdminTicket : Form
    {
        private string TicketNumber, username, userType;
        public static frmAdminTicket dgvRefresh;
        public frmAdminTicket(string TicketNumber)
        {
            InitializeComponent();
            this.TicketNumber = TicketNumber;
            dgvRefresh = this;
        }

        Class1 AdminTicket = new Class1("LAPTOP-751I04E4\\SQLEXPRESS", "CS311-2022", "trix", "12345");

        private void frmAdminTicket_Load(object sender, EventArgs e)
        {
            try
            {

                dataGridView2.RowHeadersVisible = false;
                DataTable dt = AdminTicket.GetData("SELECT TicketNumber, Problem, Details, status, Date, Time, createdBy, lastUpdateDate, AssignedTo, AssignedBy,dateAssigned, " +
                    "CompletedBy, dateCompleted, ApprovedBy, dateApproved FROM tblTicket WHERE TicketNumber <> '" + TicketNumber + "' ORDER BY Date DESC  ");
                dataGridView2.DataSource = dt;
                dataGridView2.Columns[2].Visible = false;
                dataGridView2.Columns[6].Visible = false;
                dataGridView2.Columns[7].Visible = false;
                dataGridView2.Columns[8].Visible = false;
                dataGridView2.Columns[9].Visible = false;
                dataGridView2.Columns[10].Visible = false;
                dataGridView2.Columns[11].Visible = false;
                dataGridView2.Columns[12].Visible = false;
                dataGridView2.Columns[13].Visible = false;
                dataGridView2.Columns[14].Visible = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on Admin ticket load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchAdmin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = AdminTicket.GetData("SELECT TicketNumber, Problem, status, Date, Time  FROM tblTicket WHERE TicketNumber <> '" + TicketNumber +
                    "' AND (TicketNumber LIKE '%" + txtSearchAdmin.Text + "%' OR Problem LIKE '%" + txtSearchAdmin.Text + "%' OR status LIKE '%" + txtSearchAdmin.Text +
                    "%' OR Date LIKE '%" + txtSearchAdmin.Text + "%' OR Time LIKE '%" + txtSearchAdmin.Text + "%')" +
                    " ORDER BY  TicketNumber ");
                dataGridView2.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on search", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
       

        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("Are you sure you want to delete this data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    AdminTicket.executeSQL("DELETE FROM tblTicket WHERE TicketNumber = '" + dataGridView2.Rows[fullrowSelect].Cells[0].Value.ToString() + "'");
                    if (AdminTicket.rowAffected > 0)
                    {
                        MessageBox.Show("Ticket deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AdminTicket.executeSQL("INSERT INTO tblTicketDeleteLogsAdmin VALUES('" + DateTime.Now.ToString("dd-MM-yyyy") + "', '" + DateTime.Now.ToLongTimeString() +
                        "', 'Ticket Management' , '" + dataGridView2.Rows[fullrowSelect].Cells[0].Value.ToString() + "','" + TicketNumber + "')");
                        frmAdminTicket.dgvRefresh.btnRefreshAdmin_Click(sender, e);
                    }
                }

            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error on delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void btnRefreshAdmin_Click(object sender, EventArgs e)
        {
            frmAdminTicket_Load(sender, e);
        }

        private void btnAssignAdmin_Click(object sender, EventArgs e)
        {
            string status;
            status = dataGridView2.Rows[fullrowSelect].Cells[3].Value.ToString();
            if (status == "PENDING")
            {
                string assignTicketNumber, assignProblem, assignDetails, assignDate, assigncreatedBy, AssignedTechnician,  AssignedBy;
                assignTicketNumber = dataGridView2.Rows[fullrowSelect].Cells[0].Value.ToString();
                assignProblem = dataGridView2.Rows[fullrowSelect].Cells[1].Value.ToString();
                assignDetails = dataGridView2.Rows[fullrowSelect].Cells[2].Value.ToString();
                assignDate = dataGridView2.Rows[fullrowSelect].Cells[4].Value.ToString();
                assigncreatedBy = dataGridView2.Rows[fullrowSelect].Cells[6].Value.ToString();
                AssignedTechnician = dataGridView2.Rows[fullrowSelect].Cells[8].Value.ToString();
                AssignedBy = dataGridView2.Rows[fullrowSelect].Cells[9].Value.ToString();

                frmAssignAdmin AssignTicket = new frmAssignAdmin(assignTicketNumber, assignProblem, assignDetails, assignDate,  assigncreatedBy, AssignedTechnician,  AssignedBy, username);

                AssignTicket.Show();
            }
            else
            {
                MessageBox.Show("Status should be PENDING", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnApprove_Click(object sender, EventArgs e)
        {
            string Status;
            Status = dataGridView2.Rows[fullrowSelect].Cells[3].Value.ToString();
            if (Status == "WAITING FOR APPROVAL")
            {
                string updateTicketnumber, updateProblem, updateDetails, updateCompletedBy, updateDate;
                updateTicketnumber = dataGridView2.Rows[fullrowSelect].Cells[0].Value.ToString();
                updateProblem = dataGridView2.Rows[fullrowSelect].Cells[1].Value.ToString();
                updateDetails = dataGridView2.Rows[fullrowSelect].Cells[2].Value.ToString();
                updateDate = dataGridView2.Rows[fullrowSelect].Cells[12].Value.ToString();
                updateCompletedBy = dataGridView2.Rows[fullrowSelect].Cells[6].Value.ToString();
                frmApproveAdminn assign = new frmApproveAdminn(updateTicketnumber, updateProblem, updateDetails, updateCompletedBy, updateDate);
                assign.Show();
            }
            else
            {
                MessageBox.Show("Ticket should be WAITING FOR APPROVAL", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnRefreshAdmin_Click_1(object sender, EventArgs e)
        {
            frmAdminTicket_Load(sender, e);
        }

        private int fullrowSelect;
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            fullrowSelect = dataGridView2.CurrentCell.RowIndex;
        }

    }
}


