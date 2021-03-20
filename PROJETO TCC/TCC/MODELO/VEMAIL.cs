using System.Text.RegularExpressions;

namespace TCC.MODELO
{
    class VEMAIL
    {


        public static bool validaEmail(string email)
        {
            Regex valida = new Regex("^[A-Za-z0-9](([_.-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([.-]?[a-zA-Z0-9]+)*)([.][A-Za-z]{2,4})$");

            if (valida.IsMatch(email))
                return true;
            else
                return false;
        }
    }
}
