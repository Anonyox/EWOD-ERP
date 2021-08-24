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

            con.ConnectionString = @"Data Source= DESKTOP-4NSQJ1G\VIVIHMODAS;Initial Catalog=lfbd;Integrated Security = true;connection timeout = 1";

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
