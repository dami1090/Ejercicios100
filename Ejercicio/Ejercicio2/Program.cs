﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio: 2";
            string preg;
            int num;
            Console.WriteLine("Ingrese un numero: ");
            preg = Console.ReadLine();
            while (!int.TryParse(preg, out num) || num < 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                preg = Console.ReadLine();
            }
            Console.WriteLine("Resultado al cuadrado es: {0}\nResultado al cubo es: {1}", Math.Pow(num, 2), Math.Pow(num, 3));
            Console.ReadLine();
        }
    }
}
