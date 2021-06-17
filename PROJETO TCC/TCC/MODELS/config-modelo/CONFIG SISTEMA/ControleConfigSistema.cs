using System;
using System.Data;
using TCC.CONTROLE;

namespace TCC.MODELO
{
    class ControleConfigSistema
    {

        //CLASSE RESPONSÁVEL PARA CONTROLAR A COMUNICAÇÃO ENTRE A TELA CONFIG LOGS E O BANCO DE DADOS 





        #region VARIÁVEIS E INSTÂNCIAS
        configsistemaDaoComandos configSistema = new configsistemaDaoComandos();


        public string mensagem;
        public bool tem = false;
        public DataTable dtr = new DataTable();



        string regCad;

        string regExc;

        string regAlt;

        string regTot;

        #endregion






        #region MÉTODOS DE FUNCIONALIDADES
        public DataTable listarLogs()
        {

            DataTable dt = new DataTable();
            dt = configSistema.listarLogs();

            return dt;
        } //LISTAGEM DE LOGS

        public DataTable listarLogsCad()
        {
            this.dtr = configSistema.listarLogsCad();

            return dtr;
        } //LISTAGEM DE LOGS

        public DataTable listarLogsExclu()
        {
            this.dtr = configSistema.listarLogsExclu();

            return dtr;
        } //LISTAGEM DE LOGS

        public DataTable listarLogsAlt()
        {
            this.dtr = configSistema.listarLogsAlt();

            return dtr;
        } //LISTAGEM DE LOGS

        public DataTable listarLogsBaix()
        {
            this.dtr = configSistema.listarLogsBaix();

            return dtr;
        } //LISTAGEM DE LOGS

        public DataTable listarLogsAcess()
        {
            this.dtr = configSistema.listarLogsAcess();

            return dtr;
        } //LISTAGEM DE LOGS

        public DataTable listarLogsPorUser(String user)
        {
            this.dtr = configSistema.listarLogsPorUser(user);

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

        public String deletaLogs(String tipo)
        {


            this.mensagem = configSistema.deletaLogs(tipo);

            if (configSistema.tem)
            {
                this.mensagem = configSistema.mensagem;
                tem = true;


            }
            else
            {
                this.mensagem = "ERRO COM BANCO DE DADOS";
                tem = false;
            }

            return mensagem;

        } //RETIRA TODOS PRODUTOS DO CARRINHO
        #endregion







    }
}