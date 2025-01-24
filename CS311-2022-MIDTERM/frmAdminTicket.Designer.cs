namespace CS311_2022_MIDTERM
{
    partial class frmAdminTicket
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
            this.btnAssignAdmin = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtSearchAdmin = new System.Windows.Forms.TextBox();
            this.btnDeleteAdmin = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnRefreshAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAssignAdmin
            // 
            this.btnAssignAdmin.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAssignAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAssignAdmin.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignAdmin.Location = new System.Drawing.Point(115, 392);
            this.btnAssignAdmin.Name = "btnAssignAdmin";
            this.btnAssignAdmin.Size = new System.Drawing.Size(116, 44);
            this.btnAssignAdmin.TabIndex = 23;
            this.btnAssignAdmin.Text = "&ASSIGN ";
            this.btnAssignAdmin.UseVisualStyleBackColor = false;
            this.btnAssignAdmin.Click += new System.EventHandler(this.btnAssignAdmin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::CS311_2022_MIDTERM.Properties.Resources.search__1_;
            this.pictureBox2.Location = new System.Drawing.Point(642, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 22);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // txtSearchAdmin
            // 
            this.txtSearchAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSearchAdmin.Location = new System.Drawing.Point(506, 35);
            this.txtSearchAdmin.Name = "txtSearchAdmin";
            this.txtSearchAdmin.Size = new System.Drawing.Size(172, 22);
            this.txtSearchAdmin.TabIndex = 20;
            this.txtSearchAdmin.TextChanged += new System.EventHandler(this.txtSearchAdmin_TextChanged);
            // 
            // btnDeleteAdmin
            // 
            this.btnDeleteAdmin.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDeleteAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteAdmin.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAdmin.Location = new System.Drawing.Point(506, 392);
            this.btnDeleteAdmin.Name = "btnDeleteAdmin";
            this.btnDeleteAdmin.Size = new System.Drawing.Size(109, 45);
            this.btnDeleteAdmin.TabIndex = 19;
            this.btnDeleteAdmin.Text = "&DELETE";
            this.btnDeleteAdmin.UseVisualStyleBackColor = false;
            this.btnDeleteAdmin.Click += new System.EventHandler(this.btnDeleteAdmin_Click);
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
            this.dataGridView2.Location = new System.Drawing.Point(32, 63);
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
            this.dataGridView2.Size = new System.Drawing.Size(679, 307);
            this.dataGridView2.TabIndex = 26;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.Peru;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApprove.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.Location = new System.Drawing.Point(308, 394);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(116, 44);
            this.btnApprove.TabIndex = 31;
            this.btnApprove.Text = "&APPROVE";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnRefreshAdmin
            // 
            this.btnRefreshAdmin.BackColor = System.Drawing.Color.RosyBrown;
            this.btnRefreshAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefreshAdmin.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshAdmin.Location = new System.Drawing.Point(64, 23);
            this.btnRefreshAdmin.Name = "btnRefreshAdmin";
            this.btnRefreshAdmin.Size = new System.Drawing.Size(106, 34);
            this.btnRefreshAdmin.TabIndex = 32;
            this.btnRefreshAdmin.Text = "&REFRESH ";
            this.btnRefreshAdmin.UseVisualStyleBackColor = false;
            this.btnRefreshAdmin.Click += new System.EventHandler(this.btnRefreshAdmin_Click_1);
            // 
            // frmAdminTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CS311_2022_MIDTERM.Properties.Resources._154406_blurred_gradient_748x4212;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.btnRefreshAdmin);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnAssignAdmin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtSearchAdmin);
            this.Controls.Add(this.btnDeleteAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAdminTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin -Ticket Management";
            this.Load += new System.EventHandler(this.frmAdminTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAssignAdmin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSearchAdmin;
        private System.Windows.Forms.Button btnDeleteAdmin;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnRefreshAdmin;
    }
}