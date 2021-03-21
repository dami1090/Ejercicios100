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
            int numero;
            string preg;
            string resultado;
            int resultadoDecimal;

            do
            {
                Console.WriteLine("Ingrese un numero para convertirlo en binario: ");
                preg = Console.ReadLine();

            } while (!int.TryParse(preg, out numero));
            resultado = Conversor.DecimalBinario(numero);
            Console.WriteLine("El numero en binario es: {0}", resultado);

            resultadoDecimal = Conversor.BinarioDecimal(resultado);
            Console.WriteLine("El numero otra vez en decimal es: {0}", resultadoDecimal);
            Console.ReadLine();
        }
    }
}
