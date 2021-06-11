using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TCC.MODELS.relatorio_modelo;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace TCC.VISÃO
{
    public partial class RelatorioEstoque : Form
    {
        #region VARIÁVEIS E INSTÂNCIAS

        String contaEntrada;
        relatorioEstoqueControle relCtr = new relatorioEstoqueControle();
        String quantidadeProduto;
        String dispesas;
        int op1 = 0;
        int op2 = 0;
        int op3 = 0;
        int tot = 0;

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

        public void contarOperacao()
        {
            String opera = relCtr.contarOperacao();
            String opera2 = relCtr.contarOperacao2();
            String opera3 = relCtr.contarOperacao3();

            if (relCtr.tem)
            {
                this.op1 = Convert.ToInt32(opera);
                this.op2 = Convert.ToInt32(opera2);
                this.op3 = Convert.ToInt32(opera3);

                this.tot = (op1 + op2) + op3 ;

            }

            lbl5.Text = tot.ToString();

        }
        

        public void filtrarSemana()
        {
            DataTable dtd = new DataTable();

            dtd = relCtr.filtrarSemana();

            dtgestoque.Rows.Clear();

            foreach (DataRow item in dtd.Rows)
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

        public void filtrarMes()
        {
            DataTable dtdm = new DataTable();

            dtdm = relCtr.filtrarMes();

            dtgestoque.Rows.Clear();

            foreach (DataRow item in dtdm. Rows)
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


        public void filtrarAno()
        {
            DataTable dtaa = new DataTable();

            dtaa = relCtr.filtrarAno();

            dtgestoque.Rows.Clear();

            foreach (DataRow item in dtaa.Rows)
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
            timer1.Start();
            formataGrid();
            listarProduto();
            contarEntradas();
            contarProdutos();
            contarDispesas();
            contarOperacao();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listarProduto();
            timer1.Start();
        }

        private void btnfiltroSemana_Click(object sender, EventArgs e)
        {
            filtrarSemana();
        }

        private void btnfiltroSemana_MouseEnter(object sender, EventArgs e)
        {
            btnfiltroSemana.Size = new Size(68, 40);
        }

        private void btnfiltroSemana_MouseLeave_1(object sender, EventArgs e)
        {
            btnfiltroSemana.Size = new Size(62, 35);
        }

        private void btnfiltroMes_Click(object sender, EventArgs e)
        {
            filtrarMes();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            filtrarAno();
        }

        private void btnfiltroMes_MouseEnter(object sender, EventArgs e)
        {
            btnfiltroMes.Size = new Size(68, 40);
        }

        private void btnfiltroMes_MouseLeave(object sender, EventArgs e)
        {
            btnfiltroMes.Size = new Size(62, 35);
        }

        private void btn3_MouseEnter(object sender, EventArgs e)
        {
            btnfiltrarAno.Size = new Size(68, 40);
        }

        private void btnfiltrarAno_MouseLeave(object sender, EventArgs e)
        {
            btnfiltrarAno.Size = new Size(62, 35);
        }

        private void btnfiltrarPersonalizado_MouseEnter(object sender, EventArgs e)
        {
            btnfiltrarPersonalizado.Size = new Size(68, 40);
        }

        private void btnfiltrarPersonalizado_MouseLeave(object sender, EventArgs e)
        {
            btnfiltrarPersonalizado.Size = new Size(62, 35);
        }
    }
}
