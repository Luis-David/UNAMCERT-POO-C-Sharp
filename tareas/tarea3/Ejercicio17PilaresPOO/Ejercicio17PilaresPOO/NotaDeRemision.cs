using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio17PilaresPOO
{
    class NotaDeRemision : Venta
    {
        public string nombreCliente;

        public NotaDeRemision(Producto[] p, string nombre1, string fecha1)
        {
            this.nombreCliente = nombre1;
            base.ArtVendidos = p;
            base.Fecha = fecha1;
            base.calcularSubtotal(base.ArtVendidos);
            base.calcularTotal();
        }
      

        public override void imprimir()
        {

            Console.WriteLine("Cliente: " + nombreCliente);
            Console.WriteLine("Productos comprados: " + base.ArtVendidos.Length);
            foreach (Producto p in base.ArtVendidos)
            {
                Console.WriteLine("\t"+p);
            }
            Console.WriteLine("Subtotal: " + base.SubTotal);
            Console.WriteLine("Total: " + base.Total);
        }
    }
}
