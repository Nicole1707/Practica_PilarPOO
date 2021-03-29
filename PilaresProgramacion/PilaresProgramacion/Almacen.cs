using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaresProgramacion
{
    class Almacen
    {
        private string producto;
        public string Producto
        {
            get
            {
                return producto;
            }
            set
            {
                producto = value;
            }
        }

        private int codigo;
        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }
        private int precio;
        public int Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }
        public void APro()
        {
            Console.WriteLine("Producto agregado con exito");
            Console.WriteLine("Nombre del producto: " + Producto + ". Codigo del producto: " + Codigo + ". Precio del producto: " + Precio);

        }

    }
}
