using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Empleado : Persona
    {
        public string Puesto { get; set; }
        public decimal sueldo { get; set; }
        public Empleado(string nombre, int edad,string puesto, decimal sueldo): base(nombre,edad)
        {
            Puesto = puesto;
            this.sueldo = sueldo;

        }
        public override void saludar()
        {
            Console.WriteLine("Hola soy el empleado: {0} y mi puesto es: {1}", Nombre, Puesto);
        }
        public void trabajar()
        {
            Console.WriteLine("Estoy trabajando Zzzz {0}",Nombre);
        }
        public override string ToString()
        {
            return string.Format("{0}, {1}, {3}, {2}", Nombre, Edad, sueldo, Puesto);
        }
    }
}
