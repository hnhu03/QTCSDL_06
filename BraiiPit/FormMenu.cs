using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace BraiiPit
{
    public partial class FormMenu : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=HNHU\NEWSERVER;Initial Catalog=QuanLiBanHang;Integrated Security=True;Encrypt=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadMenuList()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Mon";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridMon.DataSource = table;

        }


        public FormMenu()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textMM.ReadOnly = true;
            if (GridMon.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                GridMon.CurrentRow.Selected = true;
                textMM.Text = GridMon.Rows[e.RowIndex].Cells["MaMon"].Value.ToString();
                textTM.Text = GridMon.Rows[e.RowIndex].Cells["TenMon"].Value.ToString();
                textDG.Text = GridMon.Rows[e.RowIndex].Cells["DonGiaBan"].Value.ToString();
            }

        }

        private void FormMenu_Load_1(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadMenuList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Mon where TenMon  like N'%" + textTim.Text.Trim() + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridMon.DataSource = table;

        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into Mon values('" + textMM.Text + "','" + textTM.Text + "','" + textDG.Text + "')";
            command.ExecuteNonQuery();
            LoadMenuList();

        }

        private void buttonsua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update Mon set TenMon = '" + textTM.Text + "',DonGiaBan = '" + textDG.Text + "' where MaMon = '" + textMM.Text + "'";
            command.ExecuteNonQuery();
            LoadMenuList();

        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from Mon where MaMon = ('" + textMM.Text + "')";
            command.ExecuteNonQuery();
            LoadMenuList();

        }

        private void buttonrs_Click(object sender, EventArgs e)
        {
            LoadMenuList();
            textMM.ReadOnly = false;
            textMM.Text = "";
            textTM.Text = "";
            textDG.Text = "";



        }
    }
}
