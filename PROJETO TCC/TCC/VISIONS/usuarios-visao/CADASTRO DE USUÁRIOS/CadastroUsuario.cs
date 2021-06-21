using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TCC.MODELO;

namespace TCC.VISÃO
{
    public partial class CadastroUsuario : Form
    {

        //CLASSE PRINCIPAL DA TELA CADASTRO DE USUÁRIO





        #region VARIÁVEIS E INSTÂNCIAS
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        Controle controle = new Controle();
        menuAdministrador menuzAdm = new menuAdministrador();
        public String sexoSelecao;
        public string cpf;
        public static List<Button> botoes;
        //public String email;
        public bool ok = false;
        #endregion






        #region CONSTRUTOR
        public CadastroUsuario()
        {
            InitializeComponent();
            menuzAdm.valida = 2;
            validaTeclas();


        }
        #endregion






        #region MÉTODOS DE FUNCIONALIDADES

        private void cadastrarUsuário()
        {
            Controle controle = new Controle();
            verificaSexo();
            if (MessageBox.Show("Deseja cadastrar novo usuário ?", "CADASTRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {




                if (!verificaCamposCadastro())
                {

                    MessageBox.Show("Preencha todos os campos", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    String mensagem = controle.cadastrar(txtuser.Text, txtsenha.Text, txtconfSenha.Text, txtcpf.Text, txtdepart.Text, txtemail.Text,
                       cmbperfil.Text, txtendereco.Text, txtnumero.Text, txtcidade.Text, txtbairro.Text, txtestado.Text, txtcep.Text, txtcomplemento.Text, txttelefone.Text, sexoSelecao);
                    if (controle.tem)
                    {
                        MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(controle.mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    if (controle.mensagem == "CADASTRADO COM SUCESSO")
                    {
                        limpaCampos();


                        btnCadastrar.Enabled = false;
                        txtuser.Enabled = false;
                        txtsenha.Enabled = false;
                        txtconfSenha.Enabled = false;
                        txtemail.Enabled = false;
                        cmbperfil.Enabled = false;
                        txtcpf.Enabled = false;
                        chcSenha.Enabled = false;

                        txtendereco.Enabled = false;
                        txtestado.Enabled = false;
                        txtcidade.Enabled = false;
                        txtbairro.Enabled = false;
                        txtcomplemento.Enabled = false;
                        txtnumero.Enabled = false;

                        txtcep.Enabled = false;
                        txttelefone.Enabled = false;
                        txtdepart.Enabled = false;
                        rdbmasculino.Enabled = false;
                        rdbfeminino.Enabled = false;



                        // cmd.CommandText = "INSERT INTO logs VALUES(Novo Usuário Cadastrado)";


                    }
                }

            }
        } //CADASTRA USUÁRIO

        private void verificaSeUsuarioDigitadoJaEstaCadastrado()
        {
            Controle controle = new Controle();

            String mensagem = controle.verificaUsuario(txtuser.Text);

            if (mensagem == "USUÁRIO JÁ EXISTENTE, INSIRA UM USUÁRIO VÁLIDO")
            {
                if (MessageBox.Show("USUÁRIO JÁ CADASTRADO, INSIRA UM USUÁRIO VÁLIDO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)

                {
                    txtuser.Text = "";
                    txtuser.Focus();
                }


            }
        } //VERIFICA SE USUÁRIO DIGITADO JÁ É EXISTENTE NO BANCO 

        private void verificaSeCpfDigitadoJaEstaCadastrado()
        {
            Controle controle = new Controle();
            string cpf = txtcpf.Text;

            String mensagem = controle.verificaCpf(txtcpf.Text);

            if (VCPF.verificaCpf(cpf))
            {



                if (mensagem == "CPF JÁ CADASTRADO, INSIRA UM CPF VÁLIDO")
                {
                    if (MessageBox.Show("CPF JÁ CADASTRADO, INSIRA UM CPF VÁLIDO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)

                    {
                        txtcpf.Text = "";
                        txtcpf.Focus();

                    }
                }
            }
            else
            {
                MessageBox.Show("CPF INVÁLIDO, INSIRA UM CPF VÁLIDO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcpf.Text = "";
                txtcpf.Focus();
            }
        } //VERIFICA SE CPF DIGITADO JÁ É EXISTENTE NO BANCO

        private void verificaSeEmailDigitadoJaEstaCadastrado()
        {
            Controle controle = new Controle();
            string email = txtemail.Text;

            String mensagem = controle.verificaEmail(txtemail.Text);

            if (VEMAIL.validaEmail(email))
            {



                if (mensagem == "EMAIL JÁ CADASTRADO, INSIRA UM EMAIL VÁLIDO")
                {
                    if (MessageBox.Show("EMAIL JÁ CADASTRADO, INSIRA UM EMAIL VÁLIDO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)

                    {
                        txtemail.Text = "";
                        txtemail.Focus();

                    }
                }
            }
            else
            {
                MessageBox.Show("EMAIL INVÁLIDO, INSIRA UM EMAIL VÁLIDO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtemail.Text = "";
                txtemail.Focus();
            }
        } //VERIFICA SE O EMAIL DIGITADO JÁ É EXISTENTE NO BANCO

        public void listaUsers()
        {

            controle.listaUser();

            DataTable dt = new DataTable();

            dt = controle.dtr;

            dtUsers.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {

                int n = dtUsers.Rows.Add();
                dtUsers.Rows[n].Cells[0].Value = item["usuario"].ToString();
                dtUsers.Rows[n].Cells[1].Value = item["departamento"].ToString();
                dtUsers.Rows[n].Cells[2].Value = item["email"].ToString();
                dtUsers.Rows[n].Cells[3].Value = item["telefone"].ToString();
                dtUsers.Rows[n].Cells[4].Value = item["sexo"].ToString();

            }
        } //LISTA TODOS OS USUÁRIOS CADASTRADOS

        private void limpaCampos()
        {
            txtuser.Text = "";
            txtsenha.Text = "";
            txtconfSenha.Text = "";
            txtcpf.Text = "";
            txtdepart.Text = "";
            txtemail.Text = "";
            txtestado.Text = "";
            txtcep.Text = "";
            cmbperfil.Text = "";
            txtendereco.Text = "";
            txtnumero.Text = "";
            txtcidade.Text = "";
            txtbairro.Text = "";
            txtcomplemento.Text = "";
            txttelefone.Text = "";
            rdbmasculino.Checked = false;
            rdbfeminino.Checked = false;
        } //LIMPA OS CAMPOS 

        private void verificaSexo()
        {
            if (rdbmasculino.Checked)
            {
                sexoSelecao = "Masculino";
            }
            else if (rdbfeminino.Checked)
            {
                sexoSelecao = "Feminino";
            }
            else
            {
                sexoSelecao = "";
            }
        } //VERIFICA RDB PRESSIONADO

        public bool verificaCamposCadastro()
        {
            if (txtuser.Text == string.Empty | txtsenha.Text == string.Empty
                | txtconfSenha.Text == string.Empty | txtcpf.Text == string.Empty |
                txtdepart.Text == string.Empty | txtemail.Text == string.Empty | cmbperfil.Text == string.Empty |
                txtendereco.Text == string.Empty |
                txtnumero.Text == string.Empty | txtbairro.Text == string.Empty | txtcomplemento.Text == string.Empty |
                txttelefone.MaskFull == false)
            {
                btnCadastrar.Enabled = false;

                return false;
            }
            else
            {
                btnlimpar.Enabled = true;


                return true;
            }








        } //VERIFICA SE OS CAMPOS ESTÃO PREENCHIDOS

        public string Maiuscula(TextBox tbox)
        {
            TextInfo textinfo = new CultureInfo("PT-BR", true).TextInfo;
            tbox.Text = textinfo.ToTitleCase(tbox.Text);
            return tbox.Text;
        } //TORNA A PRIMEIRA LETRA DO CAMPO MAÍÚSCULA 

        private void validaTeclas()
        {
            txtsenha.MaxLength = 10;
            txtconfSenha.MaxLength = 10;
            txtuser.MaxLength = 15;
            txtdepart.MaxLength = 20;
            txtnumero.MaxLength = 10;
            txtbairro.MaxLength = 20;
            txtcomplemento.MaxLength = 15;
            txtcidade.MaxLength = 20;

        } //VALIDA TECLAS DE ACORDO COM CADA CAMPO

        private void formataGrid()
        {
             //CadastroUsuario cad = new CadastroUsuario();
            //cad.Size = new Size(1155, 1000);



            // TODO: esta linha de código carrega dados na tabela 'tccDataSet.produtos'. Você pode movê-la ou removê-la conforme necessário.


            dtUsers.BorderStyle = BorderStyle.None;  //DTEMAIL NOME DA VARIÁVEL
            //dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            // dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            /// dataGridView1.BackgroundColor = Color.White;

            dtUsers.EnableHeadersVisualStyles = false;
            dtUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 209, 178);     //FromArgb(20, 25, 72);
            dtUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        } //FORMATA DATA GRID 

        private void CadastroUsuario_Shown(object sender, EventArgs e)
        {

            formataGrid();
            listaUsers();
            MessageBox.Show("Para cadastrar um usuário, clique no botão adicionar!!", "Novo Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);

        } //LOAD DO FORM
        #endregion






        #region DESIGN
        private void btnAcessar_Click(object sender, EventArgs e)

        {
            cadastrarUsuário();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            Close();

        }

        private void CadastroUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            btnCadastrar.Visible = true;
            lblendereco.Visible = true;
            lblnumero.Visible = true;
            lblcidade.Visible = true;
            lblbairro.Visible = true;
            lblestado.Visible = true;
            lblcep.Visible = true;
            lblcomplemento.Visible = true;
            lbltelefone.Visible = true;

            txtendereco.Visible = true;
            txtnumero.Visible = true;
            txtcidade.Visible = true;
            txtbairro.Visible = true;
            txtestado.Visible = true;
            txtcep.Visible = true;
            txtcomplemento.Visible = true;
            txttelefone.Visible = true;


        }

        private void chcSenha_MouseEnter(object sender, EventArgs e)
        {

        }

        private void chcSenha_MouseLeave(object sender, EventArgs e)
        {

        }

        private void chcSenha_Click(object sender, EventArgs e)
        {

            if (chcSenha.Checked)
            {
                txtsenha.UseSystemPasswordChar = false;
                txtconfSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtsenha.UseSystemPasswordChar = true;
                txtconfSenha.UseSystemPasswordChar = true;
            }
        }



        private void cmbPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CadastroUsuario_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operação Cancelada!!", "OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpaCampos();
            txtuser.Enabled = false;
            txtsenha.Enabled = false;
            txtconfSenha.Enabled = false;
            txtemail.Enabled = false;
            cmbperfil.Enabled = false;
            txtcpf.Enabled = false;
            chcSenha.Enabled = false;

            txtendereco.Enabled = false;
            txtestado.Enabled = false;
            txtcidade.Enabled = false;
            txtbairro.Enabled = false;
            txtcomplemento.Enabled = false;
            txtnumero.Enabled = false;

            txtcep.Enabled = false;
            txttelefone.Enabled = false;
            txtdepart.Enabled = false;
            rdbmasculino.Enabled = false;
            rdbfeminino.Enabled = false;

            btnlimpar.Enabled = false;
            btnAdicionar.Enabled = true;
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            Maiuscula(txtuser);
            verificaSeUsuarioDigitadoJaEstaCadastrado();
        }

        private void txtDepart_Leave(object sender, EventArgs e)
        {
            Maiuscula(txtdepart);
        }

        private void txtEndereco_Leave(object sender, EventArgs e)
        {
            Maiuscula(txtendereco);
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            Maiuscula(txtnumero);
        }

        private void txtCidade_Leave(object sender, EventArgs e)
        {
            Maiuscula(txtcidade);
        }

        private void txtBairro_Leave(object sender, EventArgs e)
        {
            Maiuscula(txtbairro);
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDepart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtComplemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void rdbMasculino_Click(object sender, EventArgs e)
        {


            if (verificaCamposCadastro())
            {
                rdbmasculino.Checked = true;
                btnCadastrar.Enabled = true;


            }
            else
            {
                rdbmasculino.Checked = false;
            }



        }

        private void rdbFeminino_Click(object sender, EventArgs e)
        {





            if (verificaCamposCadastro())
            {
                rdbfeminino.Checked = true;
                btnCadastrar.Enabled = true;
            }
            else
            {
                rdbfeminino.Checked = false;
            }

        }

        private void CadastroUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuAdministrador menu = new menuAdministrador();
            menu.btncadastroUsuario.Visible = false;
        }

        private void txtcomplemento_Leave(object sender, EventArgs e)
        {
            Maiuscula(txtcomplemento);
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            verificaSeEmailDigitadoJaEstaCadastrado();
        }

        private void txtcpf_Leave(object sender, EventArgs e)
        {
            verificaSeCpfDigitadoJaEstaCadastrado();
        }

        private void txtcep_Leave(object sender, EventArgs e)
        {
            string cep = txtcep.Text;
            if (!VCEP.validaCep(cep))
            {
                MessageBox.Show("CEP INVÁLIDO, DIGITE UM CEP VÁLIDO", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcep.Text = "";
                txtcep.Focus();
            }
        }

        private void txttelefone_Leave(object sender, EventArgs e)
        {
            string telefone = txttelefone.Text;
            if (!VTLF.validaTelefone(telefone))
            {
                MessageBox.Show("TELEFONE INVÁLIDO, DIGITE UM TELEFONE VÁLIDO", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttelefone.Text = "";
                txttelefone.Focus();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operação Iniciada!!", "OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtuser.Enabled = true;
            txtsenha.Enabled = true; ;
            txtconfSenha.Enabled = true;
            txtemail.Enabled = true;
            cmbperfil.Enabled = true;
            txtcpf.Enabled = true;
            chcSenha.Enabled = true;

            txtendereco.Enabled = true;
            txtestado.Enabled = true;
            txtcidade.Enabled = true;
            txtbairro.Enabled = true;
            txtcomplemento.Enabled = true;
            txtnumero.Enabled = true;

            txtcep.Enabled = true;
            txttelefone.Enabled = true;
            txtdepart.Enabled = true;
            rdbmasculino.Enabled = true;
            rdbfeminino.Enabled = true;

            btnAdicionar.Enabled = false;
            btnlimpar.Enabled = true;

            txtuser.Focus();
        }





        #endregion

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

        private void btnCadastrar_MouseEnter(object sender, EventArgs e)
        {
            lblcadastrar.Visible = true;
            btnCadastrar.Size = new Size(68, 40);
        }

        private void btnCadastrar_MouseLeave(object sender, EventArgs e)
        {
            lblcadastrar.Visible = false;
            btnCadastrar.Size = new Size(64, 38);
        }

        private void btnlimpar_MouseEnter(object sender, EventArgs e)
        {
            lblcancelar.Visible = true;
            btnlimpar.Size = new Size(68, 40);
        }

        private void btnlimpar_MouseLeave(object sender, EventArgs e)
        {
            lblcancelar.Visible = false;
            btnlimpar.Size = new Size(64, 38);
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
           

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
