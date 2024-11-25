using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Domain.Entities;

namespace VIARO.Infrastructure.Maps
{
    public class AlumnoMap : IEntityTypeConfiguration<Alumno>
    {
        public void Configure(EntityTypeBuilder<Alumno> builder)
        {
            builder.ToTable("alumnos");
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id).HasColumnName("Id").HasColumnType("int").ValueGeneratedOnAdd();
            builder.Property(p => p.Nombre).HasColumnName("Nombre").HasColumnType("varchar").HasMaxLength(76);
            builder.Property(p => p.Apellidos).HasColumnName("Apellidos").HasColumnType("varchar").HasMaxLength(76);
            builder.Property(p => p.Genero).HasColumnName("Genero").HasColumnType("varchar").HasMaxLength(1);
            builder.Property(p => p.FechaNacimiento).HasColumnName("FechaNacimiento").HasColumnType("datetime");
        }
    }
}
