using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaresProgramacion
{
    class Ingresar
    {
        public void agregar()
        {
            Console.Clear();
            Almacen almacenar = new Almacen();
            Console.WriteLine("ALMACENAR PRODUCTO");
            Console.WriteLine("Ingrese el nombre del producto");
            almacenar.Producto = Console.ReadLine();
            Console.WriteLine("Ingrese el codigo del producto");
            almacenar.Codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del producto");
            almacenar.Precio = Convert.ToInt32(Console.ReadLine());
            almacenar.APro();
            
            Console.ReadKey();
        }
        public void agregarPersona()
        {
            Console.Clear();
            Cliente nuevo = new Cliente();
            Empleado nueEm = new Empleado();
            Console.WriteLine("Seleccione");
            Console.WriteLine("[1] Cliente      [2] Empleado");
            int selc = Convert.ToInt32(Console.ReadLine());
            if (selc == 1)
            {
                Console.WriteLine("Ingrese el nombre del cliente");
                nuevo.nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la edad del cliente");
                nuevo.edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la direccion del cliente");
                nuevo.direcccion = Console.ReadLine();
                Console.WriteLine("Ingrese el codigo del cliente");
                nuevo.codigoCliente= Convert.ToInt32(Console.ReadLine());
                nuevo.NueCliente();
                

            }
            else
            {
                Console.WriteLine("Ingrese el nombre del empleado");
                nueEm.nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la edad del empleado");
                nueEm.edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la direccion del empleado");
                nueEm.direcccion = Console.ReadLine();
                Console.WriteLine("Ingrese el puesto del empleado");
                nueEm.puesto = Console.ReadLine();
                Console.WriteLine("Ingrese el codigo del empleado");
                nueEm. codEmpl = Convert.ToInt32(Console.ReadLine());
                nueEm.NueEmple();
                
            }
            Console.ReadKey();
        }
    }
}
