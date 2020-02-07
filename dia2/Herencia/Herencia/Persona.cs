using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Persona
    {
        protected string Nombre { get; set; }
        public int Edad { set; get; }

        public Persona() { }

        public Persona(String nombre, int edad) {
            Nombre = nombre;
            Edad = edad;
        }

        public virtual void saludar()
        {
            Console.WriteLine("Hola mi nombre es: {0}", Nombre);

        }

        public override string ToString()
        {
            return string.Format("{0}, {1}",Nombre,Edad);
        }
    }
}
