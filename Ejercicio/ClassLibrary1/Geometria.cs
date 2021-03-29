using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Punto
    {
        private int x;
        private int y;
        public int GetX()
        {
            return this.x;
        }
        public int GetY()
        {
            return this.y;
        }
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public float GetArea()
        {
            return this.area;
        }
        public float GetPerimetro()
        {
            return this.perimetro;
        }
        public Rectangulo(Punto v1, Punto v3)
        {
            
            this.vertice1 = v1;
            this.vertice3 = v3;
            this.vertice2 = new Punto(v1.GetX(), v3.GetY());
            this.vertice4 = new Punto(v1.GetY(), v3.GetX());
            this.area = this.Area();
            this.perimetro = this.Perimetro();
            
        }
        public float Area()
        {
            float resultado;
            Punto punto1, punto3;
            int altura;
            int Base;
            punto1 = this.vertice1;
            punto3 = this.vertice3;
            altura = Math.Abs(punto3.GetY()) - Math.Abs(punto1.GetY());
            Base = Math.Abs(punto3.GetX()) - Math.Abs(punto1.GetX());
            resultado = (float)Math.Abs((Base * altura));
            return resultado;
        }
        public float Perimetro()
        {
            Punto punto1, punto3;
            int altura;
            int Base;
            punto1 = this.vertice1;
            punto3 = this.vertice3;
            altura = Math.Abs(punto3.GetY()) - Math.Abs(punto1.GetY());
            Base = Math.Abs(punto3.GetX()) - Math.Abs(punto1.GetX());
            return (float)Math.Abs((Base * altura) * 2);
        }
        public void Mostrar()
        {
            Console.WriteLine("Area: {0},\nPerimetro: {1},\nvertice1: ({2};{3}),\nvertice2: ({4};{5}),\nvertice3: ({6};{7}),\nvertice4: ({8};{9}) ", this.GetArea(), this.GetPerimetro(),this.vertice1.GetX(),this.vertice1.GetY(),this.vertice2.GetX(),this.vertice2.GetY(),this.vertice3.GetX(),this.vertice3.GetY(),this.vertice4.GetX(),this.vertice4.GetY());
        }
    }


}
