using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9ClaseMath
{
    class Circulo
    {
        public double radio;
        public double getAreaConRedondeo()
        {
            return Math.Round(Math.PI * Math.Pow(radio, 2));
        }
        public double getAreaConRedondeo2decimales()
        {
            return Math.Round(Math.PI * Math.Pow(radio, 2),2);
        }
        public double getPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }
}
