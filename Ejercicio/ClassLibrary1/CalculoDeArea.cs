using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDami
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double n)
        {
            return n*n;
        }

        public static double CalcularTriangulo(double n, double l)
        {
            return (n*l)/2;
        }
        public static double CalcularCirculo(double n)
        {
            return Math.PI*(n*n);
        }
    }
}
