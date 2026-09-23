using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyectoCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1= 4,num2 = 5,num6;
            int suma;
            string nombre = "Nicolas";
            bool esCharp = true;
            float num3 = 3.5f;
            decimal num4 = 2.5m;
            string numero5 = "14";

            suma = num1 + num2 + (int)num3 + (int)num4 + int.Parse(numero5);

            Console.WriteLine("Hola mundo");
            //cw + tab + tab
            Console.WriteLine("la suma es: " + suma);
            Console.WriteLine("Hola " + nombre);
            Console.WriteLine("Lenguar C#: " + esCharp);

            //ingresar dato
            Console.WriteLine("Ingrese número 6: ");

            //num6 = int.Parse(Console.ReadLine());
            int.TryParse(Console.ReadLine(), out num6);
            suma += num6;
            Console.WriteLine("la suma es: " + suma);


            Console.ReadLine();
        }
    }
}
