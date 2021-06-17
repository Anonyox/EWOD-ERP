using System;
using System.Data;
using TCC.CONTROLS.relatorio_controledao.PRODUTOS;

namespace TCC.MODELS.relatorio_modelo
{
    class relatorioEstoqueControle
    {
        relatorioEstoqueDaoComandos relDao = new relatorioEstoqueDaoComandos();
        String nome;
        String quantidade;
        DataTable dt = new DataTable();
        String despesas;
        String opera;
        String opera2;
        String opera3;
        public bool tem;
        public String contarEntradas()
        {
           nome = relDao.contarEntradas();

            tem = true;

            return nome;
        }

        public String contarProdutos()
        {
            quantidade = relDao.contarProdutos();

            tem = true;

            return quantidade;
        }

        public DataTable listarProdutos()
        {
            this.dt = relDao.listarProdutos();

            tem = true;

            return dt;
        }

        public String contarDespesas(string colunaCompra, string colunaQuantidade)
        {
            despesas = relDao.contarDespesas(colunaCompra,colunaQuantidade);

            tem = true;

            return despesas;
        }

        public String contarOperacao()
        {
            opera = relDao.contarOperacao();

            tem = true;

            return opera;
        }

        public String contarOperacao2()
        {
            opera2 = relDao.contarOperacao2();


            tem = true;

            return opera2;
        }

        public String contarOperacao3()
        {
            opera3 = relDao.contarOperacao3();

            tem = true;

            return opera3;
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

        public DataTable filtrarData(string dataInicial,string dataFinal)
        {
            
            DataTable dtdmf = new DataTable();

            dtdmf = relDao.filtrarData(dataInicial, dataFinal);

            return dtdmf;
        }

    }
}
