using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaresProgramacion
{
    class Cliente:Persona
    {
        public int codigoCliente;

        public void NueCliente()
        {
            Console.WriteLine("Cliente agregado con exito");
            Console.WriteLine("Nombre: " + nombre + ". Edad: " + edad + ". Direccion: " + direcccion  + ". Codigo del cliente: " + codigoCliente);
            Console.ReadKey();
        }
    }
}
