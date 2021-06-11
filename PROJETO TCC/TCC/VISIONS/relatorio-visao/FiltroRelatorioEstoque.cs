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
        public FiltroRelatorioEstoque()
        {
            InitializeComponent();
        }

        relatorioEstoqueControle relCtr = new relatorioEstoqueControle();

        RelatorioEstoque relEst = new RelatorioEstoque();

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


        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnfiltrar_Click(object sender, EventArgs e)
        {
            passarData.dataInicial = txtdataInicial.Text;
            passarData.dataFinal = txtdataFinal.Text;

            filtrarData();
        }
    }
}
