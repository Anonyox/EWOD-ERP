using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using TCC.CONTROLE;
using TCC.MODELS.produto_modelo;

namespace TCC.VISÃO
{
    public partial class CadastroProduto : Form
    {


        #region CONSTRUTOR
        public CadastroProduto()
        {
            InitializeComponent();
            menuz.valida = 2;
            //listarProdutos();



        }
        #endregion





        #region VARIÁVEIS E INSTÂNCIAS

        menuAdministrador menuz = new menuAdministrador();
        produtoControle cadpro = new produtoControle();

        SqlDataReader dr;
        Conexao con = new Conexao();

        bool tem = false;

        public DateTime datadecadastro = System.DateTime.Now;

        string nomeAnterior = "";



        #endregion






        #region MÉTODOS DE FUNCIONALIDADES

        public void listarProdutos()
        {
            DataTable dtr = new DataTable();



            dtr = cadpro.listarProdutos();

            dtproduto.Rows.Clear();


            foreach (DataRow item in dtr.Rows)
            {

                dtproduto.Refresh();

                int n = dtproduto.Rows.Add();
                //dtproduto.Rows[n].Cells[0].Value = Properties.Resources.icons8_editar_propriedade_100;
                dtproduto.Rows[n].Cells[0].Value = item["nome"].ToString();
                dtproduto.Rows[n].Cells[1].Value = item["fornecedor"].ToString();
                dtproduto.Rows[n].Cells[2].Value = item["tipo"].ToString();
                dtproduto.Rows[n].Cells[3].Value = item["modelo"].ToString();
                dtproduto.Rows[n].Cells[4].Value = item["quantidade"].ToString();
                dtproduto.Rows[n].Cells[5].Value = item["valordecompra"].ToString();
                dtproduto.Rows[n].Cells[6].Value = item["valordevenda"].ToString();
                dtproduto.Rows[n].Cells[7].Value = item["dataDeCadastro"].ToString();



            }



        } //LISTAGEM DE PRODUTOS

        public string letraMaiscula(TextBox tbox)
        {
            TextInfo textinfo = new CultureInfo("PT-BR", true).TextInfo;
            tbox.Text = textinfo.ToTitleCase(tbox.Text);
            return tbox.Text;
        }

        public void alterarProduto()
        {

        }

