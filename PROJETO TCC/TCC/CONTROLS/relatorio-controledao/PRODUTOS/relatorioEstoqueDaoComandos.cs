using System;
using System.Data;
using System.Data.SqlClient;
using TCC.CONTROLE;

namespace TCC.CONTROLS.relatorio_controledao.PRODUTOS
{
    class relatorioEstoqueDaoComandos
    {
        #region VARIÁVEIS E INSTÂNCIAS 
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        SqlCommand cmd3 = new SqlCommand();
        SqlDataReader dr;
        Conexao con = new Conexao();
        String entrada;
        String quantidade;
        String despesas;
        String opera;
        String opera2;
        String opera3;
        String opera4;
        #endregion






        #region MÉTODOS DE FUNCIONALIDADE

        public String contarEntradas()
        {
            cmd.CommandText = "SELECT count(nome) FROM produtos";

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entrada = dr.GetValue(0).ToString();
                }

                con.desconectar();

            }
            catch (Exception)
            {

                throw;
            }
            dr.Close();
            con.desconectar();
            return entrada;
            
        }



        /*public String contarSaidas()
        {
            cmd.CommandText = "";
        }*/



        public String contarProdutos()
        {
            cmd.CommandText = "SELECT SUM(Quantidade) FROM estoqueProdutos ";

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    quantidade = dr.GetValue(0).ToString();
                }

               
                con.desconectar();
                
            }
            catch (Exception)
            {

                throw;
            }

            dr.Close();
            return quantidade;
        }



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



        public String contarDespesas(string colunaCompra, string colunaQuantidade)
        {
            cmd.CommandText = "SELECT FORMAT(SUM(@produtos.valordeCompra * @estoqueProdutos.Quantidade), 'c', 'pt-br') AS VALOR_TOTAL FROM produtos, estoqueProdutos";
            cmd.Parameters.AddWithValue("@produtos.valordeCompra", colunaCompra);
            cmd.Parameters.AddWithValue("@estoqueProdutos.Quantidade", colunaQuantidade);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    despesas = dr.GetValue(0).ToString();
                }
                con.desconectar();

            }
            catch (Exception)
            {

                throw;
            }
            dr.Close();
            return despesas;

        }



        public String contarOperacao()
        {
            SqlDataReader drt;

            cmd.CommandText = "SELECT COUNT (tipo) FROM logs WHERE tipo = 'Cadastrou Produto'  "; 

            try
            {
                cmd.Connection = con.conectar();
                drt = cmd.ExecuteReader();

                while (drt.Read())
                {
                    opera = drt.GetValue(0).ToString();
                }
                con.desconectar();

            }
            catch (Exception)
            {

                throw;
            }

            drt.Close();
            return opera;
            
        }



        public String contarOperacao2()
        {
            SqlDataReader dr2;
            cmd2.CommandText = "SELECT COUNT(tipo) FROM logs WHERE tipo = 'Alterou Produto'";

            try
            {
                cmd2.Connection = con.conectar();
                dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    opera2 = dr2.GetValue(0).ToString();
                }
                con.desconectar();
            }
            catch (Exception)
            {

                throw;
            }
            dr2.Close();
            return opera2;
        }



        public String contarOperacao3()
        {
            SqlDataReader dr3;
            cmd3.CommandText = " SELECT COUNT(tipo) FROM logs WHERE tipo = 'Excluiu Produto'";

            try
            {
                cmd3.Connection = con.conectar();
                dr3 = cmd3.ExecuteReader();
                while (dr3.Read())
                {
                    opera3 = dr3.GetValue(0).ToString();
                }
                con.desconectar();
            }
            catch (Exception)
            {

                throw;
            }
            dr3.Close();
            return opera3;
        }



        /*public String contarSaidas()
        {
            cmd.CommandText = ""
        }*/



        public DataTable filtrarSemana()
        {
            cmd.CommandText = "SELECT P.nome, P.fornecedor,P.tipo, P.modelo, format (P.valordeCompra, 'c', 'pt-br') as valordeCompra, format (P.valordeVenda, 'c', 'pt-br') as valordeVenda, FORMAT (P.dataDeCadastro, 'dd/MM/yyyy ') as dataDeCadastro, E.Quantidade FROM produtos P, estoqueProdutos E WHERE P.dataDeCadastro BETWEEN GETDATE() - 8 AND GETDATE() AND P.codProduto = E.idProduto ";

            try
            {
                cmd.Connection = con.conectar();
                DataTable dtd = new DataTable();
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();

                dap.Fill(dtd);

                con.desconectar();

                return dtd;
                
            }
            catch (Exception)
            {

                throw;
            }
        }



        public DataTable fitrarMes()
        {
            cmd.CommandText = "SELECT P.nome, P.fornecedor,P.tipo, P.modelo, format (P.valordeCompra, 'c', 'pt-br') as valordeCompra, format (P.valordeVenda, 'c', 'pt-br') as valordeVenda, FORMAT (P.dataDeCadastro, 'dd/MM/yyyy ') as dataDeCadastro, E.Quantidade FROM produtos P, estoqueProdutos E WHERE P.dataDeCadastro BETWEEN GETDATE() - 32 AND GETDATE() AND P.codProduto = E.idProduto ORDER BY P.datadeCadastro DESC";

            try
            {
                cmd.Connection = con.conectar();
                DataTable dtdm = new DataTable();
                SqlDataAdapter dam = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();

                dam.Fill(dtdm);
                con.desconectar();

                return dtdm;


            }
            catch (Exception)
            {

                throw;
            }
        }



        public DataTable filtrarAno()
        {
            cmd.CommandText = "SELECT P.nome, P.fornecedor,P.tipo, P.modelo, format (P.valordeCompra, 'c', 'pt-br') as valordeCompra, format (P.valordeVenda, 'c', 'pt-br') as valordeVenda, FORMAT (P.dataDeCadastro, 'dd/MM/yyyy ') as dataDeCadastro, E.Quantidade FROM produtos P, estoqueProdutos E WHERE P.dataDeCadastro BETWEEN GETDATE() - 367 AND GETDATE() AND P.codProduto = E.idProduto ORDER BY P.datadeCadastro DESC";

            try
            {
                cmd.Connection = con.conectar();
                DataTable dta = new DataTable();
                SqlDataAdapter daa = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();

                daa.Fill(dta);
                con.desconectar();

                return dta;
            }
            catch (Exception)
            {

                throw;
            }
            
          


        }



        public DataTable filtrarData(string dataInicial, string dataFinal)
        {
            cmd.CommandText = "SELECT * FROM produtos P, estoqueProdutos E WHERE (P.datadeCadastro BETWEEN @datainicial AND @datafinal) AND P.codProduto = E.idProduto ORDER BY P.datadeCadastro DESC";
            cmd.Parameters.AddWithValue("@datainicial", dataInicial);
            cmd.Parameters.AddWithValue("@datafinal", dataFinal);
            try
            {
                cmd.Connection = con.conectar();
                DataTable dtdmf = new DataTable();
                SqlDataAdapter dtd = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();

                dtd.Fill(dtdmf);
                con.desconectar();
                cmd.Parameters.RemoveAt("@datainicial");
                cmd.Parameters.RemoveAt("@datafinal");


                return dtdmf;




            }
            catch (Exception)
            {

                throw;
            }
        }

        public String contarBaixas()
        {
            SqlDataReader drr;

            cmd.CommandText = "SELECT COUNT (tipo) FROM logs WHERE tipo = 'Baixou Produto'  ";

            try
            {
                cmd.Connection = con.conectar();
                drr = cmd.ExecuteReader();

                while (drr.Read())
                {
                    opera4 = drr.GetValue(0).ToString();
                }
                con.desconectar();

            }
            catch (Exception)
            {

                throw;
            }

            drr.Close();
            return opera4;
        }

        #endregion





    }
}
