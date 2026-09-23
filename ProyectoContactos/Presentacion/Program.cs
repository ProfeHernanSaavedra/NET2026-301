using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactoBLL cbll = new ContactoBLL();

            Persona persona1 = new Persona("Alam","Brito",123456);
            Persona persona2 = new Persona("Armando", "Casas", 654321);
            Persona persona3 = new Persona("Juan","Perez",232323);

            persona1.Grupo = Clasificacion.Trabajo;
            persona3.Grupo = Clasificacion.Trabajo;

            cbll.Agregar(persona1);
            cbll.Agregar(persona2);
            cbll.Agregar(persona3);
            Console.WriteLine("Todos los contactos: ");
            foreach (Persona p in cbll.Listar())
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("Contactos grupo Trabajo: ");
            foreach (Persona p in cbll.Listar(Clasificacion.Trabajo))
            {
                Console.WriteLine(p);
            }


            Console.ReadLine(); //para que no se cierre la consola al mostrar resultados

        }
    }
}
