using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BraiiPit
{
    public partial class FormManager : Form
    {
        bool sidebarExpand;
        bool sidebarCollapse;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public FormManager()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            sidebarContainer.Controls.Add(leftBorderBtn);

        }
        private void ActivateButton1(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(255, 224, 192);
                currentBtn.ForeColor = Color.IndianRed;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.IndianRed;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;



            }
        }
        private void DisableButton1()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.IndianRed;
                currentBtn.ForeColor = Color.FromArgb(255, 224, 192);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(255, 224, 192);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton1();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(255, 224, 192);
                currentBtn.ForeColor = Color.IndianRed;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.IndianRed;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = Color.IndianRed;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon

            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.IndianRed;
                currentBtn.ForeColor = Color.FromArgb(255, 224, 192);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(255, 224, 192);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            formcha.Controls.Add(childForm);
            formcha.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormManager_Load(object sender, EventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton1(sender);
            OpenChildForm(new FormNhapchitiet());
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarContainer.Width -= 10;
                if (sidebarContainer.Width == sidebarContainer.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebarContainer.Width += 10;
                if (sidebarContainer.Width == sidebarContainer.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {

        }

        private void nhaptimer_Tick(object sender, EventArgs e)
        {
            if (sidebarCollapse)
            {
                sidebarNhap.Height -= 10;
                if (sidebarNhap.Height == sidebarNhap.MinimumSize.Height)
                {
                    sidebarCollapse = false;
                    nhaptimer.Stop();
                }
            }
            else
            {
                sidebarNhap.Height += 10;
                if (sidebarNhap.Height == sidebarNhap.MaximumSize.Height)
                {
                    sidebarCollapse = true;
                    nhaptimer.Stop();
                }
            }
        }

        private void buttonNhap_Click(object sender, EventArgs e)
        {
            nhaptimer.Start();
            ActivateButton(sender);

        }

        private void iconButtonMenu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormMenu());
        }

        private void iconButtonHangNhap_Click(object sender, EventArgs e)
        {
            ActivateButton1(sender);
            OpenChildForm(new FormHangNhapVao());
        }

        private void iconButtonHoadonNhap_Click(object sender, EventArgs e)
        {
            ActivateButton1(sender);
            OpenChildForm(new FormNhap());
        }

        private void iconButtonHoadonBan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormBan());
        }

        private void iconButtonChitietBan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormBanChiTiet());
        }

        private void iconButtonKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormKhachHang());
        }

        private void iconButtonNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormNhanVien());
        }

        private void iconButtonTaiKhoan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormTaiKhoan());
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {

            sidebarTimer.Start();
            if (sidebarExpand = false)
            {
                sidebarTimer.Start();
            }
            DisableButton();
            leftBorderBtn.Visible = false;
            if (sidebarCollapse = true)
            {
                nhaptimer.Start();
            }
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất?", "Quản Lý Quán BraiiPit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
