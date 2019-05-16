using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VAOCA_DIARS.DB;
using VAOCA_DIARS.Models;

namespace VAOCA_DIARS.Controllers
{
    public class MatriculaController : Controller
    {
        private AppContext entidades = new AppContext();
        // GET: Matricula
        public ActionResult Index()
        {
            return View(entidades.Matriculas.ToList());
        }
        [HttpGet]
        public ActionResult Crear()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Crear(Matricula m)
        {
            entidades.Matriculas.Add(m);
            entidades.SaveChanges();
            return View();
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            return View(entidades.Matriculas.Where(o => o.Id == id).First());
        }
        [HttpPost]
        public ActionResult Editar(int id, Matricula m)
        {
            var mat = entidades.Matriculas.Where(o => o.Id == id).First();

            mat.Fecha = m.Fecha;
            mat.MontoTotal = m.MontoTotal;
            mat.Estado = m.Estado;
            entidades.SaveChanges();
            return View();
        }
        public ActionResult Detalles(int id)
        {
            return View(entidades.Matriculas.Where(o => o.Id == id).First());
        }
        public ActionResult Eliminar(int id)
        {
            var dato = entidades.Matriculas.Where(o => o.Id == id).First();
            entidades.Matriculas.Remove(dato);
            entidades.SaveChanges();
            return View();
        }


    }
}