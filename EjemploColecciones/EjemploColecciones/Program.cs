using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploColecciones
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] dias = new string[7];
            string[] dias = { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };
            Console.WriteLine(dias[0]);

            Console.WriteLine("\nRecorriedo con for");
            //for + tab + tab
            for (int i = 0; i < dias.Length; i++)
            {
                Console.WriteLine(dias[i]);
            }

            Console.WriteLine("\nRecorriedo con foreach");
            //fore + tab + tab
            foreach (string dia in dias)
            {
                Console.WriteLine(dia);
            }

            Console.WriteLine("\nMatrices");
            //Matrices
            int[,] sala = new int[8,10];
            Random rand = new Random();
            //Console.WriteLine("Matriz de " + fila + "x" + columna + "y");
            Console.WriteLine("Matriz de {0} x {1}", sala.GetLength(0),sala.GetLength(1) );
            Console.WriteLine("Contenido posicion 0,0 : " + sala[0,0]);

            for (int f = 0; f < sala.GetLength(0); f++)
            {
                for (int c = 0; c < sala.GetLength(1); c++)
                {
                    sala[f, c] = rand.Next(0, 2);
                    Console.Write(sala[f,c] + " ");
                }
                Console.WriteLine("");
            }


            //listas
            Console.WriteLine("\n\nListas");
            List<string> colores = new List<string>();

            colores.Add("rojo");
            colores.Add("azul");
            colores.Add("verde");
            colores.Add("blanco");
            Console.WriteLine("primer elemento: " + colores[0]);

            Console.WriteLine("\nRecorrer con foreach");
            foreach (string color in colores)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine();
            colores.Insert(0, "amarillo");
            foreach (string color in colores)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine("El total de elementos en la lista es de : " + colores.Count);

            colores.Remove("rojo");
            
            Console.WriteLine();
            
            foreach (string color in colores)
            {
                Console.WriteLine(color);
            }



            Console.ReadLine();
        }
    }
}
