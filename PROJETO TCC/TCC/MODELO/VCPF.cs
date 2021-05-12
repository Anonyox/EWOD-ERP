using System;
using System.Linq;

namespace TCC.MODELO
{
    class VCPF
    {

        //REGEX DE VALIDACPF






        #region VARIÁVEIS E INSTÂNCIAS
        public String cpf;
        #endregion





        #region MÉTODOS DE FUNCIONALIDADES
        public static bool verificaCpf(string cpf)
        {
            int[] v1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] v2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string x, y;
            int soma, resto;



            if (cpf.Length != 11)
            {
                cpf = cpf.Trim();
                cpf = cpf.Replace(".", "").Replace("-", "");
                if (cpf.Distinct().Count() == 1)
                    return false;

            }

            x = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(x[i].ToString()) * v1[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;

            else
                resto = 11 - resto;

            y = resto.ToString();
            x = x + y;

            /////////
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(x[i].ToString()) * v2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;

            else
                resto = 11 - resto;

            y = y + resto.ToString();

            return cpf.EndsWith(y);










        }
        #endregion






    }
}
