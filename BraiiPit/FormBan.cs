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
    public partial class FormBan : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=HNHU\NEWSERVER;Initial Catalog=QuanLiBanHang;Integrated Security=True;Encrypt=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadBanList()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Ban";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridBan.DataSource = table;

        }
        public FormBan()
        {
            InitializeComponent();
        }

        private void FormBan_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadBanList();
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into Ban(MaHoaDon,MaKhachHang,NgayBan) values('" + textMHD.Text + "','" + textMKH.Text + "','" + textTG.Text + "')";
            command.ExecuteNonQuery();
            LoadBanList();
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from Ban where MaHoaDon = ('" + textMHD.Text + "')";
            command.ExecuteNonQuery();
            LoadBanList();
        }

        private void buttonsua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update Ban set MaKhachHang = '" + textMKH.Text + "',NgayBan = '" + textTG.Text + "' where MaHoaDon = '" + textMHD.Text + "'";
            command.ExecuteNonQuery();
            LoadBanList();
        }

        private void buttonrs_Click(object sender, EventArgs e)
        {
            LoadBanList();
            textMHD.ReadOnly = false;
            textMHD.Text = "";
            textMKH.Text = "";
            textTG.Text = "";
            textTT.Text = "";
            textVAT.Text = "";
            textTC.Text = "";
        }

        private void buttontim_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Ban where MaHoaDon  like N'%" + textTim.Text.Trim() + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridBan.DataSource = table;
        }

        private void GridBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textMHD.ReadOnly = true;
            textTT.ReadOnly = true;
            textVAT.ReadOnly = true;
            textTC.ReadOnly = true;
            if (GridBan.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                GridBan.CurrentRow.Selected = true;
                textMHD.Text = GridBan.Rows[e.RowIndex].Cells["MaHoaDon"].Value.ToString();
                textMKH.Text = GridBan.Rows[e.RowIndex].Cells["MaKhachHang"].Value.ToString();
                textTG.Text = GridBan.Rows[e.RowIndex].Cells["NgayBan"].Value.ToString();
                textTT.Text = GridBan.Rows[e.RowIndex].Cells["TongTienHang"].Value.ToString();
                textVAT.Text = GridBan.Rows[e.RowIndex].Cells["VAT"].Value.ToString();
                textTC.Text = GridBan.Rows[e.RowIndex].Cells["TongCong"].Value.ToString();

            }
        }
    }
}
