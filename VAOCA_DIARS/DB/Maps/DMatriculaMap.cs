using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using VAOCA_DIARS.Models;

namespace VAOCA_DIARS.DB.Maps
{
    public class DMatriculaMap : EntityTypeConfiguration<DMatricula>
    {
        public DMatriculaMap()
        {
            ToTable("DMatricula");
            HasKey(o => o.Id);

            HasRequired(o => o.matricula).WithMany(o => o.DMatriculas).HasForeignKey(o => o.IdMatricula);
            HasRequired(o => o.curso).WithMany(o => o.dMatriculas).HasForeignKey(o => o.IdCurso);

        }
    }
}