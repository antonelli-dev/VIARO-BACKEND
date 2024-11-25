using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Domain.Entities;

namespace VIARO.Infrastructure.Maps
{
    public class AlumnoGradoMap : IEntityTypeConfiguration<AlumnoGrado>
    {
        public void Configure(EntityTypeBuilder<AlumnoGrado> builder)
        {
            builder.ToTable("alumno_grado");
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id).HasColumnName("Id").HasColumnType("int").ValueGeneratedOnAdd();
            builder.Property(p => p.AlumnoId).HasColumnName("AlumnoId").HasColumnType("int");
            builder.HasOne(p => p.Alumno).WithMany().HasForeignKey(p => p.AlumnoId);
            builder.Property(p => p.GradoId).HasColumnName("GradoId").HasColumnType("int");
            builder.HasOne(p => p.Grado).WithMany().HasForeignKey(p=>p.GradoId);
            builder.Property(p => p.Seccion).HasColumnName("Seccion").HasColumnType("varchar").HasMaxLength(16);
        }
    }
}
