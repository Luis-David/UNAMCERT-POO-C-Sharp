using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Juan",30);
            p.saludar();
            Console.WriteLine(p.ToString());
            Empleado e = new Empleado("Pedro",25,"Mercenario",30000);
            Console.WriteLine(p.ToString());
            e.saludar();
            e.trabajar();

            Persona p1 = new Persona("David", 22);
            Persona p2 = new Persona("Xotla", 21);

            Persona[] gente=new Persona[4];

            gente[0] = p;
            gente[1] = p1;
            gente[2] = p2;
            gente[3] = e;

            Console.WriteLine();
            Console.WriteLine("Lista de solo empleados");
            foreach(var per in gente)
            {
                if(per is Empleado)
                {
                    Console.WriteLine(per.ToString());
                }
            }
            Console.ReadKey();

        }
    }
}
