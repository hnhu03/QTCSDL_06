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
    public partial class FormNhapchitiet : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=HNHU\NEWSERVER;Initial Catalog=QuanLiBanHang;Integrated Security=True;Encrypt=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadBanCTList()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Nhapchitiet";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridNhapCT.DataSource = table;

        }
        public FormNhapchitiet()
        {
            InitializeComponent();
        }

        private void buttontim_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Nhapchitiet where MaNhapHang  like N'%" + textTim.Text.Trim() + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridNhapCT.DataSource = table;
        }

        private void buttonrs_Click(object sender, EventArgs e)
        {
            LoadBanCTList();
            textMNH.ReadOnly = false;
            textMNH.Text = "";
            textMHN.Text = "";
            textSL.Text = "";
            textTHN.Text = "";
            textDG.Text = "";
            textCNC.Text = "";
            textTT.Text = "";
        }

        private void buttonsua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update Nhapchitiet set MaHangNhap = '" + textMHN.Text + "', SoLuong = '" + textSL.Text + "',CongNoCu = '" + textCNC.Text + "' where MaNhapHang = '" + textMNH.Text + "'";
            command.ExecuteNonQuery();
            LoadBanCTList();
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from Nhapchitiet where MaNhapHang = ('" + textMNH.Text + "') and MaHangNhap = ('" + textMHN.Text + "')  ";
            command.ExecuteNonQuery();
            LoadBanCTList();
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into Nhapchitiet(MaNhapHang,MaHangNhap,SoLuong,CongNoCu) values('" + textMNH.Text + "','" + textMHN.Text + "','" + textSL.Text + "','" + textCNC.Text + "')";
            command.ExecuteNonQuery();
            LoadBanCTList();
        }

        private void FormNhapchitiet_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadBanCTList();
        }

        private void GridNhapCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textMNH.ReadOnly = true;
            textTHN.ReadOnly = true;
            textDG.ReadOnly = true;
            textTT.ReadOnly = true;
            if (GridNhapCT.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                GridNhapCT.CurrentRow.Selected = true;
                textMNH.Text = GridNhapCT.Rows[e.RowIndex].Cells["MaNhapHang"].Value.ToString();
                textMHN.Text = GridNhapCT.Rows[e.RowIndex].Cells["MaHangNhap"].Value.ToString();
                textSL.Text = GridNhapCT.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
                textTHN.Text = GridNhapCT.Rows[e.RowIndex].Cells["TenHangNhap"].Value.ToString();
                textDG.Text = GridNhapCT.Rows[e.RowIndex].Cells["DonGiaNhap"].Value.ToString();
                textCNC.Text = GridNhapCT.Rows[e.RowIndex].Cells["CongNoCu"].Value.ToString();
                textTT.Text = GridNhapCT.Rows[e.RowIndex].Cells["ThanhTien"].Value.ToString();

            }
        }
    }
}
