using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.CONTROLE;
using static TCC.login;

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

        String user = DadosGeral.nomeUser;
        public String perfillog = verificaPerfill.perfil;

        public string tipo1 = "Estornou Venda";
        public string tipo2 = "Cadastrou Venda";
        string dataLog = DateTime.Now.ToString();

        public Boolean tem = false;

        public string quantidadeEstoque;
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

        public String verificaQuantidadeRestanteNoEstoque(String nomeProduto)
        {
            cmd.CommandText = ("SELECT E.quantidade FROM estoqueProdutos E INNER JOIN produtos P ON E.idProduto = P.codProduto and P.nome = @nomeProdutoE");
            cmd.Parameters.AddWithValue("@nomeProdutoE", nomeProduto);
            cmd.Connection = con.conectar();



            try
            {

                SqlDataReader registro = cmd.ExecuteReader();

                while (registro.Read())
                {

                    this.quantidadeEstoque = registro.GetValue(0).ToString();
                    cmd.Parameters.RemoveAt("@nomeProdutoE");
                    this.tem = true;






                }

                registro.Close();



                //dtEmail.DataSource = dt;



            }
            catch (SqlException)
            {

                this.tem = false;
            }

            return quantidadeEstoque;
        }

        public bool estornar(String cod,String nomeProduto,String qtd)
        {
            cmd.CommandText = ("UPDATE estoqueProdutos set quantidade = @baixaEstoque from produtos where estoqueProdutos.idProduto = produtos.codProduto and produtos.nome = @nomeDoProduto");

            cmd.Parameters.AddWithValue("@baixaEstoque", qtd);
            cmd.Parameters.AddWithValue("@nomeDoProduto", nomeProduto);

            cmd2.CommandText = "Insert into logs (tipo,dataLog,usuario,perfil,qtdprodutoBaixado,produtoBaixado) values (@tipo, @dataLog, @usuario, @perfil, @baixar, @prod)";

            cmd2.Parameters.AddWithValue("@tipo", tipo1);
            cmd2.Parameters.AddWithValue("@datalog", dataLog);
            cmd2.Parameters.AddWithValue("@usuario", user);
            cmd2.Parameters.AddWithValue("@perfil", perfillog);
            cmd2.Parameters.AddWithValue("@baixar", qtd);
            cmd2.Parameters.AddWithValue("@prod", nomeProduto);

            cmd3.CommandText = "DELETE FROM vendas where codVendaRealizada = @cod AND nomeProduto = @nome ";

            cmd3.Parameters.AddWithValue("@cod", cod);
            cmd3.Parameters.AddWithValue("@nome", nomeProduto);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                cmd2.Connection = con.conectar();
                cmd2.ExecuteNonQuery();
                cmd3.Connection = con.conectar();
                cmd3.ExecuteNonQuery();

                cmd.Parameters.RemoveAt("@nomeDoProduto");
                cmd.Parameters.RemoveAt("@baixaEstoque");

                cmd2.Parameters.RemoveAt("@tipo");
                cmd2.Parameters.RemoveAt("@datalog");
                cmd2.Parameters.RemoveAt("@usuario");
                cmd2.Parameters.RemoveAt("@perfil");
                cmd2.Parameters.RemoveAt("@baixar");
                cmd2.Parameters.RemoveAt("@prod");

                cmd3.Parameters.RemoveAt("@cod");
                cmd3.Parameters.RemoveAt("@nome");



                this.tem = true;
                
            }
            catch (Exception)
            {

                throw;
            }
            con.desconectar();
            return tem;



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

        public String contarOperacao2()
        {
            SqlDataReader dr2;
            cmd2.CommandText = "SELECT COUNT(tipo) FROM logs WHERE tipo = 'Estornou Venda'";

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
