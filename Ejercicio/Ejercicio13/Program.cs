using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDami;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            string preg;
            string resultado;
            double resultadoDecimal;

            do
            {
                Console.WriteLine("Ingrese un numero para convertirlo en binario: ");
                preg = Console.ReadLine();

            } while (!double.TryParse(preg, out numero));
            resultado = Conversor.DecimalBinario(numero);
            Console.WriteLine("El numero en binario es: {0}", resultado);

            resultadoDecimal = Conversor.BinarioDecimal(resultado);
            Console.WriteLine("El numero otra vez en decimal es: {0}", resultadoDecimal);
            Console.ReadLine();
        }
    }
}
