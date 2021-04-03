using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar;
        #region Constructores
        private Pesos()
        {
            this.cantidad = 0;
        }
        public Pesos(double cant) : this()
        {
            this.cantidad = Math.Round(cant,2);
        }
        public Pesos(double cant, double cotiz) : this(cant)
        {
            this.cantidad = Math.Round(cant,2);
            Pesos.cotizRespectoDolar = cotiz;
        }
        #endregion
        #region Getters
        public static double GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion
        #region Constructor implicito static
        public static implicit operator Pesos(double num)
        {
            Pesos p = new Pesos((double)num);
            return p;
        }
        #endregion
        #region Los Operators de == y !=
        public static bool operator ==(Pesos p1, Pesos p2)
        {
            bool result = false;
            if (p1.cantidad == p2.cantidad)
            {
                result = true;
            }
            return result;
        }
        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Pesos p1, Dolar d1)
        {
            bool result = false;
            if (p1 == (Pesos)d1)
            {
                result = true;
            }
            return result;
        }
        public static bool operator !=(Pesos p1, Dolar d1)
        {
            return !(p1 == d1);
        }
        public static bool operator ==(Pesos p1, Euro e1)
        {
            bool result = false;
            if (p1 == (Pesos)((Dolar)e1))
            {
                result = true;
            }
            return result;
        }
        public static bool operator !=(Pesos p1, Euro e1)
        {
            return !(p1 == e1);
        }

        #endregion
        #region Operator de + y -
        public static Pesos operator +(Pesos p1, Dolar d1)
        {
            Pesos resultado = (Pesos)d1;
            resultado = resultado.cantidad + p1.cantidad;
            return resultado;
        }
        public static Pesos operator -(Pesos p1, Dolar d1)
        {
            Pesos resultado = (Pesos)d1;
            resultado = p1.cantidad - resultado.cantidad;
            return resultado;
        }
        public static Pesos operator +(Pesos p1, Euro e1)
        {
            Pesos resultado = (Pesos)e1;
            resultado = resultado.cantidad + p1.cantidad;
            return resultado;
        }
        public static Pesos operator -(Pesos p1, Euro e1)
        {
            Pesos resultado = (Pesos)e1;
            resultado = p1.cantidad - resultado.cantidad;
            return resultado;
        }
        #endregion
        #region Operator explicit euro peso

        public static explicit operator Dolar(Pesos p)
        {
            Dolar d = new Dolar(p.cantidad / Pesos.GetCotizacion());
            return d;
        }
        public static explicit operator Euro(Pesos p)
        {
            Euro e = new Euro((p.cantidad / Pesos.cotizRespectoDolar) / Euro.GetCotizacion());
            return e;
        }

        #endregion
        public static explicit operator double(Pesos p1)
        {
            return p1.cantidad;
        }
    }
}
