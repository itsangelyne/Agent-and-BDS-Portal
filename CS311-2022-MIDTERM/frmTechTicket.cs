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
    public partial class frmTechTicket : Form
    {
        private string TicketNumber, username, userType;
        public static frmTechTicket dgvRefresh;
        public frmTechTicket(string TicketNumber)
        {
            InitializeComponent();
            this.TicketNumber = TicketNumber;
        }

        Class1 ticket = new Class1("LAPTOP-751I04E4\\SQLEXPRESS", "CS311-2022", "trix", "12345");
        private void frmTechTicket_Load(object sender, EventArgs e)
        {
            try
            {

                dataGridView2.RowHeadersVisible = false;
                DataTable dt = ticket.GetData("SELECT TicketNumber, Problem, Details, status, Date, Time, createdBy, lastUpdateDate, AssignedTo, AssignedBy,dateAssigned, " +
                    "CompletedBy, dateCompleted, ApprovedBy, dateApproved FROM tblTicket WHERE TicketNumber <> '" + TicketNumber + "' ORDER BY TicketNumber ");
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
                MessageBox.Show(error.Message, "Error on ticket load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtSearchTech_TextChanged(object sender, EventArgs e)
        {

            try
            {
                DataTable dt = ticket.GetData("SELECT TicketNumber, Problem, status, Date, Time  FROM tblTicket WHERE TicketNumber <> '" + TicketNumber +
                    "' AND (TicketNumber LIKE '%" + txtSearchTech.Text + "%' OR Problem LIKE '%" + txtSearchTech.Text + "%' OR status LIKE '%" + txtSearchTech.Text +
                    "%' OR Date LIKE '%" + txtSearchTech.Text + "%' OR Time LIKE '%" + txtSearchTech.Text + "%')" +
                    " ORDER BY  TicketNumber ");
                dataGridView2.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on search", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private int fullrowSelect;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            fullrowSelect = dataGridView2.CurrentCell.RowIndex;

        }

        private void btnUpdateTech_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddTech_Click(object sender, EventArgs e)
        {
                frmCreateTech CreateTech = new frmCreateTech(TicketNumber);
                CreateTech.Show();
            }
            
        private void btnRefreshTech_Click(object sender, EventArgs e)
        {
            frmTechTicket_Load(sender, e);
        }

        private void btnDeleteTech_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("Are you sure you want to delete this data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    ticket.executeSQL("DELETE FROM tblTicket WHERE TicketNumber = '" + dataGridView2.Rows[fullrowSelect].Cells[0].Value.ToString() + "'");
                    if (ticket.rowAffected > 0)
                    {
                        MessageBox.Show("Ticket deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ticket.executeSQL("INSERT INTO tblTicketDeletelogs VALUES('" + DateTime.Now.ToString("dd-MM-yyyy") + "', '" + DateTime.Now.ToLongTimeString() +
                        "', 'Ticket Management' , '" + dataGridView2.Rows[fullrowSelect].Cells[0].Value.ToString() + "','" + TicketNumber + "')");
                        frmTicket.dgvRefresh.btnRefresh_Click(sender, e);
                    }

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
    }

