﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;
        #region Constructores
        private Euro()
        {
            this.cantidad = 0;
        }
        public Euro(double cant) : this()
        {
            this.cantidad = cant;
        }
        public Euro(double cant, double cotiz) : this(cant)
        {
            this.cantidad = cant;
            Euro.cotizRespectoDolar = cotiz;
        }
        #endregion
        #region Getters
        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion
        #region Constructor implicito static
        public static implicit operator Euro(double num)
        {
            Euro e = new Euro((double)num);
            return e;
        }
        #endregion
        #region Los Operators de == y !=
        public static bool operator ==(Euro e1, Euro e2)
        {
            bool result = false;
            if (e1.cantidad == e2.cantidad)
            {
                result = true;
            }
            return result;
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
        public static bool operator ==(Euro e1, Dolar d1)
        {
            bool result = false;

            if (e1.cantidad == (d1.GetCantidad() / Euro.GetCotizacion()))
            {
                result = true;
            }
            return result;
        }
        public static bool operator !=(Euro e1, Dolar d1)
        {
            return !(e1 == d1);
        }

        public static bool operator ==(Euro e1, Pesos p1)
        {
            bool result = false;
            double resultado;
            resultado = p1.GetCantidad() / Pesos.GetCotizacion();
            if (e1.cantidad == (resultado / Euro.GetCotizacion()))
            {
                result = true;
            }
            return result;
        }
        public static bool operator !=(Euro e1, Pesos p1)
        {
            return !(e1 == p1);
        }

        #endregion
        #region Operator de + y -
        public static Euro operator +(Euro e1, Dolar d1)
        {
            Euro resultado = new Euro();
            resultado.cantidad = (d1.GetCantidad() / Euro.GetCotizacion()) + e1.cantidad;
            return resultado;
        }
        public static Euro operator -(Euro e1, Dolar d1)
        {
            Euro resultado = new Euro();
            resultado.cantidad = e1.cantidad - (d1.GetCantidad() / Euro.GetCotizacion());
            return resultado;
        }
        public static Euro operator +(Euro e1, Pesos p1)
        {
            Euro resultado = new Euro();
            resultado.cantidad = ((p1.GetCantidad() / Pesos.GetCotizacion()) / Euro.GetCotizacion()) + e1.cantidad;
            return resultado;
        }
        public static Euro operator -(Euro e1, Pesos p1)
        {
            Euro resultado = new Euro();
            resultado.cantidad = e1.cantidad - ((p1.GetCantidad() / Pesos.GetCotizacion()) / Euro.GetCotizacion());
            return resultado;
        }
        #endregion
        #region Operator explicit euro peso

        public static explicit operator Dolar(Euro e)
        {
            Dolar d = new Dolar(e.cantidad * Euro.cotizRespectoDolar);
            return d;
        }
        public static explicit operator Pesos(Euro e)
        {
            Pesos p = new Pesos((e.cantidad * Euro.cotizRespectoDolar)*Pesos.GetCotizacion());
            return p;
        }

        #endregion
    }
}
