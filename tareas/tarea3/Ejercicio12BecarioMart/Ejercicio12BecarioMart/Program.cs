using System;
using System.Collections.Generic;
namespace Ejercicio12BecarioMart
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> productos= new List<string>();
            List<double> precios = new List<double>();
            double saldo;
            bool repetir= false;
            do
            {
                try
                {
                    Console.WriteLine("Ingrese su saldo disponible: ");
                    saldo = Convert.ToDouble(Console.ReadLine());
                    do
                    {
                        Console.WriteLine("Ingrese nombre del producto a comprar: ");
                        productos.Add(Console.ReadLine());
                        Console.WriteLine("Ingrese el precio del producto a comprar: ");
                        precios.Add(Convert.ToDouble(Console.ReadLine()));
                        Console.WriteLine("Quieres comprar otro producto? y/n");
                        repetir=Console.ReadLine().Equals("y") ? true:false;

                    } while (repetir);
                    Console.WriteLine("");

                    Console.WriteLine("Producto\tPrecio");
                    
                    do
                    {
                        int i = 0;
                        double suma = 0;
                        foreach (var p in productos)
                        {
                            Console.WriteLine("{0}\t{1}",p,precios.ToArray()[i++]);
                            suma += precios.ToArray()[i-1];
                        }
                        Console.WriteLine("Total a pagar: {0}", suma);
                        Console.WriteLine();
                    
                        Console.WriteLine("1. Comprar");
                        Console.WriteLine("2. Dejar producto");
                        Console.WriteLine("Ingrese una opción");
                        string op = Console.ReadLine();
                        repetir = true;
                        if (op.Equals("1"))
                        {
                            if (saldo >= suma)
                            {
                                Console.WriteLine("Gracias por su compra!");
                                repetir = false;
                            }
                            else
                            {
                                Console.WriteLine("Saldo insuficiente, porfavor eliminar algunos productos.");
                                repetir = true;
                            }
                        }
                        else if (op.Equals("2"))
                        {
                            i = 0;
                            foreach (var p in productos)
                            {
                                Console.WriteLine("{0}\t{1}\t indice: {2}", p, precios.ToArray()[i++],i-1);
                            }
                            Console.WriteLine("Ingrese el indice del producto a eliminar");

                            int n = Convert.ToInt32(Console.ReadLine());
                            productos.RemoveAt(n);
                            precios.RemoveAt(n);
                        }
                        else
                        {
                            Console.WriteLine("opcion invalida");
                        }
                    } while (repetir);



                }
                catch (FormatException e)
                {
                    Console.WriteLine("Debe de ingresar un numero");
                    Console.WriteLine("Vuelve a intentarlos.");
                    repetir = true;
                }
            } while (repetir);

        }
    }
}
