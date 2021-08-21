using System;
using System.Data.SqlClient;

namespace TCC.CONTROLE
{
    class Conexao
    {

        //CLASSE PRINCIPAL DE CONEXÃO COM O BANCO DE DADOS





        #region VARIÁVEIS E INSTÂNCIAS
        SqlConnection con = new SqlConnection();
        SqlConnection con2 = new SqlConnection();
        SqlConnection con3 = new SqlConnection();
        SqlConnection con4 = new SqlConnection();
        SqlCommand command = new SqlCommand();
        public String mensagem = "";
        public bool verificaConexao = false;

        #endregion






        #region CONSTRUTOR
        public Conexao()
        {
            #region STRINGS DE CONEXÃO


            //CONEXÃO EXTERNA COM RADMIN VPN                       //PORTA
            con.ConnectionString = @"Data Source= tcp: 26.186.226.18,9022;Initial Catalog=lfbd;User ID=etec;Password=123456;connection timeout = 1";



            //CONEXÃO LOCAL IP WINDOWS ESTÁTICO
            //con2.ConnectionString = @"Data Source=  192.168.1.5;Initial Catalog=tcc;User ID=etec;Password=123456;connection timeout = 1";



            //CONEXÃO EXTERNA UTILIZANDO IP FIXO                     //PORTA
            //con3.ConnectionString = @"Data Source= tcp: 177.125.224.77,1433;Initial Catalog=lfbd;User ID=SA;Password=lionforce@147;connection timeout = 1";

           // con4.ConnectionString = @"Data Source= DESKTOP-GQFE158\SQLEXPRESS;Initial Catalog=lfbd;Integrated Security = true;connection timeout = 1";

            #endregion
        }
        #endregion






        #region MÉTODOS DE FUNCIONALIDADES

        public SqlConnection conectar()
        {




            if (con.State == System.Data.ConnectionState.Closed)
            {


                try
                {

                    con.Open();



                }
                catch (Exception)
                {
                    try
                    {

                        con = con2;
                        con.Open();

                    }
                    catch (Exception)
                    {

                        try
                        {
                            con = con3;
                            con.Open();
                        }
                        catch (Exception)
                        {
                            try
                            {
                                con = con4;
                                con.Open();
                            }
                            catch (Exception)
                            {

                                this.mensagem = "ERRO DE CONEXÃO COM O SERVIDOR";
                            }


                        }

                    }

                }
            }
            return con;


        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }


        }

        #endregion






    }
}
