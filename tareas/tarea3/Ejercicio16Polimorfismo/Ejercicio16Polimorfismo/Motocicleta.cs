using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio16Polimorfismo
{
    class Motocicleta:Vehiculo
    {
        public override void estacionar()
        {
            Console.WriteLine("Soy una motocicleta y sé como estacionarme");
        }
    }
}
