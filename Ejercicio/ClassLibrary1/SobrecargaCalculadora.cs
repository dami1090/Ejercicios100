using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDami
{
    public class SobrecargaCalculadora
    {
        //public float num1;
        //public float num2;
        /// <summary>
        /// Para sumar flotantes y probar las sobre cargas
        /// </summary>
        /// <param name="n1">flotante a sumar</param>
        /// <param name="n2">Segundo flotante</param>
        /// <returns>Devuelve la suma de flotantes</returns>
        public static float Sumar(float n1, float n2)
        {
            return n1 + n2;
        }
        public static float Sumar(float n1, float n2, float n3)
        {
            return n1 +SobrecargaCalculadora.Sumar(n2, n3);// reutilizo el anterior sobrecarga
        }
        public static float Sumar(float n1, int n2, float n3)// el return no crea otra sobrecarga, el tipo de dato SI!
        {
            return n1 + n2 + n3;
        }
    }
}
