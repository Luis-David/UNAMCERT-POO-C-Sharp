using System;

namespace Ejercicio11Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] m1,m2,resultado;
                Console.WriteLine("Ingrese el tamaño de la matriz cuadrada: ");
                int n = Convert.ToInt32(Console.ReadLine());
                m1 = new double[n,n];
                m2 = new double[n, n];
                resultado = new double[n, n];
                Console.WriteLine("*** Llenado de la matriz 1");
                llenarMatriz(m1);
                imprimir(m1);
                Console.WriteLine("*** Llenado de la matriz 2");
                llenarMatriz(m2);
                imprimir(m2);
                int opcion;
                do
                {
                    Console.WriteLine("1.- Sumar");
                    Console.WriteLine("2.- Restar");
                    Console.WriteLine("3.- Multiplicar");
                    Console.WriteLine("4.- Salir");
                    Console.WriteLine("Ingrese una opción: ");
                    
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Matrices a sumar: ");
                            imprimir(m1);
                            Console.WriteLine("-----------|----------");
                            imprimir(m2);
                            for(int i=0; i<n; i++)
                            {
                                for(int j=0; j<n; j++)
                                {
                                    resultado[i, j] = m1[i, j] + m2[i, j];
                                }
                            }
                            Console.WriteLine("El resultado es: ");
                            imprimir(resultado);
                            break;
                        case 2:
                            Console.WriteLine("Matrices a restar: ");
                            imprimir(m1);
                            Console.WriteLine("----------------------");
                            imprimir(m2);
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    resultado[i, j] = m1[i, j] - m2[i, j];
                                }
                            }
                            Console.WriteLine("El resultado es: ");
                            imprimir(resultado);
                            break;
                        case 3: 
                            Console.WriteLine("Matrices a multiplicar: ");
                            imprimir(m1);
                            Console.WriteLine("----------------------");
                            imprimir(m2);
                            double suma;
                            int l ;
                            for (int i = 0; i < n; i++)
                            {
                                l = 0;
                                for (int j = 0; j < n; j++,l++)
                                {
                                    suma = 0;
                                    for(int k=0; k<n; k++)
                                    {
                                         suma+= m1[i, k] * m2[k, l];
                                    }
                                    resultado[i, j] = suma;
                                }
                            }
                            Console.WriteLine("El resultado es: ");
                            imprimir(resultado);
                            break;
                        case 4: break;
                        default:
                            Console.WriteLine("Error: opción invalida, vuelva a intentar.");
                            break;


                    }
                } while (opcion != 4);

        }
        public static void llenarMatriz(double[,] m)
        {
            int j=0;
           
            for (int i=0; i < Math.Sqrt(m.Length); ++i)
            {
                try
                {
                    Console.WriteLine("Ingrese los elementos de la fila {0} de la matriz(ejemplo: 1,2,3): ",i);
                    string fila = Console.ReadLine();
                    j = 0;
                    foreach (var n in fila.Split(","))
                    {
                        m[i, j++] = Convert.ToDouble(n);
                    }
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("Error: se excedieron las columnas de la matrix.");
                    i = i < 0 ? i : --i;
                    Console.WriteLine("Vuelva a intentar.");
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Error: debes de ingresar un numero.");
                    Console.WriteLine("Vuelve a intentarlo.");
                    i = i < 0 ? i : --i;

                }
            }
        }
        public static void imprimir(double[,] m)
        {
            double size = Math.Sqrt(m.Length);
            for(int i=0; i<size; i++)
            {
                for(int j=0; j<size; j++)
                {
                    Console.Write("\t"+m[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
