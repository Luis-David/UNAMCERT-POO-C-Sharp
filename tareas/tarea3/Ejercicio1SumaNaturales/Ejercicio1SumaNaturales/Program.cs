using System;

namespace Ejercicio1SumaNaturales
{
    class Program
    {
        static void Main(string[] args)
        {
           try
            {
                Console.WriteLine("Ingrese un numero natural.");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Error: Debe de ingresar un numero positivo.");
                    return;
                }
                Console.WriteLine("La suma de los {0} numeros naturales es: {1}",n,n*(n+1)/2);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Error: Debe de ingresar un numero.");
            }
            
        }
    }
}
