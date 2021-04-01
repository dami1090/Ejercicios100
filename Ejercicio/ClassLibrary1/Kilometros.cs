using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDami
{
    public class Kilometros
    {
        double cantidadKilometros;

        private Kilometros(double k1)
        {
            this.cantidadKilometros = k1;

        }
        public static implicit operator Kilometros(int num)
        {
            Kilometros kilometro = new Kilometros((double)num);
            return kilometro;
        }

        public static explicit operator double(Kilometros k1)
        {
            return k1.cantidadKilometros;
        }

    }
}
