using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2CalificandoAlumnos
{
    class Alumno
    {
        string nombre;
        string apellidos;
        DateTime fechaDenacimiento;
        public string Nombre{
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string FechaDeNacimiento
        {
            get { return fechaDenacimiento.Day+"/"+fechaDenacimiento.Month+"/"+fechaDenacimiento.Year; }
            set
            {
                fechaDenacimiento = DateTime.Parse(value);
            }
        }
    }
}
