using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using VAOCA_DIARS.Models;

namespace VAOCA_DIARS.DB.Maps
{
    public class MatriculaMap : EntityTypeConfiguration<Matricula>
    {
        public MatriculaMap()
        {
            ToTable("Matricula");
            HasKey(o => o.Id);
            HasRequired(o => o.estudiante).WithMany(o => o.matricula).HasForeignKey(o => o.IdEstudiante);

        }
    }
}