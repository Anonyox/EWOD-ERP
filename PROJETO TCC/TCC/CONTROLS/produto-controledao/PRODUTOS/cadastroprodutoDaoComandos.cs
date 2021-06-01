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
        #region VARIÁVEIS E INTÂNCIAS
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;       
        DataTable dt = new DataTable();
        public bool tem = false;
        public string mensagem = ("");
        #endregion



        #region CONSTRUTOR
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

        public String cadastrarProdutos (string nome, string fornecedor, string tipo, string modelo, float quantidade, float valordeCompra, float valordeVenda,
            string dataDeCadastro)
        {
            tem = false;

            cmd.CommandText = "insert into produtos values (@a, @b, @c, @d, @e, @f, @g, @h)";
            cmd.Parameters.AddWithValue("@a", nome);
            cmd.Parameters.AddWithValue("@b", fornecedor);
            cmd.Parameters.AddWithValue("@c", tipo);
            cmd.Parameters.AddWithValue("@d", modelo);
            cmd.Parameters.AddWithValue("@e", quantidade);
            cmd.Parameters.AddWithValue("@f", valordeCompra);
            cmd.Parameters.AddWithValue("@g", valordeVenda);
            cmd.Parameters.AddWithValue("@h", dataDeCadastro);
            //INSERT NA TABELA PRODUTOS

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();

                //ABRIR CONEXÃO DOS PRODUTOS

               

                this.mensagem = "CADASTRADO COM SUCESSO!!";
                tem = true;
            }
            catch (SqlException)
            {

                this.mensagem = "ERRO COM O BANCO DE DADOS";
            }
            return mensagem;
            con.desconectar();
        }

        /*public String alterarProduto(string nome, string fornecedor, string tipo, string modelo, string quantidade, string valordeCompra, string valordeVenda)
        {
            tem = false;

            cmd.CommandText = "update produtos set @coluna = @valor where codProduto = @codproduto";
            cmd.Parameters.AddWithValue("@coluna", coluna);
        }*/



    #endregion


    }
}
