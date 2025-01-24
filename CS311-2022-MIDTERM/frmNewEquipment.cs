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
    public partial class frmNewEquipment : Form
    {
        private string createdBy;
        public static frmNewEquipment dgvRefresh;
        public frmNewEquipment(string createdBy)
        {
            InitializeComponent();
            this.createdBy = createdBy;
            dgvRefresh = this;
        }
    
        Class1 NewEquipment = new Class1("LAPTOP-751I04E4\\SQLEXPRESS", "CS311-2022", "trix", "12345");
            private void validateAssetNumber()
            { 
                DataTable dt = NewEquipment.GetData("SELECT * FROM tblEquipment WHERE AssetNumber = '" + txtAsset.Text + "'");

                    if (txtAsset.Text == "")
                    {
                        errorProvider1.SetError(txtAsset, "Asset Number is required");
                    }
                    else if (txtAsset.TextLength < 6)
                    {
                        errorProvider1.SetError(txtAsset, "Asset number and serial number should be unique");
                    }
                    else if (dt.Rows.Count > 0)
                    {
                        errorProvider1.SetError(txtAsset, "Asset Number already in use");
                    }

                    else
                    {
                        errorProvider1.SetError(txtAsset, "");
                    }
                  }
            private void validateSerialNumber()
            {
            
                DataTable dt = NewEquipment.GetData("SELECT * FROM tblEquipment WHERE SerialNumber = '" + txtSerial.Text + "'");

                    if (txtSerial.Text == "")
                    {
                        errorProvider1.SetError(txtSerial, "Serial Number is required");
                    }
                    else if (txtSerial.TextLength < 6)
                    {
                        errorProvider1.SetError(txtSerial, "Asset number and serial number should be unique");
                    }
                    else if (dt.Rows.Count > 0)
                    {
                        errorProvider1.SetError(txtSerial, "Serial Number already in use");
                    }

                    else
                    {
                        errorProvider1.SetError(txtSerial, "");
                    }
                 }
            private void validateType()
            {
                    if (cmbType.SelectedIndex< 0)
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
                        errorProvider1.SetError(txtModel, "Year should only be numeric");
                    }
                    else if (txtModel.TextLength < 4)
                    {
                        errorProvider1.SetError(txtModel, "Year should contain 4 characters only");
                    }
                    else if (txtModel.TextLength < 4)
                    {
                        errorProvider1.SetError(txtModel, "Year should be from 1900 to 3000 only");
                    }

                     else
                    {
                        errorProvider1.SetError(txtModel, "");
                    }
                }
       
            private void validateBranch()
                {
                    if (cmbBranch.SelectedIndex < 0)
                    {
                        errorProvider1.SetError(cmbBranch, "Branch is required ");
                    }
                    else
                    {
                        errorProvider1.SetError(cmbBranch, "");
                    }
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


            private void btnSave_Click(object sender, EventArgs e)
            {

                validateAssetNumber();
                validateSerialNumber();
                validateType();
                validateManufacturer();
                validateYear();
                validateBranch();
                validateDepartment();
                countErrors();
                if (errorCount == 0)
                {
                    try
                    {
                        DialogResult answer = MessageBox.Show("Are you sure you want to save this data?", " Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        NewEquipment.executeSQL("INSERT INTO tblEquipment (AssetNumber,SerialNumber, Type, Manufacturer, YearModel, Description, Branch, Department,Status,CreatedBy, DateCreated) VALUES ('" + txtAsset.Text +"', '" + txtSerial.Text + "', '" + cmbType.Text.ToUpper() + "', '" + txtManufacturer.Text +
                            "', '" + txtModel.Text + "', '" + txtDescribe.Text + "', '" + cmbBranch.Text.ToUpper() + "', '" + cmbDepartment.Text.ToUpper() + "', 'WORKING','"  + createdBy + 
                            "','" + DateTime.Now.ToString ("dd-MM-yy") + "')");


                        if (NewEquipment.rowAffected > 0)
                        {
                            MessageBox.Show("New Equipment Added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            frmEquipment.dgvRefresh.btnRefresh_Click(sender, e);
                        }
                    }

                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message, "Error on Add new Equipment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }

        private void frmNewEquipment_Load(object sender, EventArgs e)
        {

        }
    }
        }

