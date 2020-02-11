using System;
using System.IO;
namespace Ejercicio18Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
           // FileStream f = File.OpenWrite("notas.txt");
            StreamWriter sf;
            string op="";
            do
            {

                Console.WriteLine("1. crear nota.");
                Console.WriteLine("2. ver notas.");
                Console.WriteLine("3. salir");
                Console.WriteLine("Ingresa una opcion: ");
                op = Console.ReadLine();
                if (op.Equals("1"))
                {
                    Console.WriteLine("Ingrese el contenido de la nota: ");
                    string nota = Console.ReadLine();
                    sf = new StreamWriter("notas.txt", true);//Se abre el archivo para añadir nuevas lineas
                    sf.WriteLine(DateTime.Today+" -> "+nota);
                    sf.Close();
                }
                else if (op.Equals("2"))
                {
                    Console.WriteLine("Contenido del archivo notas.txt");
                    Console.WriteLine(File.ReadAllText("notas.txt"));
                }
                else
                {
                    Console.WriteLine("Opción invalida.");
                }
            } while (!op.Equals("3"));
            
        }
    }
}
