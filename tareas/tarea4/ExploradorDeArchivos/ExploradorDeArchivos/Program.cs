using System;
using System.IO;
namespace ExploradorDeArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo("C:\\Users\\luis\\Documents");

            Uri r = new Uri("C:\\Users\\luis\\Documents\\passwifi.txt");
            Console.WriteLine("l1: " + r.ToString());
            Console.WriteLine("l2: " + r.OriginalString);
            Console.WriteLine("l2: "+Path.GetPathRoot(r.OriginalString));
            Console.WriteLine("l1: " + Path.IsPathFullyQualified("C:\\Users\\luis\\Documents"));
            Console.WriteLine("l1: " + Path.IsPathRooted("C:\\**dasd"));
            Console.WriteLine("l221:extension " + Path.HasExtension("C:\\Users\\luis\\Documents"));
            Console.WriteLine("l221:extension 2" + Path.HasExtension("C:\\Users\\luis\\Documents\\passwifi.txt"));
            Console.WriteLine("l221: path padre: " + Directory.GetParent("C:\\hola\\dos").ToString());
            Console.WriteLine("l122: nombrearchivo " + Path.GetFileName("C:\\Users\\luis\\Documents"));
            Console.WriteLine("l222: "+Path.GetDirectoryName(r.OriginalString));
            foreach (var f2 in d.GetFiles())
            {
                Console.WriteLine(f2.Name);
                if (f2.Name.Equals("Ciencia_Sin_Seso.pdf"))
                {
                    Console.WriteLine("Elimino el archivo");

                    f2.CopyTo("C:\\Users\\luis\\Pictures\\copia.pdf");
                }
            }

        }
    }
}
