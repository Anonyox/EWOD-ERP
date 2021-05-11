using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC.CONTROLE;
using TCC.MODELO;

namespace TCC.VISÃO
{


    public partial class CadastroVendas : Form
    {
        ControleVenda controleVenda = new ControleVenda();
         int codOperacao = 0;
        int validaMsg = 0;



        public CadastroVendas()
        {
            InitializeComponent();
            

        }

        private void CadastroVendas_Load(object sender, EventArgs e)
        {
            
            // TODO: esta linha de código carrega dados na tabela 'tccDataSet.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.tccDataSet.produtos);

            lblteste.BorderStyle = BorderStyle.None;  //DTEMAIL NOME DA VARIÁVEL
            //dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            lblteste.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            // dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            /// dataGridView1.BackgroundColor = Color.White;

            lblteste.EnableHeadersVisualStyles = false;
            lblteste.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            lblteste.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 209, 178);     //FromArgb(20, 25, 72);
            lblteste.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

          



        }

        public void listaCarrinho()
        {

           
            String codlist = codOperacao.ToString();

            

            controleVenda.listaCarrinho(codlist);

            DataTable dt = new DataTable();

            dt = controleVenda.dtr;

            lblteste.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {

                int n = lblteste.Rows.Add();
                lblteste.Rows[n].Cells[0].Value = item["codOperacao"].ToString();
                lblteste.Rows[n].Cells[1].Value = item["produtoPedido"].ToString();
                lblteste.Rows[n].Cells[2].Value = item["tipoProduto"].ToString();
                lblteste.Rows[n].Cells[3].Value = item["estiloModeloPedido"].ToString();
                lblteste.Rows[n].Cells[4].Value = item["valordeCompraPedido"].ToString();
                lblteste.Rows[n].Cells[5].Value = item["valordeVendaPedido"].ToString();
                lblteste.Rows[n].Cells[6].Value = item["quantidade"].ToString();

            }

        }

        public void adicionaAoCarrinho()
        {
           
            string codOp = codOperacao.ToString();

            Decimal vlc, vlv;
            int qtd = 0;

            vlc = Convert.ToDecimal(txtvalordeCompra.Text);
            vlv = Convert.ToDecimal(txtvalorDeVenda.Text);
            qtd = Convert.ToInt32(txtquantidade.Text);
           
            

            String mensagem = controleVenda.adicionaAoCarrinho(codOp, lsbProduto.Text, txttipo.Text, vlc,
                vlv, qtd, txtestiloModelo.Text);
            if (controleVenda.tem)
            {
                MessageBox.Show(mensagem, "Adicionando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show(mensagem, "Adicionando", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }


        }

        public void procuraCodigoOperacao()
        {
            

            String codRecebe = controleVenda.procuraCodigoOperacao();
            if (controleVenda.tem)
            {

                
                codOperacao = Convert.ToInt32(codRecebe) + 1;
                
                
            }
            else
           {
                MessageBox.Show("ERRO DE CONEXÃO COM SERVIDOR", "OPERAÇÃO ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        public void procuraUltimoCodigoOperacao()
        {


            String codRecebe = controleVenda.procuraCodigoUltimoCodigoOperacao();
            if (controleVenda.tem)
            {
                codOperacao = Convert.ToInt32(codRecebe);
                listaCarrinho();
              
            }
            else
            {
                MessageBox.Show("ERRO DE CONEXÃO COM SERVIDOR", "OPERAÇÃO ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        #region design
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           
            procuraCodigoOperacao();
           

            lsbProduto.Enabled = true;
            txttipo.Enabled = true;
            txtvalordeCompra.Enabled = true;
            txtvalorDeVenda.Enabled = true;
            txtquantidade.Enabled = true;
            txtestiloModelo.Enabled = true;

            lsbProduto.Focus();
            btnCadastrar.Enabled = false;
            btnCancelar.Enabled = true;
            btnAdicionar.Enabled = true;
        }

        private void btnExtornar_MouseEnter(object sender, EventArgs e)
        {
            btnExtornar.Size = new Size(90, 43);
        }

        private void btnExtornar_MouseLeave(object sender, EventArgs e)
        {
            btnExtornar.Size = new Size(65, 43);
        }

        private void btnAdicionar_MouseEnter(object sender, EventArgs e)
        {
            btnAdicionar.Size = new Size(90, 43);
        }

        private void btnAdicionar_MouseLeave(object sender, EventArgs e)
        {
            btnAdicionar.Size = new Size(65, 43);
        }

        private void btnFinalizar_MouseEnter(object sender, EventArgs e)
        {
            btnFinalizar.Size = new Size(90, 43);
        }

        private void btnFinalizar_MouseLeave(object sender, EventArgs e)
        {
            btnFinalizar.Size = new Size(65, 43);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            if (validaMsg == 0)
            {
                MessageBox.Show("Para realizar uma venda, clique no botão adicionar", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            validaMsg = 1;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lsbProduto.Enabled = false;
            txttipo.Enabled = false;
            txtvalordeCompra.Enabled = false;
            txtvalorDeVenda.Enabled = false;
            txtquantidade.Enabled = false;
            txtestiloModelo.Enabled = false;

            btnCadastrar.Enabled = true;
            btnAdicionar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja finalizar a venda ?", "Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        #endregion

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            
            adicionaAoCarrinho();

            listaCarrinho();



        }

        
    }
}
