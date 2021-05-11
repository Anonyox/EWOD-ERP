using System;
using System.Data.SqlClient;

namespace TCC.CONTROLE
{
    class Conexao
    {
        SqlConnection con = new SqlConnection();
        SqlConnection con2 = new SqlConnection();
        SqlConnection con3 = new SqlConnection();
        SqlCommand command = new SqlCommand();
        public String mensagem = "";
        public bool verificaConexao = false;
        public Conexao()
        {
            con.ConnectionString = @"Data Source= tcp: 26.186.226.18,9022;Initial Catalog=tcc;User ID=etec;Password=123456;connection timeout = 1";
            con2.ConnectionString = @"Data Source=  192.168.1.5;Initial Catalog=tcc;User ID=etec;Password=123456;connection timeout = 1";
            con3.ConnectionString = @"Data Source= tcp: 177.125.224.84,9022;Initial Catalog=tcc;User ID=etec;Password=123456;connection timeout = 1";
           


        }

        public  SqlConnection conectar()
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

                            this.mensagem = "ERRO DE CONEXÃO COM O SERVIDOR";
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


    }
}
