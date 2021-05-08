using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TCC.MODELO;

namespace TCC.VISÃO
{
    public partial class CadastroUsuario : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        menuAdministrador menuzAdm = new menuAdministrador();
        public String sexoSelecao;
        public string cpf;
        public static List<Button> botoes;
        //public String email;
        public bool ok = false;
        public CadastroUsuario()
        {
            InitializeComponent();
            menuzAdm.valida = 2;
            validaTeclas();

        }



        private void btnAcessar_Click(object sender, EventArgs e)

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
                        lblendereco.Visible = false;
                        lblnumero.Visible = false;
                        lblcidade.Visible = false;
                        lblbairro.Visible = false;
                        lblestado.Visible = false;
                        lblcep.Visible = false;
                        lblcomplemento.Visible = false;
                        lbltelefone.Visible = false;
                        lblsexo.Visible = false;
                        txtendereco.Visible = false;
                        txtnumero.Visible = false;
                        txtcidade.Visible = false;
                        txtbairro.Visible = false;
                        txtestado.Visible = false;
                        txtcep.Visible = false;
                        txtcomplemento.Visible = false;
                        txttelefone.Visible = false;
                        rdbmasculino.Visible = false;
                        rdbfeminino.Visible = false;

                        // cmd.CommandText = "INSERT INTO logs VALUES(Novo Usuário Cadastrado)";


                    }
                }

            }

        }

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
        }

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








        }

        public void verificaCamposProximo()
        {
            if (txtuser.Text == string.Empty | txtsenha.Text == string.Empty
                | txtconfSenha.Text == string.Empty | txtcpf.Text == string.Empty |
                txtdepart.Text == string.Empty | txtemail.Text == string.Empty)
            {


            }
            else
            {

                btnlimpar.Enabled = true;
            }
        }

        private void CadastroUsuario_Shown(object sender, EventArgs e)
        {

        }

        private void cmbPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            verificaCamposProximo();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void CadastroUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        public string Maiuscula(TextBox tbox)
        {
            TextInfo textinfo = new CultureInfo("PT-BR", true).TextInfo;
            tbox.Text = textinfo.ToTitleCase(tbox.Text);
            return tbox.Text;
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            Maiuscula(txtuser);
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

        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

            if (!verificaCamposCadastro())
            {
                lblsexo.Visible = false;
                rdbmasculino.Visible = false;
                rdbfeminino.Visible = false;


            }
            else
            {
                lblsexo.Visible = true;
                rdbmasculino.Visible = true;
                rdbfeminino.Visible = true;
            }
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
        }

        private void txtcpf_Leave(object sender, EventArgs e)
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
    }
}
