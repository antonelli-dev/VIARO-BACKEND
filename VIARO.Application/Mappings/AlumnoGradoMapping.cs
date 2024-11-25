using Mapster;
using School.Application.DTOs;
using School.Domain.Entities;

namespace VIARO.Application.Mappings
{
    public static class AlumnoGradoMapping
    {
        public static void Configure()
        {
            TypeAdapterConfig<AlumnoGradoDto, AlumnoGrado>.NewConfig()
                .Map(dst => dst.Id, src => src.Id)
                .Map(dst => dst.AlumnoId, src => src.AlumnoId)
                .Map(dst => dst.GradoId, src => src.GradoId)
                .Map(dst => dst.Seccion, src => src.Seccion);
        }
    }
}
