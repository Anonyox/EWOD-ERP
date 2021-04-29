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
using System.Data.OleDb;

namespace TCC.VISÃO
{
    public partial class EditarUsuario : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source= tcp: 177.125.224.84,9022;Initial Catalog=tcc;User ID=etec;Password=123456;connection timeout = 1");
        SqlDataReader dr;

        int validamsg = 0;
        public EditarUsuario()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tccDataSet.logins'. Você pode movê-la ou removê-la conforme necessário.
            this.loginsTableAdapter.Fill(this.tccDataSet.logins);
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT usuario FROM logins", con);
            //cmd.CommandText = ;

            dr = cmd.ExecuteReader();

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            while (dr.Read())
            {
                collection.Add(dr["usuario"].ToString());
            }

            txtnomeUsuario.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtnomeUsuario.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtnomeUsuario.AutoCompleteCustomSource = collection;

            dr.Close();
            con.Close();


        }


        private void EditarUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            if (validamsg == 0)
            {
                MessageBox.Show("Primeiro digite o nome do usuário que pretende alterar !!", "Defina o usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            validamsg = 1;


        }

        private void txtnomeUsuario_MouseClick(object sender, MouseEventArgs e)
        {






        }

        private void txtnomeUsuario_Leave(object sender, EventArgs e)
        {
            





        }

        private void txtnomeUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtnomeUsuario_Leave_1(object sender, EventArgs e)
        {
            string usuario = Convert.ToString(txtnomeUsuario.Text);
            con.Open();
            //Elaborar Select que contenha cada um dos campos da tabela
            SqlCommand cmd = new SqlCommand("SELECT cidade,endereco,complemento,bairro,telefone,CEP,estado,perfil,departamento FROM logins WHERE usuario LIKE @param ", con);
            cmd.Parameters.AddWithValue("@param", txtnomeUsuario.Text + "%");
            dr = cmd.ExecuteReader();
            //criar variáveis para armazenar os campos
            AutoCompleteStringCollection collection2 = new AutoCompleteStringCollection();

            //atribuir as variáveis para os txts
            while (dr.Read())
            {

                collection2.Add(dr["cidade"].ToString());
                txtCidade.Text = dr["cidade"].ToString();
                txtenderecoUsuario.Text = dr["endereco"].ToString();
                txtbairroUsuario.Text = dr["bairro"].ToString();
                txttelefoneUsuario.Text = dr["telefone"].ToString();
                txtcomplementoUsuario.Text = dr["complemento"].ToString();
                txtcepUsuario.Text = dr["CEP"].ToString();
                cbestadoUsuario.Text = dr["estado"].ToString();
                cbperfilUsuario.Text = dr["perfil"].ToString();
                cbdepartamentoUsuario.Text = dr["departamento"].ToString();
                

            }


            //colocar no formato auto-complete

            




            dr.Close();
            con.Close();

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {            
            string SenhaAdm = "";
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT senha FROM logins WHERE perfil = 'Administrador'",con);
            cmd.Parameters.AddWithValue("senha", SenhaAdm);
            dr = cmd.ExecuteReader();

            dr.Close();
            con.Close();

            if(txtnomeUsuario.Text == "")
            {
                MessageBox.Show("Defina o Usuário que deseja Alterar", "Erro de Confirmação!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
                if(txtsenhaAdm.Text == SenhaAdm)
                {
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("UPDATE SET cidade = @cidade, endereco = @endereco,complemento = @complemento,bairro = @bairro,telefone = @telefone, CEP = @CEP,estado = @estado,perfil = @perfil,departamento = @departemento WHERE usuario = @usuario");
                        cmd2.Parameters.AddWithValue("@cidade",txtCidade.Text);
                        cmd2.Parameters.AddWithValue("@usuario", txtnomeUsuario.Text);
                        cmd2.Parameters.AddWithValue("@endereco", txtenderecoUsuario.Text);
                        cmd2.Parameters.AddWithValue("@complemento", txtcomplementoUsuario.Text);
                        cmd2.Parameters.AddWithValue("@bairro", txtbairroUsuario.Text);
                        cmd2.Parameters.AddWithValue("@telefone", txttelefoneUsuario.Text);
                        cmd2.Parameters.AddWithValue("@CEP", txtcepUsuario.Text);
                        cmd2.Parameters.AddWithValue("@estado", cbestadoUsuario.Text);
                        cmd2.Parameters.AddWithValue("@perfil", cbperfilUsuario.Text);
                        cmd2.Parameters.AddWithValue("@departamento", cbdepartamentoUsuario.Text);
                    dr = cmd2.ExecuteReader();

                    MessageBox.Show("Alteração realizada com Sucesso!!", "Ação realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtnomeUsuario.Text = ("");
                    txtCidade.Text = ("");
                    txtcepUsuario.Text = ("");
                    txtbairroUsuario.Text = ("");
                    txtcomplementoUsuario.Text = ("");
                    cbperfilUsuario.Text = ("");
                    cbestadoUsuario.Text = ("");
                    cbdepartamentoUsuario.Text = ("");
                    txttelefoneUsuario.Text = ("");
                    txtenderecoUsuario.Text = ("");


                    dr.Close();
                    con.Close();

                }
                else if (txtsenhaAdm.Text != SenhaAdm)
                {
                    MessageBox.Show("Senha de Administrador inválida", "Erro de Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtnomeUsuario.Text = ("");
            txtCidade.Text = ("");
            txtcepUsuario.Text = ("");
            txtbairroUsuario.Text = ("");
            txtcomplementoUsuario.Text = ("");
            cbperfilUsuario.Text = ("");
            cbestadoUsuario.Text = ("");
            cbdepartamentoUsuario.Text = ("");
            txttelefoneUsuario.Text = ("");
            txtenderecoUsuario.Text = ("");
            
        }
    }
}   