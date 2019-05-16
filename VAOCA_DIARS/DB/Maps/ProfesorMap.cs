using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using VAOCA_DIARS.Models;

namespace VAOCA_DIARS.DB.Maps
{
    public class ProfesorMap : EntityTypeConfiguration<Profesor>
    {
        public ProfesorMap()
        {

            ToTable("Profesor");
            HasKey(o => o.Id);
            HasRequired(o => o.usuario).WithMany(o => o.profesores).HasForeignKey(o => o.IdUsuario);
        }
    }
}