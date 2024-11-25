using Microsoft.Extensions.DependencyInjection;
using School.Application.Services;

namespace VIARO.Application.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<AlumnoService>()
                .AddTransient<AlumnoGradoService>()
                .AddTransient<ProfesorService>()
                .AddTransient<GradoService>();
        }
    }
}
