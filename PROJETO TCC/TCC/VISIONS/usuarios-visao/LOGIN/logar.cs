using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TCC.CONTROLE;
using TCC.MODELO;
using TCC.VISÃO;

namespace TCC
{

    public partial class login : Form

    {

        //CLASSE PRINCIPAL TELA DE LOGIN





        #region VARIÁVEIS E INSTÂNCIAS
        loginDaoComandos lgd = new loginDaoComandos();
        Conexao conex = new Conexao();
        public String perfil;
        #endregion






        #region CONSTRUTOR
        public login()
        {
            InitializeComponent();
        }
        #endregion






        #region CLASSES DE ARMAZENAMENTO DE DADOS
        public static class DadosGeral
        {
            public static String nomeUser;
        }

        public static class verificaPerfill
        {
            public static String perfil;
        }

        public static class senhaUser
        {
            public static String senha;
        }

        public static class nomeUser
        {
            public static String usuario;
        }
        #endregion






        #region MÉTODOS DE FUNCIONALIDADES
        public string Maiuscula(TextBox tbox)
        {
            TextInfo textinfo = new CultureInfo("PT-BR", true).TextInfo;
            tbox.Text = textinfo.ToTitleCase(tbox.Text);
            return tbox.Text;
        } //PRIMEIRA LETRA MAÍUSCULAS DO CAMPO USUÁRIO

        private void verificacao()
        {


            DadosGeral.nomeUser = txtUser.Text;
            senhaUser.senha = txtSenha.Text;



            Controle controle = new Controle();
            loginDaoComandos lgd = new loginDaoComandos();
            String mensagem = lgd.mensagem;

            controle.acessar(txtUser.Text, txtSenha.Text);



            if (!controle.mensagem.Equals(""))
            {



                if (controle.mensagem == "ERRO DE CONEXÃO COM O SERVIDOR")
                {
                    MessageBox.Show(controle.mensagem, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }



            }

            else
            {
                if (controle.tem)
                {
                    lgd.verificaPerfil(txtUser.Text, txtSenha.Text);
                    verificaPerfill.perfil = lgd.perfil;

                    MessageBox.Show("Logado com Sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    menuAdministrador menu = new menuAdministrador();
                    //menu.Closed += (s, args) => this.Close();
                    menu.ShowDialog();

                }

                else
                {
                    MessageBox.Show("Login não encontrado, verifique login e senha", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }




        } //VERIFICA SE CONTÉM O USUÁRIO E SENHA DIGITADOS, NO BANCO, ALÉM DE PESQUISAR O PERFIL DO USUÁRIO 

        #endregion






        #region DESIGN
        private void btnAcessar_Click(object sender, EventArgs e)
        {
            verificacao();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Text = "";
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {

            if (txtUser.Text.Equals(String.Empty))
            {
                txtUser.Text = "Usuário";
            }
            else
            {
                Maiuscula(txtUser);
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text.Equals(String.Empty))
            {
                txtSenha.Text = "senha";
            }

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void login_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.Text = "";
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals("Usuário"))
            {
                txtUser.Text = "Usuário";
            }
            else
            {
                txtUser.Text = "";
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion






    }
}