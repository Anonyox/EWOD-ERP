using System;
using System.Data;
using System.Data.SqlClient;

namespace TCC.CONTROLE
{
    public class vendaDaoComandos
    {

        //CLASSE DE COMUNICAÇÃO DIRETA COM BANCO DE DADOS





        #region VARIÁVEIS E IN^STÂNCIAS
        public string mensagem;
        public Boolean tem = false;
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public string quantidadeEstoque;
        #endregion






        #region MÉTODOS DE FUNCIONALIDADES

        public DataTable listaCarrinho(String codOperacao)
        {
           
            
            


            cmd.CommandText = "select codOperacao, produtoPedido, tipoProduto, estilomodeloPedido, " +
                " format (valordeCompraPedido, 'c', 'pt-br') as valorDeCompraPedido, " +
                " format (valordeVendaPedido, 'c', 'pt-br') as valordeVendaPedido, " +
                " quantidade " +
                " from itemDePedido where codOperacao = @codOperacaoLista ";
            cmd.Parameters.AddWithValue("@codOperacaoLista", codOperacao);
            cmd.Connection = con.conectar();
           


            try
            {
                
              
                cmd.ExecuteNonQuery();
                


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtr = new DataTable();

                da.Fill(dtr);

                con.desconectar();

                cmd.Parameters.RemoveAt("@codoperacaoLista");
                return dtr;
               








                //dtEmail.DataSource = dt;



            }
            catch (SqlException)
            {
                throw;
                
            }
        } //LISTAGEM DE CARRINHO 

        public String adicionaAoCarrinho(String codOperacao, String produtoPedido, String tipoProduto, //ADICIONA AO CARRINHO 
            Decimal valorDeCompra, Decimal valorDeVenda, float quantidade, String estiloModelo, float valorTotal)
        {


            cmd.CommandText = "insert into itemDePedido values (@a,@b,@c,@d,@e,@f,@g,@h)"; 
            
            cmd.Parameters.AddWithValue("@a", codOperacao);
            cmd.Parameters.AddWithValue("@b", produtoPedido);
            cmd.Parameters.AddWithValue("@c", tipoProduto);
            cmd.Parameters.AddWithValue("@d", estiloModelo);
            cmd.Parameters.AddWithValue("@e", valorDeCompra);
            cmd.Parameters.AddWithValue("@f", valorDeVenda);
            cmd.Parameters.AddWithValue("@g", quantidade);
            cmd.Parameters.AddWithValue("@h", valorTotal);
            

            

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

        public String deletaTodosProdutosDoCarrinho(String codOperacao)
        {
            cmd.CommandText = "delete from itemDePedido where codOperacao = @codigo";

            cmd.Parameters.AddWithValue("@codigo", codOperacao);


            try
            {

                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.RemoveAt("@codigo");

                this.mensagem = "PRODUTOS RETIRADOS DO CARRINHO";
                tem = true;
                return mensagem;


            }
            catch (Exception)
            {

                this.mensagem = "ERRO COM BANCO DE DADOS";
                tem = false;
            }
            return mensagem;
        } //RETIRA TODOS PRODUTOS DO CARRINHO

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

        } //FAZ A BUSCA DO ÚLTIMO CÓDIGO DE OPERAÇÃO E ADICIONA 1

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

        } //FAZ A BUSCA DO ÚLTIMO CÓDIGO DE OPERAÇÃO

        public String somaProdutosAdicionadosAoCarrinho(int codOperacaoSomaTotal)
        {
            String codOperacaoSoma = "";


            cmd.CommandText = ("SELECT  SUM(valorTotal) FROM itemDePedido where codOperacao = @a  ");
            cmd.Parameters.AddWithValue("@a", codOperacaoSomaTotal);
            cmd.Connection = con.conectar();

            try
            {
                SqlDataReader reg = cmd.ExecuteReader();

                while (reg.Read())
                {
                    codOperacaoSoma = reg.GetValue(0).ToString();

                    cmd.Parameters.RemoveAt("@a");
                    this.tem = true;

                    con.desconectar();
                    return codOperacaoSoma;

                }
            }
            catch (Exception)
            {

                throw;
            }





            return codOperacaoSoma;
        }

        public String verificaQuantidadeRestanteNoEstoque(String nomeProduto)
        {
            cmd.CommandText = ("SELECT quantidade from PRODUTOS where nome = @nomeProduto");
            cmd.Parameters.AddWithValue("@nomeProduto", nomeProduto);
            cmd.Connection = con.conectar();



            try
            {
                
                SqlDataReader registro = cmd.ExecuteReader();

                while (registro.Read())
                {
                    
                    this.quantidadeEstoque = registro.GetValue(0).ToString();
                    cmd.Parameters.RemoveAt("@nomeProduto");
                    this.tem = true;

                    
                   
                   


                }



                //dtEmail.DataSource = dt;



            }
            catch (SqlException)
            {

                this.tem = false;
            }



            con.desconectar();
            
            return this.quantidadeEstoque;
        }

        public bool verificaSeOMesmoProdutoJaFoiInserido(String nomeDoProduto, String codOperacaoBusca)
        {
            cmd.CommandText = ("Select produtoPedido from itemDePedido where produtoPedido = @nomeDoProduto and codOperacao = @codOperacaoBusca");
            cmd.Parameters.AddWithValue("@nomeDoProduto", nomeDoProduto);
            cmd.Parameters.AddWithValue("@codOperacaoBusca", codOperacaoBusca);
            cmd.Connection = con.conectar();


           
            try
            {
                SqlDataReader registro = cmd.ExecuteReader();



                while (registro.Read())
                {

                    cmd.Parameters.RemoveAt("@nomeDoProduto");
                    cmd.Parameters.RemoveAt("@codOperacaoBusca");
                    registro.Close();
                    this.tem = true;
                    return this.tem;
                    

                }

                cmd.Parameters.RemoveAt("@nomeDoProduto");
                cmd.Parameters.RemoveAt("@codOperacaoBusca");
                registro.Close();
                tem = false;
                return tem;
                //dtEmail.DataSource = dt;



            }
            catch (SqlException)
            {
                
            }


            
            con.desconectar();
            return this.tem;


        }


        #endregion






    }
}
