using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC.VISÃO;

namespace TCC.CONTROLE
{   
    class cadastroprodutoDaoComandos
    {
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;       
        DataTable dt = new DataTable();
        CadastroProduto cadastroproduto = new CadastroProduto();
        public bool tem;
        public string nomeproduto;
        public string mensagem;
             
        public DataTable listarProdutos()
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from produtos";
            cmd.Connection = con.conectar();


            try
            {
                con.conectar();
                cmd.ExecuteNonQuery();


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                
                da.Fill(dt);

                con.desconectar();

               

            }
            catch (SqlException)
            {

                throw;
            }

            return dt;

        }

        public void buscarProduto()
        {

            SqlCommand cmd = new SqlCommand("SELECT nome FROM produtos", con.conectar());

            dr = cmd.ExecuteReader();

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            while (dr.Read())
            {
                collection.Add(dr["nome"].ToString());
            }
           

            dr.Close();
            con.desconectar();

        }

      /* public bool VerificarProduto(string nome)
        {
            cmd.CommandText = "SELECT nome FROM dbo.produtos WHERE nome = @nome";
            cmd.Parameters.AddWithValue("@nome", nome);

            if (nome != dr["@nome"].ToString())
            {
                tem = false;
             
                
                
            }
                


        }*/



    }
}
