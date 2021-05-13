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
    
    public partial class MenuPerfil_Geral_ : Form

    {
        String geral = "geral";
        public MenuPerfil_Geral_()
        {
            InitializeComponent();
            
        }

        private void MenuPerfil_Geral__Shown(object sender, EventArgs e)
        {
            Global global = new Global();
            global.validaTela = geral.ToString();
        }
    }
}
