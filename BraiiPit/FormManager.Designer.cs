namespace BraiiPit
{
    partial class FormManager
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
            components = new System.ComponentModel.Container();
            sidebarContainer = new FlowLayoutPanel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButtonMenu = new FontAwesome.Sharp.IconButton();
            sidebarNhap = new FlowLayoutPanel();
            buttonNhap = new FontAwesome.Sharp.IconButton();
            iconButtonHangNhap = new FontAwesome.Sharp.IconButton();
            iconButtonHoadonNhap = new FontAwesome.Sharp.IconButton();
            iconButtonChitietNhap = new FontAwesome.Sharp.IconButton();
            iconButtonHoadonBan = new FontAwesome.Sharp.IconButton();
            iconButtonChitietBan = new FontAwesome.Sharp.IconButton();
            iconButtonKhachHang = new FontAwesome.Sharp.IconButton();
            iconButtonNhanVien = new FontAwesome.Sharp.IconButton();
            iconButtonTaiKhoan = new FontAwesome.Sharp.IconButton();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            nhaptimer = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            formcha = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            sidebarContainer.SuspendLayout();
            sidebarNhap.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            formcha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // sidebarContainer
            // 
            sidebarContainer.BackColor = Color.IndianRed;
            sidebarContainer.Controls.Add(iconButton1);
            sidebarContainer.Controls.Add(iconButtonMenu);
            sidebarContainer.Controls.Add(sidebarNhap);
            sidebarContainer.Controls.Add(iconButtonHoadonBan);
            sidebarContainer.Controls.Add(iconButtonChitietBan);
            sidebarContainer.Controls.Add(iconButtonKhachHang);
            sidebarContainer.Controls.Add(iconButtonNhanVien);
            sidebarContainer.Controls.Add(iconButtonTaiKhoan);
            sidebarContainer.Dock = DockStyle.Left;
            sidebarContainer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            sidebarContainer.Location = new Point(0, 0);
            sidebarContainer.MaximumSize = new Size(262, 739);
            sidebarContainer.MinimumSize = new Size(69, 739);
            sidebarContainer.Name = "sidebarContainer";
            sidebarContainer.Size = new Size(69, 739);
            sidebarContainer.TabIndex = 0;
            // 
            // iconButton1
            // 
            iconButton1.BackgroundImageLayout = ImageLayout.Stretch;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Gill Sans Ultra Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.FromArgb(255, 224, 192);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.House;
            iconButton1.IconColor = Color.FromArgb(255, 224, 192);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(3, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(257, 61);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "  BraiiPit";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButtonMenu
            // 
            iconButtonMenu.FlatStyle = FlatStyle.Flat;
            iconButtonMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButtonMenu.ForeColor = Color.FromArgb(255, 224, 192);
            iconButtonMenu.IconChar = FontAwesome.Sharp.IconChar.TableList;
            iconButtonMenu.IconColor = Color.FromArgb(255, 224, 192);
            iconButtonMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonMenu.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonMenu.Location = new Point(3, 70);
            iconButtonMenu.Name = "iconButtonMenu";
            iconButtonMenu.Size = new Size(257, 61);
            iconButtonMenu.TabIndex = 1;
            iconButtonMenu.Text = "            Menu";
            iconButtonMenu.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonMenu.UseVisualStyleBackColor = true;
            iconButtonMenu.Click += iconButtonMenu_Click;
            // 
            // sidebarNhap
            // 
            sidebarNhap.BackgroundImageLayout = ImageLayout.None;
            sidebarNhap.Controls.Add(buttonNhap);
            sidebarNhap.Controls.Add(iconButtonHangNhap);
            sidebarNhap.Controls.Add(iconButtonHoadonNhap);
            sidebarNhap.Controls.Add(iconButtonChitietNhap);
            sidebarNhap.Location = new Point(0, 137);
            sidebarNhap.Margin = new Padding(0, 3, 0, 3);
            sidebarNhap.MaximumSize = new Size(260, 265);
            sidebarNhap.MinimumSize = new Size(260, 65);
            sidebarNhap.Name = "sidebarNhap";
            sidebarNhap.Size = new Size(260, 65);
            sidebarNhap.TabIndex = 1;
            // 
            // buttonNhap
            // 
            buttonNhap.FlatStyle = FlatStyle.Flat;
            buttonNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNhap.ForeColor = Color.FromArgb(255, 224, 192);
            buttonNhap.IconChar = FontAwesome.Sharp.IconChar.Store;
            buttonNhap.IconColor = Color.FromArgb(255, 224, 192);
            buttonNhap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonNhap.ImageAlign = ContentAlignment.MiddleLeft;
            buttonNhap.Location = new Point(3, 3);
            buttonNhap.Name = "buttonNhap";
            buttonNhap.Size = new Size(257, 61);
            buttonNhap.TabIndex = 2;
            buttonNhap.Text = "   Nhập Hàng";
            buttonNhap.UseVisualStyleBackColor = true;
            buttonNhap.Click += buttonNhap_Click;
            // 
            // iconButtonHangNhap
            // 
            iconButtonHangNhap.FlatStyle = FlatStyle.Flat;
            iconButtonHangNhap.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            iconButtonHangNhap.ForeColor = Color.FromArgb(255, 224, 192);
            iconButtonHangNhap.IconChar = FontAwesome.Sharp.IconChar.TableList;
            iconButtonHangNhap.IconColor = Color.FromArgb(255, 224, 192);
            iconButtonHangNhap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonHangNhap.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonHangNhap.Location = new Point(3, 70);
            iconButtonHangNhap.Name = "iconButtonHangNhap";
            iconButtonHangNhap.Padding = new Padding(15, 0, 0, 0);
            iconButtonHangNhap.Size = new Size(257, 61);
            iconButtonHangNhap.TabIndex = 3;
            iconButtonHangNhap.Text = "           Hàng";
            iconButtonHangNhap.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonHangNhap.UseVisualStyleBackColor = true;
            iconButtonHangNhap.Click += iconButtonHangNhap_Click;
            // 
            // iconButtonHoadonNhap
            // 
            iconButtonHoadonNhap.FlatStyle = FlatStyle.Flat;
            iconButtonHoadonNhap.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            iconButtonHoadonNhap.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            iconButtonHoadonNhap.ForeColor = Color.FromArgb(255, 224, 192);
            iconButtonHoadonNhap.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            iconButtonHoadonNhap.IconColor = Color.FromArgb(255, 224, 192);
            iconButtonHoadonNhap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonHoadonNhap.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonHoadonNhap.Location = new Point(3, 137);
            iconButtonHoadonNhap.Name = "iconButtonHoadonNhap";
            iconButtonHoadonNhap.Padding = new Padding(15, 0, 0, 0);
            iconButtonHoadonNhap.Size = new Size(257, 61);
            iconButtonHoadonNhap.TabIndex = 4;
            iconButtonHoadonNhap.Text = "           Hóa đơn nhập hàng";
            iconButtonHoadonNhap.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonHoadonNhap.UseVisualStyleBackColor = true;
            iconButtonHoadonNhap.Click += iconButtonHoadonNhap_Click;
            // 
            // iconButtonChitietNhap
            // 
            iconButtonChitietNhap.FlatStyle = FlatStyle.Flat;
            iconButtonChitietNhap.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            iconButtonChitietNhap.ForeColor = Color.FromArgb(255, 224, 192);
            iconButtonChitietNhap.IconChar = FontAwesome.Sharp.IconChar.FileText;
            iconButtonChitietNhap.IconColor = Color.FromArgb(255, 224, 192);
            iconButtonChitietNhap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonChitietNhap.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonChitietNhap.Location = new Point(3, 204);
            iconButtonChitietNhap.Name = "iconButtonChitietNhap";
            iconButtonChitietNhap.Padding = new Padding(15, 0, 0, 0);
            iconButtonChitietNhap.Size = new Size(257, 61);
            iconButtonChitietNhap.TabIndex = 2;
            iconButtonChitietNhap.Text = "           Chi tiết hóa đơn";
            iconButtonChitietNhap.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonChitietNhap.UseVisualStyleBackColor = true;
            iconButtonChitietNhap.Click += iconButton5_Click;
            // 
            // iconButtonHoadonBan
            // 
            iconButtonHoadonBan.FlatStyle = FlatStyle.Flat;
            iconButtonHoadonBan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButtonHoadonBan.ForeColor = Color.FromArgb(255, 224, 192);
            iconButtonHoadonBan.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            iconButtonHoadonBan.IconColor = Color.FromArgb(255, 224, 192);
            iconButtonHoadonBan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonHoadonBan.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonHoadonBan.Location = new Point(3, 208);
            iconButtonHoadonBan.Name = "iconButtonHoadonBan";
            iconButtonHoadonBan.Size = new Size(257, 61);
            iconButtonHoadonBan.TabIndex = 3;
            iconButtonHoadonBan.Text = "      Hóa đơn bán";
            iconButtonHoadonBan.UseVisualStyleBackColor = true;
            iconButtonHoadonBan.Click += iconButtonHoadonBan_Click;
            // 
            // iconButtonChitietBan
            // 
            iconButtonChitietBan.FlatStyle = FlatStyle.Flat;
            iconButtonChitietBan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButtonChitietBan.ForeColor = Color.FromArgb(255, 224, 192);
            iconButtonChitietBan.IconChar = FontAwesome.Sharp.IconChar.FileText;
            iconButtonChitietBan.IconColor = Color.FromArgb(255, 224, 192);
            iconButtonChitietBan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonChitietBan.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonChitietBan.Location = new Point(3, 275);
            iconButtonChitietBan.Name = "iconButtonChitietBan";
            iconButtonChitietBan.Size = new Size(257, 61);
            iconButtonChitietBan.TabIndex = 4;
            iconButtonChitietBan.Text = "     Chi tiết bán";
            iconButtonChitietBan.UseVisualStyleBackColor = true;
            iconButtonChitietBan.Click += iconButtonChitietBan_Click;
            // 
            // iconButtonKhachHang
            // 
            iconButtonKhachHang.FlatStyle = FlatStyle.Flat;
            iconButtonKhachHang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButtonKhachHang.ForeColor = Color.FromArgb(255, 224, 192);
            iconButtonKhachHang.IconChar = FontAwesome.Sharp.IconChar.UsersLine;
            iconButtonKhachHang.IconColor = Color.FromArgb(255, 224, 192);
            iconButtonKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonKhachHang.Location = new Point(3, 342);
            iconButtonKhachHang.Name = "iconButtonKhachHang";
            iconButtonKhachHang.Size = new Size(257, 61);
            iconButtonKhachHang.TabIndex = 5;
            iconButtonKhachHang.Text = "     Khách hàng";
            iconButtonKhachHang.UseVisualStyleBackColor = true;
            iconButtonKhachHang.Click += iconButtonKhachHang_Click;
            // 
            // iconButtonNhanVien
            // 
            iconButtonNhanVien.FlatStyle = FlatStyle.Flat;
            iconButtonNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButtonNhanVien.ForeColor = Color.FromArgb(255, 224, 192);
            iconButtonNhanVien.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            iconButtonNhanVien.IconColor = Color.FromArgb(255, 224, 192);
            iconButtonNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonNhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonNhanVien.Location = new Point(3, 409);
            iconButtonNhanVien.Name = "iconButtonNhanVien";
            iconButtonNhanVien.Size = new Size(257, 61);
            iconButtonNhanVien.TabIndex = 6;
            iconButtonNhanVien.Text = "   Nhân viên";
            iconButtonNhanVien.UseVisualStyleBackColor = true;
            iconButtonNhanVien.Click += iconButtonNhanVien_Click;
            // 
            // iconButtonTaiKhoan
            // 
            iconButtonTaiKhoan.FlatStyle = FlatStyle.Flat;
            iconButtonTaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButtonTaiKhoan.ForeColor = Color.FromArgb(255, 224, 192);
            iconButtonTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.Gears;
            iconButtonTaiKhoan.IconColor = Color.FromArgb(255, 224, 192);
            iconButtonTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonTaiKhoan.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonTaiKhoan.Location = new Point(3, 476);
            iconButtonTaiKhoan.Name = "iconButtonTaiKhoan";
            iconButtonTaiKhoan.Size = new Size(257, 61);
            iconButtonTaiKhoan.TabIndex = 7;
            iconButtonTaiKhoan.Text = "  Tài khoản";
            iconButtonTaiKhoan.UseVisualStyleBackColor = true;
            iconButtonTaiKhoan.Click += iconButtonTaiKhoan_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // nhaptimer
            // 
            nhaptimer.Interval = 10;
            nhaptimer.Tick += nhaptimer_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(67, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1116, 70);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1113, 61);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(544, 11);
            label1.Name = "label1";
            label1.Size = new Size(157, 42);
            label1.TabIndex = 0;
            label1.Text = "BraiiPit";
            // 
            // formcha
            // 
            formcha.Controls.Add(pictureBox1);
            formcha.Location = new Point(266, 70);
            formcha.Name = "formcha";
            formcha.Size = new Size(917, 669);
            formcha.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 743);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 57);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(255, 224, 192);
            button1.Location = new Point(1063, 11);
            button1.Name = "button1";
            button1.Padding = new Padding(2, 0, 0, 0);
            button1.Size = new Size(36, 35);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // FormManager
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1182, 739);
            Controls.Add(formcha);
            Controls.Add(sidebarContainer);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormManager";
            sidebarContainer.ResumeLayout(false);
            sidebarNhap.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            formcha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebarContainer;
        private FontAwesome.Sharp.IconButton iconButtonMenu;
        private FlowLayoutPanel sidebarNhap;
        private FontAwesome.Sharp.IconButton buttonNhap;
        private FontAwesome.Sharp.IconButton iconButtonHangNhap;
        private FontAwesome.Sharp.IconButton iconButtonHoadonNhap;
        private FontAwesome.Sharp.IconButton iconButtonChitietNhap;
        private FontAwesome.Sharp.IconButton iconButtonHoadonBan;
        private FontAwesome.Sharp.IconButton iconButtonChitietBan;
        private FontAwesome.Sharp.IconButton iconButtonKhachHang;
        private FontAwesome.Sharp.IconButton iconButtonNhanVien;
        private FontAwesome.Sharp.IconButton iconButtonTaiKhoan;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Timer nhaptimer;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel formcha;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Button button1;
    }
}