using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hola mundo");
            Persona per = new Persona();
            per.Nombre = "Juan";
            per.Apellido = "Perez";
            per.FechaNacimiento = new DateTime(1980, 11, 2);

            Console.WriteLine("Hola " + per.Nombre);
            Console.WriteLine("Hola " + per);

            Console.WriteLine("{0} Tienes {1} años",per.Nombre,per.Edad());
            

            Persona per2 = new Persona("Alam", "Brito");
            per2.FechaNacimiento = new DateTime(1982, 3, 16);
            Console.WriteLine("Hola " + per2.Nombre  );
            Console.WriteLine("{0} Tienes {1} años", per2.Nombre, per2.Edad());




            Console.ReadLine();
        }
    }
}
