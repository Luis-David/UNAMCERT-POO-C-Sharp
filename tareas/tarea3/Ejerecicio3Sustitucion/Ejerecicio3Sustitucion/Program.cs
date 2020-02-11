using System;

namespace Ejerecicio3Sustitucion
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Ingrese una cadena: ");
            string cadena = Console.ReadLine();
            int size = cadena.Length;
            int j = 0;
            string cadena2 = cadena;
            for(int i=0; i<size; i++)
            {
                if (cadena[i] == 'a' || cadena[i] == 'e' || cadena[i] == 'i' || cadena[i] == 'o' || cadena[i] == 'u'
                        || cadena[i] == 'A' || cadena[i] == 'E' || cadena[i] == 'I' || cadena[i] == 'O' || cadena[i] == 'U')
                {
                    cadena2=cadena2.Insert(i+j++,"f");
                }
            }
            Console.WriteLine(cadena2);
        }
    }
}
