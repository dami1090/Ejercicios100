using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDami;

namespace Ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            Farenheit far,sumaF;
            Celsius cel, sumaC;
            Kelvin kel, sumaK;

            far = new Farenheit(66, 150);
            cel = new Celsius(25, 150);
            kel = new Kelvin(760, 150);

            sumaF = far + cel;
            sumaC = cel + far;
            sumaK = kel + far;
            Console.WriteLine("Farenheit({0}) - Celsius({1}) - Kelvin({2})", (double)far, cel.GetCantidad(), kel.GetCantidad());
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Farenheit({0}) - EN Celsius({1}) - EN Kelvin({2})", (double)far, (double)((Celsius)far), (double)((Kelvin)far));
            Console.WriteLine("EN Farenheit({0}) - Celsius({1}) - en KELVIN ({2}) ", (double)((Farenheit)cel), (double)cel, (double)((Kelvin)cel));
            Console.WriteLine("EN Farenheit({0}) -  EN Celsius({1}) - kelvin ({2}) ", (double)((Farenheit)kel), (double)((Celsius)kel), (double)kel);
            
            Console.WriteLine("Kelvin({0}) - Farenheit({1})", (double)kel, (double)far);
 
            Console.WriteLine("suma fanta: {0}", (double)sumaF );
            Console.ReadLine();
        }
    }
}
