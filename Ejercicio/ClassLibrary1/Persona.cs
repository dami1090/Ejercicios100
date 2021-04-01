using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDami
{
    public class Persona
    {
        #region Atributos

        public string apellido;
        public string nombre;
        public int dni;
        private static int cantidadPersonas;

        #endregion
        #region Constructores
        static Persona()
        {
            Persona.cantidadPersonas = 0;
        }

        public Persona()
        {
            this.apellido = "Sin apellido";
            this.dni = -1;
            this.nombre = "Sin nombre";
            Persona.cantidadPersonas++;
        }
        public Persona(string ape) : this()
        {
            this.apellido = ape;
        }
        public Persona(string ape, int dni) : this(ape)
        {
            this.dni = dni;
        }
        public Persona(string ape, int dni, string nom) : this(ape, dni)
        {
            this.nombre = nom;
        }
        #endregion

        public static int GetCantidadPersonas()
        {
            return Persona.cantidadPersonas;
        }
    }
}
