using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Xml.Linq;


namespace CS311_2022_MIDTERM
{
    public partial class frmMain : Form
    {
        private string username, usertype;
        private Button currentButton;
        private Random random;
        private int tempIndex;


        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index) {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
                        ((byte)(0)));
                    panelTitleBar.BackColor = color;
                   
                }
            }
        }
      

        public frmMain(string username, string usertype)
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Username:" + username;
            toolStripStatusLabel2.Text = "UserType:" + usertype;
            this.username = username;
            this.usertype = usertype;
            random = new Random();
            customizedDesing();
          

        }
        private void customizedDesing()
        {
            panelFile.Visible = false;
        }
        private void hideFile()
        {
            if (panelFile.Visible == true)
                panelFile.Visible = false;
        }
        private void showFile (Panel File)
        {
            if (File.Visible == false)
            {
                hideFile();
                File.Visible = true;
            }
            else
                File.Visible = false;
            }
        private void btnFile_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showFile(panelFile);

        }
        private void btnAccount_Click(object sender, EventArgs e)
        {
            frmAccounts accounts = new frmAccounts(username);
            accounts.MdiParent = this;
            accounts.Show();
            hideFile();

        }
        private void btnEquipment_Click(object sender, EventArgs e)
        {
            frmEquipment equipment = new frmEquipment(username);
            equipment.MdiParent = this;
            equipment.Show();
            hideFile();
        }
        private void btnTicket_Click(object sender, EventArgs e)
        {

            if (usertype == "USER")
            {
                frmTicket ticket = new frmTicket(username);
                ticket.Show();
            }
            else if (usertype == "TECHNICAL")
            {
                frmCompleteTable ticket = new frmCompleteTable(username);
                ticket.Show();
            }
            else
            {
                frmAdminTicket ticket = new frmAdminTicket(username);
                ticket.Show();
            }

        }


        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {

                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(23, 37, 48);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
                        ((byte)(0)));
                }
            }
        }
       
        private void btnReport_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
        private void vtnAbout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
        

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            frmlogin login = new frmlogin();
            login.Show();
            this.Close();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void LMAIN_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panelFile_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
                {
                   
                }
    }
}
