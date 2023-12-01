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
    public partial class FormHangNhapVao : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=HNHU\NEWSERVER;Initial Catalog=QuanLiBanHang;Integrated Security=True;Encrypt=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadHNVList()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from HangNhapVao";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridHangNhap.DataSource = table;

        }
        public FormHangNhapVao()
        {
            InitializeComponent();
        }

        private void FormHangNhapVao_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadHNVList();
        }

        private void buttontim_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from HangNhapVao where TenHangNhap  like N'%" + textTim.Text.Trim() + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridHangNhap.DataSource = table;
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into HangNhapVao values('" + textMHN.Text + "','" + textTHN.Text + "','" + textDG.Text + "')";
            command.ExecuteNonQuery();
            LoadHNVList();
        }

        private void buttonsua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update HangNhapVao set TenHangNhap = '" + textTHN.Text + "',DonGiaNhap = '" + textDG.Text + "' where MaHangNhap = '" + textMHN.Text + "'";
            command.ExecuteNonQuery();
            LoadHNVList();
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from HangNhapVao where MaHangNhap = ('" + textMHN.Text + "')";
            command.ExecuteNonQuery();
            LoadHNVList();
        }

        private void buttonrs_Click(object sender, EventArgs e)
        {
            LoadHNVList();
            textMHN.ReadOnly = false;
            textMHN.Text = "";
            textTHN.Text = "";
            textDG.Text = "";
        }

        private void GridHangNhapVao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textMHN.ReadOnly = true;
            if (GridHangNhap.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                GridHangNhap.CurrentRow.Selected = true;
                textMHN.Text = GridHangNhap.Rows[e.RowIndex].Cells["MaHangNhap"].Value.ToString();
                textTHN.Text = GridHangNhap.Rows[e.RowIndex].Cells["TenHangNhap"].Value.ToString();
                textDG.Text = GridHangNhap.Rows[e.RowIndex].Cells["DonGiaNhap"].Value.ToString();
            }
        }
    }
}
