using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BraiiPit
{
    public partial class FormKhachHang : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=HNHU\NEWSERVER;Initial Catalog=QuanLiBanHang;Integrated Security=True;Encrypt=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadKHList()
        {
            command = connection.CreateCommand();
            command.CommandText = "select MaKhachHang , TenKhachHang , DiaChiKhachHang, convert (varchar,convert(varchar(100), Decryptbypassphrase('SdtKhachHang',[encrypted SdtKhachHang]))) as SdtKhachHang from KhachHang";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridKhachHang.DataSource = table;

        }
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void buttontim_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from KhachHang where TenKhachHang  like N'%" + textTim.Text.Trim() + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridKhachHang.DataSource = table;
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into KhachHang(MaKhachHang , TenKhachHang , DiaChiKhachHang,[encrypted SdtKhachHang]) values('" + textMKH.Text + "','" + textTKH.Text + "','" + textDC.Text + "',(ENCRYPTBYPASSPHRASE('SdtKhachHang', CONVERT(VARCHAR(100), '" + textSDT.Text + "'))))";
            command.ExecuteNonQuery();
            LoadKHList();

        }

        private void buttonsua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update KhachHang set TenKhachHang = '" + textTKH.Text + "',DiaChiKhachHang = '" + textDC.Text + "',[encrypted SdtKhachHang] = ENCRYPTBYPASSPHRASE('SdtKhachHang', CONVERT(VARCHAR(100), '" + textSDT.Text + "'))  where MaKhachHang = '" + textMKH.Text + "'";
            command.ExecuteNonQuery();
            LoadKHList();
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from KhachHang where MaKhachHang = ('" + textMKH.Text + "')";
            command.ExecuteNonQuery();
            LoadKHList();
        }

        private void buttonrs_Click(object sender, EventArgs e)
        {
            LoadKHList();
            textMKH.ReadOnly = false;
            textMKH.Text = "";
            textTKH.Text = "";
            textDC.Text = "";
            textSDT.Text = "";
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadKHList();
        }

        private void GridKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textMKH.ReadOnly = true;
            if (GridKhachHang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                GridKhachHang.CurrentRow.Selected = true;
                textMKH.Text = GridKhachHang.Rows[e.RowIndex].Cells["MaKhachHang"].Value.ToString();
                textTKH.Text = GridKhachHang.Rows[e.RowIndex].Cells["TenKhachHang"].Value.ToString();
                textDC.Text = GridKhachHang.Rows[e.RowIndex].Cells["DiaChiKhachHang"].Value.ToString();
                textSDT.Text = GridKhachHang.Rows[e.RowIndex].Cells["SdtKhachHang"].Value.ToString();

            }
        }
    }
}
