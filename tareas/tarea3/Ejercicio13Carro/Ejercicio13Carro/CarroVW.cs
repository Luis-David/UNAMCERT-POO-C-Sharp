using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio13Carro
{
    class CarroVW: Carro
    {
        string modelo;
        public CarroVW(double p,double a,string modelo):base(p,a)
        {
            this.modelo = modelo;
        }
        public string Modelo {
            get { return modelo; }
            set { modelo = value; }
        }
        public override string ToString()
        {
            return "peso: " + base.Peso + " altura: " + base.Altura+" modelo: "+modelo;
        }
    }
}
