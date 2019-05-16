using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VAOCA_DIARS.DB;
using VAOCA_DIARS.Models;

namespace VAOCA_DIARS.Controllers
{
    public class UsuarioController : Controller
    {
        private AppContext context;

        public UsuarioController()
        {
            context = new AppContext();
        }


        
        public ActionResult Index()
        {
            var query = context.Usuarios
               ;

            return View(query);

        }

        public ActionResult Detalle(int id)
        {
            var Usuario = context.Usuarios.Where(o => o.Id == id).First();
            return View(Usuario);
        }
        public ActionResult Editar(int id)
        {
            ViewBag.profe = context.Profesores.ToList();
            var Usuario = context.Usuarios.Where(o => o.Id == id).First();
            return View(Usuario);
        }


        public ActionResult Actualizar(int id, Usuario UsuarioMod)
        {
            var UsuarioDb = context.Usuarios.Where(o => o.Id == id).First();


            UsuarioDb.Nombre = UsuarioMod.Nombre;
            UsuarioDb.Apellido = UsuarioMod.Apellido;
            UsuarioDb.Dni = UsuarioMod.Dni;
            UsuarioDb.Sexo = UsuarioMod.Sexo;
            UsuarioDb.Fecha = UsuarioMod.Fecha;

            context.SaveChanges();
            return RedirectToAction("Index");
        }









        [HttpGet]
        public ActionResult Crear()
        {



            return View();
        }

        [HttpPost]
        public ActionResult Crear(Usuario Usuario)
        {
            context.Usuarios.Add(Usuario);
            context.SaveChanges();

            return RedirectToAction("Index");
        }



        public ActionResult Eliminar(int id)
        {
            var context = new AppContext();
            var UsuarioDb = context.Usuarios.Where(o => o.Id == id).First();
            context.Usuarios.Remove(UsuarioDb);

            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}