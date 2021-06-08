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
    public partial class RelatorioEstoque : Form
    {
        #region VARIÁVEIS E INSTÂNCIAS

        #endregion






        #region CONSTRUTOR
        public RelatorioEstoque()
        {
            InitializeComponent();
        }
        #endregion






        #region MÉTODOS DE FUNCIONALIDADES

        #endregion






        #region DESIGN 

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion
    }
}
