using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BuscadorInmueble.Models;

namespace BuscadorInmueble.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Ingresar()
        {
            return View();
        }
        public ActionResult Registrar()
        {
            return View();
        }


        [HttpPost]
        public ActionResult ProcesarUsuario(Usuario us)
        {
            var usuario = new UsuarioModel();

            usuario.RegistrarUsuario(us);

            return RedirectToAction("Confirmacion");
        }

        public ActionResult Confirmacion()
        {
            return View();
        }

        public ActionResult IniciarSesion(Usuario us)
        {
            
            var usuario = new UsuarioModel();
            Usuario abc =  usuario.InicioSesion(us);
            return RedirectToAction("Index");
            //int ress = us.usuario1(String.Equals(us));
            //if ( ress==1)
           

        }
       
    }
}