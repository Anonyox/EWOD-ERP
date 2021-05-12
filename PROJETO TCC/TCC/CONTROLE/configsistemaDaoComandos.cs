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

        SqlDataReader regCad;

        SqlDataReader regExc;

        SqlDataReader regAlt;

        SqlDataReader regTot;
        #endregion






        #region MÉTODOS DE FUNCIONALIDADES
        public DataTable listarLogs()
        {


            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select  tipo, Convert (varchar(20),dataLog, 113) AS [dataLog] ,  usuario , perfil from logs Order By codLog DESC";
            


            try
            {

                cmd.Connection = con.conectar();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();

                




                da.Fill(dt);

                
                
                return dt;








                //dtEmail.DataSource = dt;



            }
            catch (Exception)
            {

                throw;
            }
        } //LISTAGEM DE LOGS

        public SqlDataReader selLogsCad()
        {


            

            cmd.CommandText = "select count (tipo) from logs where tipo like 'Cad%'";





            




            try
            {
                cmd.Connection = con.conectar();

                regCad = cmd.ExecuteReader();
                while (regCad.Read())
                {
                    return regCad;
                }
                con.desconectar();


                //dtEmail.DataSource = dt;



            }
            catch (Exception)
            {

                throw;
            }

            

            return regCad;
        } //LISTAGEM DE LOGS TOTAL DE CADASTROS

        public SqlDataReader selLogsExclu()
        {

           

            cmd.CommandText = "select count (tipo) from logs where tipo like 'Exclu%'";

            
            

            try
            {
                cmd.Connection = con.conectar();

                regExc = cmd.ExecuteReader();
                while (regExc.Read())
                {
                    
                    
                    return regExc;
                }

                con.desconectar();



            }
            catch (Exception)
            {

                throw;
            }

            

            return regExc;
        } //LISTAGENS DE LOGS TOTAL DE EXCLUSÃO 

        public SqlDataReader selLogsAlt()
        {

          

            cmd.CommandText = "select count (tipo) from logs where tipo like 'Alt%'";



            

            try
            {
                cmd.Connection = con.conectar();

                regAlt = cmd.ExecuteReader();
                while (regAlt.Read())
                {

                    
                    
                    return regAlt;
                    
                }

                con.desconectar();





            }
            catch (Exception)
            {

                throw;
            }
            

            return regAlt;
            
           
        } //LISTAGENS DE LOGS TOTAL DE ALTERAÇÃO

        public SqlDataReader selLogsTot()
        {

           

            cmd.CommandText = "select count (tipo) from logs";


            
           

            try
            {
                cmd.Connection = con.conectar();
                regTot = cmd.ExecuteReader();
                while (regTot.Read())

                {
                    
                    
                    return regTot;
                    
                   

                }
                con.desconectar();

            }
            catch (Exception)
            {

                throw;
            }

           

            return regTot;
        } //LISTAGENS DE LOGS TOTAL
        #endregion






    }
}
