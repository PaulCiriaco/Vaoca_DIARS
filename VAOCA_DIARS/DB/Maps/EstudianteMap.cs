using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using VAOCA_DIARS.Models;

namespace VAOCA_DIARS.DB.Maps
{
    public class EstudianteMap : EntityTypeConfiguration<Estudiante>
    {
        public EstudianteMap()
        {
            ToTable("Estudiante");
            HasKey(o => o.Id);
            HasRequired(o => o.usuario).WithMany(o => o.estudiantes).HasForeignKey(o => o.IdUsuario);
        }
    }
}