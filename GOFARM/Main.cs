using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFarm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ExittoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sapi sapiForm = new Sapi();
            sapiForm.Show();
            Hide();
        }

        private void ProduksitoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produksi ProdukForm = new Produksi();
            ProdukForm.Show();
            Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Kesehatan SehatForm = new Kesehatan();
            SehatForm.Show();
            Hide();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Pembiakan BiakForm = new Pembiakan();
            BiakForm.Show();
            Hide();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Penjualan JualForm = new Penjualan();
            JualForm.Show();
            Hide();
        }
    }
}
