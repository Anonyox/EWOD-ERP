using System.Data;
using TCC.CONTROLE;

namespace TCC.MODELO
{
    class ControleConfigSistema
    {

        //CLASSE RESPONSÁVEL PARA CONTROLAR A COMUNICAÇÃO ENTRE A TELA CONFIG LOGS E O BANCO DE DADOS 





        #region VARIÁVEIS E INSTÂNCIAS
        configsistemaDaoComandos configSistema = new configsistemaDaoComandos();

        public DataTable dtr = new DataTable();



        string regCad;

        string regExc;

        string regAlt;

        string regTot;

        #endregion






        #region MÉTODOS DE FUNCIONALIDADES
        public DataTable listarLogs()
        {
            this.dtr = configSistema.listarLogs();

            return dtr;
        } //LISTAGEM DE LOGS

        public string selLogsCad()
        {
            this.regCad = configSistema.selLogsCad();

            return regCad;
        } //LISTAGEM DE LOGS TOTAL DE CADASTROS

        public string selLogsExclu()
        {
            this.regExc = configSistema.selLogsExclu();

            return regExc;
        } //LISTAGENS DE LOGS TOTAL DE EXCLUSÃO 

        public string selLogsAlt()
        {
            this.regAlt = configSistema.selLogsAlt();

            return regAlt;
        } //LISTAGENS DE LOGS TOTAL DE ALTERAÇÃO

        public string selLogsTot()
        {
            this.regTot = configSistema.selLogsTot();

            return regTot;
        } //LISTAGENS DE LOGS TOTAL
        #endregion







    }
}