using System;

namespace Ejercicio15CalculadoraDosNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            double op1, op2;
            do
            {
                Console.WriteLine("1.- sumar");
                Console.WriteLine("2.- restar");
                Console.WriteLine("3.- dividir");
                Console.WriteLine("4.- multiplicar");
                Console.WriteLine("5.- salir");
                Console.WriteLine("Ingrese una opcion(ejemplo: 1):");
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingresa el primero operador a sumar");
                            op1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingresa el segundo operador a sumar");
                            op2 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("El resultado es: {0}", op1 + op2);
                            break;
                        case 2:
                            Console.WriteLine("Ingresa el primero operador a restar");
                            op1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingresa el segundo operador a restar");
                            op2 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("El resultado es: {0}", op1 - op2);
                            break;
                        case 3:
                            Console.WriteLine("Ingresa el primero operador a dividir");
                            op1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingresa el segundo operador a dividir");
                            op2 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("El resultado es: {0}", op1 / op2);   
                            break;
                        case 4:
                            Console.WriteLine("Ingresa el primero operador a multiplicar");
                            op1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingresa el segundor operador a multiplicar");
                            op2 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("El resultado es: {0}", op1 * op2);
                            break;
                        case 5:
                            break;
                        default:
                            Console.WriteLine("*** Opción invalida");
                            break;
                    }
                }
                catch(FormatException e)
                {
                    Console.WriteLine("Error: debe de ingresar un numero.");
                    Console.WriteLine("Vuelva a intentarlo.");
                    opcion = -1;
                }
            } while (opcion != 5);
        }
    }
}
