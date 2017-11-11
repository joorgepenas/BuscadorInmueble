using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuscadorInmueble.Models
{
    public class InmueblesModel
    {

        public List<Inmueble> ListarInmuebles()
        {
            var contexto = new DBInmuebleEntities();

            var Inmuebles = contexto.Inmueble.ToList();

            return Inmuebles;
        }

        public Inmueble GetInmueble(int id)
        {
            var contexto = new DBInmuebleEntities();

            var inmueble = contexto.Inmueble.FirstOrDefault(p => p.id_inmueble == id);

            return inmueble;
        }

        public void RegistrarPublicacion(Inmueble inmu)
        {

                var contexto = new DBInmuebleEntities();
                contexto.Inmueble.Add(inmu);

                contexto.SaveChanges();
            


        }
    }
}