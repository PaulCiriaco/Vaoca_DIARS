using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VAOCA_DIARS.DB;
using VAOCA_DIARS.Models;

namespace VAOCA_DIARS.Controllers
{
    public class DMatriculaController : Controller
    {
        private AppContext entidades = new AppContext();
        // GET: DMatricula
        public ActionResult Index()
        {
            return View(entidades.DMatriculas.ToList());
        }
        [HttpGet]
        public ActionResult Crear()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Crear(DMatricula m)
        {
            entidades.DMatriculas.Add(m);
            entidades.SaveChanges();
            return View();
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            return View(entidades.DMatriculas.Where(o => o.Id == id).First());
        }
        [HttpPost]
        public ActionResult Editar(int id, DMatricula m)
        {
            var mat = entidades.DMatriculas.Where(o => o.Id == id).First();

            mat.IdCurso = m.IdCurso;
            mat.IdMatricula = m.IdMatricula;
            entidades.SaveChanges();
            return View();
        }
        public ActionResult Detalles(int id)
        {
            return View(entidades.DMatriculas.Where(o => o.Id == id).First());
        }
        public ActionResult Eliminar(int id)
        {
            var dato = entidades.DMatriculas.Where(o => o.Id == id).First();
            entidades.DMatriculas.Remove(dato);
            entidades.SaveChanges();
            return View();
        }


    }
}