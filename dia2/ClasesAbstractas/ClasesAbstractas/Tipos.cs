using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesAbstractas
{
    class Carnivoro : Animal
    {
        public Carnivoro(string nombre) : base(nombre)
        {

        }
        public override string Come
        {
            get { return "Come otros animales"; }
        }
        public virtual void cazar()
        {
            Console.WriteLine("El animal está cazando: ");
        }

    }
    class Herbivoro : Animal
    {
        public Herbivoro(string nombre) : base(nombre) { }
        public override string Come
        {
            get { return "Comer plantas"; }
        }
        public void recolecta()
        {
            Console.WriteLine("El animal esta recolectando su comida");
        }

    }
}
