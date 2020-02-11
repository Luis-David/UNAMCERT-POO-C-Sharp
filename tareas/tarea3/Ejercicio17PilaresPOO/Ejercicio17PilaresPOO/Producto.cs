using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio17PilaresPOO
{
    class Producto
    {
        string nombre;
        int clave;
        string descripcion;
        double precio;
        public Producto(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
       
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public double Precio
        {
            get { return precio; }
            set
            {
                if (value > 0)
                    precio = value;
            }
        }
        public override string ToString()
        {
            return nombre + "  " + precio;
        }
    }
}
