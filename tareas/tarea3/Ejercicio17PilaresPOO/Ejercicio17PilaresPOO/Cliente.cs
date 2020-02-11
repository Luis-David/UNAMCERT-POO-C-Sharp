using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio17PilaresPOO
{
    class Cliente
    {
        string nombre;
        string rfc;
        string direccion;
        string telefono;
        public Cliente(string nombre)
        {
            Nombre = nombre;
            Direccion = "";
            Telefono = "";
            Rfc = "";
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Rfc
        {
            get { return rfc; }
            set { rfc = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
    }
}
