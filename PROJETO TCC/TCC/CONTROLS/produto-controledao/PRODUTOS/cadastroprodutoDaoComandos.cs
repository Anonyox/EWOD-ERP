using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC.VISÃO;
using static TCC.login;

namespace TCC.CONTROLE
{
    class cadastroprodutoDaoComandos
    {
        #region VARIÁVEIS E INTÂNCIAS
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        String user = DadosGeral.nomeUser;
        public String perfillog = verificaPerfill.perfil;
        SqlDataReader dr;
        string tipolog = "Cadastrou Produto";
        string tipolog2 = "Alterou Produto";
        DataTable dtr = new DataTable();
        public bool tem = false;
        public string mensagem = ("");
        #endregion



        #region CONSTRUTOR
        public DataTable listarProdutos()
        {

            cmd.CommandText = "SELECT P.nome, P.fornecedor,P.tipo, P.modelo, format (P.valordeCompra, 'c', 'pt-br') as valordeCompra, format (P.valordeVenda, 'c', 'pt-br') as valordeVenda, FORMAT (P.dataDeCadastro, 'dd/MM/yyyy ') as dataDeCadastro, E.idProdutoEstoque, E.Quantidade, E.datadeCadastro FROM produtos P INNER JOIN estoqueProdutos E ON E.idProduto = P.codProduto ";


            try
            {

                cmd.Connection = con.conectar();

                DataTable td = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();


                da.Fill(td);

                con.desconectar();

                return td;

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

        public String cadastrarProdutos(string nome, string fornecedor, string tipo, string modelo, float quantidade, float valordeCompra, float valordeVenda,
            string dataDeCadastro)
        {
            tem = false;

            cmd.CommandText = "BEGIN TRANSACTION; DECLARE @id[int]; INSERT INTO produtos VALUES(@a,@b,@c,@d,@f,@g,@h); SELECT @id = SCOPE_IDENTITY(); INSERT INTO estoqueProdutos(idProduto, Quantidade) VALUES(@id, @e);COMMIT TRANSACTION; ";
            cmd.Parameters.AddWithValue("@a", nome);
            cmd.Parameters.AddWithValue("@b", fornecedor);
            cmd.Parameters.AddWithValue("@c", tipo);
            cmd.Parameters.AddWithValue("@d", modelo);
            cmd.Parameters.AddWithValue("@e", quantidade);
            cmd.Parameters.AddWithValue("@f", valordeCompra);
            cmd.Parameters.AddWithValue("@g", valordeVenda);
            cmd.Parameters.AddWithValue("@h", dataDeCadastro);

            cmd2.CommandText = "Insert into logs (tipo,dataLog,usuario,perfil) values (@tipo, @dataLog, @usuario, @perfil)";

            cmd2.Parameters.AddWithValue("@tipo", tipolog);
            cmd2.Parameters.AddWithValue("@datalog", dataDeCadastro);
            cmd2.Parameters.AddWithValue("@usuario", user);
            cmd2.Parameters.AddWithValue("@perfil", perfillog);

            //INSERT NA TABELA PRODUTOS

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();

                cmd2.Connection = con.conectar();
                cmd2.ExecuteNonQuery();

                cmd.Parameters.RemoveAt("@a");
                cmd.Parameters.RemoveAt("@b");
                cmd.Parameters.RemoveAt("@c");
                cmd.Parameters.RemoveAt("@d");
                cmd.Parameters.RemoveAt("@e");
                cmd.Parameters.RemoveAt("@f");
                cmd.Parameters.RemoveAt("@g");
                cmd.Parameters.RemoveAt("@h");

                cmd2.Parameters.RemoveAt("@tipo");
                cmd2.Parameters.RemoveAt("@datalog");
                cmd2.Parameters.RemoveAt("@usuario");
                cmd2.Parameters.RemoveAt("@perfil");

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

        public String salvarAlteracao(string nome, string fornecedor, string tipo, string modelo, float quantidade, float valordeCompra, float valordeVenda,
            string dataDeCadastro)
        {
            SqlCommand cmd2 = new SqlCommand();
            SqlCommand cmd3 = new SqlCommand();
            tem = false;

            //cmd.CommandText = "UPDATE produtos INNER JOIN estoqueProdutos ON produtos.codProduto = estoqueProdutos.idProduto SET produtos.nome = @a, produtos.fornecedor = @b, produtos.tipo = @c, produtos.modelo = @d,produtos.valordeCompra = @f, produtos.valordeVenda = @g, produtos.dataDeCadastro = @h + estoqueProduto.Quantidade = @e, estoqueProduto.datadeCadastro = @e WHERE nome = @nomeAnterior";
            cmd.CommandText = "UPDATE produtos SET fornecedor = @b, tipo = @c, modelo = @d, valordeCompra = @f,valordeVenda = @g,dataDeCadastro = @h from estoqueProdutos WHERE produtos.codProduto = estoqueProdutos.idProduto AND produtos.nome = @nomeAnterior";
            cmd2.CommandText = "UPDATE estoqueProdutos SET Quantidade = @e, datadeCadastro = produtos.dataDeCadastro FROM produtos WHERE estoqueProdutos.idProduto = produtos.codProduto and produtos.nome = @a";
            cmd3.CommandText = "Insert into logs (tipo,dataLog,usuario,perfil) values (@tipo, @dataLog, @usuario, @perfil)";

            cmd.Parameters.AddWithValue("@b", fornecedor);
            cmd.Parameters.AddWithValue("@c", tipo);
            cmd.Parameters.AddWithValue("@d", modelo);
            cmd.Parameters.AddWithValue("@f", valordeCompra);
            cmd.Parameters.AddWithValue("@g", valordeVenda);
            cmd.Parameters.AddWithValue("@h", dataDeCadastro);
            cmd.Parameters.AddWithValue("@nomeAnterior", nome);

            cmd2.Parameters.AddWithValue("@a", nome);
            cmd2.Parameters.AddWithValue("@e", quantidade);

         

            cmd3.Parameters.AddWithValue("@tipo", tipolog2);
            cmd3.Parameters.AddWithValue("@datalog", dataDeCadastro);
            cmd3.Parameters.AddWithValue("@usuario", user);
            cmd3.Parameters.AddWithValue("@perfil", perfillog);






            //INSERT NA TABELA PRODUTOS

            try
            {
                cmd.Connection = con.conectar();
                cmd2.Connection = con.conectar();
                cmd3.Connection = con.conectar();

                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();



                
               
                cmd.Parameters.RemoveAt("@b");
                cmd.Parameters.RemoveAt("@c");
                cmd.Parameters.RemoveAt("@d");
                cmd.Parameters.RemoveAt("@f");
                cmd.Parameters.RemoveAt("@g");
                cmd.Parameters.RemoveAt("@h");
                cmd.Parameters.RemoveAt("@nomeAnterior");

                cmd2.Parameters.RemoveAt("@a");
                cmd2.Parameters.RemoveAt("@e");

                cmd3.Parameters.RemoveAt("@tipo");
                cmd3.Parameters.RemoveAt("@datalog");
                cmd3.Parameters.RemoveAt("@usuario");
                cmd3.Parameters.RemoveAt("@perfil");




                con.desconectar();
                //ABRIR CONEXÃO DOS PRODUTOS



                this.mensagem = "ALTERADO COM SUCESSO!!";
                tem = true;
            }
            catch (SqlException)
            {

                this.mensagem = "ERRO COM O BANCO DE DADOS";
            }
            return mensagem;


        }

        public String excluirProduto(string nome)
        {
            cmd.CommandText = "DELETE FROM produtos WHERE nome = @n";
            cmd.Parameters.AddWithValue("@n", nome);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();

                cmd.Parameters.RemoveAt("@n");
                con.desconectar();

                this.mensagem = "PRODUTO RETIRADO COM SUCESSO!!";
                tem = true;


            }
            catch (SqlException)
            {
                this.mensagem = "ERRO COM O BANCO DE DADOS!!";

               
            }
            return mensagem;

        }

        #endregion


    }
}
