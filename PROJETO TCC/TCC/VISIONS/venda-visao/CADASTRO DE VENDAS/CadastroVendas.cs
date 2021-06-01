﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using TCC.CONTROLE;
using TCC.MODELO;

namespace TCC.VISÃO
{


    public partial class CadastroVendas : Form
    {

        //CLASSE PRINCIPAL DO FORMULÁRIO




        #region VARIÁVEIS E INSTÂNCIAS 
        ControleVenda controleVenda = new ControleVenda();
        SqlDataReader dr;
        Conexao con = new Conexao();
        int codOperacao = 0;
        int validaMsg = 0;
        string quantidadeEstoque;

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
            iniciaAutoComplete();
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

            DateTime data = DateTime.Now;
            txtData.Text = data.ToString();








        } //FORM LOAD

        public void iniciaAutoComplete()

        {

            SqlCommand cmd = new SqlCommand("SELECT nome FROM produtos where quantidade > 0", con.conectar());
            //cmd.CommandText = ;

            dr = cmd.ExecuteReader();

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            while (dr.Read())
            {
                collection.Add(dr["nome"].ToString());
            }

            lsbProduto.AutoCompleteMode = AutoCompleteMode.Suggest;
            lsbProduto.AutoCompleteSource = AutoCompleteSource.CustomSource;

            lsbProduto.AutoCompleteCustomSource = collection;

            dr.Close();
            con.desconectar();
        }   //INICIA AUTO COMPLETE

        public void limpaCampos()
        {
            lsbProduto.Text = "";
            txttipo.Text = "";
            txtvalordeCompra.Text = "";
            txtvalorDeVenda.Text = "";
            txtquantidade.Text = "";
            txtestiloModelo.Text = "";
        } //LIMPA OS CAMPOS

