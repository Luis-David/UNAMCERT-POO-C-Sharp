using System;

namespace Ejercicio14UsoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Avion a = new Avion();
            Pajaro p = new Pajaro();
            CarroVolador c = new CarroVolador();
            IVolar[] voladores = new IVolar[3];
            voladores[0] = a;
            voladores[1] = p;
            voladores[2] = c;
            Console.WriteLine("******* Todos asciende al cielo");
            //Mando la orden de que todos vuelen
            foreach(var v in voladores)
            {
                v.ascender();
            }
            Console.WriteLine("******* Todos giran a la derecha");

            //Mando la orden de que todos giren a la derecha
            foreach (var v in voladores)
            {
                v.girarALaDerecha();
            }
            /*
         El objetivo de la interfaz es poder ejecutar un mismo método en todas los objetos que tengan implementada
         una misma interfaz, creando de esta forma un protocolo de comunicación entre distintos objetos.
             */
        }
    }
}
