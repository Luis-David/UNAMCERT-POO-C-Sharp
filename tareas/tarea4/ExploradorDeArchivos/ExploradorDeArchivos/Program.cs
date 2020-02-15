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
            bool repetir = true;
            do {
                consola.imprimirPrompt();
                instruccion = Console.ReadLine();
                try
                {
                    string[] tokens = instruccion.Split(" ");
                    string comando = tokens[0].ToLower();
                    string[] argumentos=null;
                    if (tokens.Length >= 2)
                    {
                        ArraySegment<string> arg = new ArraySegment<string>(tokens, 1, tokens.Length - 1);
                        argumentos = arg.ToArray();
                    }
                    switch (consola.esValidoComando(comando, argumentos))
                    {
                        case 0:
                            consola.imprimirHistoria();
                            break;
                        case 1:
                            repetir = false;
                            break;
                        case 2:
                            consola.limpiarConsola();
                            break;
                        case 3:
                            consola.listarArchivos();
                            break;
                        case 4:
                            //Crear archivo
                            consola.crearArchivo(argumentos[0]);
                            break;
                        case 5://CD
                            if (argumentos[0].Equals(".."))
                                consola.irADirectorioPadre();
                            else
                                consola.irAlDirectorio(argumentos[0]);
                            break;
                        case 6:
                            consola.copiarArchivo(argumentos[0], argumentos[1]);
                            break;
                        case 7://mover
                            consola.moverArchivo(argumentos[0],argumentos[1]);
                            break;
                        default:
                            break;
                    }
                    if(instruccion.Length!=0)
                        consola.agregarRegistroComando(instruccion);
                }
                catch(ExcepcionComandoNoEncontrado e)
                {
                    Console.WriteLine(e.Message);
                }
                catch(ExcepcionNumArgumentos e)
                {
                    Console.WriteLine(e.Message);
                }
                catch(IOException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch(UnauthorizedAccessException e)
                {
                    Console.WriteLine(e.Message);

                }

            } while (repetir);
        }
    }
}
