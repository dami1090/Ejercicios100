using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDami
{
    public class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool resultado = false;
            if (valor > min && valor < max)
            {
                resultado = true;
            }
            return resultado;
        }

        public static bool ValidarS_N(char c)
        {
            bool resultado = false;

            if (c.Equals('s') || c.Equals('S'))
            {
                resultado = true;
            }
            return resultado;
        }
    }
}
