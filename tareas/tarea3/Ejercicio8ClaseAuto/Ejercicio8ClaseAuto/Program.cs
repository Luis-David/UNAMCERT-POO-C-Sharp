using System;

namespace Ejercicio8ClaseAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto a1 = new Auto();
            a1.Nombre ="Sedán";
            a1.Modelo = "2015";
            Console.WriteLine("nombre: {0} modelo {1} color {2} velocidad: {3}",a1.Nombre,a1.Modelo,a1.Color,a1.MaxVelocidad);
            Auto a2 = new Auto("bocho", "2019");
            a2.girarAlaDerecha();

            Console.WriteLine("nombre: {0} modelo {1} color {2} velocidad: {3}", a2.Nombre, a2.Modelo, a2.Color, a2.MaxVelocidad);

            Auto a3 = new Auto("Ferrari", "2000", 300);
            a3.girarAlaIzquierda();
            a3.Color = "rojo";
            Console.WriteLine("nombre: {0} modelo {1} color {2} velocidad: {3}", a3.Nombre, a3.Modelo, a3.Color, a3.MaxVelocidad);


        }
    }
}
