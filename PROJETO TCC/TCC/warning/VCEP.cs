using System.Text.RegularExpressions;

namespace TCC.MODELO
{
    class VCEP
    {

        //REGEX DE VALIDACEP





        #region MÉTODOS DE FUNCIONALIDADES
        public static bool validaCep(string cep)
        {
            Regex valida = new Regex("[0 - 9]{ 5 }|-|[0 - 9]{ 3}");

            if (valida.IsMatch(cep))
                return true;
            else
                return false;
        }
        #endregion






    }
}
