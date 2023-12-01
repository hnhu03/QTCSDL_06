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
    public partial class FormTaiKhoan : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=HNHU\NEWSERVER;Initial Catalog=QuanLiBanHang;Integrated Security=True;Encrypt=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadTKList()
        {
            command = connection.CreateCommand();
            command.CommandText = "select TaiKhoan, (try_convert (varchar,convert(varchar(50), Decryptbypassphrase('MatKhau', [encrypted Passwords])))) as  MatKhau from TaiKhoan";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridTaiKhoan.DataSource = table;

        }
        public FormTaiKhoan()
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
            textTK.ReadOnly = true;
            if (GridTaiKhoan.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                GridTaiKhoan.CurrentRow.Selected = true;
                textTK.Text = GridTaiKhoan.Rows[e.RowIndex].Cells["TaiKhoan"].Value.ToString();
                textMK.Text = GridTaiKhoan.Rows[e.RowIndex].Cells["MatKhau"].Value.ToString();

            }

        }

        private void buttontim_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from TaiKhoan where TaiKhoan  like N'%" + textTim.Text.Trim() + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridTaiKhoan.DataSource = table;
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO TaiKhoan ([TaiKhoan], [encrypted Passwords]) VALUES (  '" + textTK.Text + "', ENCRYPTBYPASSPHRASE('MatKhau', CONVERT(VARCHAR(100), '" + textMK.Text + "')))";
            command.ExecuteNonQuery();
            LoadTKList();
        }

        private void buttonsua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE TaiKhoan SET [encrypted Passwords] = ENCRYPTBYPASSPHRASE('MatKhau', CONVERT(VARCHAR(100), '" + textMK.Text + "')) where TaiKhoan = '" + textTK.Text + "'";
            command.ExecuteNonQuery();
            LoadTKList();

        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from TaiKhoan where TaiKhoan = ('" + textTK.Text + "')";
            command.ExecuteNonQuery();
            LoadTKList();
        }

        private void buttonrs_Click(object sender, EventArgs e)
        {
            LoadTKList();
            textTK.ReadOnly = false;
            textTK.Text = "";
            textMK.Text = "";

        }
    }
}
