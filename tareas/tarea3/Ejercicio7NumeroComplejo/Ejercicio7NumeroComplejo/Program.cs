using System;

namespace Ejercicio7NumeroComplejo
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroComplejo n1 = new NumeroComplejo(22, 2);
            NumeroComplejo n2 = new NumeroComplejo(12, 9);
            Console.WriteLine("Numero complejos a sumar: ");
            n1.imprimir();
            n2.imprimir();

            NumeroComplejo res;
            res = n1 + n2;
            Console.WriteLine("El resultado es:");
            res.imprimir();
        }
    }
}
