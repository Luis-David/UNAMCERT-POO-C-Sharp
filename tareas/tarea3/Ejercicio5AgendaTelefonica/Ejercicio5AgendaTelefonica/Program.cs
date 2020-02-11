using System;
using System.Collections.Generic;
namespace Ejercicio5AgendaTelefonica
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> agenda = new Dictionary<string, string>();
            int opcion = 0;
            do
            {
                try
                {
                    Console.WriteLine("1.- Agregar Contacto");
                    Console.WriteLine("2.- Eliminar Contacto");
                    Console.WriteLine("3.- Mostrar Contacto");
                    Console.WriteLine("4.- Salir");
                    Console.WriteLine("Ingrese una opción: ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                   
                    string nombre,telefono;
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese el nombre del nuevo contacto: ");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese el telefono del nuevo contacto: ");
                            telefono = Console.ReadLine();
                            agenda.Add(nombre, telefono);
                            break;
                        case 2:
                            Console.WriteLine("Ingrese el nombre del contacto a eliminar: ");
                            nombre = Console.ReadLine();
                            agenda.Remove(nombre);
                            break;
                        case 3:
                            Console.WriteLine("Ingrese el nombre del contacto a mostrar: ");
                            nombre = Console.ReadLine();
                            Console.WriteLine("El contacto {0} tiene el siguiente número: {1}",nombre, agenda[nombre]);
                            break;
                        case 4:
                            break;
                        default:
                            Console.WriteLine("Opcion invalida vuelva a intentarlo.");
                            break;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Error: debes de ingresar un numero.");
                    Console.WriteLine("Vuelve a intentarlo.");
                    opcion = 0;
                }
                catch(KeyNotFoundException e)
                {
                    Console.WriteLine("Error: No existe el contacto");
                    Console.WriteLine("Vuelve a intentarlo.");

                }
            } while (opcion!= 4);
        }
    }
}
