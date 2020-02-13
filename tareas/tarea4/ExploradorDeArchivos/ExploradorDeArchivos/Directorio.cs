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
        DirectoryInfo[] directorios;
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
                DirectoryInfo d = new DirectoryInfo(value);
                archivos = d.GetFiles();
                directorios = d.GetDirectories();
                ruta = value; 
            }
        }
        public FileInfo[] Archivos
        {
            get { return archivos; }
        }
        public DirectoryInfo[] Directorios
        {
            get { return directorios; }
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
