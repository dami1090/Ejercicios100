using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDami
{
    public class Kelvin
    {
        private double cantidad;
        private static double TemperaturaRespectoFarenheit;

        #region Constructores
        private Kelvin()
        {
            this.cantidad = 0;
        }
        public Kelvin(double cant) : this()
        {
            this.cantidad = Math.Round(cant, 2);
        }
        public Kelvin(double cant, double cotiz) : this(cant)
        {
            this.cantidad = Math.Round(cant, 2);
            Kelvin.TemperaturaRespectoFarenheit = cotiz;
        }
        #endregion

        #region Getters
        public static double GetTemperatura()
        {
            return Kelvin.TemperaturaRespectoFarenheit;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion

        #region Constructor implicito static
        public static implicit operator Kelvin(double num)
        {
            Kelvin k = new Kelvin((double)num);
            return k;
        }
        #endregion

        #region Los Operators de == y !=
        public static bool operator ==(Kelvin k1, Kelvin k2)
        {
            bool result = false;
            if (k1.cantidad == k2.cantidad)
            {
                result = true;
            }
            return result;
        }
        public static bool operator !=(Kelvin k1, Kelvin k2)
        {
            return !(k1 == k2);
        }
        public static bool operator ==(Kelvin k1, Farenheit f1)
        {
            bool result = false;
            if (k1 == (Kelvin)f1)
            {
                result = true;
            }
            return result;
        }
        public static bool operator !=(Kelvin k1, Farenheit f1)
        {
            return !(k1 == f1);
        }
        public static bool operator ==(Kelvin k1, Celsius c1)
        {
            bool result = false;
            if (k1 == (Kelvin)((Farenheit)c1))
            {
                result = true;
            }
            return result;
        }
        public static bool operator !=(Kelvin k1, Celsius c1)
        {
            return !(k1 == c1);
        }

        #endregion

        #region Operator de + y -
        public static Kelvin operator +(Kelvin k1, Farenheit f1)
        {
            Kelvin resultado = (Kelvin)f1;
            resultado = resultado.cantidad + k1.cantidad;
            return resultado;
        }
        public static Kelvin operator -(Kelvin k1, Farenheit f1)
        {
            Kelvin resultado = (Kelvin)f1;
            resultado = k1.cantidad - resultado.cantidad;
            return resultado;
        }
        public static Kelvin operator +(Kelvin k1, Celsius c1)
        {
            Kelvin resultado = (Kelvin)c1;
            resultado = resultado.cantidad + k1.cantidad;
            return resultado;
        }
        public static Kelvin operator -(Kelvin k1, Celsius c1)
        {
            Kelvin resultado = (Kelvin)c1;
            resultado = k1.cantidad - resultado.cantidad;
            return resultado;
        }
        #endregion

        #region Operator explicit euro peso

        public static explicit operator Farenheit(Kelvin k)
        {
            Farenheit f = new Farenheit(((k.cantidad - 273.15) * 1.8)+32);
            return f;
        }
        public static explicit operator Celsius(Kelvin k)
        {
            Celsius c = new Celsius(k.cantidad - 273.15);
            return c;
        }

        #endregion
        public static explicit operator double(Kelvin k1)
        {
            return k1.cantidad;
        }
    }
}
