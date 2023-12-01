namespace BraiiPit
{
    partial class FormBan
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
            textTT = new TextBox();
            label3 = new Label();
            buttontim = new Button();
            buttonrs = new Button();
            buttonxoa = new Button();
            buttonsua = new Button();
            buttonthem = new Button();
            textTim = new TextBox();
            textTG = new TextBox();
            textMKH = new TextBox();
            textMHD = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            GridBan = new DataGridView();
            textTC = new TextBox();
            label5 = new Label();
            textVAT = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)GridBan).BeginInit();
            SuspendLayout();
            // 
            // textTT
            // 
            textTT.Location = new Point(207, 590);
            textTT.Name = "textTT";
            textTT.Size = new Size(214, 27);
            textTT.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 224, 192);
            label3.Location = new Point(28, 593);
            label3.Name = "label3";
            label3.Size = new Size(177, 20);
            label3.TabIndex = 43;
            label3.Text = "Tổng tiền (chưa VAT)";
            // 
            // buttontim
            // 
            buttontim.BackColor = Color.FromArgb(255, 224, 192);
            buttontim.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttontim.ForeColor = Color.IndianRed;
            buttontim.Location = new Point(698, 624);
            buttontim.Name = "buttontim";
            buttontim.Size = new Size(88, 39);
            buttontim.TabIndex = 42;
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
            buttonrs.TabIndex = 41;
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
            buttonxoa.TabIndex = 40;
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
            buttonsua.TabIndex = 39;
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
            buttonthem.TabIndex = 38;
            buttonthem.Text = "Thêm";
            buttonthem.UseVisualStyleBackColor = false;
            buttonthem.Click += buttonthem_Click;
            // 
            // textTim
            // 
            textTim.Location = new Point(522, 632);
            textTim.Multiline = true;
            textTim.Name = "textTim";
            textTim.PlaceholderText = "Tìm theo mã hóa đơn ";
            textTim.Size = new Size(151, 27);
            textTim.TabIndex = 37;
            // 
            // textTG
            // 
            textTG.Location = new Point(207, 546);
            textTG.Name = "textTG";
            textTG.Size = new Size(214, 27);
            textTG.TabIndex = 36;
            // 
            // textMKH
            // 
            textMKH.Location = new Point(207, 501);
            textMKH.Name = "textMKH";
            textMKH.Size = new Size(214, 27);
            textMKH.TabIndex = 35;
            // 
            // textMHD
            // 
            textMHD.Location = new Point(207, 456);
            textMHD.Name = "textMHD";
            textMHD.Size = new Size(214, 27);
            textMHD.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(255, 224, 192);
            label4.Location = new Point(28, 549);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 33;
            label4.Text = "Thời gian";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 224, 192);
            label2.Location = new Point(27, 504);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 32;
            label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 224, 192);
            label1.Location = new Point(27, 459);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 31;
            label1.Text = "Mã hóa đơn ";
            // 
            // GridBan
            // 
            GridBan.BackgroundColor = Color.White;
            GridBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridBan.Location = new Point(0, 0);
            GridBan.Name = "GridBan";
            GridBan.RowHeadersWidth = 51;
            GridBan.RowTemplate.Height = 29;
            GridBan.Size = new Size(921, 435);
            GridBan.TabIndex = 30;
            GridBan.Tag = "";
            GridBan.CellClick += GridBan_CellClick;
            // 
            // textTC
            // 
            textTC.Location = new Point(566, 454);
            textTC.Name = "textTC";
            textTC.Size = new Size(217, 27);
            textTC.TabIndex = 48;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(255, 224, 192);
            label5.Location = new Point(439, 457);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 47;
            label5.Text = "Tổng cộng";
            // 
            // textVAT
            // 
            textVAT.Location = new Point(207, 633);
            textVAT.Name = "textVAT";
            textVAT.Size = new Size(214, 27);
            textVAT.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(255, 224, 192);
            label6.Location = new Point(28, 636);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 45;
            label6.Text = "VAT";
            // 
            // FormBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(920, 669);
            Controls.Add(textTC);
            Controls.Add(label5);
            Controls.Add(textVAT);
            Controls.Add(label6);
            Controls.Add(textTT);
            Controls.Add(label3);
            Controls.Add(buttontim);
            Controls.Add(buttonrs);
            Controls.Add(buttonxoa);
            Controls.Add(buttonsua);
            Controls.Add(buttonthem);
            Controls.Add(textTim);
            Controls.Add(textTG);
            Controls.Add(textMKH);
            Controls.Add(textMHD);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GridBan);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBan";
            Text = "FormBan";
            Load += FormBan_Load;
            ((System.ComponentModel.ISupportInitialize)GridBan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textTT;
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
        private DataGridView GridBan;
        private TextBox textTC;
        private Label label5;
        private TextBox textVAT;
        private Label label6;
    }
}