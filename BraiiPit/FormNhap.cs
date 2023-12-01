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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BraiiPit
{
    public partial class FormNhap : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=HNHU\NEWSERVER;Initial Catalog=QuanLiBanHang;Integrated Security=True;Encrypt=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadNhapList()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Nhap";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridNhap.DataSource = table;

        }
        public FormNhap()
        {
            InitializeComponent();
        }

        private void FormNhap_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadNhapList();
        }

        private void buttontim_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Nhap where MaNhapHang  like N'%" + textTim.Text.Trim() + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridNhap.DataSource = table;
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into Nhap(MaNhapHang,MaNhanVien,Ngay) values('" + textMNH.Text + "','" + textMNV.Text + "','" + textTG.Text + "')";
            command.ExecuteNonQuery();
            LoadNhapList();
        }

        private void buttonsua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update Nhap set MaNhanVien = '" + textMNV.Text + "',Ngay = '" + textTG.Text + "',TongTien = '" + textTT.Text + "' where MaNhapHang = '" + textMNH.Text + "'";
            command.ExecuteNonQuery();
            LoadNhapList();
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from Nhap where MaNhapHang = ('" + textMNH.Text + "')";
            command.ExecuteNonQuery();
            LoadNhapList();
        }

        private void buttonrs_Click(object sender, EventArgs e)
        {
            LoadNhapList();
            textMNH.ReadOnly = false;
            textMNH.Text = "";
            textMNV.Text = "";
            textTG.Text = "";
            textTT.Text = "";
        }

        private void GridNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textMNH.ReadOnly = true;
            textTT.ReadOnly = true;
            if (GridNhap.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                GridNhap.CurrentRow.Selected = true;
                textMNH.Text = GridNhap.Rows[e.RowIndex].Cells["MaNhapHang"].Value.ToString();
                textMNV.Text = GridNhap.Rows[e.RowIndex].Cells["MaNhanVien"].Value.ToString();
                textTG.Text = GridNhap.Rows[e.RowIndex].Cells["Ngay"].Value.ToString();
                textTT.Text = GridNhap.Rows[e.RowIndex].Cells["TongTien"].Value.ToString();

            }
        }
    }
}
