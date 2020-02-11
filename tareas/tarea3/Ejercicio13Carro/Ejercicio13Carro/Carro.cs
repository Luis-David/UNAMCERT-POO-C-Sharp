using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio13Carro
{
    class Carro
    {
        double peso;
        double altura;
        bool encendido;
        public Carro(double p, double a)
        {
            peso = p;
            altura = a;
        }
        public void encender()
        {
            encendido = true;
            Console.WriteLine("Carro encendido");
        }
        public  void apagar()
        {
            encendido = false;
            Console.WriteLine("Carro apagado.");
        }
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public void estado()
        {
            Console.WriteLine("Está encendido.");
        }
        public override string ToString()
        {
            return "peso: "+peso+" altura: "+altura ;
        }
    }
}
