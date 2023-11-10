using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV_Joalheria.View
{
    public partial class TelaFecharVenda : Form
    {
        PDVTela xuxa;

        public TelaFecharVenda(PDVTela pdv)
        {
            InitializeComponent();
            xuxa = pdv;
            lbl_valortotal.Text = "R$ " + Convert.ToString(xuxa.tudo) + ",00".ToString();
            

            for (int i = 0; i < xuxa.dataGridViewPDV.RowCount - 1; i++)
            {

                lbl_prod1.Text += "\nPRODUTO : " + xuxa.dataGridViewPDV.Rows[i].Cells[0].Value.ToString() +
                " QUANTIDADE : " + xuxa.dataGridViewPDV.Rows[i].Cells[1].Value.ToString() +
                " UNITÁRIO : " + xuxa.dataGridViewPDV.Rows[i].Cells[2].Value.ToString();

                lbl_data.Text = DateTime.Now.ToString();
            }
        }

        private void TelaFecharVenda_Load(object sender, EventArgs e)
        {
            lbl_data.Text = DateTime.Now.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
