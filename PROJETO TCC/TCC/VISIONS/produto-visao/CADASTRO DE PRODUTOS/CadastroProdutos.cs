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
            timer1.Start();
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

        int validamsg = 0;


        #endregion






        #region MÉTODOS DE FUNCIONALIDADES


        public void permitirApenasNumeros(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        } //PERMITIR APENAS NUMEROS
        public void listarProdutos()
        {
            DataTable dtr = new DataTable();



            dtr = cadpro.listarProdutos();

            dtproduto.Rows.Clear();


            foreach (DataRow item in dtr.Rows)
            {

                dtproduto.Refresh();

                int n = dtproduto.Rows.Add();
                dtproduto.Rows[n].Cells[0].Value = Properties.Resources.editar_datagrid;
                dtproduto.Rows[n].Cells[2].Value = item["nome"].ToString();
                dtproduto.Rows[n].Cells[3].Value = item["fornecedor"].ToString();
                dtproduto.Rows[n].Cells[4].Value = item["tipo"].ToString();
                dtproduto.Rows[n].Cells[5].Value = item["modelo"].ToString();
                dtproduto.Rows[n].Cells[6].Value = item["quantidade"].ToString();
                dtproduto.Rows[n].Cells[7].Value = item["valordecompra"].ToString();
                dtproduto.Rows[n].Cells[8].Value = item["valordevenda"].ToString();
                dtproduto.Rows[n].Cells[9].Value = item["dataDeCadastro"].ToString();



            }



        } //LISTAGEM DE PRODUTOS

        public string letraMaiscula(TextBox tbox)
        {
            TextInfo textinfo = new CultureInfo("PT-BR", true).TextInfo;
            tbox.Text = textinfo.ToTitleCase(tbox.Text);
            return tbox.Text;
        }

        public bool verificarProduto()
        {
            string nomeProduto = txtnomeProduto.Text;

            this.tem = cadpro.verificarProduto(nomeProduto);

            if (cadpro.tem)
            {

                return true;


            }

            return false;

            //DESEJA ALTERAR DADOS DESSE PRODUTO ?
        }

        public void buscarProduto()
        {
            txtdata.Text = datadecadastro.ToString();

            SqlCommand cmd = new SqlCommand("SELECT nome FROM produtos", con.conectar());


            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }


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
            verificarProduto();
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


            char[] MyChar = { 'R','$'};
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
                    listarProdutos();
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

        public bool validaCampos()
        {
            if (txttipo.Text == "" || txtmodeloProduto.Text == "" || txtvalorVenda.Text == "" || txtvalorCompra.Text == "" || txtquantidadeProduto.Text == "")
                return false;
            else
                return true;
        }

        #endregion






        #region DESIGN

        private void CadastroProduto_MouseMove(object sender, MouseEventArgs e)
        {
            if(validamsg == 0)
            {
                MessageBox.Show("Para adicionar um produto ao estoque, clique no botão adicionar!!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            validamsg = 1;
        }



        private void CadastroProduto_Load_1(object sender, EventArgs e)
        {
            


            txtdata.ReadOnly = true;
            txtdata.Text = datadecadastro.ToString();

            buscarProduto();

            txtnomeProduto.Focus();

            formataGrid();


            listarProdutos();

            
            

        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            listarProdutos();

            timer1.Start();

        }


        private void dtproduto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtnomeProduto.Text = "";
            if (e.ColumnIndex == this.imgexcluir.Index && e.RowIndex >= 0)
            {
                excluirProduto();                

            }
            else if (dtproduto.SelectedRows.Count >= 0)
            {

                 txtnomeProduto.Text = dtproduto.SelectedRows[0].Cells[2].Value.ToString();
                txtfornecedor.Text = dtproduto.SelectedRows[0].Cells[3].Value.ToString();
                txttipo.Text = dtproduto.SelectedRows[0].Cells[4].Value.ToString();
                txtmodeloProduto.Text = dtproduto.SelectedRows[0].Cells[5].Value.ToString();
                txtquantidadeProduto.Text = dtproduto.SelectedRows[0].Cells[6].Value.ToString();
                txtvalorCompra.Text = dtproduto.SelectedRows[0].Cells[7].Value.ToString();
                txtvalorVenda.Text = dtproduto.SelectedRows[0].Cells[8].Value.ToString();
                txtdata.Text = dtproduto.SelectedRows[0].Cells[9].Value.ToString();

                btnsalvarAlteracao.Enabled = true;
                btnConfirmar.Enabled = false;
                txtnomeProduto.Enabled = false;
               

            


            }
           /* else
            {
                MessageBox.Show("Nenhum Produto selecionado", "SELEÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        


        private void btnCancelar_Click(object sender, EventArgs e)
        {
          
            if (txtnomeProduto.Text != "" )
            {
                limparCampos();
                txtnomeProduto.Enabled = true;
                txtnomeProduto.Focus();

                btnsalvarAlteracao.Enabled = false;
            }
            else
            {
                MessageBox.Show("Operação Cancelada!!", "OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnsalvarAlteracao.Enabled = false;
                btnAdicionar.Enabled = true;
                btnConfirmar.Enabled = false;
                btnCancelar.Enabled = false;

                dtproduto.Enabled = false;

                txtnomeProduto.Enabled = false;
                txttipo.Enabled = false;
                txtmodeloProduto.Enabled = false;
                txtfornecedor.Enabled = false;
                txtvalorCompra.Enabled = false;
                txtvalorVenda.Enabled = false;
                txtquantidadeProduto.Enabled = false;


            }
            
           
            
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
            btnConfirmar.Size = new Size(68, 40);
        }




        private void btnConfirmar_MouseLeave(object sender, EventArgs e)
        {
            lblconfirmar.Visible = false;
            btnConfirmar.Size = new Size(64, 38);
        }




        private void txtnomeProduto_Leave(object sender, EventArgs e)
        {
           
            verificarProduto();
            letraMaiscula(txtnomeProduto);

        }




        private void txtnomeProduto_TextChanged(object sender, EventArgs e)
        {
            txtdata.Text = datadecadastro.ToString();

            
            if (txtnomeProduto.Text == "")
            {
                btnConfirmar.Enabled = false;
                limparCampos();
            }
            else if (btnConfirmar.Enabled == true)
            {
                preencherCampos();
               
            }
            else
            {
                btnConfirmar.Enabled = true;
            }
          
        

        }




        private void btnConfirmar_Click(object sender, EventArgs e)
        {


            if (!verificarProduto())
            {

            
            if(txtnomeProduto.Text == string.Empty )
            {
                MessageBox.Show("Digite o nome do Produto que deseja Cadastrar!!", "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtnomeProduto.Focus();
            }
            else if (!validaCampos())
            {
                    MessageBox.Show("Digite os respectivos atributos do Produto!!", "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtnomeProduto.Focus();
            }
                else
                {
                    cadastrarProdutos();
                    limparCampos();
                }
            }
            else
            {
                MessageBox.Show("Produto já existente !!", "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);



                if (MessageBox.Show("Deseja alterar dados do produto existente ?", "ALTERAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    preencherCampos();
                    txtnomeProduto.Enabled = false;
                    btnConfirmar.Enabled = false;
                    nomeAnterior = txtnomeProduto.Text;
                    btnsalvarAlteracao.Enabled = true;

                }
                else
                {
                    limparCampos();
                    txtnomeProduto.Focus();
                }
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
            txtnomeProduto.Enabled = true;
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            lblcancelar.Visible = true;
            btnCancelar.Size = new Size(68, 40);
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            lblcancelar.Visible = false;
            btnCancelar.Size = new Size(64, 38);
        }


        private void btnSair_Click_1(object sender, EventArgs e)
        {
            if(btnCancelar.Enabled == true)
            {
                MessageBox.Show("Antes de sair, cancele a Operação!!", "OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Close();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnsalvarAlteracao_MouseEnter(object sender, EventArgs e)
        {
            lblsalvar.Visible = true;
            btnsalvarAlteracao.Size = new Size(68, 40);
        }

        private void btnsalvarAlteracao_MouseLeave(object sender, EventArgs e)
        {
            lblsalvar.Visible = false;
            btnsalvarAlteracao.Size = new Size(64, 38);

        }



        #endregion

        private void txtmodeloProduto_Leave_1(object sender, EventArgs e)
        {
            letraMaiscula(txtmodeloProduto);
        }

        private void btnAdicionar_MouseEnter(object sender, EventArgs e)
        {
            lbladicionar.Visible = true;
            btnAdicionar.Size = new Size(68, 35);
        }

        private void btnAdicionar_MouseLeave(object sender, EventArgs e)
        {
            lbladicionar.Visible = false;
            btnAdicionar.Size = new Size(64, 32);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operação Iniciada!!", "OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            dtproduto.Enabled = true;

            btnCancelar.Enabled = true;
            btnAdicionar.Enabled = false;
          

            txtnomeProduto.Enabled = true;
            txttipo.Enabled = true;
            txtmodeloProduto.Enabled = true;
            txtfornecedor.Enabled = true;
            txtvalorCompra.Enabled = true;
            txtvalorVenda.Enabled = true;
            txtquantidadeProduto.Enabled = true;

            txtnomeProduto.Focus();
        }

        private void txtvalorVenda_Leave(object sender, EventArgs e)
        {
            if(txtvalorVenda.Text != "")
            {
                float venda = float.Parse(txtvalorVenda.Text);
                txtvalorVenda.Text = string.Format("{0:C}", venda);
            }
         
        }

        private void txtvalorCompra_Leave(object sender, EventArgs e)
        {
            if(txtvalorCompra.Text != "")
            {
                float compra = float.Parse(txtvalorCompra.Text);
                txtvalorCompra.Text = string.Format("{0:C}", compra);
            }
        
        
        }

        private void txtvalorCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            permitirApenasNumeros(sender, e);
        }

        private void txtvalorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            permitirApenasNumeros(sender, e);
        }

        private void txtquantidadeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            permitirApenasNumeros(sender, e);
        }
    }

}