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
    public partial class frmUpdateEquipment : Form
    {
        private string AssetNumber, serialNumber, type,  branch, Status, LastUpdateBy;
        public static frmUpdateEquipment dgvRefresh;
        Class1 UpdateEquipment = new Class1("LAPTOP-751I04E4\\SQLEXPRESS", "CS311-2022", "trix", "12345");

        public frmUpdateEquipment(string AssetNumber, string serialNumber, string type,  string branch,  string Status, string LastUpdateBy)
        {
            InitializeComponent();
            this.AssetNumber = AssetNumber;
            this.serialNumber = serialNumber;
            this.type = type;
            this.branch = branch;
            this.Status = Status;
            this.LastUpdateBy =  LastUpdateBy;
            dgvRefresh = this;
        }
      
        private void validateSerialNumber()
        {
            if (txtSerial.Text == "")
            {
                errorProvider1.SetError(txtSerial, "Serial Number is required");
            }
            else if (txtSerial.TextLength < 7)
            {
                errorProvider1.SetError(txtSerial, "Asset number and serial number should be unique");
            }

            else
            {
                errorProvider1.SetError(txtSerial, "");
            }
        }
        private void validateType()
        {
            if (cmbType.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbType, "Type is required");
            }
            else
            {
                errorProvider1.SetError(cmbType, "");
            }
        }
        private void validateManufacturer()
        {
            if (txtManufacturer.Text == "")
            {
                errorProvider1.SetError(txtManufacturer, "Manufacturer is required");
            }
            else
            {
                errorProvider1.SetError(txtManufacturer, "");
            }
        }
        private void validateYear()
        {
            if (txtModel.Text == "")
            {
                errorProvider1.SetError(txtModel, " Year should only be numeric");
            }
            else if (txtModel.TextLength < 4)
            {
                errorProvider1.SetError(txtModel, "Year should contain 4 numbers only.");
            }
            else if (txtModel.TextLength < 4)
            {
                errorProvider1.SetError(txtModel, "Year should be from 1990 to 3000 only.");
            }

            else
            {
                errorProvider1.SetError(txtSerial, "");
            }
        }
        private void validateBranch()
        {
            if (cmbBranch.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbType, "Branch is required ");
            }
            else
            {
                errorProvider1.SetError(cmbBranch, "");
            }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void validateDepartment()
        {
            if (cmbDepartment.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbDepartment, "Department is required");
            }
            else
            {
                errorProvider1.SetError(cmbDepartment, "");
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

        private void frmUpdateEquipment_Load(object sender, EventArgs e)
        {
            txtAsset.Text = AssetNumber;
            txtSerial.Text = serialNumber;
            if (type == "MONITOR")
            {
                cmbType.SelectedIndex = 0;
            }
            else if (type == "CPU")
            {
                cmbType.SelectedIndex = 1;
            }
            else if (type == "KEYBOARD")
            {
                cmbType.SelectedIndex = 2;
            }
            else if (type == "MOUSE")
            {
                cmbType.SelectedIndex = 3;
            }
            else if (type == "AVR")
            {
                cmbType.SelectedIndex = 4;
            }
            else if (type == "MAC")
            {
                cmbType.SelectedIndex = 5;
            }
            else if (type == "PRINTER")
            {
                cmbType.SelectedIndex = 6;
            }
            else if (type == "PROJECTOR")
            {
                cmbType.SelectedIndex = 7;
            }
            else
            {
                cmbType.SelectedIndex = 1;
            }


            if (branch == "Juan Sumulong Campus (AU Legarda/Main)")
            {
                cmbBranch.SelectedIndex = 0;
            }
            else if (branch == "Jose Abad Santos (AU Pasay)")
            {
                cmbBranch.SelectedIndex = 1;
            }
            else if (branch == "Andres Bonifacio Campus (AU Pasig)")
            {
                cmbBranch.SelectedIndex = 2;
            }
            else if (branch == "Jose Rizal Campus (AU Malabon)")
            {
                cmbBranch.SelectedIndex = 3;
            }
            else if (branch == "Plaridel Campus (AU Mandaluyong)")
            {
                cmbType.SelectedIndex = 4;
            }
            else if (branch == "Apolinario Mabini Campus (AU Pasay)")
            {
                cmbBranch.SelectedIndex = 5;
            }

            else if (branch == "Elisa Esguerra Campus (AU Malabon)")
            {
                cmbBranch.SelectedIndex = 6;
            }
            else
            {
                cmbBranch.SelectedIndex = 1;
            }

            if (Status == "WORKING")
            {
                rbWorking.Checked = true;
            }
            else if (Status == "ON-REPAIR")
            {
                rbRepair.Checked = true;
            }
            else
            {
                rbRetired.Checked = true;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            validateSerialNumber();
            validateType();
            validateManufacturer();
            validateYear();
            validateBranch();
            validateDepartment();
            countErrors();
            if (errorCount == 0)
            {
                string newStatus;
                if (rbWorking.Checked)
                {
                    newStatus = rbWorking.Text.ToUpper();
                }
                else if (rbRepair.Checked)
                {
                    newStatus = rbRepair.Text.ToUpper();
                }
                else
                {
                    newStatus = rbRetired.Text.ToUpper();
                }
                try
                {
                    DialogResult answer = MessageBox.Show("Do you want to update this data?", " Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    UpdateEquipment.executeSQL("UPDATE tblEquipment SET SerialNumber = '" + txtSerial.Text + "', Type = '" + cmbType.Text.ToUpper() +"', Manufacturer = '" +
                        txtManufacturer.Text + "' ,  YearModel = '" + txtModel.Text + "',Description = '" + txtDescribe.Text + "', Branch = '" + cmbBranch.Text.ToUpper() + "', Department = '" + 
                        cmbDepartment.Text.ToUpper() +"',Status = '" + newStatus + "',  LastUpdateBy = '" + LastUpdateBy + "',   LastUpdateDate = '" + 
                        DateTime.Now.ToString("dd-MM-yyyy") +"' WHERE AssetNumber = '" + txtAsset.Text + "'");
                    
                    if (UpdateEquipment.rowAffected > 0)
                    {
                        MessageBox.Show("Equipment Updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        frmEquipment.dgvRefresh.btnRefresh_Click(sender, e);
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
