using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using TCC.MODELO;

namespace TCC.VISÃO
{


    public partial class CadastroVendas : Form
    {

        //CLASSE PRINCIPAL DO FORMULÁRIO




        #region VARIÁVEIS E INSTÂNCIAS 
        ControleVenda controleVenda = new ControleVenda();
        int codOperacao = 0;
        int validaMsg = 0;

        #endregion






        #region CONSTRUTOR
        public CadastroVendas()
        {
            InitializeComponent();


        }

        #endregion






        #region MÉTODOS DE FUNCIONALIDADES

        private void CadastroVendas_Load(object sender, EventArgs e)
        {

            // TODO: esta linha de código carrega dados na tabela 'tccDataSet.produtos'. Você pode movê-la ou removê-la conforme necessário.
            //this.produtosTableAdapter.Fill(this.tccDataSet.produtos);

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








        } //FORM LOAD

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

        } //LISTAGEM DE CARRINHO 

        public void adicionaAoCarrinho()
        {

            string codOp = codOperacao.ToString();


            Decimal vlc, vlv;
            float qtd = 0;


            float valorDeVendapedido = float.Parse(txtvalorDeVenda.Text);

            vlc = Convert.ToDecimal(txtvalordeCompra.Text);
            vlv = Convert.ToDecimal(txtvalorDeVenda.Text);

            #region quantidade * valor de venda
            qtd = float.Parse(txtquantidade.Text);
            float quantidade = float.Parse(txtquantidade.Text);

            float valorTot = qtd * valorDeVendapedido;
            #endregion



            String mensagem = controleVenda.adicionaAoCarrinho(codOp, lsbProduto.Text, txttipo.Text, vlc,
                vlv, quantidade, txtestiloModelo.Text, valorTot);
            if (controleVenda.tem)
            {
                MessageBox.Show(mensagem, "Adicionando", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(mensagem, "Adicionando", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        } //ADICIONA AO CARRINHO 

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


        } //FAZ A BUSCA DO ÚLTIMO CÓDIGO DE OPERAÇÃO E ADICIONA 1

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


        } //FAZ A BUSCA DO ÚLTIMO CÓDIGO DE OPERAÇÃO

        public void retiraDoCarrinho()
        {
            string codOp = codOperacao.ToString();



            String mensagem = controleVenda.deletaTodosProdutosDoCarrinho(codOp);
            if (controleVenda.tem)
            {
                MessageBox.Show(mensagem, "Carrinho", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(mensagem, "Carrinho", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        } //RETIRA TODOS PRODUTOS DO CARRINHO


        public void desativaCarrinho()
        {
            lsbProduto.Enabled = false;

            txttipo.Enabled = false;

            txtvalordeCompra.Enabled = false;

            txtvalorDeVenda.Enabled = false;

            txtquantidade.Enabled = false;

            txtestiloModelo.Enabled = false;
        }

        public void reativaCarrinho()
        {
            lsbProduto.Enabled = true;

            txttipo.Enabled = true;

            txtvalordeCompra.Enabled = true;

            txtvalorDeVenda.Enabled = true;

            txtquantidade.Enabled = true;

            txtestiloModelo.Enabled = true;
        }

        public void ativaSegundaEtapa()
        {
            lsbpgt.Enabled = true;
            txtDesconto.Enabled = true;
        }

        public void somaProdutosAdicionadosAoCarrinho()
        {
            int codSoma = this.codOperacao;

            float desconto;
            String valor;


            float valorTotalSemDesconto;
            String valorSemDesconto;

            float valorTotalComDesconto;
            String valorComDesconto;



            valor = controleVenda.somaProdutosAdicionadosAoCarrinho(codSoma);




            if (txtDesconto.Text == string.Empty)
            {
                valorTotalSemDesconto = float.Parse(valor);
                valorSemDesconto = string.Format("{0:C}", valorTotalSemDesconto);
                txtTotal.Text = valorSemDesconto.ToString();
            }
            else
            {

                desconto = float.Parse(txtDesconto.Text);
                float resultDesconto = float.Parse(valor);

                float desc = (desconto * resultDesconto) / 100;

                valorTotalComDesconto = resultDesconto - desc;





                valorComDesconto = string.Format("{0:C}", valorTotalComDesconto);
                txtTotal.Text = valorComDesconto.ToString();



            }


        }

        #endregion






        #region DESIGN

        public string MaiusculaTxt(TextBox tbox)
        {
            TextInfo textinfo = new CultureInfo("PT-BR", true).TextInfo;
            tbox.Text = textinfo.ToTitleCase(tbox.Text);
            return tbox.Text;
        }

        public string Maiusculacmb(ComboBox cmbox)
        {
            TextInfo textinfo = new CultureInfo("PT-BR", true).TextInfo;
            cmbox.Text = textinfo.ToTitleCase(cmbox.Text);
            return cmbox.Text;
        }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            #region design
            lsbProduto.Enabled = false;
            txttipo.Enabled = false;
            txtvalordeCompra.Enabled = false;
            txtvalorDeVenda.Enabled = false;
            txtquantidade.Enabled = false;
            txtestiloModelo.Enabled = false;

            btnCadastrar.Enabled = true;
            btnAdicionar.Enabled = false;
            btnCancelar.Enabled = false;

            lsbProduto.Text = "";
            txttipo.Text = "";
            txtvalordeCompra.Text = "";
            txtvalorDeVenda.Text = "";
            txtquantidade.Text = "";
            txtestiloModelo.Text = "";

            btnCadastrar.Text = "";
            btnAdicionar.Text = "";
            btnCancelar.Text = "";
            #endregion
            retiraDoCarrinho();
            listaCarrinho();


        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            adicionaAoCarrinho();

            listaCarrinho();



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

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            desativaCarrinho();
            if (MessageBox.Show("Deseja finalizar a venda ?", "Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                somaProdutosAdicionadosAoCarrinho();
                ativaSegundaEtapa();
            }
            else
            {
                reativaCarrinho();
            }

        }

        private void lsbProduto_Leave(object sender, EventArgs e)
        {
            Maiusculacmb(lsbProduto);
        }

        private void txttipo_Leave(object sender, EventArgs e)
        {
            MaiusculaTxt(txttipo);
        }

        private void txtestiloModelo_Leave(object sender, EventArgs e)
        {
            Maiusculacmb(txtestiloModelo);
        }


        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            somaProdutosAdicionadosAoCarrinho();
        }

        private void txtvalordeCompra_TextChanged(object sender, EventArgs e)
        {

           

            //txtvalordeCompra.Text = String.Format("{0:C}");

        }




        #endregion


    }
}
