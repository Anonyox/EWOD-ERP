using System.Text.RegularExpressions;

namespace TCC.MODELO
{
    class VTLF
    {

        //REGEX DE VALIDATELEFONE






        #region MÉTODOS DE FUNCIONALIDADES

        public static bool validaTelefone(string telefone)
        {
            Regex valida = new Regex("|((10) | ([1 - 9][1 - 9])|)[2 - 9][0 - 9]{ 3} - [0 - 9]{ 4}");


            if (valida.IsMatch(telefone))
                return true;
            else
                return false;
        }

        #endregion






    }
}
