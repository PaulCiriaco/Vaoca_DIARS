using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VAOCA_DIARS.Models
{
    public class Usuario
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Dni { set; get; }
        public string Sexo { set; get; }

        public DateTime Fecha { set; get; }

        public List<Profesor> profesores { set; get; }
        public List<Estudiante> estudiantes { set; get; }
    }
}