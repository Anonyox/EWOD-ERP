using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.CONTROLE;

namespace TCC.MODELO
{
    public class ControleVenda
    {
        vendaDaoComandos vendaDao = new vendaDaoComandos();
        public Boolean tem = false;
        String codOperacao;

        public DataTable dtr = new DataTable();
        public string mensagem;

        public DataTable listaCarrinho(String codOperacao)
        {           
                this.dtr = vendaDao.listaCarrinho(codOperacao);
      
            return dtr;
        }

        public String adicionaAoCarrinho(String codOperacao, String produtoPedido, String tipoProduto,
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
        }
    }
}
