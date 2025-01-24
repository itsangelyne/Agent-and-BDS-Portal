using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace CS311_2022_MIDTERM
{
    public partial class frmCompleteTable : Form
    {
        private string TicketNumber, username, userType;
        public static frmCompleteTable dgvRefresh;
        public frmCompleteTable(string username)
        {
            InitializeComponent();
            this.username = username;
            this.userType = userType;
            this.TicketNumber = TicketNumber;
            dgvRefresh = this;

        }
        Class1 CompleteTable = new Class1("LAPTOP-751I04E4\\SQLEXPRESS", "CS311-2022", "trix", "12345");

        private int fullrowSelect;

        private void frmCompleteTable_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.RowHeadersVisible = false;
                DataTable dt = CompleteTable.GetData("SELECT TicketNumber, Problem, Details, status, Date, Time, createdBy, lastUpdateDate, AssignedTo, AssignedBy,dateAssigned, " +
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
                MessageBox.Show(error.Message, "Ticket should be PENDING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = CompleteTable.GetData("SELECT TicketNumber, Problem, status, Date, Time  FROM tblTicket WHERE TicketNumber <> '" + TicketNumber +
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

        public void btnRefreshAdmin_Click(object sender, EventArgs e)
        {
            frmCompleteTable_Load(sender, e);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            fullrowSelect = dataGridView1.CurrentCell.RowIndex;
        }
            
        private void btnComplete_Click(object sender, EventArgs e)
        {
            
                string updateTicketnumber, updateProblem, updateDetails, updateDate, updateCreatedBy;
                updateTicketnumber = dataGridView1.Rows[fullrowSelect].Cells[0].Value.ToString();
                updateProblem= dataGridView1.Rows[fullrowSelect].Cells[1].Value.ToString();
                updateDetails = dataGridView1.Rows[fullrowSelect].Cells[2].Value.ToString();
                updateDate = dataGridView1.Rows[fullrowSelect].Cells[4].Value.ToString();
                updateCreatedBy = dataGridView1.Rows[fullrowSelect].Cells[6].Value.ToString();
                frmCompleteTech ticket = new frmCompleteTech(updateTicketnumber, updateProblem, updateDetails, updateDate, updateCreatedBy);
                ticket.Show();
        }
     }
}
    

    


