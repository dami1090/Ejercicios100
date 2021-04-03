using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDami
{
    public class Numerodecimal
    {
        private double numero;
        private Numerodecimal(double n)
        {
            this.numero = n;
        }
        public static double operator +(Numerodecimal nd, NumeroBinario nb)
        {
            Numerodecimal result = new Numerodecimal(Conversor.BinarioDecimal(nb.numero));
            return result.numero + nd.numero;
        }
        public static double operator -(Numerodecimal nd, NumeroBinario nb)
        {
            Numerodecimal result = new Numerodecimal(Conversor.BinarioDecimal(nb.numero));
            return result.numero - nd.numero;
        }
        public static bool operator ==(Numerodecimal nd, NumeroBinario nb)
        {
            bool result = false;
            if (nd.numero == (Conversor.BinarioDecimal(nb.numero)))
            {
                result = true;
            }
            return result;
        }
        public static bool operator !=(Numerodecimal nd, NumeroBinario nb)
        {
            return !(nd==nb);
        }
        //public static explicit operator Pesos(Dolar d)
        //{
        //    Pesos p = new Pesos(d.cantidad * Pesos.GetCotizacion());
        //    return p;
        //}
    }
}
