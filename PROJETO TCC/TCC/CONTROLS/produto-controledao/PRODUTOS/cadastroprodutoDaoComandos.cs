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
        DataTable dtr = new DataTable();
        public bool tem = false;
        public string mensagem = ("");
        #endregion



        #region CONSTRUTOR
        public DataTable listarProdutos()
        {
            
            cmd.CommandText = "SELECT produtos.nome," +
                "produtos.fornecedor," +
                "produtos.tipo," +
                "produtos.modelo," +
                "produtos.valordeCompra," +
                "produtos.valordeVenda," +
                "produtos.dataDeCadastro,"+
                "estoqueProdutos.Quantidade" +
                "FROM produtos,estoqueProdutos"+
                "WHERE produtos.codProduto = estoqueProdutos.idProduto";
                cmd.Connection = con.conectar();


            try
            {            
                
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dtr);

                con.desconectar();

                return dtr;

            }
            catch (SqlException)
            {

                throw;
            }

            

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

                cmd.Parameters.RemoveAt("@a");
                cmd.Parameters.RemoveAt("@b");
                cmd.Parameters.RemoveAt("@c");
                cmd.Parameters.RemoveAt("@d");
                cmd.Parameters.RemoveAt("@e");
                cmd.Parameters.RemoveAt("@f");
                cmd.Parameters.RemoveAt("@g");
                cmd.Parameters.RemoveAt("@h");

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

        public bool verificarProduto(String nomeProduto)
        {
            cmd.CommandText = "SELECT nome FROM produtos WHERE nome = @nome";
            cmd.Parameters.AddWithValue("@nome", nomeProduto);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cmd.Parameters.RemoveAt("@nome");
                    dr.Close();
                    this.tem = true;

                    return tem;

                }

                cmd.Parameters.RemoveAt("@nome");
                dr.Close();

                this.tem = false;

                return tem;

                

            }
            catch (Exception)
            {


                throw;
            }



            con.desconectar();
        }

        public String salvarAlteracao(string nomeAnterior,string nome, string fornecedor, string tipo, string modelo, float quantidade, float valordeCompra, float valordeVenda,
            string dataDeCadastro)
        {
            tem = false;

            cmd.CommandText = "update produtos set nome = @a," +
                "fornecedor = @b," +
                "tipo = @c," +
                "modelo = @d," +
                "quantidade = @e," +
                "valordeCompra = @f," +
                "valordeVenda = @g," +
                "dataDeCadastro = @h" +
                " where nome = @nomeAnterior";


            cmd.Parameters.AddWithValue("@a", nome);
            cmd.Parameters.AddWithValue("@b", fornecedor);
            cmd.Parameters.AddWithValue("@c", tipo);
            cmd.Parameters.AddWithValue("@d", modelo);
            cmd.Parameters.AddWithValue("@e", quantidade);
            cmd.Parameters.AddWithValue("@f", valordeCompra);
            cmd.Parameters.AddWithValue("@g", valordeVenda);
            cmd.Parameters.AddWithValue("@h", dataDeCadastro);
            cmd.Parameters.AddWithValue("@nomeAnterior", nomeAnterior);
           
           
            //INSERT NA TABELA PRODUTOS

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
                cmd.Parameters.RemoveAt("@h");
                cmd.Parameters.RemoveAt("@nomeAnterior");
                //ABRIR CONEXÃO DOS PRODUTOS



                this.mensagem = "ALTERADO COM SUCESSO!!";
                tem = true;
            }
            catch (SqlException)
            {

                this.mensagem = "ERRO COM O BANCO DE DADOS";
            }
            return mensagem;
            con.desconectar();
        }

    #endregion


    }
}