        public bool verificarProduto()
        {
            string nomeProduto = txtnomeProduto.Text;

            this.tem = cadpro.verificarProduto(nomeProduto);

            if (cadpro.tem && btnsalvarAlteracao.Enabled == false)
            {


                MessageBox.Show("Produto já existente !!", "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);



                if (MessageBox.Show("Deseja alterar dados do produto existente ?", "ALTERAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    preencherCampos();
                    btnConfirmar.Enabled = false;
                    nomeAnterior = txtnomeProduto.Text;
                    btnsalvarAlteracao.Enabled = true;

                }
                else
                {
                    limparCampos();
                    txtnomeProduto.Focus();
                }

                return true;


            }

            return false;

            //DESEJA ALTERAR DADOS DESSE PRODUTO ?
        }

        public void buscarProduto()
        {

            SqlCommand cmd = new SqlCommand("SELECT nome FROM produtos", con.conectar());

            dr = cmd.ExecuteReader();

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            while (dr.Read())
            {
                collection.Add(dr["nome"].ToString());
            }

            txtnomeProduto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtnomeProduto.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtnomeProduto.AutoCompleteCustomSource = collection;


            dr.Close();
            con.desconectar();


        }

        public void preencherCampos()
        {
            if (txtnomeProduto.Text != string.Empty || btnsalvarAlteracao.Enabled == false)
            {
                txtdata.Text = datadecadastro.ToString();
                SqlCommand command = new SqlCommand("SELECT P.nome, P.fornecedor,P.tipo, P.modelo, format (P.valordeCompra, 'c', 'pt-br') as valordeCompra, format (P.valordeVenda, 'c', 'pt-br') as valordeVenda, P.dataDeCadastro,E.idProdutoEstoque, E.Quantidade, E.datadeCadastro FROM produtos P INNER JOIN estoqueProdutos E ON E.idProduto = P.codProduto WHERE nome = @nome", con.conectar());
                command.Parameters.AddWithValue("@nome", txtnomeProduto.Text);

                dr = command.ExecuteReader();

                while (dr.Read())
                {
                    txtdata.Text = dr["dataDeCadastro"].ToString();
                    txtmodeloProduto.Text = dr["modelo"].ToString();
                    txtfornecedor.Text = dr["fornecedor"].ToString();
                    txtquantidadeProduto.Text = dr["quantidade"].ToString();
                    txtvalorCompra.Text = dr["valordeCompra"].ToString();
                    txtvalorVenda.Text = dr["valordeVenda"].ToString();
                    txttipo.Text = dr["tipo"].ToString();

                    letraMaiscula(txttipo);
                    letraMaiscula(txtfornecedor);
                    letraMaiscula(txtmodeloProduto);

                }

                dr.Close();
                con.desconectar();

                if (txtnomeProduto.Text == string.Empty || btnsalvarAlteracao.Enabled == true)
                {
                    limparCampos();
                    txtnomeProduto.Focus();
                }
            }

        }

        private void limparCampos()
        {
            txtnomeProduto.Text = "";
            txtfornecedor.Text = "";
            txtdata.Text = "";
            txtmodeloProduto.Text = "";
            txtvalorCompra.Text = "";
            txtvalorVenda.Text = "";
            txtquantidadeProduto.Text = "";
            txttipo.Text = "";
        }

        public bool verificarCampos()
        {
            if (txtnomeProduto.Text == string.Empty | txtdata.Text == string.Empty | txtmodeloProduto.Text == string.Empty | txtquantidadeProduto.Text == string.Empty |
                txtfornecedor.Text == string.Empty | txttipo.Text == string.Empty | txtvalorCompra.Text == string.Empty | txtvalorVenda.Text == string.Empty)
            {
                btnConfirmar.Enabled = false;


                return false;
            }
            else
            {
                btnConfirmar.Enabled = true;

                return true;
            }

        }

        public void cadastrarProdutos()
        {
            string valordeCompraNovo = txtvalorCompra.Text;
            string valordeVendaNovo = txtvalorVenda.Text;


            char[] MyChar = { 'R', '$' };
            valordeCompraNovo = valordeCompraNovo.TrimStart(MyChar);
            valordeVendaNovo = valordeVendaNovo.TrimStart(MyChar);



            float valordeCompra = float.Parse(valordeCompraNovo);
            float valordeVenda = float.Parse(valordeVendaNovo);
            float quantidade = float.Parse(txtquantidadeProduto.Text);







            if (MessageBox.Show("Deseja Cadastrar um Novo Produto ?", "CADASTRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (!verificarCampos())
                {
                    MessageBox.Show("PREENCHA TODOS OS CAMPOS", "PREENCHER CAMPOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    String mensagem = cadpro.cadastrarProdutos(txtnomeProduto.Text, txtfornecedor.Text, txttipo.Text, txtmodeloProduto.Text,
                        quantidade, valordeCompra, valordeVenda, txtdata.Text);
                    if (cadpro.tem)
                    {
                        MessageBox.Show(mensagem, "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(cadpro.mensagem, "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (cadpro.mensagem == "CADASTRADO COM SUCESSO!!")
                    {
                        listarProdutos();
                        limparCampos();
                        btnConfirmar.Enabled = false;

                    }
                }
            }
        }

        public void formataGrid()
        {
            // TODO: esta linha de código carrega dados na tabela 'tccDataSet.logs'. Você pode movê-la ou removê-la conforme necessário.
            //this.logsTableAdapter.Fill(this.tccDataSet.logs);
            dtproduto.BorderStyle = BorderStyle.None;  //DTEMAIL NOME DA VARIÁVEL
            //dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtproduto.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            // dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            /// dataGridView1.BackgroundColor = Color.White;

            dtproduto.EnableHeadersVisualStyles = false;
            dtproduto.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtproduto.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 209, 178);     //FromArgb(20, 25, 72);
            dtproduto.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        public void salvarAlteracao()
        {
            string valordeCompraNovo = txtvalorCompra.Text;
            string valordeVendaNovo = txtvalorVenda.Text;


            char[] MyChar = { 'R', '$' };
            valordeCompraNovo = valordeCompraNovo.TrimStart(MyChar);
            valordeVendaNovo = valordeVendaNovo.TrimStart(MyChar);



            float valordeCompra = float.Parse(valordeCompraNovo);
            float valordeVenda = float.Parse(valordeVendaNovo);
            float quantidade = float.Parse(txtquantidadeProduto.Text);







            if (MessageBox.Show("Deseja Salvar as alterações ?", "ALTERAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (!verificarCampos())
                {
                    MessageBox.Show("PREENCHA TODOS OS CAMPOS", "PREENCHER CAMPOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    String mensagem = cadpro.salvarAlteracao(this.nomeAnterior, txtnomeProduto.Text, txtfornecedor.Text, txttipo.Text, txtmodeloProduto.Text,
                        quantidade, valordeCompra, valordeVenda, txtdata.Text);
                    if (cadpro.tem)
                    {
                        MessageBox.Show(mensagem, "ALTERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(cadpro.mensagem, "ALTERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (cadpro.mensagem == "ALTERADO COM SUCESSO!!")
                    {
                        listarProdutos();
                        limparCampos();
                        btnConfirmar.Enabled = false;
                        btnsalvarAlteracao.Enabled = false;

                    }
                }
            }
        }


        public void excluirProduto()
        {
            string nome = dtproduto.CurrentRow.Cells["nome"].Value.ToString();


            if (MessageBox.Show("DESEJA MESMO EXCLUIR ESTE PRODUTO ?","VERIFICAÇÃO DE AÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String mensagem = cadpro.excluirProduto(nome);

                if (cadpro.tem)
                {
                    MessageBox.Show(mensagem, "EXCLUSÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(cadpro.mensagem, "EXCLUSÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                limparCampos();
                txtnomeProduto.Focus();
            }
        }

        #endregion






        #region DESIGN
        private void CadastroProduto_Load_1(object sender, EventArgs e)
        {
            txtnomeProduto.Focus();

            formataGrid();


            listarProdutos();

            txtdata.ReadOnly = true;
            txtdata.Text = datadecadastro.ToString();
            buscarProduto();

        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            listarProdutos();

            timer1.Start();

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnsalvarAlteracao.Enabled = false;
            btnConfirmar.Enabled = true;
            limparCampos();
        }



        private void btnSair_Click(object sender, EventArgs e)
        {
            if (txtnomeProduto.Text == string.Empty && txtfornecedor.Text == string.Empty && txtmodeloProduto.Text == string.Empty && txtquantidadeProduto.Text == string.Empty && txttipo.Text == string.Empty && txtvalorCompra.Text == string.Empty && txtvalorVenda.Text == string.Empty)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Primeiro, Cancele a Operação !!", "OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void CADASTRARPRODUTO_FormClosed(object sender, FormClosedEventArgs e)
        {
            //menuz.Show();
        }



        private void btnCadastrar_MouseEnter(object sender, EventArgs e)
        {
            //btnCadastrar.Size = new Size(100, 50);
        }



        private void btnCadastrar_MouseLeave(object sender, EventArgs e)
        {
            // btnCadastrar.Size = new Size(79, 35);
        }







        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }




        private void btnConfirmar_MouseEnter(object sender, EventArgs e)
        {
            lblconfirmar.Visible = true;
        }




        private void btnConfirmar_MouseLeave(object sender, EventArgs e)
        {
            lblconfirmar.Visible = false;
        }




        private void txtnomeProduto_Leave(object sender, EventArgs e)
        {
            verificarProduto();
            letraMaiscula(txtnomeProduto);

        }




        private void txtnomeProduto_TextChanged(object sender, EventArgs e)
        {

            preencherCampos();

            btnConfirmar.Enabled = true;

        }




        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(txtnomeProduto.Text == string.Empty)
            {
                MessageBox.Show("Digite o Produto que deseja Cadastrar!!", "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cadastrarProdutos();
                limparCampos();
            }
            
        }




        private void txtfornecedor_Leave_1(object sender, EventArgs e)
        {
            letraMaiscula(txtfornecedor);
        }




        private void txtmodeloProduto_Leave(object sender, EventArgs e)
        {
            letraMaiscula(txtmodeloProduto);
        }




        private void txttipo_Leave(object sender, EventArgs e)
        {
            letraMaiscula(txttipo);
        }




        private void btnsalvarAlteracao_Click(object sender, EventArgs e)
        {
            salvarAlteracao();
            limparCampos();
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            lblcancelar.Visible = true;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            lblcancelar.Visible = false;
        }




        #endregion

        private void dtproduto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.ColumnIndex == this.imgexcluir.Index && e.RowIndex >= 0)
            {
                excluirProduto();


            }
        }
    }

}