using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio16Polimorfismo
{
    class Estacionamiento
    {
        string nombre { get; set; }
        string direccion { get; set; }
        public void estacionar(Vehiculo v)
        {
            v.estacionar();
        }
    }
}
