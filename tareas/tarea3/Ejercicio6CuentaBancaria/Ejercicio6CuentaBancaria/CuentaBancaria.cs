using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio6CuentaBancaria
{
    class CuentaBancaria
    {
        private double saldo;
        private string nombre;

        public CuentaBancaria(string nombre,double saldo)
        {
            this.nombre = nombre;
            this.saldo = saldo;
            mostrarInformación();
        }
        public void mostrarInformación()
        {
            Console.WriteLine("nombre: {0}, saldo: {1}", nombre, saldo);
        }
        public void desposito(double m)
        {
            if (m > 0)
            {
                saldo += m;
                Console.WriteLine("Se agregó exitosamente el saldo.");
            }
            mostrarInformación();
        }
        public void retiro(double m)
        {
            if (m > 0)
            {
                if (m <= saldo)
                {
                    saldo -= m;
                    mostrarInformación();
                    Console.WriteLine("Se retiro dinero exitosamente.");
                }
                else
                {
                    Console.WriteLine("No cuenta con el saldo suficiente.");
                }
            }
            
        }
        public string Nombre { get; set; }

    }
}
