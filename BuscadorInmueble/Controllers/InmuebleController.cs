using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BuscadorInmueble.Models;
namespace BuscadorInmueble.Controllers
{
    public class InmuebleController : Controller
    {
        // GET: Inmueble
        
        public ActionResult Publicar()
        {
            return View();
        }

        public ActionResult ListadoDepas()
        {
            var modelo = new InmueblesModel();

            var depas = modelo.ListarInmuebles();

            return View(depas);
        }

        public ActionResult VerInfo(int id)
        {
            var modelo = new InmueblesModel();

            var depa = modelo.GetInmueble(id);

            return View(depa);
        }
        [HttpPost]
        public ActionResult ProcesarInmueble(Inmueble inmu)
        {

          
            inmu.id_usuario = 1;

            var inmueble = new InmueblesModel();
            inmueble.RegistrarPublicacion(inmu);
            
            return RedirectToAction("ListadoDepas");
        }
    }

}