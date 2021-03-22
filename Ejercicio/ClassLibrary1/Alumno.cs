using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDami
{
    public class Alumno
    {
        byte nota1;
        byte nota2;
        float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public Alumno(string nom, string ape, int leg)
        {
            this.nombre = nom;
            this.apellido = ape;
            this.legajo = leg;
        }
        public void Mostrar()
        {
            Console.WriteLine("Nombre: {0}, Apellido: {1}, Nro legajo: {2}, Nota 1: {3}, Nota 2: {4}", this.nombre, this.apellido, this.legajo, this.nota1, this.nota2);
            if (this.notaFinal != -1)
            {
                Console.WriteLine("Nota Final: {0}", this.notaFinal);
            }
            else
            {
                Console.WriteLine("Alumno desaprobado");
            }
        }
        public void Estudiar(byte n1, byte n2)
        {
            this.nota1 = n1;
            this.nota2 = n2;
        }
        public void CalcularFinal()
        {
            if(this.nota1>=4 && this.nota1 <=10 && this.nota2 >= 4 && this.nota2 <= 10)
            {
                this.notaFinal = (float)new Random().Next(4, 10);
                Console.WriteLine(this.notaFinal);
            }
            else
            {
                this.notaFinal = -1;
                Console.WriteLine(this.notaFinal);
            }
        }
    }
}
