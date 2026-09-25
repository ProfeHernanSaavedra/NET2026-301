using System;
using System.Collections.Generic;
using System.Linq;
using Datos;

namespace Negocio
{
    public class TareaBLL
    {
        TareasPendientesEntities tp = new TareasPendientesEntities();

        public void Add(string titulo, string cuerpo, DateTime? vencimiento, int idCategoria)
        {
            if (titulo == null || titulo == "")
                throw new ArgumentException("Debe ingresar un título.");
            if (titulo.Length > 50)
                throw new ArgumentException("El título debe tener entre 1 y 50 caracteres.");
            if (cuerpo == null || cuerpo == "")
                throw new ArgumentException("Debe ingresar una descripción.");
            if (cuerpo.Length > 50)
                throw new ArgumentException("La descripción debe tener entre 1 y 50 caracteres.");
            if (vencimiento.HasValue && vencimiento.Value.Date < DateTime.Today)
                throw new ArgumentException("La fecha de vencimiento no puede ser anterior a hoy.");

            if (tp.Categoria.Where(c => c.Id == idCategoria).FirstOrDefault() == null)
                throw new ArgumentException("Seleccione una categoría válida.");

            Tarea nueva = new Tarea();
            nueva.Titulo = titulo;
            nueva.Cuerpo = cuerpo;
            nueva.FechaCreacion = DateTime.Today;
            nueva.FehcaVencimiento = vencimiento;
            nueva.estado = "PE";
            nueva.idCategoria = idCategoria;

            tp.Tarea.Add(nueva);
            tp.SaveChanges();
        }

        public Tarea Get(int id)
        {
            return tp.Tarea.Where(t => t.Id == id).FirstOrDefault();
        }

        public List<Tarea> GetAll()
        {
            return tp.Tarea.ToList();
        }
    }
}
