namespace BraiiPit
{
    partial class FormTaiKhoan
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
            textMK = new TextBox();
            textTK = new TextBox();
            label2 = new Label();
            label1 = new Label();
            GridTaiKhoan = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)GridTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // buttontim
            // 
            buttontim.BackColor = Color.FromArgb(255, 224, 192);
            buttontim.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttontim.ForeColor = Color.IndianRed;
            buttontim.Location = new Point(464, 450);
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
            buttonrs.Location = new Point(820, 592);
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
            buttonxoa.Location = new Point(705, 592);
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
            buttonsua.Location = new Point(586, 592);
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
            buttonthem.Location = new Point(464, 592);
            buttonthem.Name = "buttonthem";
            buttonthem.Size = new Size(88, 39);
            buttonthem.TabIndex = 23;
            buttonthem.Text = "Thêm";
            buttonthem.UseVisualStyleBackColor = false;
            buttonthem.Click += buttonthem_Click;
            // 
            // textTim
            // 
            textTim.Location = new Point(576, 456);
            textTim.Multiline = true;
            textTim.Name = "textTim";
            textTim.PlaceholderText = "Tìm theo tên tài khoản ";
            textTim.Size = new Size(332, 27);
            textTim.TabIndex = 22;
            // 
            // textMK
            // 
            textMK.Location = new Point(135, 533);
            textMK.Name = "textMK";
            textMK.Size = new Size(214, 27);
            textMK.TabIndex = 20;
            // 
            // textTK
            // 
            textTK.Location = new Point(135, 456);
            textTK.Name = "textTK";
            textTK.Size = new Size(214, 27);
            textTK.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 224, 192);
            label2.Location = new Point(40, 536);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 17;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 224, 192);
            label1.Location = new Point(40, 459);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 16;
            label1.Text = "Tài khoản";
            // 
            // GridTaiKhoan
            // 
            GridTaiKhoan.BackgroundColor = Color.White;
            GridTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridTaiKhoan.Location = new Point(0, 0);
            GridTaiKhoan.Name = "GridTaiKhoan";
            GridTaiKhoan.RowHeadersWidth = 51;
            GridTaiKhoan.RowTemplate.Height = 29;
            GridTaiKhoan.Size = new Size(921, 435);
            GridTaiKhoan.TabIndex = 15;
            GridTaiKhoan.Tag = "";
            GridTaiKhoan.CellClick += GridTaiKhoan_CellClick;
            // 
            // FormTaiKhoan
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
            Controls.Add(textMK);
            Controls.Add(textTK);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GridTaiKhoan);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTaiKhoan";
            Text = "FormTaiKhoan";
            Load += FormTaiKhoan_Load;
            ((System.ComponentModel.ISupportInitialize)GridTaiKhoan).EndInit();
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
        private TextBox textMK;
        private TextBox textTK;
        private Label label2;
        private Label label1;
        private DataGridView GridTaiKhoan;
    }
}