using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TCC.MODELS.relatorio_modelo;

namespace TCC.VISÃO
{
    public partial class RelatorioEstoque : Form
    {
        #region VARIÁVEIS E INSTÂNCIAS

        String contaEntrada;
        relatorioEstoqueControle relCtr = new relatorioEstoqueControle();
        String quantidadeProduto;
        String dispesas;
        #endregion






        #region CONSTRUTOR
        public RelatorioEstoque()
        {
            InitializeComponent();
        }
        #endregion






        #region MÉTODOS DE FUNCIONALIDADES

        public void contarEntradas()
        {
            contaEntrada = relCtr.contarEntradas();
            lbl1.Text = contaEntrada;
        }

        public void contarProdutos()
        {
            quantidadeProduto = relCtr.contarProdutos();
            lbl3.Text = quantidadeProduto;
        }


        public void listarProduto()
        {
            DataTable dtr = new DataTable();



            dtr = relCtr.listarProdutos();

            dtgestoque.Rows.Clear();


            foreach (DataRow item in dtr.Rows)
            {

                int n = dtgestoque.Rows.Add();

                dtgestoque.Rows[n].Cells[0].Value = item["nome"].ToString();
                dtgestoque.Rows[n].Cells[1].Value = item["fornecedor"].ToString();
                dtgestoque.Rows[n].Cells[2].Value = item["tipo"].ToString();
                dtgestoque.Rows[n].Cells[3].Value = item["modelo"].ToString();
                dtgestoque.Rows[n].Cells[4].Value = item["quantidade"].ToString();
                dtgestoque.Rows[n].Cells[5].Value = item["valordecompra"].ToString();
                dtgestoque.Rows[n].Cells[6].Value = item["valordevenda"].ToString();
                dtgestoque.Rows[n].Cells[7].Value = item["dataDeCadastro"].ToString();



            }

        }

        public void formataGrid()
        {
            // TODO: esta linha de código carrega dados na tabela 'tccDataSet.logs'. Você pode movê-la ou removê-la conforme necessário.
            //this.logsTableAdapter.Fill(this.tccDataSet.logs);
            dtgestoque.BorderStyle = BorderStyle.None;  //DTEMAIL NOME DA VARIÁVEL
            //dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtgestoque.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            // dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            /// dataGridView1.BackgroundColor = Color.White;

            dtgestoque.EnableHeadersVisualStyles = false;
            dtgestoque.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgestoque.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 209, 178);     //FromArgb(20, 25, 72);
            dtgestoque.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        public void contarDispesas()
        {
            dispesas = relCtr.contarDespesas();
            lbl4.Text = dispesas;
        }
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

        private void RelatorioEstoque_Load(object sender, EventArgs e)
        {
            formataGrid();
            listarProduto();
            contarEntradas();
            contarProdutos();
            contarDispesas();
        }
    }
}
