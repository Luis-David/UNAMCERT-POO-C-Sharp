using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio14UsoInterface
{
    class CarroVolador : IVolar
    {
        public void ascender()
        {
            Console.WriteLine("Soy un carro volador y tengo mi manera para ascender");
        }
        public void descender()
        {
            Console.WriteLine("Soy un carro volador y tengo mi manera para descender");

        }
        public void girarALaDerecha()
        {
            Console.WriteLine("Soy un carro volador y tengo mi manera de ir a la derecha");

        }
        public void girarALaIzquierda()
        {
            Console.WriteLine("Soy un carro volador y tengo mi manera de ir a la Izquierda");

        }
    }
}
