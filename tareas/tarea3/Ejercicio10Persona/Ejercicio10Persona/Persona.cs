using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio10Persona
{
    class Persona
    {
        string nombre;
        int edad;
        double estatura;
        double peso;
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public int Edad
        {
            set { if (value > 0) edad = value;
                else throw new Exception("Error: la edad debe ser mayor que cero");
            }
            get { return edad; }
        }
        public double Estatura
        {
            set
            {
                if (value > 0 && value < 3)
                {
                    estatura = value;
                }
                else throw new Exception("Error: La estatura debe de esta entre 0 metros y 3 metros.");
            }
            get { return estatura; }
        }
        public double Peso
        {
            set { if (value > 0) peso = value;
                else throw new Exception("Error: Peso debe ser mayor que cero.");
            }
            get { return peso; }
        }
        public void comer()
        {
            Console.WriteLine("Yo {0} estoy comiendo.", nombre);
        }
        public void caminar()
        {
            Console.WriteLine("Yo {0} estoy caminando",nombre);
        }
        public double calculaLaRaizCuadrada(double n)
        {
            return Math.Sqrt(n);
        }
    }
}
