namespace BraiiPit
{
    partial class FormDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            textmk = new TextBox();
            texttk = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.BraiiPit;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1084, 561);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textmk);
            panel1.Controls.Add(texttk);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(311, 137);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 264);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 224, 192);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(176, 197);
            button2.Name = "button2";
            button2.Size = new Size(98, 32);
            button2.TabIndex = 3;
            button2.Text = "Đăng nhập";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 224, 192);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(306, 197);
            button1.Name = "button1";
            button1.Size = new Size(98, 32);
            button1.TabIndex = 4;
            button1.Text = "Thoát ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textmk
            // 
            textmk.Location = new Point(176, 149);
            textmk.Name = "textmk";
            textmk.Size = new Size(227, 27);
            textmk.TabIndex = 2;
            textmk.UseSystemPasswordChar = true;
            // 
            // texttk
            // 
            texttk.Location = new Point(176, 93);
            texttk.Name = "texttk";
            texttk.Size = new Size(227, 27);
            texttk.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 224, 192);
            label3.Location = new Point(54, 97);
            label3.Name = "label3";
            label3.Size = new Size(102, 23);
            label3.TabIndex = 2;
            label3.Text = "Tài Khoản ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 224, 192);
            label2.Location = new Point(54, 149);
            label2.Name = "label2";
            label2.Size = new Size(94, 23);
            label2.TabIndex = 1;
            label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 224, 192);
            label1.Location = new Point(144, 26);
            label1.Name = "label1";
            label1.Size = new Size(187, 38);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập ";
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 553);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += FormDangNhap_FormClosing;
            Load += FormDangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox textmk;
        private TextBox texttk;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
    }
}