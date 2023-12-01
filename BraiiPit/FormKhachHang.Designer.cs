namespace BraiiPit
{
    partial class FormKhachHang
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
            buttontim = new Button();
            buttonrs = new Button();
            buttonxoa = new Button();
            buttonsua = new Button();
            buttonthem = new Button();
            textTim = new TextBox();
            textDC = new TextBox();
            textTKH = new TextBox();
            textMKH = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            GridKhachHang = new DataGridView();
            textSDT = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)GridKhachHang).BeginInit();
            SuspendLayout();
            // 
            // buttontim
            // 
            buttontim.BackColor = Color.FromArgb(255, 224, 192);
            buttontim.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttontim.ForeColor = Color.IndianRed;
            buttontim.Location = new Point(463, 450);
            buttontim.Name = "buttontim";
            buttontim.Size = new Size(88, 39);
            buttontim.TabIndex = 27;
            buttontim.Text = "Tìm";
            buttontim.UseVisualStyleBackColor = false;
            buttontim.Click += buttontim_Click;
            // 
            // buttonrs
            // 
            buttonrs.BackColor = Color.FromArgb(255, 224, 192);
            buttonrs.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonrs.ForeColor = Color.IndianRed;
            buttonrs.Location = new Point(819, 592);
            buttonrs.Name = "buttonrs";
            buttonrs.Size = new Size(88, 39);
            buttonrs.TabIndex = 26;
            buttonrs.Text = "Reset";
            buttonrs.UseVisualStyleBackColor = false;
            buttonrs.Click += buttonrs_Click;
            // 
            // buttonxoa
            // 
            buttonxoa.BackColor = Color.FromArgb(255, 224, 192);
            buttonxoa.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonxoa.ForeColor = Color.IndianRed;
            buttonxoa.Location = new Point(704, 592);
            buttonxoa.Name = "buttonxoa";
            buttonxoa.Size = new Size(88, 39);
            buttonxoa.TabIndex = 25;
            buttonxoa.Text = "Xóa";
            buttonxoa.UseVisualStyleBackColor = false;
            buttonxoa.Click += buttonxoa_Click;
            // 
            // buttonsua
            // 
            buttonsua.BackColor = Color.FromArgb(255, 224, 192);
            buttonsua.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonsua.ForeColor = Color.IndianRed;
            buttonsua.Location = new Point(585, 592);
            buttonsua.Name = "buttonsua";
            buttonsua.Size = new Size(88, 39);
            buttonsua.TabIndex = 24;
            buttonsua.Text = "Sửa ";
            buttonsua.UseVisualStyleBackColor = false;
            buttonsua.Click += buttonsua_Click;
            // 
            // buttonthem
            // 
            buttonthem.BackColor = Color.FromArgb(255, 224, 192);
            buttonthem.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonthem.ForeColor = Color.IndianRed;
            buttonthem.Location = new Point(463, 592);
            buttonthem.Name = "buttonthem";
            buttonthem.Size = new Size(88, 39);
            buttonthem.TabIndex = 23;
            buttonthem.Text = "Thêm";
            buttonthem.UseVisualStyleBackColor = false;
            buttonthem.Click += buttonthem_Click;
            // 
            // textTim
            // 
            textTim.Location = new Point(575, 456);
            textTim.Multiline = true;
            textTim.Name = "textTim";
            textTim.PlaceholderText = "Tìm theo tên khách hàng";
            textTim.Size = new Size(332, 27);
            textTim.TabIndex = 22;
            // 
            // textDC
            // 
            textDC.Location = new Point(184, 555);
            textDC.Name = "textDC";
            textDC.Size = new Size(214, 27);
            textDC.TabIndex = 21;
            // 
            // textTKH
            // 
            textTKH.Location = new Point(184, 506);
            textTKH.Name = "textTKH";
            textTKH.Size = new Size(214, 27);
            textTKH.TabIndex = 20;
            // 
            // textMKH
            // 
            textMKH.Location = new Point(184, 456);
            textMKH.Name = "textMKH";
            textMKH.Size = new Size(214, 27);
            textMKH.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(255, 224, 192);
            label4.Location = new Point(35, 558);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 18;
            label4.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 224, 192);
            label2.Location = new Point(34, 509);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 17;
            label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 224, 192);
            label1.Location = new Point(34, 459);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 16;
            label1.Text = "Mã khách hàng";
            // 
            // GridKhachHang
            // 
            GridKhachHang.BackgroundColor = Color.White;
            GridKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridKhachHang.Location = new Point(-1, 0);
            GridKhachHang.Name = "GridKhachHang";
            GridKhachHang.RowHeadersWidth = 51;
            GridKhachHang.RowTemplate.Height = 29;
            GridKhachHang.Size = new Size(921, 435);
            GridKhachHang.TabIndex = 15;
            GridKhachHang.Tag = "";
            GridKhachHang.CellClick += GridKhachHang_CellClick;
            // 
            // textSDT
            // 
            textSDT.Location = new Point(184, 603);
            textSDT.Name = "textSDT";
            textSDT.Size = new Size(214, 27);
            textSDT.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 224, 192);
            label3.Location = new Point(35, 606);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 28;
            label3.Text = "Số điện thoại";
            // 
            // FormKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(920, 669);
            Controls.Add(textSDT);
            Controls.Add(label3);
            Controls.Add(buttontim);
            Controls.Add(buttonrs);
            Controls.Add(buttonxoa);
            Controls.Add(buttonsua);
            Controls.Add(buttonthem);
            Controls.Add(textTim);
            Controls.Add(textDC);
            Controls.Add(textTKH);
            Controls.Add(textMKH);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GridKhachHang);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormKhachHang";
            Text = "FormKhachHang";
            Load += FormKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)GridKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttontim;
        private Button buttonrs;
        private Button buttonxoa;
        private Button buttonsua;
        private Button buttonthem;
        private TextBox textTim;
        private TextBox textDC;
        private TextBox textTKH;
        private TextBox textMKH;
        private Label label4;
        private Label label2;
        private Label label1;
        private DataGridView GridKhachHang;
        private TextBox textSDT;
        private Label label3;
    }
}