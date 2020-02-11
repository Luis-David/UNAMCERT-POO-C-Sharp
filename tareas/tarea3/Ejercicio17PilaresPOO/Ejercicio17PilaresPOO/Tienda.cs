using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio17PilaresPOO
{
    class Tienda
    {
        private string nombre;
        private List<Producto> productos;
        private List<Cliente> clientes;
        private List<NotaDeRemision> notas;
        private List<Factura> facturas;
        public Tienda(String nombre)
        {
            productos = new List<Producto>();
            clientes = new List<Cliente>();
            notas = new List<NotaDeRemision>();
            facturas = new List<Factura>();
            this.nombre = nombre;
        }
        public void agregarCliente(Cliente c)
        {
            clientes.Add(c);
        }
        public void agregarProducto(Producto p)
        {
            productos.Add(p);
        }
        public void mostrarProductos()
        {
            for (int i = 0; i < productos.Count; i++)
                Console.WriteLine(productos.ToArray()[i].Nombre + "   " + productos.ToArray()[i].Precio);
        }
        public void registroDeVenta(Factura f)
        {
            facturas.Add(f);
        }
        public void registroDeVenta(NotaDeRemision n)
        {
            notas.Add(n);
        }
        public void ListaFacturas()
        {
            for (int i = 0; i < facturas.Count; i++)
                facturas.ToArray()[i].imprimir();
        }
        public void ListarNotasDeRemision()
        {
            for (int i = 0; i < notas.Count; i++)
                notas.ToArray()[i].imprimir();
        }
    }
}
