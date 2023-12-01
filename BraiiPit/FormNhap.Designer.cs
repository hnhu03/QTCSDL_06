namespace BraiiPit
{
    partial class FormNhap
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
            textMNV = new TextBox();
            textMNH = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            GridNhap = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)GridNhap).BeginInit();
            SuspendLayout();
            // 
            // textTT
            // 
            textTT.Location = new Point(185, 604);
            textTT.Name = "textTT";
            textTT.Size = new Size(214, 27);
            textTT.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 224, 192);
            label3.Location = new Point(36, 607);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 43;
            label3.Text = "Tổng tiền";
            // 
            // buttontim
            // 
            buttontim.BackColor = Color.FromArgb(255, 224, 192);
            buttontim.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttontim.ForeColor = Color.IndianRed;
            buttontim.Location = new Point(464, 451);
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
            buttonrs.Location = new Point(820, 593);
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
            buttonxoa.Location = new Point(705, 593);
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
            buttonsua.Location = new Point(586, 593);
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
            buttonthem.Location = new Point(464, 593);
            buttonthem.Name = "buttonthem";
            buttonthem.Size = new Size(88, 39);
            buttonthem.TabIndex = 38;
            buttonthem.Text = "Thêm";
            buttonthem.UseVisualStyleBackColor = false;
            buttonthem.Click += buttonthem_Click;
            // 
            // textTim
            // 
            textTim.Location = new Point(576, 457);
            textTim.Multiline = true;
            textTim.Name = "textTim";
            textTim.PlaceholderText = "Tìm theo mã nhập hàng";
            textTim.Size = new Size(332, 27);
            textTim.TabIndex = 37;
            // 
            // textTG
            // 
            textTG.Location = new Point(185, 556);
            textTG.Name = "textTG";
            textTG.Size = new Size(214, 27);
            textTG.TabIndex = 36;
            // 
            // textMNV
            // 
            textMNV.Location = new Point(185, 507);
            textMNV.Name = "textMNV";
            textMNV.Size = new Size(214, 27);
            textMNV.TabIndex = 35;
            // 
            // textMNH
            // 
            textMNH.Location = new Point(185, 457);
            textMNH.Name = "textMNH";
            textMNH.Size = new Size(214, 27);
            textMNH.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(255, 224, 192);
            label4.Location = new Point(36, 559);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 33;
            label4.Text = "Ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 224, 192);
            label2.Location = new Point(35, 510);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 32;
            label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 224, 192);
            label1.Location = new Point(35, 460);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 31;
            label1.Text = "Mã nhập hàng";
            // 
            // GridNhap
            // 
            GridNhap.BackgroundColor = Color.White;
            GridNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridNhap.Location = new Point(0, 1);
            GridNhap.Name = "GridNhap";
            GridNhap.RowHeadersWidth = 51;
            GridNhap.RowTemplate.Height = 29;
            GridNhap.Size = new Size(921, 435);
            GridNhap.TabIndex = 30;
            GridNhap.Tag = "";
            GridNhap.CellClick += GridNhap_CellClick;
            // 
            // FormNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(920, 669);
            Controls.Add(textTT);
            Controls.Add(label3);
            Controls.Add(buttontim);
            Controls.Add(buttonrs);
            Controls.Add(buttonxoa);
            Controls.Add(buttonsua);
            Controls.Add(buttonthem);
            Controls.Add(textTim);
            Controls.Add(textTG);
            Controls.Add(textMNV);
            Controls.Add(textMNH);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GridNhap);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormNhap";
            Text = "FormNhap";
            Load += FormNhap_Load;
            ((System.ComponentModel.ISupportInitialize)GridNhap).EndInit();
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
        private TextBox textMNV;
        private TextBox textMNH;
        private Label label4;
        private Label label2;
        private Label label1;
        private DataGridView GridNhap;
    }
}