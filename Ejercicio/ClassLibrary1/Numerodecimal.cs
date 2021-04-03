using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDami
{
    public class NumeroDecimal
    {
        private double numero;
        private NumeroDecimal(double n)
        {
            this.numero = n;
        }
        public static double operator +(NumeroDecimal nd, NumeroBinario nb)
        {
            NumeroDecimal result = new NumeroDecimal(Conversor.BinarioDecimal(nb.numero));
            return result.numero + nd.numero;
        }
        public static double operator -(NumeroDecimal nd, NumeroBinario nb)
        {
            NumeroDecimal result = new NumeroDecimal(Conversor.BinarioDecimal(nb.numero));
            return result.numero - nd.numero;
        }
        public static bool operator ==(NumeroDecimal nd, NumeroBinario nb)
        {
            bool result = false;
            if (nd.numero == (Conversor.BinarioDecimal(nb.numero)))
            {
                result = true;
            }
            return result;
        }
        public static bool operator !=(NumeroDecimal nd, NumeroBinario nb)
        {
            return !(nd==nb);
        }
        //public static explicit operator Pesos(Dolar d)
        //{
        //    Pesos p = new Pesos(d.cantidad * Pesos.GetCotizacion());
        //    return p;
        //}
        public static implicit operator NumeroDecimal(double num)
        {
            NumeroDecimal nd1 = new NumeroDecimal((double)num);
            return nd1;
        }

        public static explicit operator double(NumeroDecimal nd1)
        {
            return nd1.numero;
        }
    }
}
