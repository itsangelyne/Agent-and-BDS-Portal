namespace CS311_2022_MIDTERM
{
    partial class frmUpdateEquipment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAsset = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescribe = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbWorking = new System.Windows.Forms.RadioButton();
            this.rbRetired = new System.Windows.Forms.RadioButton();
            this.rbRepair = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(408, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Serial  Number:";
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(549, 58);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(192, 22);
            this.txtSerial.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(47, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Asset  Number:";
            // 
            // txtAsset
            // 
            this.txtAsset.Enabled = false;
            this.txtAsset.Location = new System.Drawing.Point(189, 54);
            this.txtAsset.Name = "txtAsset";
            this.txtAsset.Size = new System.Drawing.Size(192, 22);
            this.txtAsset.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Chocolate;
            this.label5.Location = new System.Drawing.Point(416, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Year Model:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(549, 123);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(192, 22);
            this.txtModel.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Chocolate;
            this.label3.Location = new System.Drawing.Point(76, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Type:";
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "-Monitor-",
            " -CPU-",
            "-Keyboard-",
            "- Mouse-",
            "- AVR-",
            "-MAC-",
            " -Printer-",
            " -Projector-"});
            this.cmbType.Location = new System.Drawing.Point(189, 187);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(192, 24);
            this.cmbType.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(45, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Manufacturer";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(189, 124);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(192, 22);
            this.txtManufacturer.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Chocolate;
            this.label8.Location = new System.Drawing.Point(45, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Department";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "Dean, Graduate School of Education",
            "Dean, Graduate School of Nursing",
            "Dean, Graduate School of Business",
            "OIC, School of Liberal Arts, Social Sciences, and Humanities",
            "Cluster Dean, School of Business, Technology & Management",
            "Department Chair, College of Business Administration",
            "Cluster Dean, School of Science and Mathematics",
            "Department Chair, College of Nursing",
            "Dean, School of Education, Industrial Arts, Skills Training and Continuing Educat" +
                "ion",
            "Department Chair, College of Education",
            "Department Chair, Hospitality & Tourism Mgt.",
            "Department Chair, Institute of Accountancy",
            "Department Chair, College of Radiologic Technology",
            "Department Chair, School of Computer Science",
            "Director, International Nursing Program",
            "Department Chair, College of Medical Laboratory Science",
            "Department Chair, College of Pharmacy",
            "Department Chair, College of Physical Therapy",
            "Department Chair, School of Midwifery",
            "Department Chair, BS Psychology",
            "Department Chair, College of Criminal Justice",
            "Dean, Arellano University School of Law"});
            this.cmbDepartment.Location = new System.Drawing.Point(189, 254);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(192, 24);
            this.cmbDepartment.TabIndex = 21;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Chocolate;
            this.label7.Location = new System.Drawing.Point(433, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Branch";
            // 
            // cmbBranch
            // 
            this.cmbBranch.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Items.AddRange(new object[] {
            "-Juan Sumulong Campus (AU Legarda/Main)-",
            "- Jose Abad Santos (AU Pasay)-",
            "- Andres Bonifacio Campus (AU Pasig)-",
            "- Jose Rizal Campus (AU Malabon)-",
            "- Plaridel Campus (AU Mandaluyong)-",
            "- Apolinario Mabini Campus (AU Pasay)-",
            "- Elisa Esguerra Campus (AU Malabon)-"});
            this.cmbBranch.Location = new System.Drawing.Point(549, 193);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(192, 24);
            this.cmbBranch.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Chocolate;
            this.label6.Location = new System.Drawing.Point(419, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Description";
            // 
            // txtDescribe
            // 
            this.txtDescribe.Location = new System.Drawing.Point(549, 250);
            this.txtDescribe.Multiline = true;
            this.txtDescribe.Name = "txtDescribe";
            this.txtDescribe.Size = new System.Drawing.Size(192, 22);
            this.txtDescribe.TabIndex = 17;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.Controls.Add(this.rbWorking);
            this.groupBox1.Controls.Add(this.rbRetired);
            this.groupBox1.Controls.Add(this.rbRepair);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(237, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 83);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STATUS";
            // 
            // rbWorking
            // 
            this.rbWorking.AutoSize = true;
            this.rbWorking.Checked = true;
            this.rbWorking.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWorking.Location = new System.Drawing.Point(6, 35);
            this.rbWorking.Name = "rbWorking";
            this.rbWorking.Size = new System.Drawing.Size(90, 20);
            this.rbWorking.TabIndex = 24;
            this.rbWorking.TabStop = true;
            this.rbWorking.Text = "WORKING";
            this.rbWorking.UseVisualStyleBackColor = true;
            // 
            // rbRetired
            // 
            this.rbRetired.AutoSize = true;
            this.rbRetired.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRetired.Location = new System.Drawing.Point(229, 35);
            this.rbRetired.Name = "rbRetired";
            this.rbRetired.Size = new System.Drawing.Size(83, 20);
            this.rbRetired.TabIndex = 26;
            this.rbRetired.TabStop = true;
            this.rbRetired.Text = "RETIRED";
            this.rbRetired.UseVisualStyleBackColor = true;
            // 
            // rbRepair
            // 
            this.rbRepair.AutoSize = true;
            this.rbRepair.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRepair.Location = new System.Drawing.Point(112, 35);
            this.rbRepair.Name = "rbRepair";
            this.rbRepair.Size = new System.Drawing.Size(100, 20);
            this.rbRepair.TabIndex = 25;
            this.rbRepair.TabStop = true;
            this.rbRepair.Text = "ON-REPAIR";
            this.rbRepair.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(215, 416);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(378, 44);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "&SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmUpdateEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(797, 492);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescribe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAsset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUpdateEquipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Equipment";
            this.Load += new System.EventHandler(this.frmUpdateEquipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAsset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescribe;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbWorking;
        private System.Windows.Forms.RadioButton rbRetired;
        private System.Windows.Forms.RadioButton rbRepair;
    }
}