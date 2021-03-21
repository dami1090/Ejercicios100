using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDami
{
    public class Boligrafo
    {
        short cantidadTintaMaxima = 100;
        ConsoleColor color;
        short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
            Console.WriteLine("Tinta: {0},Color{1}", this.tinta, this.color);
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            bool flag = false;
            string concatenar = "";
            int dif;
            int cantidadTinta = this.tinta;
            dif = this.tinta - gasto;
            if (dif >= 0)
            {
                SetTinta((short)(gasto*(-1)));

                    while (gasto > 0)
                    {
                        concatenar += "*";
                        gasto--;
                    }
                    flag = true;
            }
            else
            {
                while (cantidadTinta > 0)
                {
                    concatenar += "*";
                    cantidadTinta--;
                }
                this.tinta = 0;
            }

            dibujo = concatenar;
            return flag;
        }
        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }
        private void SetTinta(short tinta)
        {
            if (tinta > 0)
            {
                if(this.tinta + tinta >= cantidadTintaMaxima)
                {
                    this.Recargar();
                }
                this.tinta += tinta;
            }
            else
            {
                this.tinta += tinta;
            }

            //if (this.tinta >= 100)
            //{
            //    Recargar();
            //}
            //if (this.tinta <= 0)
            //{
            //    this.tinta = 0;
            //}
            return;
        }

    }
}
