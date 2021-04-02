using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar dol,sumaDE;
            Euro eur, sumaEP;
            Pesos pes, sumaPD;
            double cotizDolar = 1;
            double cotizEuro = 1.08;
            double cotizPeso = 66;

            dol = new Dolar(150, cotizDolar);
            eur = new Euro(100, cotizEuro);
            pes = new Pesos(12000, cotizPeso);

            sumaDE = dol - eur;
            sumaEP = eur - pes;
            sumaPD = pes - dol;

            Console.WriteLine("Cotizaciones");
            Console.WriteLine("Dolar: {0}\tEuro: {1}\tPeso: {2}", Dolar.GetCotizacion(), Euro.GetCotizacion(), Pesos.GetCotizacion());
            Console.WriteLine("suma dolar({1}) - euro({2}): {0}",sumaDE.GetCantidad(),dol.GetCantidad(),eur.GetCantidad());
            Console.WriteLine("suma euro({1}) - pesos({2}): {0}",sumaEP.GetCantidad(),eur.GetCantidad(),pes.GetCantidad());
            Console.WriteLine("suma pesos({1}) - dolar({2}): {0}",sumaPD.GetCantidad(),pes.GetCantidad(),dol.GetCantidad());
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
