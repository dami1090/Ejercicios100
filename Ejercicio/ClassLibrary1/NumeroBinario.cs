using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDami
{
    public class NumeroBinario
    {
        public string numero;
        private NumeroBinario(string s)
        {
            this.numero = s;
        }
        public static string operator +(NumeroBinario nb, NumeroDecimal nd)
        {
            double result = Conversor.BinarioDecimal(nb.numero);
            result = result + (double)nd;
            return Conversor.DecimalBinario(result);
        }
        public static string operator -(NumeroBinario nb, NumeroDecimal nd)
        {
            double result = Conversor.BinarioDecimal(nb.numero);
            result = result - (double)nd;
            return Conversor.DecimalBinario(result);
        }
        public static bool operator ==(NumeroBinario nb, NumeroDecimal nd)
        {
            bool result = false;
            if ((double)nd == (Conversor.BinarioDecimal(nb.numero)))
            {
                result = true;
            }
            return result;
        }
        public static bool operator !=(NumeroBinario nb, NumeroDecimal nd)
        {
            return !(nb == nd);
        }
        //-----------------------------------------------
        public static implicit operator NumeroBinario(string num)
        {
            NumeroBinario nd1 = new NumeroBinario((string)num);
            return nd1;
        }

        public static explicit operator string(NumeroBinario nd1)
        {
            return nd1.numero;
        }
    }
}
