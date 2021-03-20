using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TCC.MODELO
{
    class VCEP
    {
        public static bool validaCep(string cep)
        {
            Regex valida = new Regex("[0 - 9]{ 5 }|-|[0 - 9]{ 3}");

            if (valida.IsMatch(cep))
                return true;
            else
                return false;
        }
    }
}
