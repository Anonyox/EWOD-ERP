
using System;
using System.Data;
using System.Data.SqlClient;
using static TCC.login;

namespace TCC.CONTROLE
{

    class loginDaoComandos

    {

        //CLASSE RESPONSÁVEL PARA CONTROLAR A COMUNICAÇÃO DIRETA COM O BANCO DAS TELAS :
        //LOGIN;
        //CADASTRAR USUÁRIO;
        //ALTERAR DADOS DE ACESSO DO USUÁRIO;
        //EDITAR USUÁRIO;





        #region VARIÁVEIS E INSTÂNCIAS
        public bool tem = false;
         public String mensagem = ("");

        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();

        Conexao con = new Conexao();
        SqlDataReader dr;
        public String perfil;
        public String perfillog = verificaPerfill.perfil;

        public string tipo = "Acesso ao sistema";
        public string tipo2 = "Alterou o Nome de Usuário";
        public string tipo3 = "Alterou o Email do Usuário";
        public string tipo4 = "Alterou a Senha do Usuário";

        String user = DadosGeral.nomeUser;

        public DateTime dataLog = System.DateTime.Now;
        #endregion






        #region MÉTODOS DE FUNCIONALIDADES(TELA DE LOGIN)
        public bool verificarlogin(String login, String senha)
        {

            //comandos sql (se tem no banco)
            cmd.CommandText = "select * from logins where usuario = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);


            /*cmd2.CommandText = "Insert into logs (tipo,dataLog,usuario, perfil) values (@tipo, @dataLog, @usuario, @perfil)";
            cmd2.Parameters.AddWithValue("@tipo", tipo);
            cmd2.Parameters.AddWithValue("@datalog", dataLog);
            cmd2.Parameters.AddWithValue("@usuario", login);
            cmd2.Parameters.AddWithValue("@perfil", perfil);
            */


            try
            {
                cmd.Connection = con.conectar();


                if (!con.mensagem.Equals(""))
                {
                    this.mensagem = con.mensagem;

                    return tem;

                }

                else
                {
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)//se foi encontrado
                    {
                        tem = true;
                        con.desconectar();

                    }

                }
                dr.Close();

            }
            catch (SqlException)
            {

                this.mensagem = "Erro com Banco de Dados!";
            }

            return tem;
        } //VERIFICA SE O USUÁRIO DIGITADO NA TELA DE LOGIN CONTÉM NO BANCO

        public void verificaPerfil(String login2, String senha2)
        {

            cmd.CommandText = ("select perfil from logins where usuario = @login and senha = @senha");
            cmd.Parameters.AddWithValue("@login", login2);
            cmd.Parameters.AddWithValue("@senha", senha2);





            cmd.Connection = con.conectar();
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    perfil = dr[0].ToString();








                }
                dr.Close();
                cmd2.CommandText = "Insert into logs (tipo,dataLog,usuario, perfil) values (@tipo, @dataLog, @usuario, @perfil)";
                cmd2.Parameters.AddWithValue("@tipo", tipo);
                cmd2.Parameters.AddWithValue("@datalog", dataLog);
                cmd2.Parameters.AddWithValue("@usuario", login2);
                cmd2.Parameters.AddWithValue("@perfil", perfil);

