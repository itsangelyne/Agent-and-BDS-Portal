using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CS311_2022_MIDTERM
{
    public partial class frmEquipment : Form
    {
        private string AssetNumber;
        public static frmEquipment dgvRefresh;
        public frmEquipment(string AssetNumber)
        {
            InitializeComponent();          
            this.AssetNumber = AssetNumber;
            dgvRefresh = this;
        }

        Class1 equipment = new Class1("LAPTOP-751I04E4\\SQLEXPRESS", "CS311-2022", "trix", "12345");

     
        private void frmEquipment_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.RowHeadersVisible = false;
                DataTable dt = equipment.GetData("SELECT AssetNumber, SerialNumber, Type, Branch, Status, Manufacturer, YearModel, Description, Branch, Department, createdBy FROM tblEquipment WHERE AssetNumber <> '" + AssetNumber + "' ORDER BY AssetNumber DESC ");
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on equipment load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = equipment.GetData("SELECT AssetNumber, SerialNumber, Type, Branch  FROM tblEquipment WHERE AssetNumber <> '" + AssetNumber  +
                    "' AND ( AssetNumber LIKE '%" + txtSearch.Text + "%' OR SerialNumber LIKE '%" + txtSearch.Text + "%' OR Type LIKE '%" + txtSearch.Text + "%' " +
                    "OR Branch LIKE '%" + txtSearch.Text + "%')" + " ORDER BY  AssetNumber ");
         
                dataGridView1.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on search", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             frmNewEquipment newEquipment = new frmNewEquipment(AssetNumber);
             newEquipment.Show();
            }

        public void btnRefresh_Click(object sender, EventArgs e)
        {
            frmEquipment_Load(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)

        {
            DialogResult answer = MessageBox.Show("Do you want to update this data?", " Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string editAsset, editSerial, editType,  editbranch, editStatus;
            editAsset = dataGridView1.Rows[rowSelected].Cells[0].Value.ToString();
            editSerial = dataGridView1.Rows[rowSelected].Cells[1].Value.ToString();
            editType = dataGridView1.Rows[rowSelected].Cells[2].Value.ToString();
            editbranch = dataGridView1.Rows[rowSelected].Cells[3].Value.ToString();
            editStatus = dataGridView1.Rows[rowSelected].Cells[4].Value.ToString();
            frmUpdateEquipment newEquipment = new frmUpdateEquipment(editAsset, editSerial, editType,  editbranch, editStatus, AssetNumber);
            newEquipment.Show();
        }
        private int rowSelected;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            rowSelected = dataGridView1.CurrentCell.RowIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("Are you sure you want to delete this data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    equipment.executeSQL("DELETE FROM tblEquipment WHERE AssetNumber = '" + dataGridView1.Rows[rowSelected].Cells[0].Value.ToString() + "'");
                    if (equipment.rowAffected > 0)
                    {
                        MessageBox.Show("Equipment deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        equipment.executeSQL("INSERT INTO tblEquipDeletelogs VALUES('" + DateTime.Now.ToString("dd-MM-yyyy") + "', '" + DateTime.Now.ToLongTimeString() +
                            "', 'Equipment Management' , '" + dataGridView1.Rows[rowSelected].Cells[0].Value.ToString() + "','" + AssetNumber + "')");
                        
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

