namespace BraiiPit
{
    partial class FormHangNhapVao
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
            textDG = new TextBox();
            textTHN = new TextBox();
            textMHN = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            GridHangNhap = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)GridHangNhap).BeginInit();
            SuspendLayout();
            // 
            // buttontim
            // 
            buttontim.BackColor = Color.FromArgb(255, 224, 192);
            buttontim.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttontim.ForeColor = Color.IndianRed;
            buttontim.Location = new Point(463, 448);
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
            buttonrs.Location = new Point(819, 590);
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
            buttonxoa.Location = new Point(704, 590);
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
            buttonsua.Location = new Point(585, 590);
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
            buttonthem.Location = new Point(463, 590);
            buttonthem.Name = "buttonthem";
            buttonthem.Size = new Size(88, 39);
            buttonthem.TabIndex = 23;
            buttonthem.Text = "Thêm";
            buttonthem.UseVisualStyleBackColor = false;
            buttonthem.Click += buttonthem_Click;
            // 
            // textTim
            // 
            textTim.Location = new Point(575, 454);
            textTim.Multiline = true;
            textTim.Name = "textTim";
            textTim.PlaceholderText = "Tìm theo tên hàng ";
            textTim.Size = new Size(332, 27);
            textTim.TabIndex = 22;
            // 
            // textDG
            // 
            textDG.Location = new Point(177, 606);
            textDG.Name = "textDG";
            textDG.Size = new Size(214, 27);
            textDG.TabIndex = 21;
            // 
            // textTHN
            // 
            textTHN.Location = new Point(177, 531);
            textTHN.Name = "textTHN";
            textTHN.Size = new Size(214, 27);
            textTHN.TabIndex = 20;
            // 
            // textMHN
            // 
            textMHN.Location = new Point(177, 454);
            textMHN.Name = "textMHN";
            textMHN.Size = new Size(214, 27);
            textMHN.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(255, 224, 192);
            label4.Location = new Point(41, 609);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 18;
            label4.Text = "Đơn giá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 224, 192);
            label2.Location = new Point(39, 534);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 17;
            label2.Text = "Tên hàng nhập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 224, 192);
            label1.Location = new Point(39, 457);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 16;
            label1.Text = "Mã hàng nhập";
            // 
            // GridHangNhap
            // 
            GridHangNhap.BackgroundColor = Color.White;
            GridHangNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridHangNhap.Location = new Point(-1, -2);
            GridHangNhap.Name = "GridHangNhap";
            GridHangNhap.RowHeadersWidth = 51;
            GridHangNhap.RowTemplate.Height = 29;
            GridHangNhap.Size = new Size(921, 435);
            GridHangNhap.TabIndex = 15;
            GridHangNhap.Tag = "";
            GridHangNhap.CellClick += GridHangNhapVao_CellClick;
            // 
            // FormHangNhapVao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(920, 669);
            Controls.Add(buttontim);
            Controls.Add(buttonrs);
            Controls.Add(buttonxoa);
            Controls.Add(buttonsua);
            Controls.Add(buttonthem);
            Controls.Add(textTim);
            Controls.Add(textDG);
            Controls.Add(textTHN);
            Controls.Add(textMHN);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GridHangNhap);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHangNhapVao";
            Text = "FormHangNhapVao";
            Load += FormHangNhapVao_Load;
            ((System.ComponentModel.ISupportInitialize)GridHangNhap).EndInit();
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
        private TextBox textDG;
        private TextBox textTHN;
        private TextBox textMHN;
        private Label label4;
        private Label label2;
        private Label label1;
        private DataGridView GridHangNhap;
    }
}