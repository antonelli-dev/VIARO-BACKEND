using Microsoft.EntityFrameworkCore;
using School.Domain.Entities;
using VIARO.Infrastructure.Maps;

namespace VIARO.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<AlumnoGrado> GradosAlumnos { get; set; }
        public DbSet<Grado> Grados { get; set; }
        public DbSet<Profesor> Profesores { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlumnoMap());
            modelBuilder.ApplyConfiguration(new AlumnoGradoMap());
            modelBuilder.ApplyConfiguration(new ProfesorMap());
            modelBuilder.ApplyConfiguration(new GradoMap());
        }
    }
}
