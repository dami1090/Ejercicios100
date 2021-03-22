using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDami;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alum1 = new Alumno("Juanpi", "Torrico", 76);
            Alumno alum2 = new Alumno("Gloria", "ibino", 42);
            Alumno alum3 = new Alumno("Aquiles", "Baeza", 98);

            alum1.Estudiar((byte)7, (byte)8);
            alum1.CalcularFinal();
            alum1.Mostrar();
            Console.WriteLine();

            alum2.Estudiar((byte)2, (byte)2);
            alum2.CalcularFinal();
            alum2.Mostrar();
            Console.WriteLine();

            alum3.Estudiar((byte)5, (byte)6);
            alum3.CalcularFinal();
            alum3.Mostrar();

            Console.ReadLine();
        }
    }
}
