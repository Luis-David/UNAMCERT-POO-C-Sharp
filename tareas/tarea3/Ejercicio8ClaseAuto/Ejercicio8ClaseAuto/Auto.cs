using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio8ClaseAuto
{
    class Auto
    {
        string nombre;
        string color;
        string modelo;
        int maxVelocidad;
        public Auto(){ color = "blanco"; }

        public Auto(string n,string m)
        {
            nombre = n;
            modelo = m;
            color = "blanco";
        }
        public Auto(string n, string m,int v)
        {
            nombre = n;
            modelo = m;
            maxVelocidad = v;
            color = "blanco";
        }
        public string Color
        {
            get{ return color; }
            set { color = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public int MaxVelocidad
        {
            get { return maxVelocidad; }
            set { maxVelocidad = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public void acelerar()
        {
            Console.WriteLine("Estoy acelerando");
        }
        public void girarAlaDerecha()
        {
            Console.WriteLine("Giro a la derecha");
        }
        public void girarAlaIzquierda()
        {
            Console.WriteLine("Giro a la Izquierda");
        }
    }
}
