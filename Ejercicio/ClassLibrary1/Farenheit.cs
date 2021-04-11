using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDami
{
    public class Farenheit
    {
        private double cantidad;
        private static double TemperaturaRespectoFarenheit;

        #region Constructores
        private Farenheit()
        {
            this.cantidad = 0;
        }
        public Farenheit(double cant) : this()
        {
            this.cantidad = Math.Round(cant, 2);
        }
        public Farenheit(double cant, double grados) : this(cant)
        {
            this.cantidad = Math.Round(cant, 2);
            Farenheit.TemperaturaRespectoFarenheit = grados;
        }
        #endregion

        #region Getters
        public static double GetTemperatura()
        {
            return Farenheit.TemperaturaRespectoFarenheit;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion

        #region Constructor implicito static
        public static implicit operator Farenheit(double num)
        {
            Farenheit temp = new Farenheit((double)num);
            return temp;
        }
        #endregion

        #region Los Operators de == y !=
        public static bool operator ==(Farenheit d1, Farenheit d2)
        {
            bool result = false;
            if (d1.cantidad == d2.cantidad)
            {
                result = true;
            }
            return result;
        }
        public static bool operator !=(Farenheit d1, Farenheit d2)
        {
            bool result = false;
            if (d1.cantidad != d2.cantidad)
            {
                result = true;
            }
            return result;
        }
        // EURO = Celsius
        public static bool operator ==(Farenheit d1, Celsius c1)
        {
            bool result = false;
            if (d1 == (Farenheit)c1)
            {
                result = true;
            }
            return result;
        }
        public static bool operator !=(Farenheit d1, Celsius c1)
        {
            return !(d1 == c1);
        }
        //PESOS = KELVIN
        public static bool operator ==(Farenheit d1, Kelvin p1)
        {
            bool result = false;
            if (d1 == (Farenheit)p1)
            {
                result = true;
            }
            return result;
        }
        public static bool operator !=(Farenheit d1, Kelvin p1)
        {
            return !(d1 == p1);
        }

        #endregion

        #region Operator de + y -
        public static Farenheit operator +(Farenheit f1, Celsius c1)
        {
            Farenheit result = (Farenheit)c1;
            result = result.cantidad + f1.cantidad;
            return result;
        }
        public static Farenheit operator -(Farenheit f1, Celsius c1)
        {
            Farenheit result = (Farenheit)c1;
            result = f1.cantidad - result.cantidad;
            return result;
        }
        public static Farenheit operator +(Farenheit f1, Kelvin k1)
        {
            Farenheit resultado = (Farenheit)k1;
            resultado = resultado.cantidad + f1.cantidad;
            return resultado;
        }
        public static Farenheit operator -(Farenheit f1, Kelvin k1)
        {
            Farenheit resultado = (Farenheit)k1;
            resultado = f1.cantidad - resultado.cantidad;
            return resultado;
        }
        #endregion

        #region Operator explicit euro peso

        public static explicit operator Celsius(Farenheit f)
        {
            Celsius c = new Celsius((f.cantidad - 32)* 0.56);
            return c;
        }
        public static explicit operator Kelvin(Farenheit f)
        {
            Kelvin k = new Kelvin(((f.cantidad-32)* 0.56) + 273.15 );
            return k;
        }

        #endregion

        public static explicit operator double(Farenheit f1)
        {
            return f1.cantidad;
        }
    }
}
