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

namespace BraiiPit
{
    public partial class FormBanChiTiet : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=HNHU\NEWSERVER;Initial Catalog=QuanLiBanHang;Integrated Security=True;Encrypt=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadBanCTList()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from BanChiTiet";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridBanCT.DataSource = table;

        }
        public FormBanChiTiet()
        {
            InitializeComponent();
        }

        private void FormBanChiTiet_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadBanCTList();
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values('" + textMHD.Text + "','" + textMM.Text + "','" + textMNV.Text + "','" + textSL.Text + "')";
            command.ExecuteNonQuery();
            LoadBanCTList();
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from BanChiTiet where MaHoaDon = ('" + textMHD.Text + "') and MaMon = ('" + textMM.Text + "')  ";
            command.ExecuteNonQuery();
            LoadBanCTList();
        }

        private void buttonsua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update BanChiTiet set MaMon = '" + textMM.Text + "',MaNhanVien = '" + textMNV.Text + "',SoLuong = '" + textSL.Text + "' where MaHoaDon = '" + textMHD.Text + "'";
            command.ExecuteNonQuery();
            LoadBanCTList();
        }

        private void buttonrs_Click(object sender, EventArgs e)
        {
            LoadBanCTList();
            textMHD.ReadOnly = false;
            textMHD.Text = "";
            textMM.Text = "";
            textMNV.Text = "";
            textTM.Text = "";
            textDG.Text = "";
            textSL.Text = "";
            textTT.Text = "";
        }

        private void buttontim_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from BanChiTiet where MaHoaDon  like N'%" + textTim.Text.Trim() + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridBanCT.DataSource = table;
        }

        private void GridBanCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textMHD.ReadOnly = true;
            textTM.ReadOnly = true;
            textDG.ReadOnly = true;
            textTT.ReadOnly = true;
            if (GridBanCT.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                GridBanCT.CurrentRow.Selected = true;
                textMHD.Text = GridBanCT.Rows[e.RowIndex].Cells["MaHoaDon"].Value.ToString();
                textMM.Text = GridBanCT.Rows[e.RowIndex].Cells["MaMon"].Value.ToString();
                textMNV.Text = GridBanCT.Rows[e.RowIndex].Cells["MaNhanVien"].Value.ToString();
                textTM.Text = GridBanCT.Rows[e.RowIndex].Cells["TenMon"].Value.ToString();
                textDG.Text = GridBanCT.Rows[e.RowIndex].Cells["DonGiaBan"].Value.ToString();
                textSL.Text = GridBanCT.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
                textTT.Text = GridBanCT.Rows[e.RowIndex].Cells["ThanhTien"].Value.ToString();

            }
        }
    }
}
