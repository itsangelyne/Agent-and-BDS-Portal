using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CS311_2022_MIDTERM
{
    
    public partial class frmAssignAdmin : Form
    {
        private string username, TicketNumber, problem, Details, Date, createdBy, Technician,  AssignedBy;

        public static frmAssignAdmin dgvRefresh;
        public frmAssignAdmin(string TicketNumber, string problem, string details, string Date,  string createdBy, string Technician,
            string AssignedBy,  string username)
        {
            InitializeComponent();
            this.TicketNumber = TicketNumber;
            this.problem = problem;
            this.Details = details;
            this.Date = Date;
            this.createdBy = createdBy;
            this.Technician = Technician;
            this.AssignedBy = username;
            dgvRefresh = this;
        }

        
        Class1 AssignAdmin = new Class1("LAPTOP-751I04E4\\SQLEXPRESS", "CS311-2022", "trix", "12345");
        private void frmAssignAdmin_Load(object sender, EventArgs e)
        {
            txtTicketNumber.Text = TicketNumber;
            cmbProblem.Text = problem;
            txtDetails.Text = Details;
            txtDateCreated.Text = Date;
            txtCreatedBy.Text = createdBy;
            
            try
            {
                DataTable dt = AssignAdmin.GetData("SELECT * FROM tblAcccounts WHERE userType = 'TECHNICAL'");
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string technicals;
                        technicals = dt.Rows[i]["userName"].ToString();
                        cmbTechnician.Items.Add(technicals);
                    }
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on AssignAdmin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private void btnSave_Click(object sender, EventArgs e)
            {
           
                try
                {
                  
                        AssignAdmin.executeSQL("UPDATE tblTicket SET Status = 'ON GOING', AssignedTo = '" + cmbTechnician.Text.ToUpper() + "', AssignedBy = '" +
                            username + "', dateAssigned = '"  + DateTime.Now.ToString("dd-MM-yyyy") + "' WHERE TicketNumber = '" + txtTicketNumber.Text + "'"); 



                    if (AssignAdmin.rowAffected > 0)
                    {
                        MessageBox.Show("Assign Ticket Added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmAdminTicket newFrm = (frmAdminTicket)Application.OpenForms["frmAdminTicket"];
                        frmAdminTicket.dgvRefresh.btnRefreshAdmin_Click(sender, e);
                        this.Close();
                       }

                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error on Assign Ticket", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();

                }

            }
        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    }

