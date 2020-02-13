using System;
using System.IO;
namespace ExploradorDeArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string carpetaDocumets = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            Consola consola = new Consola(carpetaDocumets);
            
            string instruccion="";
            do {
                consola.imprimirPrompt();
                instruccion = Console.ReadLine();
                try
                {
                    if (instruccion.Equals("exit"))
                    {
                        break;
                    }
                    Console.WriteLine(consola.esValidoComando(instruccion));
                }
                catch(ExcepcionComandoNoEncontrado e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (true);
        }
    }
}
