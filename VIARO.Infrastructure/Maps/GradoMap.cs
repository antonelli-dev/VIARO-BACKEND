using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Domain.Entities;

namespace VIARO.Infrastructure.Maps
{
    public class GradoMap : IEntityTypeConfiguration<Grado>
    {
        public void Configure(EntityTypeBuilder<Grado> builder)
        {
            builder.ToTable("grados");
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Id).HasColumnName("Id").HasColumnType("int").ValueGeneratedOnAdd();
            builder.Property(p => p.ProfesorId).HasColumnName("ProfesorId").HasColumnType("int");
            builder.HasOne(p => p.Profesor).WithMany().HasForeignKey(p => p.ProfesorId);
            builder.Navigation(p => p.Profesor).AutoInclude();


        }
    }
}
