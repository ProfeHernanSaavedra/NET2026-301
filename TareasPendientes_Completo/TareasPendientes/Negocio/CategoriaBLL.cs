using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class CategoriaBLL
    {
        TareasPendientesEntities tp = new TareasPendientesEntities();

        public void Add(string nombre)
        {

            //verificar que nombre cumple con las condiciones

            if (Get(nombre)==null)
            {
                Categoria nueva = new Categoria();
                nueva.Nombre = nombre;

                tp.Categoria.Add(nueva);
                tp.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Categoria ya existe");
            }

            
        }

        public Categoria Get(string nombre)
        {
            Categoria categoria = tp.Categoria.Where(c => c.Nombre == nombre).FirstOrDefault();

            return categoria;
        }

        public List<Categoria> GetAll()
        {
            return tp.Categoria.ToList();
        }

        public void Delete(string nombre)
        {
            Categoria c = Get(nombre);

            if (c != null)
            {
                tp.Categoria.Remove(c);
                tp.SaveChanges();
            }
        }

    }
}
