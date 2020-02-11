using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio17PilaresPOO
{
    abstract class Venta
    {
        string fecha;

        Producto[] artVendidos;

        double subTotal;

        double impuesto;

        double total;

        public void setImpuesto(double imp)
        {
            impuesto = imp;
        }

        public double getImpuesto()
        {
            return impuesto;
        }

        public void calcularTotal()
        {
            double aumento;
            aumento = (impuesto / 100) * subTotal;
            total = subTotal + aumento;
        }

        public void calcularSubtotal(Producto[] p)
        {
            subTotal = 0;
            for (int i = 0; i < p.Length; i++)
            {
                subTotal += p[i].Precio;
            }
        }
        public String Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public Producto[] ArtVendidos
        {
                get { return artVendidos; }
                set { artVendidos = value; }
        }

        public double SubTotal
        {
            get { return subTotal; }
            set { subTotal = value; }
        }

        public double Impuesto
        {
            get { return impuesto; }
            set { impuesto = value; }
        }

        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        public abstract void imprimir();
    }
}
