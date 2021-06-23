using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.CONTROLS.relatorio_controledao.VENDAS;

namespace TCC.MODELS.relatorio_modelo
{
    class relatorioVendasControle
    {
        relatorioVendasDaoComandos relDao = new relatorioVendasDaoComandos();
        String nome;
        String quantidade;
        DataTable dt = new DataTable();
        String despesas;
        String opera;
        String opera2;
        String opera3;

        public string mensagem;

        string quantidadeEstoque;
        public bool tem = false;

        public DataTable listarVendas()
        {
            this.dt = relDao.listarVendas();

            tem = true;

            return dt;
        }

        public DataTable listarProdutosRelacionadosAVenda(String cod)
        {
            this.dt = relDao.listarProdutosRelacionadosAVenda(cod);

            tem = true;

            return dt;
        }

        public DataTable listarProdutosRelacionadosAVendaTotal()
        {
            this.dt = relDao.listarProdutosRelacionadosAVendaTotal();

            tem = true;

            return dt;
        }

        public String contarOperacao()
        {
            opera = relDao.contarOperacao();

            tem = true;

            return opera;
        }

        public String contarOperacao2()
        {
            opera = relDao.contarOperacao2();

            tem = true;

            return opera;
        }

        public String contarVendas()
        {
            opera = relDao.contarVendas();

            tem = true;

            return opera;
        }

        public String contarTotal(string total)
        {
            total = relDao.contarTotal(total);

            tem = true;

            return total;
        }

        public DataTable filtrarSemana()
        {
            DataTable dtd = new DataTable();
            dtd = relDao.filtrarSemana();

            tem = true;
            return dtd;
        }

        public DataTable filtrarMes()
        {
            DataTable dtdm = new DataTable();

            dtdm = relDao.fitrarMes();

            tem = true;

            return dtdm;
        }

        public DataTable filtrarAno()
        {
            DataTable dta = new DataTable();
            dta = relDao.filtrarAno();

            tem = true;
            return dta;
        }

        public DataTable filtrarSemanaItens()
        {
            DataTable dtd = new DataTable();
            dtd = relDao.filtrarSemanaItens();

            tem = true;
            return dtd;
        }

        public DataTable filtrarMesItens()
        {
            DataTable dtdm = new DataTable();

            dtdm = relDao.fitrarMesItens();

            tem = true;

            return dtdm;
        }

        public DataTable filtrarAnoItens()
        {
            DataTable dta = new DataTable();
            dta = relDao.filtrarAnoItens();

            tem = true;
            return dta;
        }

        public DataTable filtrarData(string dataInicial, string dataFinal)
        {

            DataTable dtdmf = new DataTable();

            dtdmf = relDao.filtrarData(dataInicial, dataFinal);

            return dtdmf;
        }

        public String verificaQuantidadeRestanteNoEstoque(String nomeProduto)
        {
            this.quantidadeEstoque = relDao.verificaQuantidadeRestanteNoEstoque(nomeProduto);
            if (relDao.tem)
            {

                this.tem = true;

            }
            else
            {
                this.tem = false;
            }


            return this.quantidadeEstoque;
        }

        public bool estornar(String cod, String nome, String qtd)
        {

             tem = relDao.estornar(cod, nome, qtd);
            if (relDao.tem)
            {

                this.tem = true;

            }
            else
            {
                this.tem = false;
            }

            return tem;
            

           
        }



    }
}
