using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaresProgramacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Comprar com = new ComprarAlma();
            OrdenesDev orden = new OrdenesDev();
            Ingresar agre = new Ingresar();
            int selc;
            do {
                Console.Clear();
                Console.WriteLine("***  Menu    ***");
                Console.WriteLine("[1] Almacen");
                Console.WriteLine("[2] Agregar Persona");
                Console.WriteLine("[3] Ordenes de compras ");
                Console.WriteLine("[4] Nicole ");
                Console.WriteLine("[5] Delivery ");
                selc = Convert.ToInt32(Console.ReadLine());
            
                switch (selc)
                {
                    case 1:
                        Console.Clear();
                        agre.agregar();
                        break;
                    case 2:
                        Console.Clear();
                        agre.agregarPersona();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Selecione el tipo de compra que desea realizar");
                        Console.WriteLine("[1] Compra de clientes");
                        Console.WriteLine("[2] Compra ha suplidores");
                        int si = int.Parse(Console.ReadLine());
                        if (si == 1)
                        {
                            com = new ComprarCli();
                            com.RCompra();
                            Console.WriteLine(com);
                        }
                        else if (si == 2)
                        {
                            com = new ComprarAlma();
                            com.RCompra();
                            Console.WriteLine(com);
                        }
                        else
                        {
                            Console.WriteLine("ERROR");
                        }
                        break;

                    case 4:
                        Nicole();
                        break;
                    case 5:
                        Console.WriteLine("[1] Agregar [2] Despachar [3] Cancelar");
                        int or = int.Parse(Console.ReadLine());
                        if (or == 1)
                        {
                            orden.agregar();
                        }
                        else if (or == 2)
                        {
                            orden.despachar();
                        }
                        else if (or == 3)
                        {
                            orden.cancelar();
                        }
                        else
                        {
                            Console.WriteLine("INCORRECTO");

                        }
                        break;

                }
            } while (selc<=4);



            Console.ReadKey();

        }
        public static  void Nicole()
        {
            Console.Clear();

            Console.WriteLine("Nombre: Nicole Marie");
            Console.WriteLine("Apellidos: Perez Abreu");
            Console.WriteLine("Matricula: 2019-7497");
            Console.WriteLine("Sector: Los Rios, DN");
            Console.ReadKey();
        }
    }
    
    
}
