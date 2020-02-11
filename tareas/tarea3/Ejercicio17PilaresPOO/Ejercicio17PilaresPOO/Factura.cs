using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio17PilaresPOO
{
    class Factura:Venta
    {
        public static int numFactura;
        private Cliente cliente;
        public Factura(Cliente c, Producto[] p, string fecha)
        {
            setImpuesto(0);
            base.Fecha = fecha;
            cliente = c;
            base.ArtVendidos = p;
            numFactura++;
        }

        public override void imprimir()
        {
            Console.WriteLine("Numero de factura: " + numFactura);
            Console.WriteLine("Cliente: " + cliente.Nombre);
            Console.WriteLine("Direccion: " + cliente.Direccion);
            Console.WriteLine("RFC: " + cliente.Rfc);
            Console.WriteLine("Telefono: " + cliente.Telefono);
            Console.WriteLine("Productos comprados: " + base.ArtVendidos.Length + "\n");
            foreach(Producto p in base.ArtVendidos)
            {
                Console.WriteLine("\t" + p);
            }
            calcularSubtotal(base.ArtVendidos);
            calcularTotal();
            Console.WriteLine("\nSubtotal: " + base.SubTotal);
            Console.WriteLine("Total: " + base.Total);
        }
}
}
