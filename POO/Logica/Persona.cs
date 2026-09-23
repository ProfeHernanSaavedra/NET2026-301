using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Persona
    {
        private string _nombre;
        private string _apellido; // CTR+R+E
        private DateTime _fechaNacimiento;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }

        //ctor + tab tab
        public Persona()
        {

        }

        public Persona(string nombre,string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = new DateTime(1990, 10, 11);
        }

        public int Edad()
        {
            int edad = DateTime.Today.Year - FechaNacimiento.Year;

            if (DateTime.Today < FechaNacimiento.AddYears(edad))
            {
                edad--; //edad = edad - 1;
            }

            return edad;
        }


        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }





    }
}
