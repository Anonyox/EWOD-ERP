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

        public String cadastrarProdutos(string nome, string fornecedor, string tipo, string modelo, string quantidade, string valordeCompra, string valordeVenda,
                     string datadeCadastro)
        {
            this.mensagem = cadproduto.cadastrarProdutos(nome, fornecedor, tipo, modelo, quantidade, valordeCompra, valordeVenda, datadeCadastro);

            if (cadproduto.tem)
            {
                this.tem = true;


            }
            return mensagem;
        }
    }
}
