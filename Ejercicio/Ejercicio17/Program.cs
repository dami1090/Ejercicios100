using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDami;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            short cantidadRed = 50;
            short cantidadBlue = 100;
            string draw;
            //ConsoleColor color = ConsoleColor.Red;
            Boligrafo lapiceraRed = new Boligrafo(cantidadRed, ConsoleColor.Red);
            Boligrafo lapiceraBlue = new Boligrafo(cantidadBlue, ConsoleColor.Blue);

            if (lapiceraRed.Pintar(55, out draw))
            {
                Console.ForegroundColor = lapiceraRed.GetColor();
                Console.WriteLine("Pudo acabar el dibujo");
                Console.WriteLine("resultado: {0}", draw);
            }
            else
            {
                Console.ForegroundColor = lapiceraRed.GetColor();
                Console.WriteLine("el dibujo no se completo, no habia tinta suficiente");
                Console.WriteLine("draw: {0}", draw);
            }

            if (lapiceraBlue.Pintar(30, out draw))
            {
                Console.ForegroundColor = lapiceraBlue.GetColor();
                Console.WriteLine("Pudo acabar el dibujo");
                Console.WriteLine("resultado: {0}", draw);
            }
            else
            {
                Console.ForegroundColor = lapiceraBlue.GetColor();
                Console.WriteLine("el dibujo no se completo, no habia tinta suficiente");
                Console.WriteLine("draw: {0}", draw);
            }

            lapiceraRed.Recargar();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Recargamos la lapicera ROJA");
            if (lapiceraRed.Pintar(55, out draw))
            {
                Console.ForegroundColor = lapiceraRed.GetColor();
                Console.WriteLine("Pudo acabar el dibujo");
                Console.WriteLine("resultado: {0}", draw);
            }
            else
            {
                Console.ForegroundColor = lapiceraRed.GetColor();
                Console.WriteLine("No se termino la tinta y pudo acabar el dibujo");
                Console.WriteLine("draw: {0}", draw);
            }

            Console.ForegroundColor = lapiceraBlue.GetColor();
            Console.WriteLine("Lapicera azul cantidad de tinta: {0}", lapiceraBlue.GetTinta());
            Console.ForegroundColor = lapiceraRed.GetColor();
            Console.WriteLine("Lapicera roja cantidad de tinta: {0}", lapiceraRed.GetTinta());
            Console.ReadLine();
        }
    }
}
