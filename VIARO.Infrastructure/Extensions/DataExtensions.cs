using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using School.Domain.Interfaces;
using VIARO.Infrastructure.Context;
using VIARO.Infrastructure.Repositories;

namespace VIARO.Infrastructure.Extensions
{
    public static class DataExtensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection serviceCollection, IConfigurationManager configurationManager)
        {
            string? appDbConnectionString = configurationManager.GetConnectionString("AppDb");

            serviceCollection.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(appDbConnectionString));

            return serviceCollection;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IAlumnoRepository, AlumnoRepository>();
            serviceCollection.AddTransient<IProfesorRepository, ProfesorRepository>();
            serviceCollection.AddTransient<IGradoRepository, GradoRepository>();
            serviceCollection.AddTransient<IAlumnoGradoRepository, AlumnoGradoRepository>();

            return serviceCollection;
        }
        public static WebApplication MigrateDatabase(this WebApplication webApplication)
        {
            using (var scoped = webApplication.Services.CreateScope())
            {
                using (var appContext = scoped.ServiceProvider.GetRequiredService<AppDbContext>())
                {
                    appContext.Database
                        .Migrate();
                }
            }
            return webApplication;
        }
    }
}
