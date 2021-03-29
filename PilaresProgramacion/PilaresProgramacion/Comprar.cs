using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaresProgramacion
{
    abstract class Comprar
    {
        public string NombrePro { get; set; }
        public int PrecioPro { get; set; }
        public int Cantidad { get; set; }
        public double Total{ get; set; }


        public abstract double RCompra();

        public override string ToString()
        {
            return ("Nombre del producto: "+ NombrePro + ". Precio p/u: "+PrecioPro + ". Cantidad ha comprar: " +Cantidad+ ". Total: " +Total);
        }
    }
}
