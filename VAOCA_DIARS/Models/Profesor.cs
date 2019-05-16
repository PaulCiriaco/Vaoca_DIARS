using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VAOCA_DIARS.Models
{
    public class Profesor
    {
        public int Id { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public int IdUsuario { get; set; }

        public List<Curso> curso { get; set; }
        public Usuario usuario { get; set; }
    }
}