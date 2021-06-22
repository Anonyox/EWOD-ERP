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
        public bool tem;

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
    }
}
