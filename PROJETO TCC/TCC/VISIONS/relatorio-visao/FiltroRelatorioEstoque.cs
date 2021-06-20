using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC.MODELS.relatorio_modelo;
using TCC.VISÃO;

namespace TCC.VISIONS.relatorio_visao
{
    public partial class FiltroRelatorioEstoque : Form
    {






        #region VARIÁVEIS E INSTÂNCIAS



        relatorioEstoqueControle relCtr = new relatorioEstoqueControle();

        RelatorioEstoque relEst = new RelatorioEstoque();







        #endregion










        #region CONSTRUTOR
        public FiltroRelatorioEstoque()
        {
            InitializeComponent();
        }
        #endregion












        #region MÉTODOS DE FUNCIONALIDADES

        public static class passarData
        {
            public static string dataInicial;
            public static string dataFinal;
        }

        public void filtrarData()
        {
            string dataInicial = txtdataInicial.Text;
            string dataFinal = txtdataFinal.Text;
            DataTable dtmf = new DataTable();

            dtmf = relCtr.filtrarData(dataInicial, dataFinal);

            relEst.dtgestoque.Rows.Clear();

            foreach (DataRow item in dtmf.Rows)
            {
                int n = relEst.dtgestoque.Rows.Add();

                relEst.dtgestoque.Rows[n].Cells[0].Value = item["nome"].ToString();
                relEst.dtgestoque.Rows[n].Cells[1].Value = item["fornecedor"].ToString();
                relEst.dtgestoque.Rows[n].Cells[2].Value = item["tipo"].ToString();
                relEst.dtgestoque.Rows[n].Cells[3].Value = item["modelo"].ToString();
                relEst.dtgestoque.Rows[n].Cells[4].Value = item["quantidade"].ToString();
                relEst.dtgestoque.Rows[n].Cells[5].Value = item["valordecompra"].ToString();
                relEst.dtgestoque.Rows[n].Cells[6].Value = item["valordevenda"].ToString();
                relEst.dtgestoque.Rows[n].Cells[7].Value = item["dataDeCadastro"].ToString();

            }

        }

        #endregion











        #region DESIGN
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnfiltrar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty)
            {
                passarData.dataInicial = txtdataInicial.Text;
                passarData.dataFinal = txtdataFinal.Text;

                filtrarData();
                this.Close();
            }
            else
            {
                MessageBox.Show("PREENCHA TODOS OS CAMPOS", "PREENCHER", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }











        #endregion

        private void btnfiltrar_MouseEnter(object sender, EventArgs e)
        {
            btnfiltrar.Size = new Size(68, 40);
        }

        private void btnfiltrar_MouseLeave(object sender, EventArgs e)
        {
            btnfiltrar.Size = new Size(68, 36);
        }

        private void txtdataFinal_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
