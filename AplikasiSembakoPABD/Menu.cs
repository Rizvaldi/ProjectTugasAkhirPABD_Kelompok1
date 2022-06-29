using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiSembakoPABD
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Penjual penjual = new Penjual();
            penjual.Show();
            this.Hide();
        }

        private void PembeliMenu_Click(object sender, EventArgs e)
        {
            Pembeli pembeli = new Pembeli();
            pembeli.Show();
            this.Hide();
        }

        private void BarangMenu_Click(object sender, EventArgs e)
        {
            Barang barang = new Barang();
            barang.Show();
            this.Hide();
        }

        private void TransaksiMenu_Click(object sender, EventArgs e)
        {
            Transaksi transaksi = new Transaksi();
            transaksi.Show();
            this.Hide();
        }

        private void KembaliMenu_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            back.Show();
            this.Hide();
        }
    }
}
