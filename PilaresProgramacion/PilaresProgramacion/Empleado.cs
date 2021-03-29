using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaresProgramacion
{
    class Empleado:Persona
    {
        public string puesto;
        public int codEmpl;
        
        public void NueEmple()
        {
            Console.WriteLine("Empleado agregado con exito");
            Console.WriteLine("Nombre: " + nombre+ ". Edad: " + edad + ". Direccion: " + direcccion +  ". Puesto: "+ puesto+ ". Codigo del Empleado: " + codEmpl);
            Console.ReadKey();
        }
    }
}
