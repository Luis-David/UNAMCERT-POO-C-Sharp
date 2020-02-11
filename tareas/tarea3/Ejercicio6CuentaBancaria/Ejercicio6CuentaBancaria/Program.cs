using System;

namespace Ejercicio6CuentaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria c1 = new CuentaBancaria("Luis", 10000);
            CuentaBancaria c2 = new CuentaBancaria("David", 10000);
            Console.WriteLine("*************************** Pruebas con la cuenta de {0}", c1.Nombre);
            c1.desposito(500);
            c1.retiro(2500);
            c1.retiro(25000);
            Console.WriteLine("*************************** Pruebas con la cuenta de {0}", c1.Nombre);
            c2.desposito(400);
            c2.retiro(1800);
        }
    }
}
