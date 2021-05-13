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
    public partial class CADASTRARPRODUTO : Form
    {
        Menuzinho menuz = new Menuzinho();
        public CADASTRARPRODUTO()
        {
            InitializeComponent();
            menuz.valida = 2;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CADASTRARPRODUTO_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuz.Show();
        }
    }
}
