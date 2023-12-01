namespace BraiiPit
{
    partial class FormNhapchitiet
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
            textDG = new TextBox();
            textSL = new TextBox();
            textTHN = new TextBox();
            textMHN = new TextBox();
            textCNC = new TextBox();
            label7 = new Label();
            label5 = new Label();
            textTT = new TextBox();
            label6 = new Label();
            label3 = new Label();
            buttontim = new Button();
            buttonrs = new Button();
            buttonxoa = new Button();
            buttonsua = new Button();
            buttonthem = new Button();
            textTim = new TextBox();
            textMNH = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            GridNhapCT = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)GridNhapCT).BeginInit();
            SuspendLayout();
            // 
            // textDG
            // 
            textDG.Location = new Point(566, 456);
            textDG.Name = "textDG";
            textDG.Size = new Size(214, 27);
            textDG.TabIndex = 5;
            // 
            // textSL
            // 
            textSL.Location = new Point(207, 614);
            textSL.Name = "textSL";
            textSL.Size = new Size(214, 27);
            textSL.TabIndex = 4;
            // 
            // textTHN
            // 
            textTHN.Location = new Point(207, 561);
            textTHN.Name = "textTHN";
            textTHN.Size = new Size(214, 27);
            textTHN.TabIndex = 3;
            // 
            // textMHN
            // 
            textMHN.Location = new Point(207, 511);
            textMHN.Name = "textMHN";
            textMHN.Size = new Size(214, 27);
            textMHN.TabIndex = 2;
            // 
            // textCNC
            // 
            textCNC.Location = new Point(566, 511);
            textCNC.Name = "textCNC";
            textCNC.Size = new Size(214, 27);
            textCNC.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(255, 224, 192);
            label7.Location = new Point(439, 514);
            label7.Name = "label7";
            label7.Size = new Size(103, 20);
            label7.TabIndex = 89;
            label7.Text = "Công nợ cũ ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(255, 224, 192);
            label5.Location = new Point(439, 457);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 88;
            label5.Text = "Đơn giá";
            // 
            // textTT
            // 
            textTT.Location = new Point(566, 568);
            textTT.Name = "textTT";
            textTT.Size = new Size(214, 27);
            textTT.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(255, 224, 192);
            label6.Location = new Point(439, 568);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 86;
            label6.Text = "Tổng cộng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 224, 192);
            label3.Location = new Point(27, 621);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 85;
            label3.Text = "Số lượng";
            // 
            // buttontim
            // 
            buttontim.BackColor = Color.FromArgb(255, 224, 192);
            buttontim.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttontim.ForeColor = Color.IndianRed;
            buttontim.Location = new Point(698, 624);
            buttontim.Name = "buttontim";
            buttontim.Size = new Size(88, 39);
            buttontim.TabIndex = 9;
            buttontim.Text = "Tìm";
            buttontim.UseVisualStyleBackColor = false;
            buttontim.Click += buttontim_Click;
            // 
            // buttonrs
            // 
            buttonrs.BackColor = Color.FromArgb(255, 224, 192);
            buttonrs.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonrs.ForeColor = Color.IndianRed;
            buttonrs.Location = new Point(820, 623);
            buttonrs.Name = "buttonrs";
            buttonrs.Size = new Size(88, 39);
            buttonrs.TabIndex = 13;
            buttonrs.Text = "Reset";
            buttonrs.UseVisualStyleBackColor = false;
            buttonrs.Click += buttonrs_Click;
            // 
            // buttonxoa
            // 
            buttonxoa.BackColor = Color.FromArgb(255, 224, 192);
            buttonxoa.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonxoa.ForeColor = Color.IndianRed;
            buttonxoa.Location = new Point(820, 505);
            buttonxoa.Name = "buttonxoa";
            buttonxoa.Size = new Size(88, 39);
            buttonxoa.TabIndex = 11;
            buttonxoa.Text = "Xóa";
            buttonxoa.UseVisualStyleBackColor = false;
            buttonxoa.Click += buttonxoa_Click;
            // 
            // buttonsua
            // 
            buttonsua.BackColor = Color.FromArgb(255, 224, 192);
            buttonsua.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonsua.ForeColor = Color.IndianRed;
            buttonsua.Location = new Point(820, 565);
            buttonsua.Name = "buttonsua";
            buttonsua.Size = new Size(88, 39);
            buttonsua.TabIndex = 12;
            buttonsua.Text = "Sửa ";
            buttonsua.UseVisualStyleBackColor = false;
            buttonsua.Click += buttonsua_Click;
            // 
            // buttonthem
            // 
            buttonthem.BackColor = Color.FromArgb(255, 224, 192);
            buttonthem.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonthem.ForeColor = Color.IndianRed;
            buttonthem.Location = new Point(820, 446);
            buttonthem.Name = "buttonthem";
            buttonthem.Size = new Size(88, 39);
            buttonthem.TabIndex = 10;
            buttonthem.Text = "Thêm";
            buttonthem.UseVisualStyleBackColor = false;
            buttonthem.Click += buttonthem_Click;
            // 
            // textTim
            // 
            textTim.Location = new Point(501, 630);
            textTim.Multiline = true;
            textTim.Name = "textTim";
            textTim.PlaceholderText = "Tìm theo mã nhập hàng";
            textTim.Size = new Size(172, 27);
            textTim.TabIndex = 8;
            // 
            // textMNH
            // 
            textMNH.Location = new Point(207, 456);
            textMNH.Name = "textMNH";
            textMNH.Size = new Size(214, 27);
            textMNH.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(255, 224, 192);
            label4.Location = new Point(27, 568);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 77;
            label4.Text = "Tên hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 224, 192);
            label2.Location = new Point(27, 514);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 76;
            label2.Text = "Mã hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 224, 192);
            label1.Location = new Point(27, 459);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 75;
            label1.Text = "Mã nhập hàng";
            // 
            // GridNhapCT
            // 
            GridNhapCT.BackgroundColor = Color.White;
            GridNhapCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridNhapCT.Location = new Point(0, 0);
            GridNhapCT.Name = "GridNhapCT";
            GridNhapCT.RowHeadersWidth = 51;
            GridNhapCT.RowTemplate.Height = 29;
            GridNhapCT.Size = new Size(921, 435);
            GridNhapCT.TabIndex = 74;
            GridNhapCT.Tag = "";
            GridNhapCT.CellClick += GridNhapCT_CellClick;
            // 
            // FormNhapchitiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(920, 669);
            Controls.Add(textDG);
            Controls.Add(textSL);
            Controls.Add(textTHN);
            Controls.Add(textMHN);
            Controls.Add(textCNC);
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
            Controls.Add(textMNH);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GridNhapCT);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormNhapchitiet";
            Text = "FormNhapchitiet";
            Load += FormNhapchitiet_Load;
            ((System.ComponentModel.ISupportInitialize)GridNhapCT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textDG;
        private TextBox textSL;
        private TextBox textTHN;
        private TextBox textMHN;
        private TextBox textCNC;
        private Label label7;
        private Label label5;
        private TextBox textTT;
        private Label label6;
        private Label label3;
        private Button buttontim;
        private Button buttonrs;
        private Button buttonxoa;
        private Button buttonsua;
        private Button buttonthem;
        private TextBox textTim;
        private TextBox textMNH;
        private Label label4;
        private Label label2;
        private Label label1;
        private DataGridView GridNhapCT;
    }
}