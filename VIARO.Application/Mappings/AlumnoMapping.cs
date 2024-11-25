using Mapster;
using School.Application.DTOs;
using School.Domain.Entities;

namespace VIARO.Application.Mappings
{
    public static class AlumnoMapping
    {
        public static void Configure()
        {
            TypeAdapterConfig<AlumnoDto, Alumno>.NewConfig()
                .Map(dst => dst.Id, src => src.Id)
                .Map(dst => dst.Nombre, src => src.Nombre)
                .Map(dst => dst.Apellidos, src => src.Apellidos)
                .Map(dst => dst.Genero, src => src.Genero)
                .Map(dst => dst.FechaNacimiento, src => src.FechaNacimiento);
        }
    }
}
