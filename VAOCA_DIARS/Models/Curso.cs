using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VAOCA_DIARS.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public string Horas { get; set; }
        public int IdProfesor { get; set; }

        public Profesor profesor { get; set; }
        public List<DMatricula> dMatriculas { get; set; }
    }
}