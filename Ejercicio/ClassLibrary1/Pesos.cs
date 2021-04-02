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
            this.cantidad = cant;
        }
        public Pesos(double cant, double cotiz) : this(cant)
        {
            this.cantidad = cant;
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

            if (p1.cantidad == (d1.GetCantidad() * Pesos.GetCotizacion()))
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
            double resultado;
            resultado = p1.GetCantidad() * Pesos.GetCotizacion();
            if (e1.GetCantidad() == (resultado * Euro.GetCotizacion()))
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
            Pesos resultado = new Pesos();
            resultado.cantidad = (d1.GetCantidad() * Pesos.GetCotizacion()) + p1.GetCantidad();
            return resultado;
        }
        public static Pesos operator -(Pesos p1, Dolar d1)
        {
            Pesos resultado = new Pesos();
            resultado.cantidad = p1.GetCantidad() - (d1.GetCantidad() * Pesos.GetCotizacion());
            return resultado;
        }
        public static Pesos operator +(Pesos p1, Euro e1)
        {
            Pesos resultado = new Pesos();
            resultado.cantidad = ((e1.GetCantidad() / Euro.GetCotizacion()) * Pesos.GetCotizacion()) + p1.GetCantidad();
            return resultado;
        }
        public static Pesos operator -(Pesos p1, Euro e1)
        {
            Pesos resultado = new Pesos();
            resultado.cantidad = p1.GetCantidad() - ((e1.GetCantidad() / Euro.GetCotizacion()) * Pesos.GetCotizacion());
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
            Euro e = new Euro((p.cantidad * Pesos.cotizRespectoDolar) * Euro.GetCotizacion());
            return e;
        }

        #endregion
    }
}
