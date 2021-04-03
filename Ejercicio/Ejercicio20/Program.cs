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
            pes = new Pesos(12200, cotizPeso);

            if (dol == eur)
            {
                Console.WriteLine("que cheto");
            }

            sumaDE = dol - eur;
            sumaEP = eur - pes;
            sumaPD = pes - dol;

            Console.WriteLine("Cotizaciones");
            Console.WriteLine("Dolar: {0}\tEuro: {1}\tPeso: {2}", Dolar.GetCotizacion(), Euro.GetCotizacion(), Pesos.GetCotizacion());
            Console.WriteLine("suma dolar({1}) - euro({2}): U$S {0}", (double)sumaDE, (double)dol, (double)eur);
            Console.WriteLine("suma euro({1}) - pesos({2}): €EUR {0}", sumaEP.GetCantidad(),eur.GetCantidad(),pes.GetCantidad());
            Console.WriteLine("suma pesos({1}) - dolar({2}): $ {0}", (double)sumaPD, (double)pes, (double)dol);

            Console.WriteLine("segunda tanda\n-------------------------------------------------------------------------");
            sumaDE = (Dolar)(eur - dol);
            sumaEP = (Euro)(pes - eur);
            sumaPD = (Pesos)(dol - pes);

            Console.WriteLine("suma dolar({1}) - euro({2}): U$S {0}", (double)sumaDE, (double)dol, (double)eur);
            Console.WriteLine("suma euro({1}) - pesos({2}): €EUR {0}", sumaEP.GetCantidad(), eur.GetCantidad(), pes.GetCantidad());
            Console.WriteLine("suma pesos({1}) - dolar({2}): $ {0}", (double)sumaPD, (double)pes, (double)dol);
            dol = dol + (Pesos)100;
            Console.WriteLine("suma fanta: {0}", (double)dol);
            Console.ReadLine();
        }
    }
}
