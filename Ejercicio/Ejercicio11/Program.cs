using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDami;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            string preg;
            int i = 0;
            int num;
            int acu = 0;
            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            while (i < 10)
            {
                do
                {
                    Console.WriteLine("Ingrese un numero: " + i + "/10");
                    preg = Console.ReadLine();

                } while (!int.TryParse(preg, out num));
                if (Validacion.Validar(num, -101, 101))
                {
                    i++;
                    acu = acu + num;
                    if (num > maximo)
                    {
                        maximo = num;
                    }
                    if (num < minimo)
                    {
                        minimo = num;
                    }
                    Console.WriteLine("Numero cargado correctamente!");
                }
                else
                {
                    Console.WriteLine("Numero no cargado, tendra que volver a intentar, pero esta vez correctamente!");
                }
            }
            Console.WriteLine("El promedio es: " + acu / 10);
            Console.WriteLine("El maximo ingresado es: " + maximo);
            Console.WriteLine("El minimo ingresado es: " + minimo);
            Console.ReadLine();
        }
    }
}
