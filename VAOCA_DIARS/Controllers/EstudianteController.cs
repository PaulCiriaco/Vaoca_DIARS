using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VAOCA_DIARS.DB;
using VAOCA_DIARS.Models;

namespace VAOCA_DIARS.Controllers
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        private AppContext cnx = new AppContext();
        public ActionResult Index()
        {
            return View(cnx.Estudiantes.ToList());
        }


        [HttpGet]
        public ActionResult Create()
        {
            var v = cnx.Estudiantes.ToList();
            ViewBag.c = v;
            return View();
        }


        [HttpPost]
        public ActionResult Create(Estudiante p)
        {
            cnx.Estudiantes.Add(p);
            cnx.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Estudiante p = cnx.Estudiantes.Where(o => o.Id == id).First();
            cnx.Estudiantes.Remove(p);
            cnx.SaveChanges();
            return RedirectToAction("Index");
        }



        [HttpGet]
        public ActionResult Edit(int id)
        {
            var v = cnx.Usuarios.ToList();
            ViewBag.c = v;

            Estudiante p = cnx.Estudiantes.Where(o => o.Id == id).First();

            return View(p);
        }
        [HttpPost]
        public ActionResult Edit(int id, Estudiante p)
        {
            Estudiante p1 = cnx.Estudiantes.Where(o => o.Id == id).First();
            p1.IdUsuario = p.IdUsuario;
            p1.Empresa = p.Empresa;
            p1.Correo = p.Correo;
            p1.Clave = p.Clave;
            cnx.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Details(int id)
        {
            Estudiante p = cnx.Estudiantes.Where(o => o.Id == id).First();
            return View(p);
        }
    }
}