        private void autoComplete()
        {
            if (lsbProduto.Text != string.Empty)
            {
                string usuario = Convert.ToString(lsbProduto.Text);
                //Elaborar Select que contenha cada um dos campos da tabela
                SqlCommand cmd = new SqlCommand("SELECT tipo," +
                    " format (valordeCompra, 'c', 'pt-br') as valordeCompra, " +
                    " format (valordeVenda, 'c', 'pt-br') as valordeVenda, " +
                    " modelo " +
                    "FROM produtos WHERE nome = @param and quantidade > 0  ", con.conectar());

                cmd.Parameters.AddWithValue("@param", lsbProduto.Text);

                dr = cmd.ExecuteReader();
                //criar variáveis para armazenar os campos

                //atribuir as variáveis para os txts
                while (dr.Read())
                {

                    txttipo.Text = dr["tipo"].ToString();
                    MaiusculaTxt(txttipo);
                    txtvalordeCompra.Text = dr["valordeCompra"].ToString();
                    txtvalorDeVenda.Text = dr["valordeVenda"].ToString();
                    txtestiloModelo.Text = dr["modelo"].ToString();
                    Maiusculacmb(txtestiloModelo);



                }


                //colocar no formato auto-complete






                dr.Close();
                con.desconectar();
            }
            else
            {
                limpaCampos();
                lsbProduto.Focus();
            }
        } //COMPLETA OS CAMPOS

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
            if (txtquantidade.Text != "")
            {


                string codOp = codOperacao.ToString();


                Decimal vlc, vlv;
                float qtd = 0;


                string valorVenda = txtvalorDeVenda.Text;
                char[] MyChar = { 'R', '$' };
                string NewStringVenda = valorVenda.TrimStart(MyChar);

                string valorCompra = txtvalordeCompra.Text;
                char[] MyCharCompra = { 'R', '$' };
                string NewStringCompra = valorCompra.TrimStart(MyCharCompra);




                float valorDeVendapedido = float.Parse(NewStringVenda);
                float valorDeComprapedido = float.Parse(NewStringCompra);



                vlc = Convert.ToDecimal(NewStringCompra);
                vlv = Convert.ToDecimal(valorDeVendapedido);

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
                    btnFinalizar.Enabled = true;

                }
                else
                {
                    MessageBox.Show(mensagem, "Adicionando", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
            else
            {
                MessageBox.Show("Quantidade Inválida!!", "OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtquantidade.Focus();
                txtquantidade.Text = "";
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
                btnFinalizar.Enabled = false;


            }
            else
            {
                MessageBox.Show(mensagem, "Carrinho", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        } //RETIRA TODOS PRODUTOS DO CARRINHO

        public void verificaQuantidadeRestanteNoEstoque()
        {
            if (txtquantidade.Text != "")
            {


                string quantidade = controleVenda.verificaQuantidadeRestanteNoEstoque(lsbProduto.Text);
                if (controleVenda.tem)
                {
                    this.quantidadeEstoque = quantidade;
                }
                else
                {
                    this.quantidadeEstoque = "0";
                }

            }


        } //VERIFICAQUANTIDADERESTANTENOESTOQUE

        public void realizaCalculoEstoque()
        {



            if (txtquantidade.Text != string.Empty)
            {


                float qtdestoque = float.Parse(this.quantidadeEstoque);
                float qtdInserida = float.Parse(txtquantidade.Text);


                if (qtdInserida > qtdestoque)
                {
                    MessageBox.Show("Quantidade de produtos insuficiente!! \n" +
                        "Restando Apenas : " + qtdestoque + " Peças no Estoque!!", "OPERAÇÃO ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtquantidade.Text = "";
                }

            }




        }   //REALIZA CALCULO ESTOQUE

        public void desativaCarrinho()
        {
            lsbProduto.Enabled = false;

            txttipo.Enabled = false;

            txtvalordeCompra.Enabled = false;

            txtvalorDeVenda.Enabled = false;

            txtquantidade.Enabled = false;

            txtestiloModelo.Enabled = false;

            btnCadastrar.Enabled = false;
        }  //DESATIVAR CARRINHO

        public void reativaCarrinho()
        {
            lsbProduto.Enabled = true;

            txttipo.Enabled = true;

            txtvalordeCompra.Enabled = true;

            txtvalorDeVenda.Enabled = true;

            txtquantidade.Enabled = true;

            txtestiloModelo.Enabled = true;
        } //REATIVA CARRINHO

        public void desativaSegundaEtapa()
        {
            lsbpgt.Enabled = false;
            txtDesconto.Enabled = false;
        } //DESATIVA SEGUNTA ETAPA

        public void ativaSegundaEtapa()
        {
            lsbpgt.Enabled = true;
            txtDesconto.Enabled = true;
        } //ATIVA SEGUNDA ETAPA

        public void desativaTerceiraEtapa()
        {
            txtReferencia.Enabled = false;
            txtEndereco.Enabled = false;
            txtcidadeCliente.Enabled = false;
        } //DESATIVA TERCEIRA ETAPA 

        public void ativaTerceiraEtapa()
        {
            txtReferencia.Enabled = true;
            txtEndereco.Enabled = true;
            txtcidadeCliente.Enabled = true;

        } //ATIVA TERCEIRA ETAPA

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


        } //SOMA PRODUTOS ADICIONADOS AO CARRINHO

        public void permitirApenasNumeros(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        } //PERMITIR APENAS NUMEROS

        public bool verificaSeOMesmoProdutoJaFoiInserido()
        {
            string codOp = codOperacao.ToString();
            bool tem = controleVenda.verificaSeOMesmoProdutoJaFoiInserido(lsbProduto.Text, codOp);
            if (controleVenda.tem)
            {
                MessageBox.Show("Não é possível adicionar o mesmo produto novamente!!", "OPERAÇÃO ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lsbProduto.Text = "";
                txtquantidade.Text = "";
                return true;
            }
            return false;
        } //VERIFICA SE O MESMO PRODUTO JA FOI INSERIDO





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
            MessageBox.Show("Oparação Iniciada!", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);



            lsbProduto.Enabled = true;
            txtquantidade.Enabled = true;

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
            if (!verificaSeOMesmoProdutoJaFoiInserido())
            {
                adicionaAoCarrinho();
                lsbProduto.Text = null;
                txtquantidade.Text = null;
                listaCarrinho();
            }
            



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
            if (txtTotal.Text == "")
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
            else
            {
                if (MessageBox.Show("Adicionar endereço de entrega ?", "Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                }
                else
                {

                }

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

        }


        private void txtvalordeCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            permitirApenasNumeros(sender, e);
        }

        private void txtvalorDeVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            permitirApenasNumeros(sender, e);
        }

        private void txtquantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            permitirApenasNumeros(sender, e);


        }


        private void lsbProduto_TextChanged(object sender, EventArgs e)
        {

            autoComplete();
        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            permitirApenasNumeros(sender, e);
        }

        private void txtquantidade_TextChanged(object sender, EventArgs e)
        {
            if (txtquantidade.Text != "0")
            {
                verificaQuantidadeRestanteNoEstoque();
                realizaCalculoEstoque();
            }
            else
            {
                MessageBox.Show("Quantidade Inválida!!", "OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtquantidade.Focus();
                txtquantidade.Text = "";
            }


        }

        #endregion







    }
}
