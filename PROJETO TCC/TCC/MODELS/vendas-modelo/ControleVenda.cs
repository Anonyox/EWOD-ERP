using System;
using System.Data;
using TCC.CONTROLE;

namespace TCC.MODELO
{
    public class ControleVenda
    {

        //CLASSE DE COMUNICAÇÃO DA TELA COM O BANCO DE DADOS




        #region VARIÁVEIS E INSTÂNCIAS
        vendaDaoComandos vendaDao = new vendaDaoComandos();
        public Boolean tem = false;
        String codOperacao;

        public DataTable dtr = new DataTable();
        public string mensagem;

        public string valorTexto;

        #endregion







        #region MÉTODOS DE FUNCIONALIDADES
        public DataTable listaCarrinho(String codOperacao)
        {           
                this.dtr = vendaDao.listaCarrinho(codOperacao);
      
            return dtr;
        } //LISTAGEM DE CARRINHO 

        public String adicionaAoCarrinho(String codOperacao, String produtoPedido, String tipoProduto, //ADICIONA AO CARRINHO 
            Decimal valorDeCompra, Decimal valorDeVenda, int quantidade, String estiloModelo)
        {



            this.mensagem = vendaDao.adicionaAoCarrinho(codOperacao, produtoPedido, tipoProduto, valorDeCompra, valorDeVenda, quantidade, estiloModelo);

            if (vendaDao.tem)
            {
                this.mensagem = vendaDao.mensagem;
                tem = true;
                
              
            }
            else
            {
                this.mensagem = "Erro com banco de dados";
                tem = false;
            }

            return this.mensagem;
        }

        public String deletaTodosProdutosDoCarrinho(String codOperacao)
        {


            this.mensagem = vendaDao.deletaTodosProdutosDoCarrinho(codOperacao);

            if (vendaDao.tem)
            {
                this.mensagem = vendaDao.mensagem;
                tem = true;


            }
            else
            {
                this.mensagem = "ERRO COM BANCO DE DADOS";
                tem = false;
            }

            return mensagem;

        } //RETIRA TODOS PRODUTOS DO CARRINHO

        public String procuraCodigoOperacao()
        {
            this.codOperacao = vendaDao.procuraCodigoOperacao();
            if (vendaDao.tem)
            {
                
                this.tem = true;
                 return this.codOperacao;
            }
            else
            {
                this.tem = false;
            }
           


            return this.codOperacao;
        } //FAZ A BUSCA DO ÚLTIMO CÓDIGO DE OPERAÇÃO E ADICIONA 1

        public String procuraCodigoUltimoCodigoOperacao()
        {
            this.codOperacao = vendaDao.procuraCodigoOperacao();
            if (vendaDao.tem)
            {

                this.tem = true;
                return this.codOperacao;
            }
            else
            {
                this.tem = false;
            }



            return this.codOperacao;
        } //FAZ A BUSCA DO ÚLTIMO CÓDIGO DE OPERAÇÃO

        public string somaProdutosAdicionadosAoCarrinho(String codOperacaoSoma)
        {
            this.valorTexto = vendaDao.somaProdutosAdicionadosAoCarrinho(codOperacaoSoma);

            return valorTexto;
        }
        #endregion







    }
}
