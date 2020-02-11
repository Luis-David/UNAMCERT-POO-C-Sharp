using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9ClaseMath
{
    class Cuadrado
    {
        public double lado;
        public double getArea()
        {
            return Math.Pow(lado, 2);
        }
        public double getAreaRedondeo()
        {
            return Math.Round(Math.Pow(lado,2));
        }
        public double getAreaRedondeo2decimales()
        {
            return Math.Round(Math.Pow(lado, 2), 2);
        }
        public double getPerimetro()
        {
            return 4 * lado;
        }
    }
}
