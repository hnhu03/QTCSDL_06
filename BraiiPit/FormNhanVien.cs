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
    public partial class FormNhanVien : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=HNHU\NEWSERVER;Initial Catalog=QuanLiBanHang;Integrated Security=True;Encrypt=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadTKList()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NhanVien";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridTaiKhoan.DataSource = table;

        }
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadTKList();
        }

        private void GridTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textMNV.ReadOnly = true;
            if (GridTaiKhoan.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                GridTaiKhoan.CurrentRow.Selected = true;
                textMNV.Text = GridTaiKhoan.Rows[e.RowIndex].Cells["MaNhanVien"].Value.ToString();
                textTCN.Text = GridTaiKhoan.Rows[e.RowIndex].Cells["TenChiNhanh"].Value.ToString();
                textHD.Text = GridTaiKhoan.Rows[e.RowIndex].Cells["HanhDong"].Value.ToString();
            }
        }

        private void buttontim_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NhanVien where MaNhanVien  like N'%" + textTim.Text.Trim() + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridTaiKhoan.DataSource = table;
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into NhanVien values('" + textMNV.Text + "','" + textTCN.Text + "','" + textHD.Text + "')";
            command.ExecuteNonQuery();
            LoadTKList();
        }

        private void buttonsua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update NhanVien set TenChiNhanh = '" + textTCN.Text + "',HanhDong = '" + textHD.Text + "' where MaNhanVien = '" + textMNV.Text + "'";
            command.ExecuteNonQuery();
            LoadTKList();
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from NhanVien where MaNhanVien = ('" + textMNV.Text + "')";
            command.ExecuteNonQuery();
            LoadTKList();

        }

        private void buttonrs_Click(object sender, EventArgs e)
        {
            LoadTKList();
            textMNV.ReadOnly = false;
            textMNV.Text = "";
            textTCN.Text = "";
            textHD.Text = "";
        }
    }
}
