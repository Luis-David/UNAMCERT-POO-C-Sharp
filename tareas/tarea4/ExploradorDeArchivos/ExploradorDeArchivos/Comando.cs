using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace ExploradorDeArchivos
{
    class Comando
    {
        string nombre;
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
       
    }
}
