using System;

namespace Ejercicio17PilaresPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Tienda tienda = new Tienda("Tienda Dr. Robot");
            Producto p1 = new Producto("Mouse", 80);
            tienda.agregarProducto(p1);
            Producto p2 = new Producto("Teclado", 120);
            tienda.agregarProducto(p2);
            Producto p3 = new Producto("Monitor 19 pulgadas", 1500);
            tienda.agregarProducto(p3);
            Producto p4 = new Producto("CPU intel core i3", 1052.5);
            tienda.agregarProducto(p4);
            Cliente c = new Cliente("David Florez Domingo");
            c.Direccion = "Tulipanes no.123 col. Doctores";
            c.Rfc= "DAFD830401NP7";
            c.Telefono = "51361369";

            Producto[] p = new Producto[3];
            p[0] = p1;
            p[1] = p3;
            p[2] = p4;
            Console.WriteLine("****************************** Factura ");
            Factura f = new Factura(c, p, "20/02/2020");
            f.setImpuesto(100);
            f.imprimir();
            tienda.registroDeVenta(f);

            Console.WriteLine("****************************** Nota de remision: ");
            p1 = new Producto("Mother board", 1000);
            tienda.agregarProducto(p1);
            p2 = new Producto("Cable HDMI", 120);
            Producto[] lp = new Producto[2];
            lp[0] = p1;
            lp[1] = p2;
            NotaDeRemision n = new NotaDeRemision(p, "Jose Maria Lopez", "20/11/13");
            tienda.registroDeVenta(n);
            n.imprimir();
        }
    }
}
