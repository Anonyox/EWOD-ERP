using System.Data;
using System.Data.SqlClient;
using TCC.CONTROLE;

namespace TCC.MODELO
{
    class ControleConfigSistema
    {

        //CLASSE RESPONSÁVEL PARA CONTROLAR A COMUNICAÇÃO ENTRE A TELA CONFIG LOGS E O BANCO DE DADOS 





        #region VARIÁVEIS E INSTÂNCIAS
        configsistemaDaoComandos configSistema = new configsistemaDaoComandos();

        public DataTable dtr = new DataTable();



        SqlDataReader regCad;

        SqlDataReader regExc;

        SqlDataReader regAlt;

        SqlDataReader regTot;
        #endregion






        #region MÉTODOS DE FUNCIONALIDADES
        public DataTable listarLogs()
        {
            this.dtr = configSistema.listarLogs();

            return dtr;
        } //LISTAGEM DE LOGS

        public SqlDataReader selLogsCad()
        {
            this.regCad = configSistema.selLogsCad();

            return regCad;
        } //LISTAGEM DE LOGS TOTAL DE CADASTROS

        public SqlDataReader selLogsExclu()
        {
            this.regExc = configSistema.selLogsExclu();

            return regExc;
        } //LISTAGENS DE LOGS TOTAL DE EXCLUSÃO 

        public SqlDataReader selLogsAlt()
        {
            this.regAlt = configSistema.selLogsAlt();

            return regAlt;
        } //LISTAGENS DE LOGS TOTAL DE ALTERAÇÃO

        public SqlDataReader selLogsTot()
        {
            this.regTot = configSistema.selLogsTot();

            return regTot;
        } //LISTAGENS DE LOGS TOTAL
        #endregion







    }
}