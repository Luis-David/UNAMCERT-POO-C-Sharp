using System;

namespace Ejercicio16Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto a = new Auto();
            Motocicleta m = new Motocicleta();
            Estacionamiento estacionamiento = new Estacionamiento();

            //La clase estacionamiento podrá estacionar cualquier vehiculo, ya sea moto,avion.etc
            estacionamiento.estacionar(a);
            estacionamiento.estacionar(m);


        }

    }
}
