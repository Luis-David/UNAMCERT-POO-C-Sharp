using System;

namespace ClasesAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animales = {
                new Carnivoro("Leon"),
                new Herbivoro("Jirafa")
            };
            Console.WriteLine("Lista de animales");
            foreach (Animal an in animales)
            {
                Console.WriteLine(an);
            }
            Lobo lobo = new Lobo("Lobezno");
            lobo.cazar();
            (lobo as Carnivoro).cazar();//No muestra el metodo del padre porque fue sobreescrito
            //Si no se pone en el metodo override, se puede acceder al metodo del padre tal como fue declarado
            // de lo contrario se sobreescribe.
            Pinguino pingu = new Pinguino("tux");
            pingu.cazar();
            (pingu as Carnivoro).cazar();
        }
    }
}
