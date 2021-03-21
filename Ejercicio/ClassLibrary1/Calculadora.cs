using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDami
{
    public class Calculadora
    {
        public static double Calcular(double n1, double n2, char operador)
        {
            double resultado;
            switch (operador)
            {
                case '+':
                    resultado = n1 + n2;
                    break;
                case '-':
                    resultado = n1 - n2;
                    break;
                case '*':
                    resultado = n1 * n2;
                    break;
                case '/':
                    if(Validar(n2))
                    {
                        resultado = n1 / n2;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por 0 o por negativos");
                        resultado = 0;
                    }
                    break;
                default:
                    resultado = -1;
                    break;

            }          
            return resultado;
        }

        private static bool Validar(double divisor)
        {
            bool respuesta = false;
            if (divisor > 0 )
            {
                respuesta = true;
            }
            return respuesta;
        }
    }
}
