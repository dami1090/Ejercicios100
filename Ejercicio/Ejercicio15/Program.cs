using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDami;


namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            char respuesta;
            int num,num2;
            string preg;
            char simbolo;
            bool continuar = true;
            double result;

            while (continuar)
            {
                continuar = false;
                Console.WriteLine("Caculadora");

                do
                {
                    Console.Write("Ingrese el valor del primer numero: ");
                    preg = Console.ReadLine();

                } while (!int.TryParse(preg, out num));
                do
                {
                    Console.Write("Ingrese el valor del segundo numero: ");
                    preg = Console.ReadLine();

                } while (!int.TryParse(preg, out num2));

                Console.WriteLine("ahora debera seleccionar que operacion realizar: ");
                do
                {
                    Console.Write("Suma(+) Resta(-) Multipilicacion(*)  Division(/): ");
                    simbolo = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                } while (simbolo != '+' && simbolo != '-' && simbolo != '*' && simbolo != '/');
                result = Calculadora.Calcular(num, num2, simbolo);
                Console.WriteLine("El resultado es: {0}", result);


                Console.WriteLine("¿Continuar ? (S / N) ");
                Console.Write("Respuesta: ");
                respuesta = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (Validacion.ValidarS_N(respuesta))
                {
                    continuar = true;
                }
            }
            Console.ReadLine();
        }
    }
}
