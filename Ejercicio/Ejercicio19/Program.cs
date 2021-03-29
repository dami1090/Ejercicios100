using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDami;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            BibliotecaDami.Sumador acu = new BibliotecaDami.Sumador(21);

            Console.WriteLine("Resultado de la suma de a+b: {0}",acu.Sumar("11", "58"));
            Console.WriteLine("Cantidad de sumas: {0}",acu.GetCantidadSumas());
            Console.ReadLine();
        }
    }
}
