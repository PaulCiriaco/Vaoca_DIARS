using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VAOCA_DIARS.Models
{
    public class Estudiante
    {
        public int Id { set; get; }
        public string Empresa { set; get; }
        public int IdUsuario { set; get; }
        public string Correo { set; get; }
        public string Clave { set; get; }
        public List<Matricula> matricula { get; set; }
        public Usuario usuario { set; get; }
    }
}