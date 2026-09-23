using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public enum Clasificacion
    {
        Default,
        Familia,
        Trabajo,
        Amigos
    }
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNacimiento;
        private int _telefono;
        private Clasificacion _grupo;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public int Telefono { get => _telefono; set => _telefono = value; }
        public Clasificacion Grupo { get => _grupo; set => _grupo = value; }

        public Persona()
        {

        }

        public Persona(string nombre,string apellido,int telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Grupo = Clasificacion.Default;
        }

        public override string ToString()
        {
            return Nombre + " " + Apellido + " " + Telefono;
        }


    }
}
