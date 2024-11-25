using Microsoft.Extensions.DependencyInjection;
using VIARO.Application.Mappings;

namespace VIARO.Application.Extensions
{
    public static class MappingExtensions
    {
        public static IServiceCollection AddMappings(this IServiceCollection serviceCollection)
        {
            AlumnoGradoMapping.Configure();
            AlumnoMapping.Configure();
            ProfesorMapping.Configure();
            GradoMapping.Configure();

            return serviceCollection;
        }
    }
}
