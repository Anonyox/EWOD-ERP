using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.CONTROLE
{
    public class vendaDaoComandos
    {
        public string mensagem;
        public Boolean tem = false;
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();


        public DataTable listaCarrinho(String codOperacao)
        {
           
            
            


            cmd.CommandText = "select * from itemDePedido where codOperacao = @codOperacao ";
            cmd.Parameters.AddWithValue("@codOperacao", codOperacao);
           


            try
            {
                con.conectar();
                cmd.ExecuteNonQuery();

               

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtr = new DataTable();

                da.Fill(dtr);



                cmd.Parameters.RemoveAt("@codoperacao");
                return dtr;
                con.desconectar();








                //dtEmail.DataSource = dt;



            }
            catch (SqlException)
            {
                throw;
                
            }
        }

        public String adicionaAoCarrinho(String codOperacao, String produtoPedido, String tipoProduto,
            Decimal valorDeCompra, Decimal valorDeVenda, int quantidade, String estiloModelo)
        {


            cmd.CommandText = "insert into itemDePedido values (@a,@b,@c,@d,@e,@f,@g)"; 
            
            cmd.Parameters.AddWithValue("@a", codOperacao);
            cmd.Parameters.AddWithValue("@b", produtoPedido);
            cmd.Parameters.AddWithValue("@c", tipoProduto);
            cmd.Parameters.AddWithValue("@d", estiloModelo);
            cmd.Parameters.AddWithValue("@e", valorDeCompra);
            cmd.Parameters.AddWithValue("@f", valorDeVenda);
            cmd.Parameters.AddWithValue("@g", quantidade);
            

            

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();


                cmd.Parameters.RemoveAt("@a");
                cmd.Parameters.RemoveAt("@b");
                cmd.Parameters.RemoveAt("@c");
                cmd.Parameters.RemoveAt("@d");
                cmd.Parameters.RemoveAt("@e");
                cmd.Parameters.RemoveAt("@f");
                cmd.Parameters.RemoveAt("@g");



                this.mensagem = ("Produto adicionado");
               
                con.desconectar();


                this.tem = true;
               
                return mensagem;
            }
            catch (SqlException)
            {
                tem = false;
                this.mensagem = ("Erro com banco de dados");
            }
            return mensagem;
           
        }

        public String procuraCodigoOperacao()
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();
            String codOperacao = "";

            cmd.CommandText = ("SELECT MAX(codOperacao) FROM itemDePedido");
            con.conectar();
            cmd.Connection = con.conectar();




            try
            {

                SqlDataReader reg = cmd.ExecuteReader();

                while (reg.Read())
                {
                    codOperacao = reg.GetValue(0).ToString();

                    this.tem = true;

                    con.desconectar();
                    return codOperacao;

                  
                }
              


                //dtEmail.DataSource = dt;



            }
            catch (SqlException)
            {

                this.tem = false;
            }
            return codOperacao;
            
        }

        public String procuraUltimoCodigoOperacao()
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();
            String codOperacao = "";

            cmd.CommandText = ("SELECT MAX(codOperacao) FROM itemDePedido");
            con.conectar();
            cmd.Connection = con.conectar();




            try
            {

                SqlDataReader reg = cmd.ExecuteReader();

                while (reg.Read())
                {
                    codOperacao = reg.GetValue(0).ToString();

                    this.tem = true;

                    con.desconectar();
                    return codOperacao;

                }
               


                //dtEmail.DataSource = dt;



            }
            catch (SqlException)
            {

                this.tem = false;
            }
            return codOperacao;

        }



    }
}
