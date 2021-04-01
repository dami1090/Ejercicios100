using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDami
{
    public class Metro
    {
        public double cantidadMetros;

        public Metro()
        {
            this.cantidadMetros = 0;
        }
        public Metro(double cant) : this()
        {
            this.cantidadMetros = cant;
        }
        public static Metro operator +(Metro m1, Metro m2)// retorna Metro
        {
            Metro resultado = new Metro();
            resultado.cantidadMetros = m1.cantidadMetros + m2.cantidadMetros;
            return resultado;
        }

        public static explicit operator double(Metro m1)
        {
            return m1.cantidadMetros;
        }
        public static implicit operator int (Metro m1)
        {
            return (int)m1.cantidadMetros;
        }
    }
}
