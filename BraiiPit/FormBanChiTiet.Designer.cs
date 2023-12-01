namespace BraiiPit
{
    partial class FormBanChiTiet
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
            label5 = new Label();
            label3 = new Label();
            buttontim = new Button();
            buttonrs = new Button();
            buttonxoa = new Button();
            buttonsua = new Button();
            buttonthem = new Button();
            textTim = new TextBox();
            textMHD = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            GridBanCT = new DataGridView();
            textSL = new TextBox();
            label7 = new Label();
            label6 = new Label();
            textTT = new TextBox();
            textMM = new TextBox();
            textTM = new TextBox();
            textMNV = new TextBox();
            textDG = new TextBox();
            ((System.ComponentModel.ISupportInitialize)GridBanCT).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(255, 224, 192);
            label5.Location = new Point(439, 460);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 66;
            label5.Text = "Đơn giá";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 224, 192);
            label3.Location = new Point(27, 624);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 62;
            label3.Text = "Mã nhân viên";
            // 
            // buttontim
            // 
            buttontim.BackColor = Color.FromArgb(255, 224, 192);
            buttontim.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttontim.ForeColor = Color.IndianRed;
            buttontim.Location = new Point(698, 627);
            buttontim.Name = "buttontim";
            buttontim.Size = new Size(88, 39);
            buttontim.TabIndex = 61;
            buttontim.Text = "Tìm";
            buttontim.UseVisualStyleBackColor = false;
            buttontim.Click += buttontim_Click;
            // 
            // buttonrs
            // 
            buttonrs.BackColor = Color.FromArgb(255, 224, 192);
            buttonrs.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonrs.ForeColor = Color.IndianRed;
            buttonrs.Location = new Point(820, 626);
            buttonrs.Name = "buttonrs";
            buttonrs.Size = new Size(88, 39);
            buttonrs.TabIndex = 60;
            buttonrs.Text = "Reset";
            buttonrs.UseVisualStyleBackColor = false;
            buttonrs.Click += buttonrs_Click;
            // 
            // buttonxoa
            // 
            buttonxoa.BackColor = Color.FromArgb(255, 224, 192);
            buttonxoa.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonxoa.ForeColor = Color.IndianRed;
            buttonxoa.Location = new Point(820, 508);
            buttonxoa.Name = "buttonxoa";
            buttonxoa.Size = new Size(88, 39);
            buttonxoa.TabIndex = 59;
            buttonxoa.Text = "Xóa";
            buttonxoa.UseVisualStyleBackColor = false;
            buttonxoa.Click += buttonxoa_Click;
            // 
            // buttonsua
            // 
            buttonsua.BackColor = Color.FromArgb(255, 224, 192);
            buttonsua.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonsua.ForeColor = Color.IndianRed;
            buttonsua.Location = new Point(820, 568);
            buttonsua.Name = "buttonsua";
            buttonsua.Size = new Size(88, 39);
            buttonsua.TabIndex = 58;
            buttonsua.Text = "Sửa ";
            buttonsua.UseVisualStyleBackColor = false;
            buttonsua.Click += buttonsua_Click;
            // 
            // buttonthem
            // 
            buttonthem.BackColor = Color.FromArgb(255, 224, 192);
            buttonthem.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonthem.ForeColor = Color.IndianRed;
            buttonthem.Location = new Point(820, 449);
            buttonthem.Name = "buttonthem";
            buttonthem.Size = new Size(88, 39);
            buttonthem.TabIndex = 57;
            buttonthem.Text = "Thêm";
            buttonthem.UseVisualStyleBackColor = false;
            buttonthem.Click += buttonthem_Click;
            // 
            // textTim
            // 
            textTim.Location = new Point(520, 633);
            textTim.Multiline = true;
            textTim.Name = "textTim";
            textTim.PlaceholderText = "Tìm theo mã hóa đơn ";
            textTim.Size = new Size(153, 27);
            textTim.TabIndex = 56;
            // 
            // textMHD
            // 
            textMHD.Location = new Point(207, 459);
            textMHD.Name = "textMHD";
            textMHD.Size = new Size(214, 27);
            textMHD.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(255, 224, 192);
            label4.Location = new Point(27, 571);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 52;
            label4.Text = "Tên món";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 224, 192);
            label2.Location = new Point(27, 517);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 51;
            label2.Text = "Mã món";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 224, 192);
            label1.Location = new Point(27, 462);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 50;
            label1.Text = "Mã hóa đơn ";
            // 
            // GridBanCT
            // 
            GridBanCT.BackgroundColor = Color.White;
            GridBanCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridBanCT.Location = new Point(0, 3);
            GridBanCT.Name = "GridBanCT";
            GridBanCT.RowHeadersWidth = 51;
            GridBanCT.RowTemplate.Height = 29;
            GridBanCT.Size = new Size(921, 435);
            GridBanCT.TabIndex = 49;
            GridBanCT.Tag = "";
            GridBanCT.CellClick += GridBanCT_CellClick;
            // 
            // textSL
            // 
            textSL.Location = new Point(566, 514);
            textSL.Name = "textSL";
            textSL.Size = new Size(214, 27);
            textSL.TabIndex = 69;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(255, 224, 192);
            label7.Location = new Point(439, 517);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 68;
            label7.Text = "Số lượng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(255, 224, 192);
            label6.Location = new Point(439, 571);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 64;
            label6.Text = "Tổng cộng";
            // 
            // textTT
            // 
            textTT.Location = new Point(566, 571);
            textTT.Name = "textTT";
            textTT.Size = new Size(214, 27);
            textTT.TabIndex = 65;
            // 
            // textMM
            // 
            textMM.Location = new Point(207, 514);
            textMM.Name = "textMM";
            textMM.Size = new Size(214, 27);
            textMM.TabIndex = 70;
            // 
            // textTM
            // 
            textTM.Location = new Point(207, 564);
            textTM.Name = "textTM";
            textTM.Size = new Size(214, 27);
            textTM.TabIndex = 71;
            // 
            // textMNV
            // 
            textMNV.Location = new Point(207, 617);
            textMNV.Name = "textMNV";
            textMNV.Size = new Size(214, 27);
            textMNV.TabIndex = 72;
            // 
            // textDG
            // 
            textDG.Location = new Point(566, 459);
            textDG.Name = "textDG";
            textDG.Size = new Size(214, 27);
            textDG.TabIndex = 73;
            // 
            // FormBanChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(920, 669);
            Controls.Add(textDG);
            Controls.Add(textMNV);
            Controls.Add(textTM);
            Controls.Add(textMM);
            Controls.Add(textSL);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(textTT);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(buttontim);
            Controls.Add(buttonrs);
            Controls.Add(buttonxoa);
            Controls.Add(buttonsua);
            Controls.Add(buttonthem);
            Controls.Add(textTim);
            Controls.Add(textMHD);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GridBanCT);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBanChiTiet";
            Text = "FormBanChiTiet";
            Load += FormBanChiTiet_Load;
            ((System.ComponentModel.ISupportInitialize)GridBanCT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textTC;
        private Label label5;
        private TextBox textVAT;
        private Label label3;
        private Button buttontim;
        private Button buttonrs;
        private Button buttonxoa;
        private Button buttonsua;
        private Button buttonthem;
        private TextBox textTim;
        private TextBox textTG;
        private TextBox textMKH;
        private TextBox textMHD;
        private Label label4;
        private Label label2;
        private Label label1;
        private DataGridView GridBanCT;
        private TextBox textSL;
        private Label label7;
        private Label label6;
        private TextBox textTT;
        private TextBox textBox2;
        private Label label8;
        private TextBox textMM;
        private TextBox textTM;
        private TextBox textMNV;
        private TextBox textDG;
    }
}