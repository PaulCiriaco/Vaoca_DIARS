using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using VAOCA_DIARS.Models;

namespace VAOCA_DIARS.DB.Maps
{
    public class CursoMap : EntityTypeConfiguration<Curso>
    {
        public CursoMap()
        {
            ToTable("Curso");
            HasKey(o => o.Id);
            HasRequired(o => o.profesor).WithMany(o => o.curso).HasForeignKey(o => o.IdProfesor);
        }

    }
}