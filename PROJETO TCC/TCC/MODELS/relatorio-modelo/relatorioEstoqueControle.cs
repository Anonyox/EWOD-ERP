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
        public String contarEntradas()
        {
           nome = relDao.contarEntradas();

            return nome;
        }

        public String contarProdutos()
        {
            quantidade = relDao.contarProdutos();

            return quantidade;
        }

        public DataTable listarProdutos()
        {
            this.dt = relDao.listarProdutos();

            return dt;
        }

        public String contarDespesas()
        {
            despesas = relDao.contarDespesas();

            return despesas;
        }

    }
}
