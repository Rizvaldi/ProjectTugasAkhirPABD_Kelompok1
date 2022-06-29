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
    public partial class Pembeli : Form
    {
        public Pembeli()
        {
            InitializeComponent();
            Fill_Combo_Barang();
        }

        void Fill_Combo_Barang()
        {
            SqlConnection conn = new SqlConnection("Data Source=MSI\\MSSQLSERVER02;Initial Catalog=datapenjualan;User ID=sa;Password=123");
            SqlCommand query = new SqlCommand("Select * From Barang", conn);
            SqlDataAdapter sda = new SqlDataAdapter(query);

            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                sda.Fill(dt);

                txtidbarang1.DisplayMember = "id_barang";
                txtidbarang1.DataSource = dt;
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        void insertData()
        {
            SqlConnection con = new SqlConnection("Data Source=MSI\\MSSQLSERVER02;Initial Catalog=datapenjualan;User ID=sa;Password=123");
            con.Open();
            SqlCommand query = new SqlCommand("insert into Pembeli (id_pembeli,id_barang,nama_pembeli,nama_barang,no_pembeli,alamat,jumlah_barang,jenis_pembayaran,total_pembayaran,tanggal_pembayaran) " +
                "values('" + txtidpembeli.Text + "', '" + txtidbarang1.Text + "', '" + txtnamapembeli.Text + "', '" + txtnamabarang1.Text + "', '" + txtnomortelepon.Text + "', '" + txtalamat.Text + "', '" + txtjumlah.Text + "', '" + CbPembayaran.Text + "', '" + txttotal.Text + "', '" + tgl_transaksi.Value.ToString() + "')", con);
            query.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Tersimpan");
            getData();

        }

        void getData()
        {
            SqlConnection con = new SqlConnection("Data Source=MSI\\MSSQLSERVER02;Initial Catalog=datapenjualan;User ID=sa;Password=123");
            SqlCommand cmd = new SqlCommand("Select * From Pembeli", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void updateData()
        {
            SqlConnection con = new SqlConnection("Data Source=MSI\\MSSQLSERVER02;Initial Catalog=datapenjualan;User ID=sa;Password=123");
            con.Open();
            SqlCommand cmd = new SqlCommand("exec updatePembeli  '" + txtidpembeli.Text + "', '" + txtidbarang1.Text + "', '" + txtnamapembeli.Text + "', '" + txtnamabarang1.Text + "', '" + txtnomortelepon.Text + "', '" + txtalamat.Text + "', '" + txtjumlah.Text + "', '" + CbPembayaran.Text + "', '" + txttotal.Text + "', '" + tgl_transaksi.Value + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Succes Edit Data...");
            con.Close();
            getData();
        }

        void deleteData()
        {
            SqlConnection con = new SqlConnection("Data Source=MSI\\MSSQLSERVER02;Initial Catalog=datapenjualan;User ID=sa;Password=123");
            con.Open();
            SqlCommand delete = new SqlCommand("exec deletePembeli '" + txtidpembeli.Text + "'", con);
            delete.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil di Hapus");
            getData();
        }

        private void Pembeli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datapenjualanDataSet.Pembeli' table. You can move, or remove it, as needed.
            this.pembeliTableAdapter2.Fill(this.datapenjualanDataSet.Pembeli);
            // TODO: This line of code loads data into the 'sembakoDataSet1.Pembeli' table. You can move, or remove it, as needed.
            this.pembeliTableAdapter1.Fill(this.sembakoDataSet1.Pembeli);

            CbPembayaran.Items.Add("Cash");
            CbPembayaran.Items.Add("Debit");

        }

        private void KembaliPembeli_Click(object sender, EventArgs e)
        {
            Menu back = new Menu();
            back.Show();
            this.Hide();
        }

        private void txtidbarang1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=MSI\\MSSQLSERVER02;Initial Catalog=datapenjualan;User ID=sa;Password=123");
            SqlCommand query = new SqlCommand("Select * From Barang where id_barang = '"+txtidbarang1.Text+"'", conn);
            SqlDataReader sdr;

            try
            {
                conn.Open();
                sdr = query.ExecuteReader();
                while (sdr.Read())
                {
                    txtnamabarang1.Text = sdr.GetString(4);
                    
                }
            }
            catch (Exception et)
            {
                MessageBox.Show(et.Message);
            }
        }

        private void SimpanPembeli_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=MSI\\MSSQLSERVER02;Initial Catalog=datapenjualan;User ID=sa;Password=123");
            insertData();
            conn.Close();
        }

        private void EditPembeli_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void HapusPembeli_Click(object sender, EventArgs e)
        {
            deleteData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                txtidpembeli.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtidbarang1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtnamapembeli.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtnamabarang1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txtnomortelepon.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                txtalamat.Text = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                txtjumlah.Text = dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                CbPembayaran.Text = dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                txttotal.Text = dataGridView1.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
                tgl_transaksi.Text = dataGridView1.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
            }
        }
    }
}
