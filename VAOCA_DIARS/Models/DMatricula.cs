using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VAOCA_DIARS.Models
{
    public class DMatricula
    {
        public int Id { get; set; }
        public int IdMatricula { get; set; }
        public int IdCurso { get; set; }

        public Curso curso{get; set;}
        public Matricula matricula { get; set; }
    }
}