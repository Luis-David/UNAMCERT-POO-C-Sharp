using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1Ejemplo1
{
    class Persona
    {
        public string nombre { get; set; }
        public int edad { get; set; }

        public Persona(string nombre,int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public string getNombre()
        {
            return nombre;
        }
        public int getEdad()
        {
            return edad;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Persona p = obj as Persona;

            return p.getNombre().Equals(getNombre()) && edad==p.getEdad();
        }
    }
}
