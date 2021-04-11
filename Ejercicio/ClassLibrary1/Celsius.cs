using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDami
{
    public class Celsius
    {
        private double cantidad;
        private static double TemperaturaRespectoFarenheit;

        #region Constructores
        private Celsius()
        {
            this.cantidad = 0;
        }
        public Celsius(double cant) : this()
        {
            this.cantidad = Math.Round(cant, 2);
        }
        public Celsius(double cant, double cotiz) : this(cant)
        {
            this.cantidad = Math.Round(cant, 2);
            Celsius.TemperaturaRespectoFarenheit = cotiz;
        }
        #endregion

        #region Getters
        public static double GetTemperatura()
        {
            return Celsius.TemperaturaRespectoFarenheit;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion

        #region Constructor implicito static
        public static implicit operator Celsius(double num)
        {
            Celsius c = new Celsius((double)num);
            return c;
        }
        #endregion

        #region Los Operators de == y !=
        public static bool operator ==(Celsius c1, Celsius c2)
        {
            bool result = false;
            if (c1.cantidad == c2.cantidad)
            {
                result = true;
            }
            return result;
        }
        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return !(c1 == c2);
        }
        public static bool operator ==(Celsius e1, Farenheit d1)
        {
            bool result = false;
            if (e1 == (Celsius)d1)
            {
                result = true;
            }
            return result;
        }
        public static bool operator !=(Celsius e1, Farenheit d1)
        {
            return !(e1 == d1);
        }
        public static bool operator ==(Celsius e1, Kelvin p1)
        {
            bool result = false;
            if (e1 == (Celsius)((Farenheit)p1))
            {
                result = true;
            }
            return result;
        }
        public static bool operator !=(Celsius e1, Kelvin p1)
        {
            return !(e1 == p1);
        }

        #endregion

        #region Operator de + y -
        public static Celsius operator +(Celsius c1, Farenheit f1)
        {
            Celsius resultado = (Celsius)f1;
            resultado = resultado.cantidad + c1.cantidad;
            return resultado;
        }
        public static Celsius operator -(Celsius c1, Farenheit f1)
        {
            Celsius resultado = (Celsius)f1;
            resultado = c1.cantidad - resultado.cantidad;
            return resultado;
        }
        public static Celsius operator +(Celsius c1, Kelvin k1)
        {
            Celsius resultado = (Celsius)k1;
            resultado = resultado.cantidad + c1.cantidad;
            return resultado;
        }
        public static Celsius operator -(Celsius c1, Kelvin k1)
        {
            Celsius resultado = (Celsius)k1;
            resultado = c1.cantidad - resultado.cantidad;
            return resultado;
        }
        #endregion

        #region Operator explicit euro peso

        public static explicit operator Farenheit(Celsius c)
        {
            Farenheit d = new Farenheit((c.cantidad * 1.8)+32);
            return d;
        }
        public static explicit operator Kelvin(Celsius c)
        {
            Kelvin k = new Kelvin(c.cantidad + 273.15);
            return k;
        }

        #endregion

        public static explicit operator double(Celsius c1)
        {
            return c1.cantidad;
        }
    }
}
