using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV_Joalheria.View
{
    public partial class MenuVenda : Form
    {
        public MenuVenda()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PDVTela pdv = new PDVTela();
            pdv.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void créditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreditosTela cred = new CreditosTela();
            cred.Show();
        }
    }
}
