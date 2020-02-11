using System;

namespace Ejercicio10Persona
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repito = false;
            do
            {
                Persona p = new Persona();
                try
                {
                    repito = false;
                    Console.WriteLine("Ingrese su nombre: ");
                    p.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese su edad : ");
                    p.Edad = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrese su estatura: ");
                    p.Estatura =Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese su peso: ");
                    p.Peso =Convert.ToDouble( Console.ReadLine());

                    p.caminar();
                    p.comer();
                    Console.WriteLine("Calcula la raiz cuadrada de 25, {0} contesta: {1} ",p.Nombre,p.calculaLaRaizCuadrada(25));
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Error: debes de ingresar un numero.");
                    Console.WriteLine("Vuelve a intentarlo.");
                    repito = true;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    repito = true;
                }
            } while (repito);
        }
    }
}
