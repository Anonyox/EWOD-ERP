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

        string desconto;

        string valtot;

        string quantidadeEstoque;



        #endregion







        #region MÉTODOS DE FUNCIONALIDADES
        public DataTable listaCarrinho(String codOperacao)
        {
            this.dtr = vendaDao.listaCarrinho(codOperacao);

            return dtr;
        } //LISTAGEM DE CARRINHO 

        public String adicionaAoCarrinho(String codOperacao, String produtoPedido, String tipoProduto, //ADICIONA AO CARRINHO 
            Decimal valorDeCompra, Decimal valorDeVenda, float quantidade, String estiloModelo, float valTotal)
        {



            this.mensagem = vendaDao.adicionaAoCarrinho(codOperacao, produtoPedido, tipoProduto, valorDeCompra, valorDeVenda, quantidade, estiloModelo, valTotal);

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

        public String procuraUltimoCodigoDaVendaEAdicionaUm()
        {
            this.codOperacao = vendaDao.procuraUltimoCodigoDaVendaEAdicionaUm();
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
        }

        public String somaProdutosAdicionadosAoCarrinho(int codOperacaoSomaTotal)
        {
            this.valtot = vendaDao.somaProdutosAdicionadosAoCarrinho(codOperacaoSomaTotal);
            return valtot;
        }

        public String verificaQuantidadeRestanteNoEstoque(String nomeProduto)
        {
            this.quantidadeEstoque = vendaDao.verificaQuantidadeRestanteNoEstoque(nomeProduto);
            if (vendaDao.tem)
            {

                this.tem = true;

            }
            else
            {
                this.tem = false;
            }


            return this.quantidadeEstoque;
        }

        public bool verificaSeOMesmoProdutoJaFoiInserido(String nomedoProduto, String codOperacao)
        {
            this.tem = vendaDao.verificaSeOMesmoProdutoJaFoiInserido(nomedoProduto, codOperacao);

            if (vendaDao.tem)
            {
                this.tem = true;
            }

            return tem;



        }

        public String deletaProdutoSelecionadoDoCarrinho(String nome, String codOperacao)
        {
            this.mensagem = vendaDao.deletaProdutoSelecionadoDoCarrinho(nome, codOperacao);

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
        }

        public bool baixarEstoque(String nomedoProduto, String baixarEstoque)
        {
            this.tem = vendaDao.baixarEstoque(nomedoProduto, baixarEstoque);

            if (vendaDao.tem)
            {
                this.tem = true;
            }

            return tem;
            {
            }
            #endregion







        }

        public String cadastrarVenda(String codVenda, String nome, String tipo, float valorVenda, int quantidade, String modelo, String metodoPgt, float desconto, float totalVenda, float valorTotal, String data)
        {
           

            this.mensagem = vendaDao.cadastrarVenda(codVenda, nome,tipo,valorVenda,quantidade,modelo,metodoPgt,desconto,totalVenda,valorTotal,data);

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
    }
}
