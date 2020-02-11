using System;

namespace Ejercicio9ClaseMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo c = new Circulo();
            c.radio = 9.56;
            Console.WriteLine("Area del circulo: "+c.getAreaConRedondeo2decimales());
            Cuadrado cuadrado = new Cuadrado();
            cuadrado.lado = 10.0;
            Console.WriteLine("Area del cuadrado: " + cuadrado.getArea());
        }
    }
}
