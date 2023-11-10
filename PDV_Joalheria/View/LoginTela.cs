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
    public partial class LoginTela : Form
    {
        public LoginTela()
        {
            InitializeComponent();
        }

        private void btn_acessar_Click(object sender, EventArgs e)
        {

            string usuario = txt_usuario.Text;
            string senha = txt_senha.Text;

            if (usuario == "cliente" && senha == "123")
            {

                this.Hide();
                PDVTela PDV = new PDVTela();
                PDV.FormClosed += (s, args) => this.Close();
                PDV.Show();

            }

            if (usuario == "admin" && senha == "123")
            {

                this.Hide();
                MenuVenda Menu = new MenuVenda();
                Menu.FormClosed += (s, args) => this.Close();
                Menu.Show();

            }

            else
            {
                MessageBox.Show("Senha ou usuário incorreto");
            }

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

