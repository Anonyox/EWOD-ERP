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
        Conexao con = new Conexao();
        SqlDataReader dr;
        String entrada;
        String quantidade;
        String despesas;
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

        public String contarDespesas()
        {
            cmd.CommandText = "SELECT FORMAT(SUM(valordeCompra), 'c', 'pt-br') FROM produtos";

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

        #endregion
    }
}
