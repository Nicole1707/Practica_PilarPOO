using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaresProgramacion
{
   class ComprarAlma : Comprar
    {
        public override double RCompra()
        {
            Console.WriteLine("Ingrese el nombre del Producto: ");
            NombrePro = Console.ReadLine();

            Console.WriteLine("Ingrese el precio del Producto: ");
            PrecioPro = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cantidad de unidades: ");
            Cantidad = int.Parse(Console.ReadLine());

            Total = (PrecioPro * Cantidad);
           
            return Total;
        }
    }
}
