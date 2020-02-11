using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio7NumeroComplejo
{
    class NumeroComplejo
    {
        private int parteReal;
        private int parteImaginaria;

        public NumeroComplejo(int pr,int pi)
        {
            parteReal = pr;
            parteImaginaria = pi;
        }
        public int ParteReal
        {
            get { return parteReal; }
            set { parteReal = value; }
        }
        public int ParteImaginaria
        {
            get { return parteImaginaria; }
            set { parteImaginaria = value; }
        }
        public void imprimir()
        {
            Console.WriteLine("{0}+{1}i", parteReal, parteImaginaria);
        }
        public static NumeroComplejo operator+ (NumeroComplejo n1,NumeroComplejo n2)
        {

            return new NumeroComplejo(n1.parteReal + n2.parteReal, n1.ParteImaginaria + n2.ParteImaginaria);
        }
    }
}
