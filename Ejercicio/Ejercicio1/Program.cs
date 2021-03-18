using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio: 1";
            int[] num = new int[5];
            string preg;
            int i = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            int acumulador=0;
            while (i < 5)
            {
                do
                {
                    Console.WriteLine("Ingrese un numero: " + i + "/5");
                    preg = Console.ReadLine();

                } while (!int.TryParse(preg, out num[i]));
                i++;
            }
            foreach(int numero in num)
            {
                if (numero > max)
                {
                    max = numero;
                }
                if (numero < min)
                {
                    min = numero;
                }
                Console.WriteLine("Numero vale: " + numero);
                acumulador = acumulador + numero;
            }
            Console.WriteLine("min: " + min);
            Console.WriteLine("max: " + max);
            Console.WriteLine("contador i: " + i);
            Console.WriteLine("Promedio: " + acumulador / i);
            Console.ReadLine();
        }


        //static void Main(string[] args)
        //{
        //    double numero1 = 5;
        //    double numero2 = 3;
        //    double result;
        //    result = Potencia(numero1, numero2);
        //    Console.WriteLine("el resultado: " + result);
        //    Console.ReadLine();
        //}

        //// Con hacer 3/ '///' ya te hace esto para documentas re piola
        ///// <summary>
        /////  realiza Math.Pow() asi re loco
        ///// </summary>
        ///// <param name="numBase"></param>
        ///// <param name="numExponente"></param>
        ///// <returns></returns>
        //static double Potencia(double numBase, double numExponente)
        //{
        //    return Math.Pow(numBase, numExponente);
        //}
    }
}
