using Mapster;
using School.Application.DTOs;
using School.Domain.Entities;

namespace VIARO.Application.Mappings
{
    public static class GradoMapping
    {
        public static void Configure()
        {
            TypeAdapterConfig<GradoDto, Grado>.NewConfig()
                .Map(dst => dst.Id, src => src.Id)
                .Map(dst => dst.Nombre, src => src.Nombre)
                .Map(dst => dst.ProfesorId, src => src.ProfesorId);
        }
    }
}
