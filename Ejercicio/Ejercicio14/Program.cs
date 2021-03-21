using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDami;


namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,num2;
            string preg;
            double result;

            do
            {
                Console.Write("Ingrese el valor de un lado para calcular area del cuadrado: ");
                preg = Console.ReadLine();

            } while (!int.TryParse(preg, out num));
            result = CalculoDeArea.CalcularCuadrado((double)num);
            Console.WriteLine("El area del cuadrado es: {0}", result);

            do
            {
                Console.Write("Ingrese el valor del radio para calcular area del circulo: ");
                preg = Console.ReadLine();

            } while (!int.TryParse(preg, out num));
            result = CalculoDeArea.CalcularCirculo(num);
            Console.WriteLine("el area del circulo es: {0}", result);

            do
            {
                Console.Write("ingrese primero la base para calcular area del triangulo: ");
                preg = Console.ReadLine();

            } while (!int.TryParse(preg, out num));
            do
            {
                Console.Write("Ahora, ingrese la altura para calcular area del triangulo: ");
                preg = Console.ReadLine();

            } while (!int.TryParse(preg, out num2));
            result = CalculoDeArea.CalcularTriangulo(num, num2);
            Console.WriteLine("El area del triangulo es: {0}", result);
            Console.ReadLine();
        }
    }
}
