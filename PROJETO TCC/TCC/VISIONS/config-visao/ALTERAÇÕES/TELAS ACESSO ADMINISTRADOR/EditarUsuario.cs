using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using TCC.CONTROLE;

namespace TCC.VISÃO
{
    public partial class EditarUsuario : Form
    {

        //CLASSE PRINCIPAL DA TELA EDITAR USUARIO : CONFIG SISTEMA 





        #region VARIÁVEIS E INSTÂNCIAS
        string msg;
        bool tem;
        Conexao con = new Conexao();

        SqlDataReader dr;

        int validamsg = 0;
        #endregion






        #region CONSTRUTOR
        public EditarUsuario()
        {
            InitializeComponent();
        }

        #endregion






        #region MÉTODOS DE FUNCIONALIDADES


        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            listarUsuarios();

            SqlCommand cmd = new SqlCommand("SELECT usuario FROM logins", con.conectar());
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
            con.desconectar();


            formataGrid();



        }

        private void autoComplete()
        {
            if (txtnomeUsuario.Text != string.Empty)
            {
                string usuario = Convert.ToString(txtnomeUsuario.Text);
                //Elaborar Select que contenha cada um dos campos da tabela
                SqlCommand cmd = new SqlCommand("SELECT usuario, senha, cidade, endereco, cpf, complemento, bairro, telefone, cep, estado, perfil, departamento, numero FROM logins WHERE usuario = @param ", con.conectar());
                cmd.Parameters.AddWithValue("@param", txtnomeUsuario.Text);

                dr = cmd.ExecuteReader();
                //criar variáveis para armazenar os campos

                //atribuir as variáveis para os txts
                while (dr.Read())
                {
                    txtnovoNome.Text = dr["usuario"].ToString();
                    txtCidade.Text = dr["cidade"].ToString();
                    txtenderecoUsuario.Text = dr["numero"].ToString();
                    txtcpfUsuario.Text = dr["cpf"].ToString();
                    txtenderecoUsuario.Text = dr["endereco"].ToString();
                    txtbairroUsuario.Text = dr["bairro"].ToString();
                    txttelefoneUsuario.Text = dr["telefone"].ToString();
                    txtcomplementoUsuario.Text = dr["complemento"].ToString();
                    txtcepUsuario.Text = dr["cep"].ToString();
                    cbestadoUsuario.Text = dr["estado"].ToString();
                    cbperfilUsuario.Text = dr["perfil"].ToString();
                    cbdepartamentoUsuario.Text = dr["departamento"].ToString();
                    txtnovaSenha.Text = dr["senha"].ToString();



                }


                //colocar no formato auto-complete






                dr.Close();
                con.desconectar();
            }
            else
            {

                MessageBox.Show("Primeiro digite o nome do usuário que pretende alterar !!", "Defina o usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limparCampos();

                txtnomeUsuario.Focus();

            }
        }

        private void alteraDados()
        {
            if (txtnomeUsuario.Text == "")
            {
                MessageBox.Show("Defina o Usuário que deseja Alterar", "Erro de Confirmação!!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            else if (txtsenhaAdm.Text == "")
            {
                MessageBox.Show("Digite a senha de Administrador!!", "Erro de Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtsenhaAdm.Focus();
                
            }

            else if (txtnomeUsuario.Text != string.Empty && txtsenhaAdm.Text != string.Empty)
            {
                #region SelecionaSenhaAdm
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT senha FROM logins WHERE senha = @senha AND usuario = 'Usuário'";
                cmd.Parameters.AddWithValue("@senha", txtsenhaAdm.Text);

                try
                {
                    cmd.Connection = con.conectar();

                    if (!con.mensagem.Equals(""))
                    {
                        this.msg = con.mensagem;

                        MessageBox.Show(msg, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            tem = true;

                        }
                        else
                        {
                            tem = false;
                            MessageBox.Show("Senha de Administrador Inválida!!", "Erro de Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    dr.Close();
                    con.desconectar();
                }
                catch (Exception)
                {

                    msg = "Erro com o banco de dados";
                    MessageBox.Show(msg, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                #endregion

                if (tem == true)
                {
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.CommandText = "UPDATE logins SET cidade = @cidade, endereco = @endereco, complemento = @complemento, bairro = @bairro," +
                        "telefone = @telefone, CEP = @CEP, estado = @estado, " +
                        "perfil = @perfil, departamento = @departamento, senha = @senha WHERE usuario = @usuario";

                    cmd2.Parameters.AddWithValue("@usuario", txtnomeUsuario.Text);
                    cmd2.Parameters.AddWithValue("@cidade", txtCidade.Text);
                    cmd2.Parameters.AddWithValue("@endereco", txtenderecoUsuario.Text);
                    cmd2.Parameters.AddWithValue("@complemento", txtcomplementoUsuario.Text);
                    cmd2.Parameters.AddWithValue("@bairro", txtbairroUsuario.Text);
                    cmd2.Parameters.AddWithValue("@telefone", txttelefoneUsuario.Text);
                    cmd2.Parameters.AddWithValue("@CEP", txtcepUsuario.Text);
                    cmd2.Parameters.AddWithValue("@estado", cbestadoUsuario.Text);
                    cmd2.Parameters.AddWithValue("@perfil", cbperfilUsuario.Text);
                    cmd2.Parameters.AddWithValue("@departamento", cbdepartamentoUsuario.Text);
                    cmd2.Parameters.AddWithValue("@senha", txtnovaSenha.Text);

                    try
                    {
                        cmd2.Connection = con.conectar();
                        cmd2.ExecuteNonQuery();

                        MessageBox.Show("Alteração realizada com Sucesso!!", "Ação realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception)
                    {

                        msg = "Erro com o banco de dados";
                        MessageBox.Show(msg, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    limparCampos();
                    dr.Close();
                    con.desconectar();

                }

            }
        }

        private void limparCampos()
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
            txtsenhaAdm.Text = ("");
        }

        public void listarUsuarios()
        {

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandText = ("SELECT * FROM logins ORDER BY usuario ASC");
            sqlcmd.Connection = con.conectar();


            try
            {
                con.conectar();
                sqlcmd.ExecuteNonQuery();


                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();

                da.Fill(dt);






                dtgeditarUsuario.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dtgeditarUsuario.Rows.Add();

                    dtgeditarUsuario.Rows[n].Cells[0].Value = item["codUser"].ToString();
                    dtgeditarUsuario.Rows[n].Cells[1].Value = item["usuario"].ToString();
                    dtgeditarUsuario.Rows[n].Cells[2].Value = item["CPF"].ToString();
                    dtgeditarUsuario.Rows[n].Cells[3].Value = item["telefone"].ToString();
                    dtgeditarUsuario.Rows[n].Cells[4].Value = item["sexo"].ToString();
                    dtgeditarUsuario.Rows[n].Cells[5].Value = item["cep"].ToString();
                    dtgeditarUsuario.Rows[n].Cells[6].Value = item["complemento"].ToString();
                    dtgeditarUsuario.Rows[n].Cells[7].Value = item["cidade"].ToString();
                    dtgeditarUsuario.Rows[n].Cells[8].Value = item["bairro"].ToString();
                    dtgeditarUsuario.Rows[n].Cells[9].Value = item["estado"].ToString();
                    dtgeditarUsuario.Rows[n].Cells[10].Value = item["Senha"].ToString();
                    dtgeditarUsuario.Rows[n].Cells[11].Value = item["perfil"].ToString();
                    dtgeditarUsuario.Rows[n].Cells[12].Value = item["endereco"].ToString();
                    dtgeditarUsuario.Rows[n].Cells[13].Value = item["numero"].ToString();
                    dtgeditarUsuario.Rows[n].Cells[14].Value = item["email"].ToString();
                    dtgeditarUsuario.Rows[n].Cells[15].Value = item["departamento"].ToString();











                }
                con.desconectar();
                //dtEmail.DataSource = dt;



            }
            catch (Exception)
            {

                throw;
            }
        }

        private void formataGrid()
        {

            
            dtgeditarUsuario.BorderStyle = BorderStyle.None;  //DTEMAIL NOME DA VARIÁVEL
            //dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtgeditarUsuario.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            // dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            /// dataGridView1.BackgroundColor = Color.White;

            dtgeditarUsuario.EnableHeadersVisualStyles = false;
            dtgeditarUsuario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgeditarUsuario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 209, 178);     //FromArgb(20, 25, 72);
            dtgeditarUsuario.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
           
        }


        #endregion






        #region DESIGN
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
            autoComplete();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            alteraDados();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();

        }



        private void txtnomeUsuario_TextChanged_1(object sender, EventArgs e)
        {


            if (txtnomeUsuario.Text == "")
            {
                limparCampos();

                txtnomeUsuario.Focus();

            }


        }




        private void btnConfirmar_MouseEnter(object sender, EventArgs e)
        {
            lblconfirmar.Visible = true;

            btnconfirmar.Size = new Size(50, 38);


        }

        private void btnConfirmar_MouseLeave(object sender, EventArgs e)
        {
            lblconfirmar.Visible = false;
            btnconfirmar.Size = new Size(49, 35);
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            lblcancelar.Visible = true;
            btncancelar.Size = new Size(50, 38);

        }

        private void btncancelar_MouseLeave(object sender, EventArgs e)
        {
            lblcancelar.Visible = false;
            btncancelar.Size = new Size(49, 35);
        }


        //Excluir esses dois eventos
        private void btnexcluir_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnexcluir_MouseLeave(object sender, EventArgs e)
        {

        }




        private void btnexcluir_MouseEnter_1(object sender, EventArgs e)
        {
            lblexcluir.Visible = true;
            btnexcluir.Size = new Size(50, 38);
        }

        private void btnexcluir_MouseLeave_1(object sender, EventArgs e)
        {
            lblexcluir.Visible = false;
            btnexcluir.Size = new Size(49, 35);
        }


        private void pbolhoFechado_Click(object sender, EventArgs e)
        {
            txtsenhaAdm.PasswordChar = (char)0;
            pbolhoFechado.Visible = false;
            pbolhoAberto.Visible = true;
        }

        private void pbolhoAberto_Click(object sender, EventArgs e)
        {
            txtsenhaAdm.PasswordChar = '*';
            pbolhoAberto.Visible = false;
            pbolhoFechado.Visible = true;
        }

        private void pbolhoAberto_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pbolhoAberto_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pbolhoFechado_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pbolhoFechado_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        #endregion


    }
}