using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace ExploradorDeArchivos
{
    class Directorio
    {
        string ruta;
        FileInfo[] archivos;
        public Directorio(){ }
        public Directorio(string ruta)
        {
            if (Directory.Exists(ruta))
                Ruta = ruta;
            else
                throw new DirectoryNotFoundException("Ruta no existe o está mal formada.");
        }
        public string Ruta{
            get { return ruta; }
            set {
                DirectoryInfo d = new DirectoryInfo(ruta);
                archivos = d.GetFiles();
                ruta = value; 
            }
        }
        public FileInfo[] Archivos
        {
            get { return archivos; }
        }
        public FileInfo getArchivo(string nombre)
        {
            foreach(var a in archivos)
            {
                if (a.Name.Equals(nombre))
                {
                    return a;
                }
            }
            return null;
        }
        public Directorio getDirectorioPadre()
        {
            DirectoryInfo directorioPadre = Directory.GetParent(ruta);
            if (directorioPadre != null)
                return new Directorio(directorioPadre.ToString());
            return null;
        }
    }
}
