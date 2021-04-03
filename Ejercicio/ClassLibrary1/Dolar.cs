using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;
        #region Constructores
        private Dolar()
        {
            this.cantidad = 0;
        }
        public Dolar(double cant) : this()
        {
            this.cantidad = Math.Round(cant,2);
        }
        public Dolar(double cant, double cotiz) : this(cant)
        {
            this.cantidad = Math.Round(cant,2);
            Dolar.cotizRespectoDolar = cotiz;
        }
        #endregion
        #region Getters
        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion
        #region Constructor implicito static
        public static implicit operator Dolar(double num)
        {
            Dolar verde = new Dolar((double)num);
            return verde;
        }
        #endregion
        #region Los Operators de == y !=
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            bool result = false;
            if (d1.cantidad == d2.cantidad)
            {
                result = true;
            }
            return result;
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            bool result = false;
            if (d1.cantidad != d2.cantidad)
            {
                result = true;
            }
            return result;
        }
        public static bool operator ==(Dolar d1, Euro e1)
        {
            bool result = false;
            if(d1 == (Dolar)e1)
            {
                result = true;
            }
            return result;
        }
        public static bool operator !=(Dolar d1, Euro e1)
        {
            return !(d1 == e1);
        }
        public static bool operator ==(Dolar d1, Pesos p1)
        {
            bool result = false;
            if (d1 == (Dolar)p1)
            {
                result = true;
            }
            return result;
        }
        public static bool operator !=(Dolar d1, Pesos p1)
        {
            return !(d1 == p1);
        }

        #endregion
        #region Operator de + y -
        public static Dolar operator +(Dolar d1, Euro e1)
        {
            //Dolar resultado = new Dolar();
            //resultado.cantidad = (e1.GetCantidad() * Euro.GetCotizacion()) + d1.cantidad;
            //return resultado;
            Dolar result = (Dolar)e1;
            result = result.cantidad + d1.cantidad;
            return result;
        }
        public static Dolar operator -(Dolar d1, Euro e1)
        {
            //Dolar resultado = new Dolar();
            //resultado.cantidad = d1.cantidad - (e1.GetCantidad() * Euro.GetCotizacion());
            //return resultado;
            Dolar result = (Dolar)e1;
            result =  d1.cantidad - result.cantidad;
            return result;
        }
        public static Dolar operator +(Dolar d1, Pesos p1)
        {
            Dolar resultado = (Dolar)p1;
            resultado = resultado.cantidad + d1.cantidad;
            return resultado;
        }
        public static Dolar operator -(Dolar d1, Pesos p1)
        {
            Dolar resultado = (Dolar)p1;
            resultado = d1.cantidad - resultado.cantidad;
            return resultado;
        }
        #endregion
        #region Operator explicit euro peso

        public static explicit operator Euro(Dolar d)
        {
            Euro e = new Euro(d.cantidad / Euro.GetCotizacion());
            return e;
        }
        public static explicit operator Pesos(Dolar d)
        {
            Pesos p = new Pesos(d.cantidad * Pesos.GetCotizacion());
            return p;
        }

        #endregion

        public static explicit operator double(Dolar d1)
        {
            return d1.cantidad;
        }
    }
}
