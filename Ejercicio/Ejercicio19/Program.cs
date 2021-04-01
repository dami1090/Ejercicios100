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
            Sumador acu = new Sumador(14);
            Sumador sum2 = new Sumador(24);

            if (acu | sum2)
            {
                Console.WriteLine("son iguales las cantidad de suma");
            }
            if (!(acu | sum2))
            {
                Console.WriteLine("tienen distintas cantidades de suma");
            }
            Console.WriteLine("Resultado de la suma de a+b: {0}",acu.Sumar("11", "58"));
            Console.WriteLine("Cantidad sumas de acu: {0}\nCantidad sumas de sum2: {1}",(int)acu,(int)sum2);//acu.GetCantidadSumas());
            Console.ReadLine();
        }
    }
}
