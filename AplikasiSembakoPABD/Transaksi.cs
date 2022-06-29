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
    public partial class Transaksi : Form
    {
        public Transaksi()
        {
            InitializeComponent();
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datapenjualanDataSet.Transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter1.Fill(this.datapenjualanDataSet.Transaksi);

        }

        private void KembaliTransaksi_Click(object sender, EventArgs e)
        {
            Menu back = new Menu();
            back.Show();
            this.Hide();
        }
    }
}
