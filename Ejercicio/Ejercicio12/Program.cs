using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDami;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            char respuesta = 's';
            int num,i=0,acu=0;
            string preg;
            bool continuar = true;
            while(continuar)
            {
                continuar = false;

                do
                {
                    Console.WriteLine("Ingrese numero:                   /" +"Cantidad cargada: "+ i);
                    preg = Console.ReadLine();

                } while (!int.TryParse(preg, out num));

                i++;
                acu = acu + num;
                Console.WriteLine("¿Continuar ? (S / N) ");
                Console.Write("Respuesta: ");
                respuesta = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (Validacion.ValidarS_N(respuesta))
                {
                    continuar = true;
                }

            }
            Console.WriteLine("El valor total sumado es: "+acu);
            Console.ReadLine();
        }
    }
}
