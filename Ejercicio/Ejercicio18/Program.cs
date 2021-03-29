using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDami;

namespace Ejercicio18
{
    class PruebaGeometria
    {
        static void Main(string[] args)
        {
            //x / y
            //v1 = 0 / 2           v4 = ? 5 / 2
            //v2 =? 0 / 0             v3 = 5 / 0
            Geometria.Punto p1 = new Geometria.Punto(0, 2);
            Geometria.Punto p3 = new Geometria.Punto(5, 0);
            Geometria.Rectangulo recta = new Geometria.Rectangulo(p1, p3);

            Console.WriteLine("Area: {0},\nPerimetro: {1},\n", recta.GetArea(), recta.GetPerimetro());
            Console.WriteLine("ahroa funcion mostarr");
            recta.Mostrar();
            Console.ReadLine();
        }
    }
}
