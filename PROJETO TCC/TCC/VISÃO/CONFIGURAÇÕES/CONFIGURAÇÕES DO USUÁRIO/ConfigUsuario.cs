using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TCC.CONTROLE;
using TCC.MODELO;

namespace TCC.VISÃO
{
    public partial class ConfigUsuario : Form
    {

        //CLASSE PRINCIPAL CONFIGURÇOES DO USUÁRIO





        #region VARIÁVEIS E INSTÂNCIAS
        public String usuario = login.DadosGeral.nomeUser;
        public String senha = login.senhaUser.senha;
        menuAdministrador menuz = new menuAdministrador();
        bool val = false;
        #endregion






        #region CONSTRUTOR
        public ConfigUsuario()
        {
            InitializeComponent();
        }
        #endregion






        #region MÉTODOS DE FUNCIONALIDADES

        private void alterarUsuario()
        {
            Controle Control = new Controle();

            loginDaoComandos lgd = new loginDaoComandos();

            String mensagem;

            //Control.verificaUsuario(txt1.Text);


            if (txt1.Text != "" && txt2.Text != "")
            {


                if (txt2.Text == senha)
                {



                    if (MessageBox.Show("Deseja alterar o nome de Usuário?",
                        "ALTERAR", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        mensagem = Control.alteraUsuario(usuario, txt1.Text);

                        if (Control.mensagem == "USUÁRIO ALTERADO COM SUCESSO")
                        {
                            MessageBox.Show(mensagem, "ALTERAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt1.Text = "";
                            txt2.Text = "";
                            if (MessageBox.Show("SUA SESSÃO FOI ENCERRADA POR MOTIVOS DE ALTERAÇÃO NO LOGIN!", "SAINDO", MessageBoxButtons.OK,
                                MessageBoxIcon.Information) == DialogResult.OK)
                            {

                                Application.Exit();
                            }
                        }
                        else
                        {
                            MessageBox.Show(Control.mensagem, "ALTERAR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                }
                else
                {
                    MessageBox.Show("SENHA DE CONFIRMAÇÃO INVÁLIDA", "ALTERAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("PREENCHA TODOS OS CAMPOS", "ALTERAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        } //BUSCA E ALTERA NOME DE USUÁRIO

        private void alteraEmail()
        {
            Controle Control = new Controle();

            loginDaoComandos lgd = new loginDaoComandos();

            String mensagem;

            Control.verificaUsuario(txt1.Text);


            if (txt1.Text != "" && txt2.Text != "")
            {


                if (txt2.Text == senha)
                {



                    if (MessageBox.Show("Deseja alterar o seu email de Usuário?",
                        "ALTERAR", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        mensagem = Control.alteraEmail(txt1.Text, usuario);

                        if (Control.mensagem == "EMAIL ALTERADO COM SUCESSO")
                        {
                            MessageBox.Show(mensagem, "ALTERAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt1.Text = "";
                            txt2.Text = "";
                        }
                        else
                        {
                            MessageBox.Show(Control.mensagem, "ALTERAR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                }
                else
                {
                    MessageBox.Show("SENHA DE CONFIRMAÇÃO INVÁLIDA", "ALTERAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("PREENCHA TODOS OS CAMPOS", "ALTERAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } //BUSCA E ALTERA EMAIL DE USUÁRIO

        private void alteraSenha()
        {
            Controle Control = new Controle();

            loginDaoComandos lgd = new loginDaoComandos();

            String mensagem;

            //Control.verificaUsuario(txt1.Text);


            if (txt1.Text != "" && txt2.Text != "")
            {


                if (txt2.Text == senha)
                {



                    if (MessageBox.Show("Deseja alterar a senha de Usuário?",
                        "ALTERAR", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        mensagem = Control.alteraSenha(txt1.Text, usuario);

                        if (Control.mensagem == "SENHA ALTERADA COM SUCESSO")
                        {
                            MessageBox.Show(mensagem, "ALTERAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt1.Text = "";
                            txt2.Text = "";
                            if (MessageBox.Show("SUA SESSÃO FOI ENCERRADA POR MOTIVOS DE ALTERAÇÃO NO LOGIN!", "SAINDO", MessageBoxButtons.OK,
                                MessageBoxIcon.Information) == DialogResult.OK)
                            {

                                Application.Exit();
                            }
                        }
                        else
                        {
                            MessageBox.Show(Control.mensagem, "ALTERAR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                }
                else
                {
                    MessageBox.Show("SENHA DE CONFIRMAÇÃO INVÁLIDA", "ALTERAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("PREENCHA TODOS OS CAMPOS", "ALTERAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } //BUSCA E ALTERA SENHA DE USUÁRIO

        public string Maiuscula(TextBox tbox)
        {
            TextInfo textinfo = new CultureInfo("PT-BR", true).TextInfo;
            tbox.Text = textinfo.ToTitleCase(tbox.Text);
            return tbox.Text;
        } //PRIMEIRA LETRA MAIUSCULA NOS CAMPOS



        #endregion






        #region DESIGN
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ConfigUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnalterarUsuario_MouseEnter(object sender, EventArgs e)
        {
            btnalterarUsuario.Size = new Size(265, 150);
            lblalterarUsuario.Visible = true;
        }

        private void btnalterarUsuario_MouseLeave(object sender, EventArgs e)
        {
            btnalterarUsuario.Size = new Size(265, 127);
            lblalterarUsuario.Visible = false;
        }

        private void btnalterarEmail_MouseLeave(object sender, EventArgs e)
        {
            btnalterarEmail.Size = new Size(265, 127);
            lblalterarEmail.Visible = false;
        }

        private void btnalterarEmail_MouseEnter(object sender, EventArgs e)
        {
            btnalterarEmail.Size = new Size(265, 150);
            lblalterarEmail.Visible = true;
        }

        private void btnalterarSenha_MouseEnter(object sender, EventArgs e)
        {
            btnalterarSenha.Size = new Size(265, 150);
            lblalterarSenha.Visible = true;
        }

        private void btnalterarSenha_MouseLeave(object sender, EventArgs e)
        {
            btnalterarSenha.Size = new Size(265, 127);
            lblalterarSenha.Visible = false;
        }

        private void btnalterarUsuario_Click(object sender, EventArgs e)
        {
            txt1.Focus();

            btnalterarEmail.Visible = false;
            btnalterarSenha.Visible = false;
            btnalterarUsuario.Location = new Point(285, 167);
            lblalterarUsuario.Location = new Point(330, 306);

            lbl1.Text = "Novo Usuário : ";
            lbl1.Visible = true;
            lbl2.Text = "Senha de Usuário : ";
            lbl2.Visible = true;
            lbl4.Visible = true;

            lbl1.Location = new Point(32, 351);
            lbl4.Location = new Point(380, 395);
            val = false;




            //83; 348
            txt1.Location = new Point(165, 348);
            txt2.Location = new Point(165, 393);
            txt1.Visible = true;
            txt2.Visible = true;

            chb1.Location = new Point(360, 400);
            chb1.Visible = true;

            btn1.Text = "Voltar";
            btn2.Text = "Alterar";

            btn1.Visible = true;
            btn2.Visible = true;

            btn1.Location = new Point(100, 473);
            btn2.Location = new Point(246, 473);





        }

        private void btn1_Click(object sender, EventArgs e)
        {
            val = false;
            txt1.UseSystemPasswordChar = false;

            btnalterarUsuario.Visible = true;
            btnalterarEmail.Visible = true;
            btnalterarSenha.Visible = true;
            btnalterarUsuario.Location = new Point(44, 167);
            lblalterarUsuario.Location = new Point(81, 306);

            btnalterarEmail.Location = new Point(285, 167);
            lblalterarEmail.Location = new Point(335, 306);

            btnalterarSenha.Location = new Point(532, 167);
            lblalterarSenha.Location = new Point(575, 306);

            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;

            txt1.Visible = false;
            txt2.Visible = false;
            txt3.Visible = false;

            chb1.Visible = false;

            btn1.Visible = false;
            btn2.Visible = false;

            txt1.Text = "";
            txt2.Text = "";

        }

        private void btn2_Click(object sender, EventArgs e)
        {

            if (btn2.Text == "Alterar")
            {
                alterarUsuario();


            }

            else if (btn2.Text == "Alterar Email")
            {
                alteraEmail();
            }
            else if (btn2.Text == "Alterar Senha")
            {
                alteraSenha();
            }
        }

        private void btnalterarEmail_Click(object sender, EventArgs e)
        {
            val = false;
            txt1.Focus();

            btnalterarUsuario.Visible = false;
            btnalterarSenha.Visible = false;

            btnalterarEmail.Location = new Point(285, 167);


            lbl1.Text = "Novo Email : ";
            lbl1.Visible = true;
            lbl2.Text = "Senha de Usuário : ";
            lbl2.Visible = true;
            lbl4.Visible = true;


            lbl1.Location = new Point(48, 351);
            lbl4.Location = new Point(380, 400);


            txt1.Location = new Point(165, 348);
            txt2.Location = new Point(165, 393);
            txt1.Visible = true;
            txt2.Visible = true;

            btn1.Text = "Voltar";
            btn1.Visible = true;
            btn2.Text = "Alterar Email";
            btn2.Visible = true;

            chb1.Visible = true;
            chb1.Location = new Point(360, 404);











        }

        private void txt1_Leave(object sender, EventArgs e)
        {

            Controle controle = new Controle();

            if (btn2.Text == "Alterar")
            {
                Maiuscula(txt1);
                String mensagem = controle.verificaUsuario(txt1.Text);

                if (mensagem == "USUÁRIO JÁ EXISTENTE, INSIRA UM USUÁRIO VÁLIDO")
                {
                    if (MessageBox.Show("USUÁRIO JÁ CADASTRADO, INSIRA UM USUÁRIO VÁLIDO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)

                    {
                        txt1.Text = "";
                        txt1.Focus();
                    }


                }


            }

            else if (btn2.Text == "Alterar Email")
            {
                if (txt1.Text != "")
                {

                    if (VEMAIL.validaEmail(txt1.Text))
                    {

                        String mensagem = controle.verificaEmail(txt1.Text);

                        if (mensagem == "EMAIL JÁ CADASTRADO, INSIRA UM EMAIL VÁLIDO")
                        {
                            if (MessageBox.Show("EMAIL JÁ CADASTRADO, INSIRA UM EMAIL VÁLIDO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)

                            {
                                txt1.Text = "";
                                txt1.Focus();
                            }


                        }
                    }
                    else
                    {
                        MessageBox.Show("EMAIL INVÁLIDO, INSIRA UM EMAIL VÁLIDO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt1.Text = "";
                        txt1.Focus();
                    }
                }
            }

        }

        private void ConfigUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void chb1_Click(object sender, EventArgs e)
        {
            if (val == false)
            {
                if (chb1.Checked)
                {

                    txt2.UseSystemPasswordChar = false;

                }
                else
                {
                    txt2.UseSystemPasswordChar = true;

                }
            }

            else if (val == true)
            {
                if (chb1.Checked)
                {
                    txt1.UseSystemPasswordChar = false;
                    txt2.UseSystemPasswordChar = false;

                }
                else
                {
                    txt1.UseSystemPasswordChar = true;
                    txt2.UseSystemPasswordChar = true;

                }
            }
        }

        private void btnalterarSenha_Click(object sender, EventArgs e)
        {
            txt1.Focus();
            txt1.UseSystemPasswordChar = true;
            val = true;

            btnalterarUsuario.Visible = false;
            btnalterarEmail.Visible = false;

            lblalterarSenha.Location = new Point(330, 306);
            btnalterarSenha.Location = new Point(285, 167);


            lbl1.Text = "Nova senha : ";
            lbl1.Visible = true;
            lbl2.Text = "Senha de Usuário : ";
            lbl2.Visible = true;
            lbl4.Visible = true;


            lbl1.Location = new Point(46, 351);
            lbl4.Location = new Point(380, 400);


            txt1.Location = new Point(165, 348);
            txt2.Location = new Point(165, 393);
            txt1.Visible = true;
            txt2.Visible = true;

            btn1.Text = "Voltar";
            btn1.Visible = true;
            btn2.Text = "Alterar Senha";
            btn2.Visible = true;

            chb1.Visible = true;
            chb1.Location = new Point(360, 404);
        }

        #endregion






    }
}