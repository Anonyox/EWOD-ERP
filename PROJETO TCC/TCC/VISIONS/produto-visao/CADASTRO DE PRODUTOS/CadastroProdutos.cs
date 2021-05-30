using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
            SqlCommand command = new SqlCommand("SELECT quantidade, valordeCompra, valordeVenda FROM produtos WHERE nome = @nome", con.conectar());
            command.Parameters.AddWithValue("@nome", txtnomeProduto.Text);

            dr = command.ExecuteReader();

            while (dr.Read())
            {
                //txtcodigoProduto.Text = dr["codProduto"].ToString();
                txtquantidadeProduto.Text = dr["quantidade"].ToString();
                txtvalorCompra.Text = dr["valordeCompra"].ToString();
                txtvalorVenda.Text = dr["valordeVenda"].ToString();
                //cmbtipo.Text = dr["tipo"].ToString();

            }

            dr.Close();
            con.desconectar();
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
            cmbtipo.Text = "";
        }

        public bool verificarCampos()
        {
            if (txtnomeProduto.Text == string.Empty | txtdata.Text == string.Empty | txtmodeloProduto.Text == string.Empty | txtquantidadeProduto.Text == string.Empty |
                txtfornecedor.Text == string.Empty | cmbtipo.Text == string.Empty | txtvalorCompra.Text == string.Empty | txtvalorVenda.Text == string.Empty)
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
            if (MessageBox.Show("Deseja Cadastrar um Novo Produto ?", "CADASTRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (!verificarCampos())
                {
                    MessageBox.Show("PREENCHA TODOS OS CAMPOS", "PREENCHER CAMPOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    String mensagem = cadpro.cadastrarProdutos(txtnomeProduto.Text, txtfornecedor.Text, cmbtipo.Text, txtmodeloProduto.Text,
                        txtquantidadeProduto.Text, txtvalorCompra.Text, valordeVenda.HeaderText, txtdata.Text);
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
                        limparCampos();
                        btnConfirmar.Enabled = false;

                    }
                }
            }
        }


        #endregion






        #region DESIGN

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
            //buscarProduto();                  
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
            preencherCampos();
        }

        #endregion

    }
}