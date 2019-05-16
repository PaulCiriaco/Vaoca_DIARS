using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using VAOCA_DIARS.DB.Maps;
using VAOCA_DIARS.Models;

namespace VAOCA_DIARS.DB
{
    public class AppContext : DbContext
    {
        public IDbSet<Profesor> Profesores { get; set; }
        public IDbSet<Curso> Cursos { get; set; }
        public IDbSet<Estudiante> Estudiantes { get; set; }
        public IDbSet<Usuario> Usuarios { get; set; }
        public IDbSet<Matricula> Matriculas{ get; set; }
        public IDbSet<DMatricula> DMatriculas { get; set; }
        public AppContext()
        {
            Database.SetInitializer<AppContext>(null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new CursoMap());
            modelBuilder.Configurations.Add(new ProfesorMap());
            modelBuilder.Configurations.Add(new EstudianteMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new MatriculaMap());
            modelBuilder.Configurations.Add(new DMatriculaMap());

        }
    }
}