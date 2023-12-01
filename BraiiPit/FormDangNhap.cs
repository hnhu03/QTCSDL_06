using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace BraiiPit
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection ql = new SqlConnection(@"Data Source=HNHU\NEWSERVER;Initial Catalog=QuanLiBanHang;Integrated Security=True;Encrypt=False");
                ql.Open();
                string sql = "SELECT * FROM TaiKhoan WHERE TaiKhoan = @username and (try_convert (varchar,convert(varchar(50), Decryptbypassphrase('MatKhau', [encrypted Passwords])))) = @password";
                SqlCommand cmd = new SqlCommand(sql, ql);
                cmd.Parameters.AddWithValue("@username", texttk.Text);
                cmd.Parameters.AddWithValue("@password", textmk.Text);

                string tk = texttk.Text;
                string mk = textmk.Text;
                string sql1 = "select * from TaiKhoan where TaiKhoan ='" + tk + "' and  (try_convert (varchar,convert(varchar(50), Decryptbypassphrase('MatKhau', [encrypted Passwords])))) = '" + mk + "' ";
                SqlCommand cmd1 = new SqlCommand(sql1, ql);
                SqlDataReader dta = cmd1.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    FormManager f = new FormManager();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Quản Lý Quán BraiiPit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }


}
