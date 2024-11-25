using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Domain.Entities;

namespace VIARO.Infrastructure.Maps
{
    public class ProfesorMap : IEntityTypeConfiguration<Profesor>
    {
        public void Configure(EntityTypeBuilder<Profesor> builder)
        {
            builder.ToTable("profesores");
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id).HasColumnName("Id").HasColumnType("int").ValueGeneratedOnAdd();
            builder.Property(p => p.Nombre).HasColumnName("Nombre").HasColumnType("varchar").HasMaxLength(76);
            builder.Property(p => p.Apellidos).HasColumnName("Apellidos").HasColumnType("varchar").HasMaxLength(76);
            builder.Property(p => p.Genero).HasColumnName("Genero").HasColumnType("varchar").HasMaxLength(1);
        }
    }
}
