namespace BraiiPit
{
    partial class FormMenu
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
            GridMon = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            textMM = new TextBox();
            textTM = new TextBox();
            textDG = new TextBox();
            textTim = new TextBox();
            buttonthem = new Button();
            buttonsua = new Button();
            buttonxoa = new Button();
            buttonrs = new Button();
            buttontim = new Button();
            ((System.ComponentModel.ISupportInitialize)GridMon).BeginInit();
            SuspendLayout();
            // 
            // GridMon
            // 
            GridMon.BackgroundColor = Color.White;
            GridMon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridMon.Location = new Point(0, -1);
            GridMon.Name = "GridMon";
            GridMon.RowHeadersWidth = 51;
            GridMon.RowTemplate.Height = 29;
            GridMon.Size = new Size(921, 435);
            GridMon.TabIndex = 0;
            GridMon.Tag = "";
            GridMon.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 224, 192);
            label1.Location = new Point(40, 458);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã món ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 224, 192);
            label2.Location = new Point(40, 535);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên món ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(255, 224, 192);
            label4.Location = new Point(40, 610);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 4;
            label4.Text = "Đơn giá";
            // 
            // textMM
            // 
            textMM.Location = new Point(135, 455);
            textMM.Name = "textMM";
            textMM.Size = new Size(214, 27);
            textMM.TabIndex = 5;
            // 
            // textTM
            // 
            textTM.Location = new Point(135, 532);
            textTM.Name = "textTM";
            textTM.Size = new Size(214, 27);
            textTM.TabIndex = 6;
            // 
            // textDG
            // 
            textDG.Location = new Point(135, 607);
            textDG.Name = "textDG";
            textDG.Size = new Size(214, 27);
            textDG.TabIndex = 7;
            // 
            // textTim
            // 
            textTim.Location = new Point(576, 455);
            textTim.Multiline = true;
            textTim.Name = "textTim";
            textTim.PlaceholderText = "Tìm theo tên món ";
            textTim.Size = new Size(332, 27);
            textTim.TabIndex = 8;
            // 
            // buttonthem
            // 
            buttonthem.BackColor = Color.FromArgb(255, 224, 192);
            buttonthem.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonthem.ForeColor = Color.IndianRed;
            buttonthem.Location = new Point(464, 591);
            buttonthem.Name = "buttonthem";
            buttonthem.Size = new Size(88, 39);
            buttonthem.TabIndex = 9;
            buttonthem.Text = "Thêm";
            buttonthem.UseVisualStyleBackColor = false;
            buttonthem.Click += buttonthem_Click;
            // 
            // buttonsua
            // 
            buttonsua.BackColor = Color.FromArgb(255, 224, 192);
            buttonsua.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonsua.ForeColor = Color.IndianRed;
            buttonsua.Location = new Point(586, 591);
            buttonsua.Name = "buttonsua";
            buttonsua.Size = new Size(88, 39);
            buttonsua.TabIndex = 10;
            buttonsua.Text = "Sửa ";
            buttonsua.UseVisualStyleBackColor = false;
            buttonsua.Click += buttonsua_Click;
            // 
            // buttonxoa
            // 
            buttonxoa.BackColor = Color.FromArgb(255, 224, 192);
            buttonxoa.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonxoa.ForeColor = Color.IndianRed;
            buttonxoa.Location = new Point(705, 591);
            buttonxoa.Name = "buttonxoa";
            buttonxoa.Size = new Size(88, 39);
            buttonxoa.TabIndex = 11;
            buttonxoa.Text = "Xóa";
            buttonxoa.UseVisualStyleBackColor = false;
            buttonxoa.Click += buttonxoa_Click;
            // 
            // buttonrs
            // 
            buttonrs.BackColor = Color.FromArgb(255, 224, 192);
            buttonrs.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonrs.ForeColor = Color.IndianRed;
            buttonrs.Location = new Point(820, 591);
            buttonrs.Name = "buttonrs";
            buttonrs.Size = new Size(88, 39);
            buttonrs.TabIndex = 12;
            buttonrs.Text = "Reset";
            buttonrs.UseVisualStyleBackColor = false;
            buttonrs.Click += buttonrs_Click;
            // 
            // buttontim
            // 
            buttontim.BackColor = Color.FromArgb(255, 224, 192);
            buttontim.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttontim.ForeColor = Color.IndianRed;
            buttontim.Location = new Point(464, 449);
            buttontim.Name = "buttontim";
            buttontim.Size = new Size(88, 39);
            buttontim.TabIndex = 14;
            buttontim.Text = "Tìm";
            buttontim.UseVisualStyleBackColor = false;
            buttontim.Click += button5_Click;
            // 
            // FormMenu
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
            Controls.Add(textTM);
            Controls.Add(textMM);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GridMon);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            Text = "FormMenucs";
            Load += FormMenu_Load_1;
            ((System.ComponentModel.ISupportInitialize)GridMon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GridMon;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox textMM;
        private TextBox textTM;
        private TextBox textDG;
        private TextBox textTim;
        private Button buttonthem;
        private Button buttonsua;
        private Button buttonxoa;
        private Button buttonrs;
        private Button buttontim;
    }
}