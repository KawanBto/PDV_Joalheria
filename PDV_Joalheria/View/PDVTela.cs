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
    public partial class PDVTela : Form
    {

        public int tudo = 0;
        string prod;
        string lbl_prod1, lbl_prod2, lbl_prod3, lbl_prod4, lbl_prod5, lbl_prod6, lbl_prod7, lbl_prod8;
        int lbl_valor1, lbl_valor2, lbl_valor3, lbl_valor4, lbl_valor5, lbl_valor6, lbl_valor7, lbl_valor8;

        public PDVTela()
        {
            InitializeComponent();
        }

        private void btn_a1_Click(object sender, EventArgs e)
        {
            string registroa1 = "10";

            txt_cod.Text = registroa1;
        }

        private void btn_a2_Click(object sender, EventArgs e)
        {
            string registroa2 = "11";

            txt_cod.Text = registroa2;
        }

        private void btn_a3_Click(object sender, EventArgs e)
        {
            string registroa3 = "12";

            txt_cod.Text = registroa3;
        }

        private void btn_a4_Click(object sender, EventArgs e)
        {
            string registroa4 = "13";

            txt_cod.Text = registroa4;
        }

        private void btn_adc_Click(object sender, EventArgs e)
        {
            string codigo = txt_cod.Text;
            int qtd = ((int)num_qtd.Value);
            string[] numprod = { lbl_prod1, lbl_prod2, lbl_prod3, lbl_prod4, lbl_prod5, lbl_prod6, lbl_prod7, lbl_prod8 };
            int[] numvalors = { lbl_valor1, lbl_valor2, lbl_valor3, lbl_valor4, lbl_valor5, lbl_valor6, lbl_valor7, lbl_valor8 };
            string[] itens = { "Anel1", "Anel2", "Anel3", "Anel4", "Colar1", "Colar2", "Colar3", "Colar4" };
            int[] valor = { 1451, 1011, 1181, 1731, 2140, 1451, 1451, 1451 };
            int total = 0;
            int cont = 9;
            string convert = txt_cod.Text;
            int contagem = Convert.ToInt32(convert);
            int i = -1;
            int l = -1;

            do
            {
                cont += 1;
                i += 1;
                l += 1;

                if (contagem == cont)
                {
                    total = qtd * valor[i];
                    tudo += total;
                    dataGridViewPDV.Rows.Add(itens[i], valor[i], num_qtd.Value, total);
                    lbl_total.Text = "R$: " + tudo.ToString() + ",00";

                    numprod[l] = itens[i];
                    numvalors[l] = valor[i];

                }

            } while (contagem != cont);
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            TelaFecharVenda telaFecharVenda = new TelaFecharVenda(this);
            telaFecharVenda.Show();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            lbl_total.Text = string.Empty;
            txt_cod.Text = string.Empty;
            num_qtd.Value = 0;
            dataGridViewPDV.Rows.Clear();
            tudo = 0;
        }

        private void btn_c1_Click(object sender, EventArgs e)
        {
            string registroo1 = "14";

            txt_cod.Text = registroo1;
        }

        private void btn_c2_Click(object sender, EventArgs e)
        {
            string registroo2 = "15";

            txt_cod.Text = registroo2;
        }

        private void btn_c3_Click(object sender, EventArgs e)
        {
            string registroo3 = "16";

            txt_cod.Text = registroo3;
        }

        private void btn_c4_Click(object sender, EventArgs e)
        {
            string registroo4 = "17";

            txt_cod.Text = registroo4;
        }
    }
}
