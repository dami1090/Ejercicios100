using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDami;

namespace Clase_3___Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(SobrecargaCalculadora.Sumar(65, 22, 152));
            //Persona persona1 = new Persona("shisus");
            //Persona persona2 = new Persona("Maria",666,"Ares");
            //Console.WriteLine(Persona.GetCantidadPersonas());
            int suma;
            Metro sumaMetros;
            Centimetro sumaCentrimetro;
            Kilometros kilometro;
            Metro metro1 = new Metro(10);
            Centimetro centimetro1 = new Centimetro(10);

            kilometro = 100;//implicito
            //kilometro = (Kilometros)100; //explicito, pero solo es util para mostrar, aca no xq deberia devolver un objeto kilometro
            sumaMetros = metro1 + metro1; // Sin instancear  "sumaMetro" xq devuelve un objeto metro
            suma = sumaMetros;
            sumaCentrimetro = metro1 + centimetro1;// multiplique a cm, mas facil q dividir, ademas de ambiguedad( 2 veces el operator "+" con Metro + Centimetro)
            centimetro1.cantidadCentimetro = sumaCentrimetro.cantidadCentimetro;
            if(centimetro1 == sumaCentrimetro)
            {
                Console.WriteLine("Son iguales");
            }
            if (centimetro1 != sumaCentrimetro)
            {
                Console.WriteLine("Son distintos");
            }
            Console.WriteLine((double)sumaMetros);
            Console.WriteLine(suma);
            Console.WriteLine("Suma de metro + centimetro: {0}cm", (double)sumaCentrimetro);
            Console.WriteLine("El kilometro: {0}", (double)kilometro);
            Console.ReadLine();
        }
    }
}
