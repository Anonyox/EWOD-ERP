using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.CONTROLE;

namespace TCC.CONTROLS.relatorio_controledao.VENDAS
{
    class relatorioVendasDaoComandos
    {


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





        public DataTable listarVendas()
        {
            cmd.CommandText = "select codVendaRealizada, metodoPagamento, Cast(Cast(desconto as decimal(18,2)) as varchar(5)) + ' %' as Desconto, format (totalFinal, 'c', 'pt-br') as totalFinal, FORMAT (dataVenda, 'dd/MM/yyyy ') as dataVenda from vendas where codVendaRealizada != 0 group by codVendaRealizada, metodoPagamento, desconto, totalFinal, dataVenda order by dataVenda";


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

        public DataTable listarProdutosRelacionadosAVenda(String cod)
        {
            cmd.CommandText = "select nomeProduto, tipoProduto, quantidade, modelo,  format (valorDeVenda, 'c', 'pt-br') as valorDeVenda, format (totalUnitario, 'c', 'pt-br') as totalUnitario from vendas where codVendaRealizada = @cod";
            cmd.Parameters.AddWithValue("@cod", cod);

            try
            {

                cmd.Connection = con.conectar();

                DataTable td = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();

                

                da.Fill(td);
                cmd.Parameters.RemoveAt("@cod");

                con.desconectar();


                return td;

            }
            catch (SqlException)
            {

                throw;
            }


        }

    }
}
