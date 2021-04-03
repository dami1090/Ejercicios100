using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDami;

namespace Ejercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroBinario objBinario = "1001";
            NumeroDecimal objDecimal = 9;

            if(objBinario == objDecimal)
            {
                Console.WriteLine("Son iguales!");
            }
            Console.WriteLine("consversor: {0}", Conversor.DecimalBinario(23));

            Console.WriteLine("Suma decimal resultado: {0}", (double)(objDecimal + objBinario));
            Console.WriteLine("Suma binaria resultado: {0}", (string)(objBinario + objDecimal));
            Console.ReadLine();
        }
    }
}
