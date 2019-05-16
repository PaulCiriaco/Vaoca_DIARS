using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VAOCA_DIARS.Models
{
    public class Matricula
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public float MontoTotal { get; set; }
        public string Estado { get; set; }
        public int IdEstudiante { get; set; }

        public Estudiante estudiante { get; set; }
        public List<DMatricula> DMatriculas { get; set; }
    }
}