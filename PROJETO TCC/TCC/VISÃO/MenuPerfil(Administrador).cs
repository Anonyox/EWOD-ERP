using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TCC.CONTROLE;
using TCC.MODELO;
using static TCC.login;

namespace TCC.VISÃO
{
    public partial class menuAdministrador : Form
    {
        public int valida = 1;
        public int validaEnableCadUser  = 1;
        login login = new login();
        String user = DadosGeral.nomeUser;
        



        public String perfil = verificaPerfill.perfil;
        

        //VERIFICAR VARIAVEIS PARA O PEDRÃO
        public menuAdministrador()
        {

            InitializeComponent();
            
          


            valida = 1;
            String user = DadosGeral.nomeUser;
            perfilAcessa.perfil = this.perfil;
        }

        public static class perfilAcessa
        {
            public static String perfil;
        }

        private void Menuzinho_Shown(object sender, EventArgs e)
        {
            verificaPerfilTela();
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //this.WindowState = FormWindowState.Maximized;
            //btnRestaurar.Visible = true;
           
            verificaPerfilTela();
            if (valida == 1)
            {
                MessageBox.Show("Seja Bem Vindo, " + user, "Logado com Sucesso!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            }


        }
         
        private void btncadastroUsuario_Click(object sender, EventArgs e)
        {

            CadastroUsuario cadastroUser = new CadastroUsuario();
            if (Application.OpenForms.OfType<CadastroUsuario>().Count() > 0)
            {
                Application.OpenForms.OfType<CadastroUsuario>().First().Focus();
            }
            else
            {
                
                cadastroUser.Owner = this;
                cadastroUser.Show(); 
            }
           



        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            sairLog();
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void btnsairDoSistema_Click(object sender, EventArgs e)
        {
            sairLog();
             foreach (Form child in this.OwnedForms) //FORMULÁRIOS FILHOS
            {
                child.Close();//FECHA FILHOS
            }
            this.Hide();//ESCONDE MENU
            Form logar = new login();
            logar.Show();//ABRE TELA DE LOGIN


        }


            public void sairLog()
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();

            string tipo = "Saiu do Sistema";
            DateTime dataLog = System.DateTime.Now;

            cmd.CommandText = "Insert into logs (tipo,dataLog,usuario, perfil) values (@tipo, @dataLog, @usuario, @perfillog)";
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@datalog", dataLog);
            cmd.Parameters.AddWithValue("@usuario", user);
            cmd.Parameters.AddWithValue("@perfillog", perfil);

            try
            {
                con.conectar();
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                
                con.desconectar();
            }
            catch (Exception)
            {

                throw;
            }
        }



        private void btncadastroProdutos_Click(object sender, EventArgs e)
        {
            txtfornecedor cadProduto = new txtfornecedor();

            if (Application.OpenForms.OfType<txtfornecedor>().Count() > 0)
            {
                Application.OpenForms.OfType<txtfornecedor>().First().Focus();
            }
            else
            {
               
                cadProduto.Owner = this;
                cadProduto.Show();
            }
        }

        private void btncadastroProdutos_MouseEnter(object sender, EventArgs e)
        {
            btncadastroProdutos.Size = new Size(265, 150);
            lblcadastroProduto.Visible = true;
        }

        private void btncadastroProdutos_MouseLeave(object sender, EventArgs e)
        {
            btncadastroProdutos.Size = new Size(265, 127);
            lblcadastroProduto.Visible = false;
        }

        private void btncadastroCliente_MouseEnter(object sender, EventArgs e)
        {
            btncadastroCliente.Size = new Size(265, 150);
            lblcadastroCliente.Visible = true;
        }

        private void btncadastroCliente_MouseLeave(object sender, EventArgs e)
        {

            btncadastroCliente.Size = new Size(265, 127);
            lblcadastroCliente.Visible = false;
        }

        private void btncadastroUsuario_MouseEnter(object sender, EventArgs e)
        {      
                btncadastroUsuario.Size = new Size(265, 150);
                lblcadastroUsuario.Visible = true;

        }

        private void btncadastroUsuario_MouseLeave(object sender, EventArgs e)
        {
            btncadastroUsuario.Size = new Size(265, 127);
            lblcadastroUsuario.Visible = false;
        }

        private void btncadastroVenda_MouseEnter(object sender, EventArgs e)
        {
            btncadastroVenda.Size = new Size(265, 150);
            lblcadastroVenda.Visible = true;
        }

        private void btncadastroVenda_MouseLeave(object sender, EventArgs e)
        {
            btncadastroVenda.Size = new Size(265, 127);
            lblcadastroVenda.Visible = false;
        }

        private void btnrelatorioVenda_MouseEnter(object sender, EventArgs e)
        {
            btnrelatorioVenda.Size = new Size(265, 150);
            lblrelatorioVenda.Visible = true;
        }

        private void btnrelatorioVenda_MouseLeave(object sender, EventArgs e)
        {
            btnrelatorioVenda.Size = new Size(265, 127);
            lblrelatorioVenda.Visible = false;
        }

        private void btnrelatorioEstoque_MouseEnter(object sender, EventArgs e)
        {
            btnrelatorioEstoque.Size = new Size(265, 150);
            lblrelatorioEstoque.Visible = true;
        }

        private void btnrelatorioEstoque_MouseLeave(object sender, EventArgs e)
        {
            btnrelatorioEstoque.Size = new Size(265, 127);
            lblrelatorioEstoque.Visible = false;
        }

        private void btnconfigUsuario_MouseEnter(object sender, EventArgs e)
        {
            btnconfiguracoesUsuario.Size = new Size(265, 150);
            lblconfigUsuario.Visible = true;
        }

        private void btnconfigUsuario_MouseLeave(object sender, EventArgs e)
        {
            btnconfiguracoesUsuario.Size = new Size(265, 127);
            lblconfigUsuario.Visible = false;
        }

        private void btnconfigSistema_MouseEnter(object sender, EventArgs e)
        {
            btnconfiguracoesSistema.Size = new Size(265, 127);
            lblconfigSistema.Visible = true;
        }

        private void btnconfigSistema_MouseLeave(object sender, EventArgs e)
        {
            btnconfiguracoesSistema.Size = new Size(265, 110);
            lblconfigSistema.Visible = false;
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            btnlogout.Size = new Size(265, 150);
            lbllogout.Visible = true;
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnlogout.Size = new Size(265, 127);
            lbllogout.Visible = false;
        }

        public void verificaPerfilTela()
        {
            
            if (perfil == "Compras")
            {
                btncadastroCliente.Visible = false;
                lblcadastroCliente.Visible = false;
                btncadastroUsuario.Visible = false;
                lblcadastroUsuario.Visible = false;
                btncadastroVenda.Visible = false;
                lblcadastroVenda.Visible = false;
                btnrelatorioVenda.Visible = false;
                lblrelatorioVenda.Visible = false;
                btnconfiguracoesSistema.Visible = false;
                lblconfigSistema.Visible = false;
                pcblogo.Visible = true;


                //CASO CLIENTE QUEIRA INICIALIZAR COM A TELA NORMAL


                btncadastroProdutos.Location = new Point(12, 235);  
                lblcadastroProduto.Location = new Point(61, 387);
                btnrelatorioEstoque.Location = new Point(391, 238);
                lblrelatorioEstoque.Location = new Point(450, 387);
                btnconfiguracoesUsuario.Location = new Point(761, 238);
                lblconfigUsuario.Location = new Point(821, 387);
                btnlogout.Location = new Point(391, 421);
                lbllogout.Location = new Point(506, 561);
                

                //CASO CLIENTE QUEIRA INICIALIZAR COM A TELA MAXIMIZADA

              /*  
                btncadastroProdutos.Location = new Point(-2, 300);
                lblcadastroProduto.Location = new Point(55, 450);
                btnrelatorioEstoque.Location = new Point(580, 300);
                lblrelatorioEstoque.Location = new Point(640, 450);
                btnconfiguracoesUsuario.Location = new Point(1136, 300);
                lblconfigUsuario.Location = new Point(1195, 450);
                btnlogout.Location = new Point(580, 550);
                lbllogout.Location = new Point(695, 700);

                lblData.Location = new Point(2, 835);
                lblHora.Location = new Point(125, 835);
                */
                 lblData.Location = new Point(3, 680);
                  lblHora.Location = new Point(127, 680);

                 //PICTURE BOX
                 pcblogo.Location = new Point(837, 600); //LOGO
                 pcblogo.Size = new Size(169, 107); //LOGO


                 //PANELS
                 pn1.Location = new Point(-50, 705);
                 pn2.Location = new Point(125, 670);

                

            }

            else if (perfil == "Vendas")
            {
                btncadastroProdutos.Visible = false;
                lblcadastroProduto.Visible = false;
                btncadastroUsuario.Visible = false;
                lblcadastroUsuario.Visible = false;
                btnrelatorioEstoque.Visible = false;
                lblrelatorioEstoque.Visible = false;
                btnrelatorioVenda.Visible = false;
                lblrelatorioVenda.Visible = false;
                btnconfiguracoesSistema.Visible = false;
                lblconfigSistema.Visible = false;
                pcblogo.Visible = true;

                 //INICIAR TELA EM MODO NORMAL CASO CLIENTE QUEIRA

                 btncadastroCliente.Location = new Point(391, 238);
                 lblcadastroCliente.Location = new Point(450, 387);
                 btnconfiguracoesUsuario.Location = new Point(761, 238);
                 lblconfigUsuario.Location = new Point(821, 387);
                 btnlogout.Location = new Point(391, 421);
                 lbllogout.Location = new Point(506, 561);



                //INICIAR TELA EM MODO MAXIMIZADO CASO CLIENTE QUEIRA

                /* btncadastroVenda.Location = new Point(-2, 300);
                 lblcadastroVenda.Location = new Point(55, 450);
                 btncadastroCliente.Location = new Point(580, 300);
                 lblcadastroCliente.Location = new Point(640, 450);
                 btnconfiguracoesUsuario.Location = new Point(1136, 300);
                 lblconfigUsuario.Location = new Point(1190, 450);
                 btnlogout.Location = new Point(580, 550);
                 lbllogout.Location = new Point(695, 700);
                */
                lblData.Location = new Point(3, 680);
                 lblHora.Location = new Point(127, 680);
                
                //PICTURE BOX
                pcblogo.Location = new Point(837, 600); //LOGO
                pcblogo.Size = new Size(169, 107); //LOGO


                //PANELS
                pn1.Location = new Point(-50, 705);
                pn2.Location = new Point(125, 670);
               
            }

            else if (perfil == "Geral")
            {
                btnconfiguracoesSistema.Visible = false;
                lblconfigSistema.Visible = false;
                
                //INICIAR TELA NORMAL

                btnconfiguracoesUsuario.Location = new Point(202, 401);
                lblconfigUsuario.Location = new Point(249, 531);
                btnlogout.Location = new Point(577, 401);
                lbllogout.Location = new Point(690, 531);



                //INICIAR TELA MAXIMIZADA

                /* //  BUTTONS
                 btncadastroProdutos.Location = new Point(-2, 50);
                 btncadastroCliente.Location = new Point(580, 50);
                 btncadastroUsuario.Location = new Point(1136, 50);
                 btncadastroVenda.Location = new Point(-2, 300);
                 btnrelatorioVenda.Location = new Point(580, 300);
                 btnrelatorioEstoque.Location = new Point(1136, 300);
                 btnconfiguracoesUsuario.Location = new Point(400, 550);
                 //btnconfiguracoesSistema.Location = new Point(580, 550);
                 btnlogout.Location = new Point(755, 550);


                 //LABELS
                 lblcadastroProduto.Location = new Point(61, 203);
                 lblcadastroCliente.Location = new Point(635, 203);
                 lblcadastroUsuario.Location = new Point(1195, 203);
                 lblcadastroVenda.Location = new Point(60, 450);
                 lblrelatorioVenda.Location = new Point(640, 450);
                 lblrelatorioEstoque.Location = new Point(1195, 450);
                 lblconfigUsuario.Location = new Point(450, 700);
                 //lblconfigSistema.Location = new Point(625, 700);

                 lbllogout.Location = new Point(870, 700);
                 lblData.Location = new Point(2, 835);
                 lblHora.Location = new Point(125, 835);
                */

                 lblData.Location = new Point(3, 680);
                  lblHora.Location = new Point(127, 680);

                 //PICTURE BOX
                 pcblogo.Location = new Point(837, 600); //LOGO
                 pcblogo.Size = new Size(169, 107); //LOGO


                 //PANELS
                 pn1.Location = new Point(-50, 705);
                 pn2.Location = new Point(125, 670);

             }

             else
             {

                 //  BUTTONS
                 btncadastroProdutos.Location = new Point(-2, 50);
                 btncadastroCliente.Location = new Point(391, 50);
                 btncadastroUsuario.Location = new Point(761, 50);
                 btncadastroVenda.Location = new Point(-2, 238);
                 btnrelatorioVenda.Location = new Point(391, 238);
                 btnrelatorioEstoque.Location = new Point(761, 238);
                 btnconfiguracoesUsuario.Location = new Point(-2, 412);
                 btnconfiguracoesSistema.Location = new Point(391, 421);
                 btnlogout.Location = new Point(761, 421);


                 //LABELS
                 lblcadastroProduto.Location = new Point(49, 203);
                 lblcadastroCliente.Location = new Point(450, 203);
                 lblcadastroUsuario.Location = new Point(821, 203);
                 lblcadastroVenda.Location = new Point(61, 387);
                 lblrelatorioVenda.Location = new Point(450, 387);
                 lblrelatorioEstoque.Location = new Point(821, 387);
                 lblconfigUsuario.Location = new Point(45, 561);
                 lblconfigSistema.Location = new Point(433, 561);
                 lbllogout.Location = new Point(875, 561);
                 lblData.Location = new Point(2, 680);
                 lblHora.Location = new Point(125, 680);

                 //PICTURE BOX
                 pcblogo.Location = new Point(849, 593); //LOGO
                 pcblogo.Size = new Size(178, 111); //LOGO


                 //PANELS
                 //pn1.Location = new Point(-2, 705);
                 //pn2.Location = new Point(120, 663);
                 //  BUTTONS
                 /*
                 btncadastroProdutos.Location = new Point(10, 50);
                 btncadastroCliente.Location = new Point(580, 50);
                 btncadastroUsuario.Location = new Point(1136, 50);
                 btncadastroVenda.Location = new Point(-2, 300);
                 btnrelatorioVenda.Location = new Point(580, 300);
                 btnrelatorioEstoque.Location = new Point(1136, 300);
                 btnconfiguracoesUsuario.Location = new Point(-2, 550);
                 btnconfiguracoesSistema.Location = new Point(580, 560);
                 btnlogout.Location = new Point(1137, 550);


                 //LABELS
                 lblcadastroProduto.Location = new Point(61, 203);
                 lblcadastroCliente.Location = new Point(635, 203);
                 lblcadastroUsuario.Location = new Point(1195, 203);
                 lblcadastroVenda.Location = new Point(60, 450);
                 lblrelatorioVenda.Location = new Point(640, 450);
                 lblrelatorioEstoque.Location = new Point(1195, 450);
                 lblconfigUsuario.Location = new Point(40, 700);
                 lblconfigSistema.Location = new Point(625, 700);

                 lbllogout.Location = new Point(1250, 700);
                 lblData.Location = new Point(2, 835);
                 lblHora.Location = new Point(125, 835);

                 //PICTURE BOX
                 pcblogo.Location = new Point(1180, 710); //LOGO
                 pcblogo.Size = new Size(271, 184); //LOGO


                 //PANELS
                 pn1.Location = new Point(-2, 859);
                 pn2.Location = new Point(118, 817);
                 */
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void menuAdministrador_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToShortDateString();
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
           
            restaura_tela_admin();


        }

        private void restaura_tela_admin()
        {
            if (perfil == "Compras")
            {

                if (this.WindowState == FormWindowState.Normal)
                {
                    btncadastroCliente.Visible = false;
                    lblcadastroCliente.Visible = false;
                    btncadastroUsuario.Visible = false;
                    lblcadastroUsuario.Visible = false;
                    btncadastroVenda.Visible = false;
                    lblcadastroVenda.Visible = false;
                    btnrelatorioVenda.Visible = false;
                    lblrelatorioVenda.Visible = false;
                    btnconfiguracoesSistema.Visible = false;
                    lblconfigSistema.Visible = false;


                    btncadastroProdutos.Location = new Point(12, 235);
                    lblcadastroProduto.Location = new Point(61, 387);
                    btnrelatorioEstoque.Location = new Point(391, 238);
                    lblrelatorioEstoque.Location = new Point(450, 387);
                    btnconfiguracoesUsuario.Location = new Point(761, 238);
                    lblconfigUsuario.Location = new Point(821, 387);
                    btnlogout.Location = new Point(391, 421);
                    lbllogout.Location = new Point(506, 561);

                    lblData.Location = new Point(2, 680);
                    lblHora.Location = new Point(125, 680);

                    //PICTURE BOX
                    pcblogo.Location = new Point(849, 593); //LOGO
                    pcblogo.Size = new Size(178, 111); //LOGO


                    //PANELS
                    pn1.Location = new Point(-2, 705);
                    pn2.Location = new Point(123, 663);
                }

                else if (this.WindowState == FormWindowState.Maximized)
                {

                    btncadastroProdutos.Location = new Point(-2, 300);
                    lblcadastroProduto.Location = new Point(55, 450);
                    btnrelatorioEstoque.Location = new Point(580, 300);
                    lblrelatorioEstoque.Location = new Point(640, 450);
                    btnconfiguracoesUsuario.Location = new Point(1136, 300);
                    lblconfigUsuario.Location = new Point(1195, 450);
                    btnlogout.Location = new Point(580, 550);
                    lbllogout.Location = new Point(695, 700);

                    lblData.Location = new Point(2, 835);
                    lblHora.Location = new Point(125, 835);

                    //PICTURE BOX
                    pcblogo.Location = new Point(1180, 710); //LOGO
                    pcblogo.Size = new Size(271, 184); //LOGO


                    //PANELS
                    pn1.Location = new Point(-2, 859);
                    pn2.Location = new Point(123, 817);
                }
            }

            else if (perfil == "Vendas")
            {
                if (this.WindowState == FormWindowState.Normal)
                {


                    btncadastroVenda.Location = new Point(12, 238);
                    lblcadastroVenda.Location = new Point(70, 387);
                    btncadastroCliente.Location = new Point(391, 238);
                    lblcadastroCliente.Location = new Point(450, 387);
                    btnconfiguracoesUsuario.Location = new Point(761, 238);
                    lblconfigUsuario.Location = new Point(821, 387);
                    btnlogout.Location = new Point(391, 421);
                    lbllogout.Location = new Point(506, 561);

                    lblData.Location = new Point(2, 680);
                    lblHora.Location = new Point(125, 680);

                    //PICTURE BOX
                    pcblogo.Location = new Point(849, 593); //LOGO
                    pcblogo.Size = new Size(178, 111); //LOGO


                    //PANELS
                    pn1.Location = new Point(-2, 705);
                    pn2.Location = new Point(123, 663);

                }

                else if (this.WindowState == FormWindowState.Maximized)
                {
                    btncadastroVenda.Location = new Point(-2, 300);
                    lblcadastroVenda.Location = new Point(55, 450);
                    btncadastroCliente.Location = new Point(580, 300);
                    lblcadastroCliente.Location = new Point(640, 450);
                    btnconfiguracoesUsuario.Location = new Point(1136, 300);
                    lblconfigUsuario.Location = new Point(1190, 450);
                    btnlogout.Location = new Point(580, 550);
                    lbllogout.Location = new Point(695, 700);

                    lblData.Location = new Point(2, 835);
                    lblHora.Location = new Point(125, 835);

                    //PICTURE BOX
                    pcblogo.Location = new Point(1180, 710); //LOGO
                    pcblogo.Size = new Size(271, 184); //LOGO


                    //PANELS
                    pn1.Location = new Point(-2, 859);
                    pn2.Location = new Point(123, 817);
                }
            }

            else if (perfil == "Geral")
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    //  BUTTONS
                    btncadastroProdutos.Location = new Point(-2, 50);
                    btncadastroCliente.Location = new Point(391, 50);
                    btncadastroUsuario.Location = new Point(761, 50);
                    btncadastroVenda.Location = new Point(-2, 238);
                    btnrelatorioVenda.Location = new Point(391, 238);
                    btnrelatorioEstoque.Location = new Point(761, 238);
                    btnconfiguracoesUsuario.Location = new Point(202, 401);
                    //btnconfiguracoesSistema.Location = new Point(391, 421);
                    btnlogout.Location = new Point(577, 401);


                    //LABELS
                    lblcadastroProduto.Location = new Point(61, 203);
                    lblcadastroCliente.Location = new Point(450, 203);
                    lblcadastroUsuario.Location = new Point(821, 203);
                    lblcadastroVenda.Location = new Point(61, 387);
                    lblrelatorioVenda.Location = new Point(450, 387);
                    lblrelatorioEstoque.Location = new Point(821, 387);
                    lblconfigUsuario.Location = new Point(249, 531);
                    //lblconfigSistema.Location = new Point(433, 561);
                    lbllogout.Location = new Point(690, 531);
                    lblData.Location = new Point(2, 680);
                    lblHora.Location = new Point(125, 680);

                    //PICTURE BOX
                    pcblogo.Location = new Point(849, 593); //LOGO
                    pcblogo.Size = new Size(178, 111); //LOGO


                    //PANELS
                    pn1.Location = new Point(-2, 705);
                    pn2.Location = new Point(123, 663);
                }

                else if (this.WindowState == FormWindowState.Maximized)
                {
                    //  BUTTONS
                    btncadastroProdutos.Location = new Point(-2, 50);
                    btncadastroCliente.Location = new Point(580, 50);
                    btncadastroUsuario.Location = new Point(1136, 50);
                    btncadastroVenda.Location = new Point(-2, 300);
                    btnrelatorioVenda.Location = new Point(580, 300);
                    btnrelatorioEstoque.Location = new Point(1136, 300);
                    btnconfiguracoesUsuario.Location = new Point(400, 550);
                    //btnconfiguracoesSistema.Location = new Point(580, 550);
                    btnlogout.Location = new Point(755, 550);


                    //LABELS
                    lblcadastroProduto.Location = new Point(61, 203);
                    lblcadastroCliente.Location = new Point(635, 203);
                    lblcadastroUsuario.Location = new Point(1195, 203);
                    lblcadastroVenda.Location = new Point(60, 450);
                    lblrelatorioVenda.Location = new Point(640, 450);
                    lblrelatorioEstoque.Location = new Point(1195, 450);
                    lblconfigUsuario.Location = new Point(450, 700);
                    //lblconfigSistema.Location = new Point(625, 700);

                    lbllogout.Location = new Point(870, 700);
                    lblData.Location = new Point(2, 835);
                    lblHora.Location = new Point(125, 835);

                    //PICTURE BOX
                    pcblogo.Location = new Point(1180, 710); //LOGO
                    pcblogo.Size = new Size(271, 184); //LOGO


                    //PANELS
                    pn1.Location = new Point(-2, 859);
                    pn2.Location = new Point(123, 817);
                }

            }

            else
            {

                if (this.WindowState == FormWindowState.Normal)
                {


                    //  BUTTONS
                    btncadastroProdutos.Location = new Point(-2, 50);
                    btncadastroCliente.Location = new Point(391, 50);
                    btncadastroUsuario.Location = new Point(761, 50);
                    btncadastroVenda.Location = new Point(-2, 238);
                    btnrelatorioVenda.Location = new Point(391, 238);
                    btnrelatorioEstoque.Location = new Point(761, 238);
                    btnconfiguracoesUsuario.Location = new Point(-2, 412);
                    btnconfiguracoesSistema.Location = new Point(391, 421);
                    btnlogout.Location = new Point(761, 421);


                    //LABELS
                    lblcadastroProduto.Location = new Point(49, 203);
                    lblcadastroCliente.Location = new Point(450, 203);
                    lblcadastroUsuario.Location = new Point(821, 203);
                    lblcadastroVenda.Location = new Point(61, 387);
                    lblrelatorioVenda.Location = new Point(450, 387);
                    lblrelatorioEstoque.Location = new Point(821, 387);
                    lblconfigUsuario.Location = new Point(45, 561);
                    lblconfigSistema.Location = new Point(433, 561);
                    lbllogout.Location = new Point(875, 561);
                    lblData.Location = new Point(2, 680);
                    lblHora.Location = new Point(125, 680);

                    //PICTURE BOX
                    pcblogo.Location = new Point(849, 593); //LOGO
                    pcblogo.Size = new Size(178, 111); //LOGO


                    //PANELS
                    pn1.Location = new Point(-2, 705);
                    pn2.Location = new Point(123, 663);
                }

                else if (this.WindowState == FormWindowState.Maximized)
                {
                    //  BUTTONS
                    btncadastroProdutos.Location = new Point(10, 50);
                    btncadastroCliente.Location = new Point(580, 50);
                    btncadastroUsuario.Location = new Point(1136, 50);
                    btncadastroVenda.Location = new Point(-2, 300);
                    btnrelatorioVenda.Location = new Point(580, 300);
                    btnrelatorioEstoque.Location = new Point(1136, 300);
                    btnconfiguracoesUsuario.Location = new Point(-2, 550);
                    btnconfiguracoesSistema.Location = new Point(580, 550);
                    btnlogout.Location = new Point(1137, 550);


                    //LABELS
                    lblcadastroProduto.Location = new Point(61, 203);
                    lblcadastroCliente.Location = new Point(635, 203);
                    lblcadastroUsuario.Location = new Point(1195, 203);
                    lblcadastroVenda.Location = new Point(60, 450);
                    lblrelatorioVenda.Location = new Point(640, 450);
                    lblrelatorioEstoque.Location = new Point(1195, 450);
                    lblconfigUsuario.Location = new Point(40, 700);
                    lblconfigSistema.Location = new Point(625, 700);

                    lbllogout.Location = new Point(1250, 700);
                    lblData.Location = new Point(2, 835);
                    lblHora.Location = new Point(125, 835);

                    //PICTURE BOX
                    pcblogo.Location = new Point(1180, 710); //LOGO
                    pcblogo.Size = new Size(271, 184); //LOGO


                    //PANELS
                    pn1.Location = new Point(-2, 859);
                    pn2.Location = new Point(123, 817);
                }

            }
        }

        private void menuAdministrador_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void btnconfiguracoesUsuario_Click(object sender, EventArgs e)
        {
            ConfigUsuario configUsuario = new ConfigUsuario();

            if (Application.OpenForms.OfType<ConfigUsuario>().Count() > 0)
            {
                Application.OpenForms.OfType<ConfigUsuario>().First().Focus();
            }
            else
            {

                configUsuario.Owner = this;
                configUsuario.Show();

            }
        }

        private void menuAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void btncadastroUsuario_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnconfiguracoesSistema_Click(object sender, EventArgs e)
        {
            ConfigSistema configSistema = new ConfigSistema();
            configSistema.Show();
        }

        private void btncadastroVenda_Click(object sender, EventArgs e)
        {
            CadastroVendas cadastroVendas = new CadastroVendas();
            if (Application.OpenForms.OfType<CadastroVendas>().Count() > 0)
            {
                Application.OpenForms.OfType<CadastroVendas>().First().Focus();
            }
            else
            {

                cadastroVendas.Owner = this;
                cadastroVendas.Show();
            }
        }

        private void menuAdministrador_Load(object sender, EventArgs e)
        {
            lblData.Location = new Point(3, 680);
            lblHora.Location = new Point(127, 680);

            //PICTURE BOX
            pcblogo.Location = new Point(837, 600); //LOGO
            pcblogo.Size = new Size(169, 107); //LOGO


            //PANELS
            pn1.Location = new Point(-50, 705);
            pn2.Location = new Point(125, 670);
            
        }


    }
}
