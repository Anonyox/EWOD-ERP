using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.CONTROLE;

namespace TCC.MODELS.produto_modelo
{
    public class produtoControle
    {
        #region VARIÁVEIS E INTÂNCIAS
        DataTable dtr = new DataTable();
        cadastroprodutoDaoComandos cadproduto = new cadastroprodutoDaoComandos();
        public string mensagem = ("");
        public bool tem;
        #endregion

        public DataTable listarProdutos()
        {
            this.dtr = cadproduto.listarProdutos();

            return dtr;
        } //LISTAGEM DE Produtos

        public String cadastrarProdutos(string nome, string fornecedor, string tipo, string modelo, float quantidade, float valordeCompra, float valordeVenda,
                     string datadeCadastro)
        {
            this.mensagem = cadproduto.cadastrarProdutos(nome, fornecedor, tipo, modelo, quantidade, valordeCompra, valordeVenda, datadeCadastro);

            if (cadproduto.tem)
            {
                this.tem = true;


            }
            return mensagem;
        }

        public bool verificarProduto(String nomeProduto)
        {
            this.tem = cadproduto.verificarProduto(nomeProduto);

            if (cadproduto.tem)
            {
                this.tem = true;
            }




            return tem;
        }

        public String salvarAlteracao(string nomeAnterior, string nome, string fornecedor, string tipo, string modelo, float quantidade, float valordeCompra, float valordeVenda,
                     string datadeCadastro)
        {
            this.mensagem = cadproduto.salvarAlteracao(nomeAnterior, nome, fornecedor, tipo, modelo, quantidade, valordeCompra, valordeVenda, datadeCadastro);

            if (cadproduto.tem)
            {
                this.tem = true;


            }
            return mensagem;
        }

        public String excluirProduto(string nome)
        {
            this.mensagem = cadproduto.excluirProduto(nome);

            if (cadproduto.tem)
            {
                this.tem = true;
            }
            return mensagem;

        }
    }
}
