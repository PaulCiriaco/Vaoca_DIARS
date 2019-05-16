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
    public class CursoController : Controller
    {
        // GET: Curso
        private AppContext context;

        public CursoController()
        {
            context = new AppContext();
        }

       
        public ActionResult Index()
        {
            var query = context.Cursos
               .Include(o => o.profesor)
               .ToList();

            return View(query);

        }

        public ActionResult Detalle(int id)
        {
            var curso = context.Cursos.Where(o => o.Id == id).First();
            return View(curso);
        }
        public ActionResult Editar(int id)
        {
            ViewBag.profe = context.Profesores.ToList();
            var curso = context.Cursos.Where(o => o.Id == id).First();
            return View(curso);
        }


        public ActionResult Actualizar(int id, Curso cursoMod)
        {
            var cursoDb = context.Cursos.Where(o => o.Id == id).First();

            cursoDb.Codigo = cursoMod.Codigo;
            cursoDb.Nombre = cursoMod.Nombre;
            cursoDb.Precio = cursoMod.Precio;
            cursoDb.Horas = cursoMod.Horas;
            cursoDb.IdProfesor = cursoMod.IdProfesor;

            context.SaveChanges();
            return RedirectToAction("Index");
        }









        [HttpGet]
        public ActionResult Crear()
        {

            ViewBag.profe = context.Profesores.ToList();

            return View();
        }

        [HttpPost]
        public ActionResult Crear(Curso curso)
        {
            context.Cursos.Add(curso);
            context.SaveChanges();

            return RedirectToAction("Index");
        }



        public ActionResult Eliminar(int id)
        {
            var context = new AppContext();
            var cursoDb = context.Cursos.Where(o => o.Id == id).First();
            context.Cursos.Remove(cursoDb);

            context.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}