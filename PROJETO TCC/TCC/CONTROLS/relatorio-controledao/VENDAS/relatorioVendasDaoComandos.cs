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
        String totVenda;





        public DataTable listarVendas()
        {
            cmd.CommandText = "select codVendaRealizada, metodoPagamento, Cast(Cast(desconto as decimal(18,2)) as varchar(5)) + ' %' as Desconto, format (totalFinal, 'c', 'pt-br') as totalFinal, FORMAT (dataVenda, 'dd/MM/yyyy ') as dataVenda from vendas where codVendaRealizada != 0 group by codVendaRealizada, metodoPagamento, desconto, totalFinal, dataVenda order by dataVenda DESC";
            cmd.Connection = con.conectar();

            DataTable td = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            try
            {

               
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
            cmd.CommandText = "select codVendaRealizada, nomeProduto, tipoProduto, quantidade, modelo,  format (valorDeVenda, 'c', 'pt-br') as valorDeVenda, format (totalUnitario, 'c', 'pt-br') as totalUnitario from vendas where codVendaRealizada = @cod and codVendaRealizada != 0 order by nomeProduto";
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

        public DataTable filtrarData(string dataInicial, string dataFinal)
        {
            cmd.CommandText = "SELECT codVendaRealizada, metodoPagamento, Cast(Cast(desconto as decimal(18,2)) as varchar(5)) + ' %' as Desconto, format (totalFinal, 'c', 'pt-br') as totalFinal, FORMAT (dataVenda, 'dd/MM/yyyy ') as dataVenda FROM VENDAS WHERE (dataVenda BETWEEN @datainicial AND @datafinal) group by codVendaRealizada, metodoPagamento, desconto, totalFinal, dataVenda  ORDER BY dataVenda";
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

        public DataTable listarProdutosRelacionadosAVendaTotal()
        {
            cmd.CommandText = "select codVendaRealizada, nomeProduto, tipoProduto, quantidade, modelo,  format (valorDeVenda, 'c', 'pt-br') as valorDeVenda, format (totalUnitario, 'c', 'pt-br') as totalUnitario from vendas where codVendaRealizada != 0 order by dataVenda";
          

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

        public String contarOperacao()
        {
            SqlDataReader drt;

            cmd.CommandText = "SELECT COUNT (tipo) FROM logs WHERE tipo = 'Cadastrou Venda'  ";

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

        public String contarVendas()
        {
            SqlDataReader drt;

            cmd.CommandText = "select COUNT(distinct codVendaRealizada) from vendas WHERE codVendaRealizada > 0";

            try
            {
                cmd.Connection = con.conectar();
                drt = cmd.ExecuteReader();

                while (drt.Read())
                {
                    totVenda = drt.GetValue(0).ToString();
                }
                con.desconectar();

            }
            catch (Exception)
            {

                throw;
            }

            drt.Close();
            return totVenda;

        }

        public String contarTotal(string total)
        {
            SqlDataReader drt;
            cmd.CommandText = "SELECT FORMAT(SUM(totalFinal), 'c', 'pt-br') AS totalFinal FROM vendas";

            try
            {

                cmd.Connection = con.conectar();
                drt = cmd.ExecuteReader();

                while (drt.Read())
                {
                    total = drt.GetValue(0).ToString();
                }
                con.desconectar();

            }
            catch (Exception)
            {

                throw;
            }
            drt.Close();
            return total;
        }

        public DataTable filtrarSemana()
        {

            cmd.CommandText = "SELECT codVendaRealizada, metodoPagamento, Cast(Cast(desconto as decimal(18,2)) as varchar(5)) + ' %' as Desconto, format (totalFinal, 'c', 'pt-br') as totalFinal, FORMAT (dataVenda, 'dd/MM/yyyy ') as dataVenda FROM VENDAS WHERE dataVenda BETWEEN GETDATE() - 8 AND GETDATE() group by codVendaRealizada, metodoPagamento, desconto, totalFinal, dataVenda  ORDER BY dataVenda ";


          

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
            cmd.CommandText = "SELECT codVendaRealizada, metodoPagamento, Cast(Cast(desconto as decimal(18,2)) as varchar(5)) + ' %' as Desconto, format (V.totalFinal, 'c', 'pt-br') as totalFinal, FORMAT (V.dataVenda, 'dd/MM/yyyy ') as dataVenda FROM VENDAS V WHERE V.dataVenda BETWEEN GETDATE() - 32 AND GETDATE() group by codVendaRealizada, metodoPagamento, desconto, totalFinal, dataVenda  ORDER BY V.dataVenda";

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
            cmd.CommandText = "SELECT codVendaRealizada, metodoPagamento, Cast(Cast(desconto as decimal(18,2)) as varchar(5)) + ' %' as Desconto, format (V.totalFinal, 'c', 'pt-br') as totalFinal, FORMAT (V.dataVenda, 'dd/MM/yyyy ') as dataVenda FROM VENDAS V WHERE V.dataVenda BETWEEN GETDATE() - 367 AND GETDATE() group by codVendaRealizada, metodoPagamento, desconto, totalFinal, dataVenda ORDER BY V.dataVenda";

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

        public DataTable filtrarSemanaItens()
        {
            cmd.CommandText = "select codVendaRealizada, nomeProduto, tipoProduto, quantidade, modelo,  format (valorDeVenda, 'c', 'pt-br') as valorDeVenda, format (totalUnitario, 'c', 'pt-br') as totalUnitario from vendas where codVendaRealizada != 0 AND dataVenda BETWEEN GETDATE() - 8 AND GETDATE() ORDER BY dataVenda ";

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

        public DataTable fitrarMesItens()
        {
            cmd.CommandText = "select codVendaRealizada, nomeProduto, tipoProduto, quantidade, modelo,  format (valorDeVenda, 'c', 'pt-br') as valorDeVenda, format (totalUnitario, 'c', 'pt-br') as totalUnitario from vendas V where codVendaRealizada != 0 AND V.dataVenda BETWEEN GETDATE() - 32 AND GETDATE() ORDER BY V.dataVenda";

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

        public DataTable filtrarAnoItens()
        {
            cmd.CommandText = "select codVendaRealizada, nomeProduto, tipoProduto, quantidade, modelo,  format (valorDeVenda, 'c', 'pt-br') as valorDeVenda, format (totalUnitario, 'c', 'pt-br') as totalUnitario from vendas V where codVendaRealizada != 0 AND V.dataVenda BETWEEN GETDATE() - 367 AND GETDATE() ORDER BY V.dataVenda";

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


    }
}
