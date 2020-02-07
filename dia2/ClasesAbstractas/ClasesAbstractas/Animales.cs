using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesAbstractas
{
    class Lobo : Carnivoro
    {
        public Lobo(string nombre): base(nombre){}

        public void MuestraColmillos()
        {
            Console.WriteLine("El lobo muestra su colmillos");
        }
        public override void cazar()
        {
            Console.WriteLine("El " + NombreComun + " usa sus colmillos para cazar. ");
        }
    }
    class Pinguino : Carnivoro
    {
        public Pinguino(string nombre) : base(nombre) { }

        public void deslizarse()
        {
            Console.WriteLine("Me estoy cayendo");
        }
        public override void cazar()
        {
            Console.WriteLine("El " + NombreComun + " usa su pico para cazar.");
        }
    }
}
