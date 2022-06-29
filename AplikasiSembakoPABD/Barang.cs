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
    public partial class Barang : Form
    {
        public Barang()
        {
            InitializeComponent();
        }

        void insertData()
        {
            SqlConnection con = new SqlConnection("Data Source=MSI\\MSSQLSERVER02;Initial Catalog=datapenjualan;User ID=sa;Password=123");
            con.Open();
            SqlCommand query = new SqlCommand("Exec insertBarang '" + txtidbarang.Text+ "', '" + txtjsbarang.Text + "', '" + txthargabarang.Text + "', '" + txtstokbarang.Text + "', '" + txtnamabarang.Text + "'", con);
            query.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Tersimpan");
            getData();

        }

        void getData()
        {
            SqlConnection con = new SqlConnection("Data Source=MSI\\MSSQLSERVER02;Initial Catalog=datapenjualan;User ID=sa;Password=123");
            SqlCommand cmd = new SqlCommand("Select * From Barang", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void updateData()
        {
            SqlConnection con = new SqlConnection("Data Source=MSI\\MSSQLSERVER02;Initial Catalog=datapenjualan;User ID=sa;Password=123");
            con.Open();
            SqlCommand cmd = new SqlCommand("exec updateBarang '" + txtidbarang.Text + "',  '" + txtjsbarang.Text + "', '" + txthargabarang.Text + "',  '" + txtstokbarang.Text + "',  '" + txtnamabarang.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Succes Edit Data...");
            con.Close();
            getData();
        }

        void deleteData()
        {
            SqlConnection con = new SqlConnection("Data Source=MSI\\MSSQLSERVER02;Initial Catalog=datapenjualan;User ID=sa;Password=123");
            con.Open();
            SqlCommand delete = new SqlCommand("exec deleteBarang '"+txtidbarang.Text+"'", con);
            delete.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil di Hapus");
            getData();
        }

        private void Barang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datapenjualanDataSet.Barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter2.Fill(this.datapenjualanDataSet.Barang);
            // TODO: This line of code loads data into the 'sembakoDataSet1.Pembeli' table. You can move, or remove it, as needed.
            this.pembeliTableAdapter.Fill(this.sembakoDataSet1.Pembeli);
            // TODO: This line of code loads data into the 'sembakoDataSet1.Barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter1.Fill(this.sembakoDataSet1.Barang);


        }

        private void KembaliBarang_Click(object sender, EventArgs e)
        {
            Menu back = new Menu();
            back.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SimpanBarang_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MSI\\MSSQLSERVER02;Initial Catalog=datapenjualan;User ID=sa;Password=123");
            insertData();
            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                txtidbarang.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtjsbarang.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txthargabarang.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtstokbarang.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txtnamabarang.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            }
        }

        private void EditBarang_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void HapusBarang_Click(object sender, EventArgs e)
        {
            deleteData();
        }

        private void TambahBarang_Click(object sender, EventArgs e)
        {
            txtidbarang.Text = "";
            txtjsbarang.Text = "";
            txthargabarang.Text = "";
            txtstokbarang.Text = "";
            txtnamabarang.Text = "";

            txtidbarang.Focus();
        }
    }
}
