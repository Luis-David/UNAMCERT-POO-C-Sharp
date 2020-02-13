using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace ExploradorDeArchivos
{
    class Comando
    {
        string nombre;
        string argumentos;
        int nArgumentos;

        public Comando(string nombre, int n)
        {
            this.nombre = nombre;
            nArgumentos = n;
        }
        public int NArgumentos
        {
            get { return nArgumentos; }
        }
        public string Nombre
        {
            get { return nombre; }
        }

        public override bool Equals(object obj)
        {
            Comando c =(Comando) obj;
            return c.Nombre.Equals(nombre) && c.NArgumentos==nArgumentos;
        }
        public bool sonValidoArgumentos(string[] arg)
        {
            for (int i = 0; i < nArgumentos; i++)
            {
                if (Path.HasExtension(arg[i]))
                {
                    arg[i] = Path.GetFullPath(arg[i]);
                }
                if (Directory.Exists(arg[i])){
                    continue;
                }
                return false;
            }
            return true;
        }
        public delegate void Ejecutar<in T>(T ruta);
    }
}
