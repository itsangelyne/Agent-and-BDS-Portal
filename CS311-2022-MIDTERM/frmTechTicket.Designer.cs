namespace CS311_2022_MIDTERM
{
    partial class frmTechTicket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnRefreshTech = new System.Windows.Forms.Button();
            this.btnAssignTech = new System.Windows.Forms.Button();
            this.btnApproveTech = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDeleteTech = new System.Windows.Forms.Button();
            this.btnUpdateTech = new System.Windows.Forms.Button();
            this.btnAddTech = new System.Windows.Forms.Button();
            this.txtSearchTech = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView2.Location = new System.Drawing.Point(33, 54);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(665, 310);
            this.dataGridView2.TabIndex = 35;
            // 
            // btnRefreshTech
            // 
            this.btnRefreshTech.BackColor = System.Drawing.Color.RosyBrown;
            this.btnRefreshTech.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefreshTech.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshTech.Location = new System.Drawing.Point(77, 14);
            this.btnRefreshTech.Name = "btnRefreshTech";
            this.btnRefreshTech.Size = new System.Drawing.Size(106, 34);
            this.btnRefreshTech.TabIndex = 34;
            this.btnRefreshTech.Text = "&REFRESH ";
            this.btnRefreshTech.UseVisualStyleBackColor = false;
            this.btnRefreshTech.Click += new System.EventHandler(this.btnRefreshTech_Click);
            // 
            // btnAssignTech
            // 
            this.btnAssignTech.BackColor = System.Drawing.Color.BurlyWood;
            this.btnAssignTech.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAssignTech.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignTech.Location = new System.Drawing.Point(441, 385);
            this.btnAssignTech.Name = "btnAssignTech";
            this.btnAssignTech.Size = new System.Drawing.Size(116, 44);
            this.btnAssignTech.TabIndex = 33;
            this.btnAssignTech.Text = "&ASSIGN ";
            this.btnAssignTech.UseVisualStyleBackColor = false;
            // 
            // btnApproveTech
            // 
            this.btnApproveTech.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnApproveTech.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApproveTech.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApproveTech.Location = new System.Drawing.Point(580, 383);
            this.btnApproveTech.Name = "btnApproveTech";
            this.btnApproveTech.Size = new System.Drawing.Size(109, 45);
            this.btnApproveTech.TabIndex = 32;
            this.btnApproveTech.Text = "&APPROVE";
            this.btnApproveTech.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::CS311_2022_MIDTERM.Properties.Resources.search__1_;
            this.pictureBox2.Location = new System.Drawing.Point(644, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 22);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // btnDeleteTech
            // 
            this.btnDeleteTech.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDeleteTech.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteTech.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTech.Location = new System.Drawing.Point(304, 384);
            this.btnDeleteTech.Name = "btnDeleteTech";
            this.btnDeleteTech.Size = new System.Drawing.Size(109, 45);
            this.btnDeleteTech.TabIndex = 29;
            this.btnDeleteTech.Text = "&DELETE";
            this.btnDeleteTech.UseVisualStyleBackColor = false;
            this.btnDeleteTech.Click += new System.EventHandler(this.btnDeleteTech_Click);
            // 
            // btnUpdateTech
            // 
            this.btnUpdateTech.BackColor = System.Drawing.Color.BurlyWood;
            this.btnUpdateTech.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateTech.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTech.Location = new System.Drawing.Point(167, 384);
            this.btnUpdateTech.Name = "btnUpdateTech";
            this.btnUpdateTech.Size = new System.Drawing.Size(116, 44);
            this.btnUpdateTech.TabIndex = 28;
            this.btnUpdateTech.Text = "&UPDATE";
            this.btnUpdateTech.UseVisualStyleBackColor = false;
            this.btnUpdateTech.Click += new System.EventHandler(this.btnUpdateTech_Click);
            // 
            // btnAddTech
            // 
            this.btnAddTech.BackColor = System.Drawing.Color.Peru;
            this.btnAddTech.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddTech.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTech.Location = new System.Drawing.Point(48, 384);
            this.btnAddTech.Name = "btnAddTech";
            this.btnAddTech.Size = new System.Drawing.Size(96, 44);
            this.btnAddTech.TabIndex = 27;
            this.btnAddTech.Text = "&ADD";
            this.btnAddTech.UseVisualStyleBackColor = false;
            this.btnAddTech.Click += new System.EventHandler(this.btnAddTech_Click);
            // 
            // txtSearchTech
            // 
            this.txtSearchTech.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSearchTech.Location = new System.Drawing.Point(508, 26);
            this.txtSearchTech.Name = "txtSearchTech";
            this.txtSearchTech.Size = new System.Drawing.Size(172, 22);
            this.txtSearchTech.TabIndex = 36;
            this.txtSearchTech.TextChanged += new System.EventHandler(this.txtSearchTech_TextChanged);
            // 
            // frmTechTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CS311_2022_MIDTERM.Properties.Resources._154406_blurred_gradient_748x4213;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnRefreshTech);
            this.Controls.Add(this.btnAssignTech);
            this.Controls.Add(this.btnApproveTech);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnDeleteTech);
            this.Controls.Add(this.btnUpdateTech);
            this.Controls.Add(this.btnAddTech);
            this.Controls.Add(this.txtSearchTech);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTechTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Technical Ticket Table";
            this.Load += new System.EventHandler(this.frmTechTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnRefreshTech;
        private System.Windows.Forms.Button btnAssignTech;
        private System.Windows.Forms.Button btnApproveTech;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDeleteTech;
        private System.Windows.Forms.Button btnUpdateTech;
        private System.Windows.Forms.Button btnAddTech;
        private System.Windows.Forms.TextBox txtSearchTech;
    }
}