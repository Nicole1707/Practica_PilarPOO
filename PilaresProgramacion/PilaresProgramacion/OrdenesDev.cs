using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaresProgramacion
{
    class OrdenesDev
    {
        public string cliente;
        public int norden;
        public int Tpagar;
        public string deli;

        public void agregar()
        {
            Console.Clear();
            Console.WriteLine("AGREGAR PEDIDO");
            Console.WriteLine("Nombre del cliente: ");
           cliente= Console.ReadLine();
            Console.WriteLine("Numero de orden: ");
            norden = int.Parse(Console.ReadLine());
            Console.WriteLine("Total a pagar: ");
            Tpagar = int.Parse(Console.ReadLine());
            Console.WriteLine("Nombre del mensajero: ");
            deli = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Nombre del cliente: " + cliente + " Numero de orden: " + norden + " Total a pagar: " + Tpagar + " Nombre del mensajero: " + deli);
        }
        public void despachar()
        {
            Console.Clear();
            Console.WriteLine("Despachar");
            Console.WriteLine("Numero de orden: ");
            norden = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(" Orden no: " + norden + "Despachada");
        }
        public void cancelar()
        {
            Console.WriteLine("CANCELAR");
            Console.WriteLine("Numero de orden: ");
            norden = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(" Orden no: " + norden + "CANCELADA");

        }
    }
}
