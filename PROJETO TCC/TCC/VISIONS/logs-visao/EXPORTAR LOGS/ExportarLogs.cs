using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC.VISIONS.logs_visao.EXPORTAR_LOGS
{
    public partial class ExportarLogs : Form
    {
        #region VARIÁVEIS E INSTÂNCIAS


        #endregion


        #region CONSTRUTOR
        public ExportarLogs()
        {
            InitializeComponent();
        }

        #endregion



        #region MÉTODOS DE FUNCIONALIDADES


        #endregion



        #region DESIGN

        private void btngerarExcel_MouseEnter(object sender, EventArgs e)
        {
            btnexportarExcel.Size = new Size(87, 67);
            lblexportar.Visible = true;

        }

        private void btnexportarExcel_MouseLeave(object sender, EventArgs e)
        {
            btnexportarExcel.Size = new Size(81, 61);
            lblexportar.Visible = false;
        }

        private void btnabrirExcel_MouseEnter(object sender, EventArgs e)
        {
            btnabrirExcel.Size = new Size(87, 67);
            lblabrir.Visible = true;
        }

        private void btnabrirExcel_MouseLeave(object sender, EventArgs e)
        {
            btnabrirExcel.Size = new Size(81, 61);
            lblabrir.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion


    }
}
