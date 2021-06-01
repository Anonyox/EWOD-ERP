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
            DataTable dt = cadpro.listarProdutos();

            dtgproduto.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dtgproduto.Rows.Add();

                dtgproduto.Rows[n].Cells[0].Value = item["nome"].ToString();
                dtgproduto.Rows[n].Cells[1].Value = item["fornecedor"].ToString();
                dtgproduto.Rows[n].Cells[2].Value = item["tipo"].ToString();
                dtgproduto.Rows[n].Cells[3].Value = item["modelo"].ToString();
                dtgproduto.Rows[n].Cells[4].Value = item["quantidade"].ToString();
                dtgproduto.Rows[n].Cells[5].Value = item["valordeCompra"].ToString();
                dtgproduto.Rows[n].Cells[6].Value = item["valordeVenda"].ToString();
                dtgproduto.Rows[n].Cells[7].Value = item["datadeCadastro"].ToString();

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

                

                if (MessageBox.Show("Deseja alterar dados do produto existente ?","ALTERAÇÃO",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
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
            if(txtnomeProduto.Text != string.Empty && btnsalvarAlteracao.Enabled == false)
            {
                txtdata.ReadOnly = false;
                SqlCommand command = new SqlCommand("SELECT quantidade, fornecedor, dataDeCadastro, modelo, tipo, valordeCompra, valordeVenda FROM produtos WHERE nome = @nome", con.conectar());
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
            }
            else
            {
                
                txtnomeProduto.Focus();

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
            float valordeCompra = float.Parse(txtvalorCompra.Text);
            float valordeVenda = float.Parse(txtvalorVenda.Text);
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
            dtgproduto.BorderStyle = BorderStyle.None;  //DTEMAIL NOME DA VARIÁVEL
            //dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtgproduto.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            // dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            /// dataGridView1.BackgroundColor = Color.White;

            dtgproduto.EnableHeadersVisualStyles = false;
            dtgproduto.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgproduto.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 209, 178);     //FromArgb(20, 25, 72);
            dtgproduto.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        public void salvarAlteracao()
        {
            float valordeCompra = float.Parse(txtvalorCompra.Text);
            float valordeVenda = float.Parse(txtvalorVenda.Text);
            float quantidade = float.Parse(txtquantidadeProduto.Text);






            if (MessageBox.Show("Deseja Salvar as alterações ?", "ALTERAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (!verificarCampos())
                {
                    MessageBox.Show("PREENCHA TODOS OS CAMPOS", "PREENCHER CAMPOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    String mensagem = cadpro.salvarAlteracao(this.nomeAnterior,txtnomeProduto.Text, txtfornecedor.Text, txttipo.Text, txtmodeloProduto.Text,
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


        #endregion






        #region DESIGN

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnsalvarAlteracao.Enabled = false;
            btnConfirmar.Enabled = true;
            limparCampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
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


        private void timer1_Tick(object sender, EventArgs e)
        {
            listarProdutos();
            timer1.Start();


        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {
            formataGrid();
            txtdata.ReadOnly = true;
            txtdata.Text = datadecadastro.ToString();
            buscarProduto();
            listarProdutos();                 
            //timer1.Start();           
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

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            cadastrarProdutos();
            limparCampos();
        }

        private void txtfornecedor_Leave(object sender, EventArgs e)
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


        #endregion

        
    }
}
