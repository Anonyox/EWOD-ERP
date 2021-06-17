using System;
using System.Data;
using System.Data.SqlClient;

namespace TCC.CONTROLE
{
    class configsistemaDaoComandos
    {

        //CLASSE RESPONSÁVEL POR SE COMUNICAR DIRETO COM BANCO DE DADOS






        #region VARIÁVEIS E INSTÂNCIAS
        Conexao con = new Conexao();

        SqlCommand cmd = new SqlCommand();



        DataTable dt = new DataTable();

        public bool tem = false;
        public string mensagem;

        String cadastro, excluir, alterar, total;

        SqlDataReader regCad;

        SqlDataReader regExc;

        SqlDataReader regAlt;

        SqlDataReader regTot;

       
        #endregion






        #region MÉTODOS DE FUNCIONALIDADES
        public DataTable listarLogs()
        {


            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select  tipo, Convert (varchar(20),dataLog, 113) AS [dataLog] ,  usuario , perfil, produtoBaixado , qtdprodutoBaixado from logs Order By codLog DESC";
            cmd.Connection = con.conectar();


            try
            {


                DataTable td = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();

                




                da.Fill(td);

                
                
                return td;








                //dtEmail.DataSource = dt;



            }
            catch (Exception)
            {

                throw;
            }
        } //LISTAGEM DE LOGS

        public DataTable listarLogsCad()
        {


            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select  tipo, Convert (varchar(20),dataLog, 113) AS [dataLog] ,  usuario , perfil , qtdprodutoBaixado from logs where tipo like 'Cad%' Order By codLog DESC";
            cmd.Connection = con.conectar();


            try
            {


                DataTable td = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();






                da.Fill(td);



                return td;








                //dtEmail.DataSource = dt;



            }
            catch (Exception)
            {

                throw;
            }
        } //LISTAGEM DE LOGS

        public DataTable listarLogsExclu()
        {


            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select  tipo, Convert (varchar(20),dataLog, 113) AS [dataLog] ,  usuario , perfil , qtdprodutoBaixado from logs where tipo like 'Exclu%' Order By codLog DESC";
            cmd.Connection = con.conectar();


            try
            {


                DataTable td = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();






                da.Fill(td);



                return td;








                //dtEmail.DataSource = dt;



            }
            catch (Exception)
            {

                throw;
            }
        } //LISTAGEM DE LOGS

        public DataTable listarLogsAlt()
        {


            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select  tipo, Convert (varchar(20),dataLog, 113) AS [dataLog] ,  usuario , perfil , qtdprodutoBaixado from logs where tipo like 'Alt%' Order By codLog DESC";
            cmd.Connection = con.conectar();


            try
            {


                DataTable td = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();






                da.Fill(td);



                return td;








                //dtEmail.DataSource = dt;



            }
            catch (Exception)
            {

                throw;
            }
        } //LISTAGEM DE LOGS

        public DataTable listarLogsBaix()
        {


            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select  tipo, Convert (varchar(20),dataLog, 113) AS [dataLog] ,  usuario , perfil , qtdprodutoBaixado, produtoBaixado from logs where tipo like 'Baix%' Order By codLog DESC";
            cmd.Connection = con.conectar();


            try
            {


                DataTable td = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();






                da.Fill(td);



                return td;








                //dtEmail.DataSource = dt;



            }
            catch (Exception)
            {

                throw;
            }
        } //LISTAGEM DE LOGS

        public DataTable listarLogsAcess()
           
        {


            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select  tipo, Convert (varchar(20),dataLog, 113) AS [dataLog] ,  usuario , perfil, produtoBaixado , qtdprodutoBaixado from logs where tipo like 'Ace%' or tipo like 'Saiu%'  Order By codLog DESC";
            cmd.Connection = con.conectar();


            try
            {


                DataTable td = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();






                da.Fill(td);



                return td;








                //dtEmail.DataSource = dt;



            }
            catch (Exception)
            {

                throw;
            }
        } //LISTAGEM DE LOGS

        public DataTable listarLogsPorUser(String user)
        {


            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select  tipo, Convert (varchar(20),dataLog, 113) AS [dataLog] ,  usuario , perfil, produtoBaixado , qtdprodutoBaixado from logs where usuario = @user Order By codLog DESC";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Connection = con.conectar();


            try
            {


                DataTable td = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();






                da.Fill(td);



                return td;








                //dtEmail.DataSource = dt;



            }
            catch (Exception)
            {

                throw;
            }
        } //LISTAGEM DE LOGS







        public String selLogsCad()
        {


           

            cmd.CommandText = "select count (tipo) from logs where tipo like 'Cad%'";





            




            try
            {
                cmd.Connection = con.conectar();

                regCad = cmd.ExecuteReader();

                while (regCad.Read())
                {
                     cadastro = regCad.GetValue(0).ToString();
                }
                con.desconectar();


                //dtEmail.DataSource = dt;



            }
            catch (Exception)
            {

                throw;
            }


            regCad.Close();
            return cadastro;
        } //LISTAGEM DE LOGS TOTAL DE CADASTROS

        public String selLogsExclu()
        {

           

            cmd.CommandText = "select count (tipo) from logs where tipo like 'Exclu%'";

            
            

            try
            {
                cmd.Connection = con.conectar();

                regExc = cmd.ExecuteReader();
                while (regExc.Read())
                {

                    excluir = regExc.GetValue(0).ToString();

                }

                con.desconectar();



            }
            catch (Exception)
            {

                throw;
            }


            regExc.Close();
            return excluir;
        } //LISTAGENS DE LOGS TOTAL DE EXCLUSÃO 

        public String selLogsAlt()
        {

          

            cmd.CommandText = "select count (tipo) from logs where tipo like 'Alt%'";



            

            try
            {
                cmd.Connection = con.conectar();

                regAlt = cmd.ExecuteReader();
                while (regAlt.Read())
                {



                    alterar = regAlt.GetValue(0).ToString();

                }

                con.desconectar();





            }
            catch (Exception)
            {

                throw;
            }

            regAlt.Close();
            return alterar;
            
           
        } //LISTAGENS DE LOGS TOTAL DE ALTERAÇÃO

        public String selLogsTot()
        {

           

            cmd.CommandText = "select count (tipo) from logs";


            
           

            try
            {
                cmd.Connection = con.conectar();
                regTot = cmd.ExecuteReader();
                while (regTot.Read())

                {


                   total = regTot.GetValue(0).ToString();



                }
                con.desconectar();

            }
            catch (Exception)
            {

                throw;
            }


            regTot.Close();
            return total;
        } //LISTAGENS DE LOGS TOTAL

        public String deletaLogs(String tipo)
        {
            cmd.CommandText = "delete from logs where Tipo = @tipo";

            cmd.Parameters.AddWithValue("@tipo", tipo);


            try
            {

                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.RemoveAt("@tipo");

                this.mensagem = "LOGS EXCLUÍDOS";
                tem = true;
                return mensagem;


            }
            catch (Exception)
            {

                this.mensagem = "ERRO COM BANCO DE DADOS";
                tem = false;
            }
            return mensagem;
        } //RETIRA TODOS PRODUTOS DO CARRINHO
        #endregion






    }
}
