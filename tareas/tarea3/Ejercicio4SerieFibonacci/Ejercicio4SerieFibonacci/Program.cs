using System;

namespace Ejercicio4SerieFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repite = false;
            do
            {
                try
                {
                    repite = false;
                    Console.WriteLine("Ingrese un numero mayor que cero: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n <= 0)
                    {
                        Console.WriteLine("Error: el numero debe ser mayor que cero.");
                        Console.WriteLine("Vuelve a intentarlo.");
                        repite = true;
                    }
                    Console.WriteLine("Serie Fibonacci: ");
                    for(int i=0; i<n; i++)
                    {
                        Console.WriteLine(fibonacci(i));
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Error: debes de ingresar un numero.");
                    Console.WriteLine("Vuelve a intentarlo.");
                    repite = true;
                }
            } while (repite);
        }
        public static long fibonacci(int n)
        {
            int i;
            long[] p = { 0, 0};
            int c = 0;

            for (i = 0; i < n; i++)
            {
                if (c == 2)
                    c = 0;
                if (i < 2)
                    p[c] = 1;
                else
                    p[c] = p[0] + p[1];
                c++;
            }
            c = c == 0 ? 1 : c;
            return p[c-1];
        }
    }
}
