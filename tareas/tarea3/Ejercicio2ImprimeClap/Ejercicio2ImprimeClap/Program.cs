using System;

namespace Ejercicio2ImprimeClap
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sigo = false;
            do
            {
                try
                {
                    sigo = false;
                    Console.WriteLine("Ingrese un numero entre 1 y 9: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese otr numero entre 1 y 9: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    if (num1 >= 1 && num1 <=9 && num2 >= 1 && num2 <= 9) {
                        for (int i = 1; i < 101; i++)
                        {
                            if (i % num1 == 0 || i % num2 == 0
                                || num1 == i || num2 == i)
                            {
                                Console.WriteLine("clap");
                            }
                            else
                            {
                                Console.WriteLine(i);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: debes de ingresar un numero entre 1 y 9.");
                        Console.WriteLine("Vuelve a intentarlo.");
                        sigo = true;

                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Error: debes de ingresar un numero.");
                    Console.WriteLine("Vuelve a intentarlo.");
                    sigo = true;
                }
            } while (sigo);

        }
    }
}
