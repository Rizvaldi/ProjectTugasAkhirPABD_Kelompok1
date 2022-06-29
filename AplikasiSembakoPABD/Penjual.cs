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

namespace AplikasiSembakoPABD
{
    public partial class Penjual : Form
    {
        DataTable dt;
        DataRow dr;
        string code;
        public Penjual()
        {
            InitializeComponent();
        }

        void insertData()
        {
            SqlConnection con = new SqlConnection("Data Source=MSI\\MSSQLSERVER02;Initial Catalog=datapenjualan;User ID=sa;Password=123");
            con.Open();
            SqlCommand query = new SqlCommand("Exec insertPenjual '" + txtpenjual.Text + "', '" + txtnamapenjual.Text + "', '" + txtalamatpenjual.Text + "', '" + txtnotlppenjual.Text + "'", con);
            query.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Tersimpan");
            getData();

        }

        void getData()
        {
            SqlConnection con = new SqlConnection("Data Source=MSI\\MSSQLSERVER02;Initial Catalog=datapenjualan;User ID=sa;Password=123");
            SqlCommand cmd = new SqlCommand("Select * From Penjual", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void updateData()
        {
            SqlConnection con = new SqlConnection("Data Source=MSI\\MSSQLSERVER02;Initial Catalog=datapenjualan;User ID=sa;Password=123");
            con.Open();
            SqlCommand cmd = new SqlCommand("exec updatePenjual '" + txtpenjual.Text + "', '" + txtnamapenjual.Text + "', '" + txtalamatpenjual.Text + "', '" + txtnotlppenjual.Text + "'" , con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Succes Edit Data...");
            con.Close();
            getData();
        }

        void deleteData()
        {
            SqlConnection con = new SqlConnection("Data Source=MSI\\MSSQLSERVER02;Initial Catalog=datapenjualan;User ID=sa;Password=123");
            con.Open();
            SqlCommand delete = new SqlCommand("exec deletePenjual '" + txtpenjual.Text + "'", con);
            delete.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil di Hapus");
            getData();
        }

        private void Penjual_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datapenjualanDataSet.Penjual' table. You can move, or remove it, as needed.
            this.penjualTableAdapter2.Fill(this.datapenjualanDataSet.Penjual);
            // TODO: This line of code loads data into the 'sembakoDataSet1.Penjual' table. You can move, or remove it, as needed.
            this.penjualTableAdapter1.Fill(this.sembakoDataSet1.Penjual);

        }

        private void KembaliPenjual_Click(object sender, EventArgs e)
        {
            Menu back = new Menu();
            back.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                txtpenjual.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtnamapenjual.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtalamatpenjual.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtnotlppenjual.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            }
        }

        private void SimpanPenjual_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MSI\\MSSQLSERVER02;Initial Catalog=datapenjualan;User ID=sa;Password=123");
            insertData();
            con.Close();
        }

        private void TambahPenjual_Click(object sender, EventArgs e)
        {
            txtpenjual.Enabled = true;
            txtnamapenjual.Enabled = true;
            txtalamatpenjual.Enabled = true;
            txtnotlppenjual.Enabled = true;
            txtpenjual.Text = "";
            txtnamapenjual.Text = "";
            txtalamatpenjual.Text = "";
            txtnotlppenjual.Text = "";
            txtpenjual.Focus();


            SimpanPenjual.Enabled = true;
            TambahPenjual.Enabled = false;
        }

        private void EditPenjual_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void HapusPenjual_Click(object sender, EventArgs e)
        {
            deleteData();
        }
    }
}
