using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuscadorInmueble.Models
{
    public class UsuarioModel
    {
        public static int cont = 0;

        public void RegistrarUsuario(Usuario us)
        {
            var contexto = new DBInmuebleEntities();
                     
            contexto.Usuario.Add(us);

            contexto.SaveChanges();
        }
        public Usuario InicioSesion(Usuario us)
        {
            var contexto = new DBInmuebleEntities();
            var Usuario = contexto.Usuario.FirstOrDefault(p => p.usuario1 == us.usuario1 && p.clave == us.clave);
            return Usuario;
           /*    
              var contexto = new DBInmuebleEntities();
            var inmueble = contexto.Inmueble.FirstOrDefault(p => p.id_inmueble == id);
            return inmueble;*/

        }
    }
}