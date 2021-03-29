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
        public Sumador(int num)
        {
            this.cantidadSumas = num;
        }
        public Sumador()
        {
            this.cantidadSumas = 0;
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
        
    }
}
