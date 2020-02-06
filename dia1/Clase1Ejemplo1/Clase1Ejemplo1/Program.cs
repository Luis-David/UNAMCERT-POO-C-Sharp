using System;
namespace Clase1Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("luis",99);
            Persona p_2 = new Persona("David", 100);
            Persona p_3 = new Persona("Alberto", 23);
            Persona p_4 = new Persona("Alberto", 23);
          //  Persona p_5 = new Persona("Armando", 21);
            Console.WriteLine("Referencias p1 y p2 son iguales?");
            Console.WriteLine(p1 == p_2);
            Console.WriteLine("Referencias p_2 y p3 son iguales?");
            Console.WriteLine(p_2 == p_3);
            Console.WriteLine("Referencias p_4 y p3 son iguales?");
            Console.WriteLine(p_4 == p_3);

            Console.WriteLine("Objetos p1 y p2 son iguales?");
            Console.WriteLine(p1.Equals(p_2));
            Console.WriteLine("Objetos p_2 y p3 son iguales?");
            Console.WriteLine(p_2.Equals(p_3));
            Console.WriteLine("Objetos p_4 y p3 son iguales?");
            Console.WriteLine(p_4.Equals(p_3));




        }
    }
}
