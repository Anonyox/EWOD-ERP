using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC.VISÃO
{
    public partial class MenuPerfil_Compras_ : Form
    {
        login login = new login();
        String compras = "compras";
        public MenuPerfil_Compras_()
        {

            InitializeComponent();
            
        }

        private void btncadastroProdutos_Click(object sender, EventArgs e)
        {
            CadastroProdutos cadProduto = new CadastroProdutos();
            this.Hide();
            cadProduto.ShowDialog();
        }

        private void btnsairDoSistema_Click(object sender, EventArgs e)
        {
            Close();
            login.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuPerfil_Compras__Shown(object sender, EventArgs e)
        {
            Global global = new Global();
            global.validaTela = compras.ToString();
        }
    }
}