                cmd2.Connection = con.conectar();
                cmd2.ExecuteNonQuery();



            }



        } //VERIFICA O PERFIL DO USUÁRIO BUSCADO
        #endregion






        #region MÉTODOS DE FUNCIONALIDADES(TELA DE CADASTRO DE USUARIO)
        public String cadastrar(String login, String senha, String confSenha, String cpf, String departamento, String email,
            String perfil, String endereco, String numero, String cidade, String bairro, String estado, String cep, String complemento, String telefone, String sexo)
        {
            tem = false;
            //comandos de inserção

            if (senha.Equals(confSenha))
            {
                /*cmd.CommandText = "select * from logins where usuario = @login";
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)//se foi encontrado
                {
                    this.mensagem = "USUÁRIO JÁ EXISTENTE, INSIRA UM USUÁRIO VÁLIDO";

                }


                else
                {
                    dr.Close();
                    cmd.CommandText = "select cpf from logins where cpf = @cpf";
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    cmd.Connection = con.conectar();
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        this.mensagem = "CPF JÁ CADASTRADO, INSIRA UM CPF VÁLIDO";
                    }



                    else
                    {
                */
                /*dr.Close();
                cmd.CommandText = "select email from logins where email = @email";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    this.mensagem = "EMAIL JÁ CADASTRADO, INSIRA UM EMAIL VÁLIDO";
                }
                else
                {
                */

                tipo = "Cadastrou Usuario";


                cmd.CommandText = "insert into logins values (@a, @b, @c, @d, @e, @f, @g, @h, @i, @j, @k, @l, @m, @n, @o)";
                cmd.Parameters.AddWithValue("@a", login);
                cmd.Parameters.AddWithValue("@b", senha);
                cmd.Parameters.AddWithValue("@c", cpf);
                cmd.Parameters.AddWithValue("@d", departamento);
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@f", perfil);
                cmd.Parameters.AddWithValue("@g", endereco);
                cmd.Parameters.AddWithValue("@h", numero);
                cmd.Parameters.AddWithValue("@i", cidade);
                cmd.Parameters.AddWithValue("@j", bairro);
                cmd.Parameters.AddWithValue("@k", estado);
                cmd.Parameters.AddWithValue("@l", cep);
                cmd.Parameters.AddWithValue("@m", complemento);
                cmd.Parameters.AddWithValue("@n", telefone);
                cmd.Parameters.AddWithValue("@o", sexo);

                cmd2.CommandText = "Insert into logs (tipo,dataLog,usuario,perfil) values (@tipo, @dataLog, @usuario, @perfil)";
                cmd2.Parameters.AddWithValue("@tipo", tipo);
                cmd2.Parameters.AddWithValue("@datalog", dataLog);
                cmd2.Parameters.AddWithValue("@usuario", user);
                cmd2.Parameters.AddWithValue("@perfil", perfillog);



                try
                {
                    //dr.Close(); ;
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();

                    cmd2.Connection = con.conectar();
                    cmd2.ExecuteNonQuery();

                    con.desconectar();


                    this.mensagem = "CADASTRADO COM SUCESSO";
                    tem = true;
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com Banco de Dados!";

                }
            }
            else
            {
                this.mensagem = "SENHAS NÃO CORRESPONDEM";
            }
            return mensagem;

        } //CADASTRA USUÁRIO

        public DataTable listaUser()
        {

            cmd.CommandText = "select usuario, departamento, email, telefone, sexo from logins ";




            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();



                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtr = new DataTable();

                da.Fill(dtr);
                con.desconectar();




                return dtr;









                //dtEmail.DataSource = dt;



            }
            catch (SqlException)
            {
                throw;

            }
        } //LISTA USUÁRIOS CADASTRADOS NO BANCO
        #endregion





        //MÉTODOS DE VERIFICAÇÃO, AS DUAS TELAS UTILIZAM
        #region MÉTODOS DE FUNCIONALIDADES(TELA DE CADASTRO DE USUÁRIO E TELA DE EDITAR DADOS DE ACESSO DO USUÁRIO 
        public String alteraUsuario(String login, String novoLogin)
        {
            cmd.CommandText = ("update logins set usuario = @novoLogin where usuario = @login");
            cmd.Parameters.AddWithValue("@novoLogin", novoLogin);
            cmd.Parameters.AddWithValue("@login", login);

            cmd2.CommandText = "Insert into logs (tipo,dataLog,usuario,perfil) values (@tipo, @dataLog, @usuario, @perfil)";
            cmd2.Parameters.AddWithValue("@tipo", tipo2);
            cmd2.Parameters.AddWithValue("@datalog", dataLog);
            cmd2.Parameters.AddWithValue("@usuario", user);
            cmd2.Parameters.AddWithValue("@perfil", perfillog);




            try
            {
                cmd.Connection = con.conectar();
                if (!con.mensagem.Equals(""))
                {
                    this.mensagem = con.mensagem;


                }
                else
                {



                    cmd.ExecuteNonQuery();

                    con.desconectar();
                    cmd2.Connection = con.conectar();
                    cmd2.ExecuteNonQuery();
                    this.mensagem = "USUÁRIO ALTERADO COM SUCESSO";







                }

                return mensagem;
            }
            catch (SqlException)
            {
                this.mensagem = "ERRO COM O BANCO DE DADOS";


            }

            return mensagem;
        } //ALTERA NOME DE USUÁRIO

        public String alteraSenha(String novaSenha, String usuario)
        {
            cmd.CommandText = ("update logins set senha = @novaSenha where usuario = @usuario");
            cmd.Parameters.AddWithValue("@novaSenha", novaSenha);
            cmd.Parameters.AddWithValue("@usuario", usuario);

            cmd2.CommandText = "Insert into logs (tipo,dataLog,usuario,perfil) values (@tipo, @dataLog, @usuario, @perfil)";
            cmd2.Parameters.AddWithValue("@tipo", tipo4);
            cmd2.Parameters.AddWithValue("@datalog", dataLog);
            cmd2.Parameters.AddWithValue("@usuario", user);
            cmd2.Parameters.AddWithValue("@perfil", perfillog);

            try
            {
                cmd.Connection = con.conectar();
                if (!con.mensagem.Equals(""))
                {
                    this.mensagem = con.mensagem;


                }
                else
                {



                    cmd.ExecuteNonQuery();

                    con.desconectar();
                    cmd2.Connection = con.conectar();
                    cmd2.ExecuteNonQuery();
                    this.mensagem = "SENHA ALTERADA COM SUCESSO";







                }

                return mensagem;
            }
            catch (SqlException)
            {
                this.mensagem = "ERRO COM O BANCO DE DADOS";


            }

            return mensagem;
        } //ALTERA SENHA DE USUÁRIO

        public String alteraEmail(String novoEmail, String usuario)
        {
            cmd.CommandText = ("update logins set email = @novoEmail where usuario = @usuario ");
            cmd.Parameters.AddWithValue("@novoEmail", novoEmail);
            cmd.Parameters.AddWithValue("@usuario", usuario);

            cmd2.CommandText = "Insert into logs (tipo,dataLog,usuario,perfil) values (@tipo, @dataLog, @usuario, @perfil)";
            cmd2.Parameters.AddWithValue("@tipo", tipo3);
            cmd2.Parameters.AddWithValue("@datalog", dataLog);
            cmd2.Parameters.AddWithValue("@usuario", user);
            cmd2.Parameters.AddWithValue("@perfil", perfillog);

            try
            {
                cmd.Connection = con.conectar();
                if (!con.mensagem.Equals(""))
                {
                    this.mensagem = con.mensagem;


                }
                else
                {



                    cmd.ExecuteNonQuery();

                    con.desconectar();
                    cmd2.Connection = con.conectar();
                    cmd2.ExecuteNonQuery();

                    this.mensagem = "EMAIL ALTERADO COM SUCESSO";







                }

                return mensagem;
            }
            catch (SqlException)
            {
                this.mensagem = "ERRO COM O BANCO DE DADOS";

            }

            return mensagem;
        } //ALTERA EMAIL DE USUÁRIO

        public String verificaUsuario(String usuario)
        {
            cmd.CommandText = "select * from logins where usuario = @login";
            cmd.Parameters.AddWithValue("@login", usuario);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)//se foi encontrado
                {
                    this.mensagem = "USUÁRIO JÁ EXISTENTE, INSIRA UM USUÁRIO VÁLIDO";
                    dr.Close();
                }

            }
            catch (Exception)
            {
                this.mensagem = "ERRO COM BANCO DE DADOS";
                throw;
            }
            dr.Close();
            return mensagem;
        } //VERIFICA SE O USUÁRIO DIGITADO JÁ CONTÉM NO BANCO

        public String verificaEmail(String email)
        {
            cmd.CommandText = "select email from logins where email = @email";
            cmd.Parameters.AddWithValue("@email", email);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    this.mensagem = "EMAIL JÁ CADASTRADO, INSIRA UM EMAIL VÁLIDO";
                }
            }
            catch (Exception)
            {
                this.mensagem = "ERRO COM BANCO DE DADOS";

            }



            return mensagem;
        } //VERIFICA SE O EMAIL DIGITADO JÁ CONTEM NO BANCO

        public String verificaCpf(String cpf)
        {
            cmd.CommandText = "select cpf from logins where cpf = @cpf";
            cmd.Parameters.AddWithValue("@cpf", cpf);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    this.mensagem = "CPF JÁ CADASTRADO, INSIRA UM CPF VÁLIDO";
                }
            }
            catch (Exception)
            {
                this.mensagem = "ERRO COM BANCO DE DADOS";

            }



            return mensagem;
        } //VERIFICA SE O CPF DIGITADO JÁ CONTEM NO BANCO
        #endregion






    }
}