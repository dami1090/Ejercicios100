using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDami
{
    public class Centimetro
    {
        public double cantidadCentimetro;

        public Centimetro()
        {
            this.cantidadCentimetro = 0;
        }
        public Centimetro(double cant) : this()
        {
            this.cantidadCentimetro = cant;
        }
        public static Centimetro operator +(Metro m1, Centimetro c2)// retorna Metro
        {
            Centimetro resultado = new Centimetro();
            resultado.cantidadCentimetro = (m1.cantidadMetros * 100) + c2.cantidadCentimetro;
            return resultado;
        }
        public static bool operator ==(Centimetro c1, Centimetro c2)// retorna Metro
        {
            bool result = false;
            if(c1.cantidadCentimetro==c2.cantidadCentimetro)
            {
                result = true;
            }
            return result;
        }
        public static bool operator !=(Centimetro c1, Centimetro c2)// retorna Metro
        {
            bool result = false;
            if (c1.cantidadCentimetro != c2.cantidadCentimetro)
            {
                result = true;
            }
            return result;
        }
        public static explicit operator double(Centimetro c1)
        {
            return c1.cantidadCentimetro;
        }
    }
}
