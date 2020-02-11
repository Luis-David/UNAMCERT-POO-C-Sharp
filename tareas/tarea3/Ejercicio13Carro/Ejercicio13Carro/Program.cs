using System;

namespace Ejercicio13Carro
{
    class Program
    {
        static void Main(string[] args)
        {
            CarroBWM c1 = new CarroBWM(1000, 2, "2019");
            CarroVW c2 = new CarroVW(2000, 1.8, "2000");
            c1.encender();
            c1.apagar();
            c1.estado();
            Console.WriteLine("modelo: "+c1.Modelo);
            Console.WriteLine(c1.ToString());
            c2.encender();
            c2.apagar();
            c2.estado();
            Console.WriteLine("modelo: " + c2.Modelo);
            Console.WriteLine(c2.ToString());
        }
    }
}
