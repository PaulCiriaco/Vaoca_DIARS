using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VAOCA_DIARS.DB;
using VAOCA_DIARS.Models;

namespace VAOCA_DIARS.Controllers
{
    public class ProfesorController : Controller
    {
        private AppContext context;

        public ProfesorController()
        {
            context = new AppContext();
        }

        public ActionResult Index()
        {
            var query = context.Profesores
               .Include(o => o.curso)
               .ToList();

            return View(query);

        }

        public ActionResult Detalle(int id)
        {


            var profesores = context.Profesores.Where(o => o.Id == id).First();

            return View(profesores);
        }
        public ActionResult Editar(int id)
        {


            var profesores = context.Profesores.Where(o => o.Id == id).First();

            return View(profesores);
        }

        [HttpGet]
        public ActionResult Crear()
        {

            ViewBag.cursos = context.Cursos.ToList();

            return View();
        }

        [HttpPost]
        public ActionResult Crear(Profesor prof)
        {
            context.Profesores.Add(prof);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Actualizar(int id, Profesor profMod)
        {


            var pDb = context.Profesores.Where(o => o.Id == id).First();

            pDb.Correo = profMod.Correo;
            pDb.Clave = profMod.Clave;
            context.SaveChanges();


            return RedirectToAction("Index");
        }

        public ActionResult Eliminar(int id)
        {
            var context = new AppContext();
            var pDb = context.Profesores.Where(o => o.Id == id).First();
            context.Profesores.Remove(pDb);

            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}