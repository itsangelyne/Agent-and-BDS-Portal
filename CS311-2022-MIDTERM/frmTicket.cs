using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS311_2022_MIDTERM
{

    public partial class frmTicket : Form
    {
        private string TicketNumber, username, userType;
        public static frmTicket dgvRefresh;
        public frmTicket(string TicketNumber)
        {
            InitializeComponent();
            this.TicketNumber = TicketNumber;
            dgvRefresh = this;

        }
        Class1 ticket = new Class1("LAPTOP-751I04E4\\SQLEXPRESS", "CS311-2022", "trix", "12345");
        private void frmTicket_Load(object sender, System.EventArgs e)
        {
            try
            {

                dataGridView1.RowHeadersVisible = false;
                DataTable dt = ticket.GetData("SELECT TicketNumber, Problem, Details, status, Date, Time, createdBy, lastUpdateDate, AssignedTo, AssignedBy,dateAssigned, " +
                    "CompletedBy, dateCompleted, ApprovedBy, dateApproved FROM tblTicket WHERE TicketNumber <> '" + TicketNumber + "' ORDER BY Date DESC ");
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[12].Visible = false;
                dataGridView1.Columns[13].Visible = false;
                dataGridView1.Columns[14].Visible = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on ticket load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = ticket.GetData("SELECT TicketNumber, Problem, status, Date, Time  FROM tblTicket WHERE TicketNumber <> '" + TicketNumber +
                    "' AND (TicketNumber LIKE '%" + txtSearch.Text + "%' OR Problem LIKE '%" + txtSearch.Text + "%' OR status LIKE '%" + txtSearch.Text +
                    "%' OR Date LIKE '%" + txtSearch.Text + "%' OR Time LIKE '%" + txtSearch.Text + "%')" +
                    " ORDER BY  TicketNumber ");
                dataGridView1.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on search", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            frmCreateTicket CreateTicket = new frmCreateTicket(TicketNumber);
            CreateTicket.Show();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {

            string editTicketNumber, editProblem, editDetails, editstatus;
            editTicketNumber = dataGridView1.Rows[fullrowSelect].Cells[0].Value.ToString();
            editProblem = dataGridView1.Rows[fullrowSelect].Cells[1].Value.ToString();
            editDetails = dataGridView1.Rows[fullrowSelect].Cells[2].Value.ToString();
            editstatus = dataGridView1.Rows[fullrowSelect].Cells[5].Value.ToString();

            frmUpdateTicket UpdateTicket = new frmUpdateTicket(editTicketNumber, editProblem, editDetails, editstatus, TicketNumber);
            UpdateTicket.Show();
        }
        private int fullrowSelect;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            fullrowSelect = dataGridView1.CurrentCell.RowIndex;
        }


       
        public void btnRefresh_Click(object sender, EventArgs e)
        {
            frmTicket_Load(sender, e);
        }


        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            string status;
            status = dataGridView1.Rows[fullrowSelect].Cells[3].Value.ToString();
            if (status == "PENDING")
            {
                try
                {
                    DialogResult answer = MessageBox.Show("Are you sure you want to delete this data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == DialogResult.Yes)
                    {
                        ticket.executeSQL("DELETE FROM tblTicket WHERE TicketNumber = '" + dataGridView1.Rows[fullrowSelect].Cells[0].Value.ToString() + "'");
                        if (ticket.rowAffected > 0)
                        {
                            MessageBox.Show("Ticket deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ticket.executeSQL("INSERT INTO tblTicketDeletelogs VALUES('" + DateTime.Now.ToString("dd-MM-yyyy") + "', '" + DateTime.Now.ToLongTimeString() +
                            "', 'Ticket Management' , '" + dataGridView1.Rows[fullrowSelect].Cells[0].Value.ToString() + "','" + TicketNumber + "')");
                            frmTicket.dgvRefresh.btnRefresh_Click(sender, e);
                        }

                    }
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error on delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Status should be PENDING", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}



