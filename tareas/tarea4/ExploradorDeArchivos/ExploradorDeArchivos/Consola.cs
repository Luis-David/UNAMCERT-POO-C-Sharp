using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace ExploradorDeArchivos
{
    class Consola
    {
        Directorio directorioActual;
        List<string> historia;
        List<Comando> comandos;
        public Consola(string ruta)
        {
            directorioActual = new Directorio(ruta);
            historia = new List<string>();
            comandos = new List<Comando>();
            string[] lc1 = { "history", "exit", "cls", "dir" };
            string[] lc2 = { "touch", "cd" };
            string[] lc3 = { "cp", "move" };
            foreach(var c in lc1)
            {
                comandos.Add(new Comando(c, 0));
            }
            foreach (var c in lc2)
            {
                comandos.Add(new Comando(c, 1));
            }
            foreach (var c in lc3)
            {
                comandos.Add(new Comando(c, 2));
            }

        }
        Directorio Directorio
        {
            get { return directorioActual; }
            set { directorioActual = value; }
        }
        
        public void listarArchivos()
        {
            Console.WriteLine("---------------------  Carpetas ---------------------");
            foreach (var d in directorioActual.Directorios)
            {
                Console.WriteLine(d.Name);
            }
            Console.WriteLine("---------------------  Archivos ---------------------");
            foreach (var f in directorioActual.Archivos) { 
                Console.WriteLine(f.Name);
            }
        }
        public void limpiarConsola()
        {
            Console.Clear();
        }
        public void eliminarArchivo(string ruta)
        {
            //La variable ruta pude contener solo el nombre del archivo o con la ruta absoluta
            FileInfo f = directorioActual.getArchivo(ruta);
            if(f!= null)
            {
                f.Delete();
            }
            else
            {
                string r = Path.GetFullPath(ruta);
                string nombre = Path.GetFileName(ruta);
                Directorio directorio = new Directorio(r);
                f = directorio.getArchivo(nombre);
                if (f != null)
                {
                    f.Delete();
                    Console.WriteLine("Se elimino el archivo {0}", nombre);

                }
                else
                    Console.WriteLine("Error: No existe el archivo {0} ", nombre);
            }
        }
       
        public void moverArchivo(string nombre,string ruta)
        {
            FileInfo f = directorioActual.getArchivo(nombre);
            try
            {
                if (f != null)
                {
               
                    if (!Path.HasExtension(ruta))
                    {
                        ruta += "\\" + nombre;
                    }
                    f.MoveTo(ruta);
                    Console.WriteLine("Se movio correctamente el archivo.");
                }
                else
                {
                    string r = Path.GetFullPath(nombre);
                    string nom = Path.GetFileName(nombre);
                    Directorio directorio = new Directorio(r);
                    f = directorio.getArchivo(nom);
                    if (f != null)
                    {
                        if (!Path.HasExtension(ruta))
                        {
                            ruta += "\\" + nombre;
                        }
                        f.MoveTo(ruta);
                        Console.WriteLine("Se elimino el archivo {0}", nombre);

                    }
                    else
                        Console.WriteLine("Error: No existe el archivo {0} ", nombre);
                }
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void copiarArchivo(string nombre, string ruta)
        {
            FileInfo f = directorioActual.getArchivo(nombre);
            try
            {
                if (f != null)
                {

                    if (!Path.HasExtension(ruta))
                    {
                        ruta += "\\" + nombre;
                    }
                    f.CopyTo(ruta);
                    Console.WriteLine("Se copio correctamente el archivo.");
                }
                else
                {
                    string r = Path.GetFullPath(nombre);
                    string nom = Path.GetFileName(nombre);
                    Directorio directorio = new Directorio(r);
                    f = directorio.getArchivo(nom);
                    if (f != null)
                    {
                        if (!Path.HasExtension(ruta))
                        {
                            ruta += "\\" + nombre;
                        }
                        f.CopyTo(ruta);
                        Console.WriteLine("Se copio correctamente el archivo {0}", nombre);
                    }
                    else
                        Console.WriteLine("Error: No existe el archivo {0} ", nombre);
                }
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void irADirectorioPadre()
        {
            Directorio padre = directorioActual.getDirectorioPadre();
            if (padre != null)
                directorioActual = padre;
        }
        public void irAlDirectorio(string ruta)
        {
            if (Directory.Exists(ruta))
            {
                Directorio dn = new Directorio(ruta);
                directorioActual = dn;
            }
            else
            {
                Console.WriteLine("El directorio no existe");
            }
        }
        public void imprimirPrompt()
        {
            Console.Write(directorioActual.Ruta + "> ");
        }
        public void agregarRegistroComando(string c)
        {
            historia.Add(c);
        }
        public void imprimirHistoria()
        {
            foreach(var c in historia)
            {
                Console.WriteLine(c);
            }
        }
        public void crearArchivo(string ruta)
        {
            if (!Path.GetPathRoot(ruta).Equals(""))
                File.Create(ruta);
            else
            {
                File.Create(Path.Join(directorioActual.Ruta, ruta));
                directorioActual.actualizarDirectorios();
            }
        }
        public int esValidoComando(string comando,string[] argumentos)
        {
            int nArgumentos = argumentos!=null ? argumentos.Length :0;
            int i = 0;
            foreach(var c in comandos)
            {
                if (c.Nombre.Equals(comando))
                {
                    if (c.Equals(new Comando(comando, nArgumentos)))
                    {
                        return i;
                    }
                    else
                    {
                        if(c.NArgumentos<nArgumentos)
                            throw new ExcepcionNumArgumentos("Tiene demasiados argumentos, solo se requieren " + c.NArgumentos);
                        else
                            throw new ExcepcionNumArgumentos("Tiene pocos argumentos, se requieren " + c.NArgumentos);

                    }
                }
                i++;
            }
            if(comando.Length!=0)
                throw new ExcepcionComandoNoEncontrado(string.Format("El comando \"{0}\" no es reconocido por esta consola.",comando));
            return -1;
        }

    }
}
