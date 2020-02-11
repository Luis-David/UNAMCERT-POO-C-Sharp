using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio16Polimorfismo
{
    class Auto:Vehiculo
    {
        public override void estacionar()
        {
            Console.WriteLine("Soy un auto y sé como estacionarme");
        }
    }
}
