using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ContactoBLL : IContactoBLL
    {

        private static List<Persona> contactos = new List<Persona>();
        public void Agregar(Persona p)
        {
            //validacion
            contactos.Add(p);
        }
        public List<Persona> Listar()
        {
            return contactos;
        }

        public List<Persona> Listar(Clasificacion grupo)
        {
            //List<Persona> contactosGrupo = new List<Persona>();

            //foreach (Persona persona in contactos)
            //{
            //    if (persona.Grupo == grupo)
            //    {
            //        contactosGrupo.Add(persona);
            //    }
            //}
            //return contactosGrupo;

            return contactos.FindAll(p => p.Grupo == grupo);
        }
    }
}
