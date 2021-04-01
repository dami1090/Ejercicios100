using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDami
{
    public class Sumador
    {
        private int cantidadSumas;
        public int GetCantidadSumas()
        {
            return this.cantidadSumas;
        }
        public Sumador()
        {
            this.cantidadSumas = 0;
        }
        public Sumador(int num):this()
        {
            this.cantidadSumas = num;
        }

        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return string.Format(a + b);
        }

        public static explicit operator int(Sumador s1)
        {
            return s1.cantidadSumas;
        }
        public static long operator +(Sumador s1, Sumador s2)
        {
            long resultado;
            resultado = (long)(s1.cantidadSumas + s2.cantidadSumas);
            return resultado;
        }
        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool resultado = false;
            if (s1.cantidadSumas == s2.cantidadSumas)
            {
                resultado = true;
            }
            return resultado;
        }
    }
}
