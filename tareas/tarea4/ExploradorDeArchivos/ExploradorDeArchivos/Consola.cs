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

        public Consola(string ruta)
        {
            directorioActual = new Directorio(ruta);
            historia = new List<string>();
        }
        Directorio Directorio
        {
            get { return directorioActual; }
            set { directorioActual = value; }
        }
        
        public void listarArchivos()
        {
            foreach (var f in directorioActual.Archivos) { 
                Console.WriteLine(f.Name);
            }
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
            if (f != null)
            {
                try
                {
                    if (!Path.HasExtension(ruta))
                    {
                        ruta += "\\" + nombre;
                    }
                    f.MoveTo(ruta);
                    Console.WriteLine("Se movio correctamente el archivo.");
                }
                catch(DirectoryNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                }
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
        public void copiarArchivo(string nombre, string ruta)
        {
            FileInfo f = directorioActual.getArchivo(nombre);
            if (f != null)
            {
                try
                {
                    if (!Path.HasExtension(ruta))
                    {
                        ruta += "\\" + nombre;
                    }
                    f.CopyTo(ruta);
                    Console.WriteLine("Se movio correctamente el archivo.");
                }
                catch (DirectoryNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                }
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
                    Console.WriteLine("Se elimino el archivo {0}", nombre);

                }
                else
                    Console.WriteLine("Error: No existe el archivo {0} ", nombre);
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
            Console.WriteLine(directorioActual.Ruta + "> ");
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

    }
}
