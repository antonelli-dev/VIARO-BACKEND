using Microsoft.AspNetCore.Builder;
using VIARO.Application.Middlewares;

namespace VIARO.Application.Exceptions
{
    public static class InjectionExtensions
    {
        public static WebApplication UseHandleExceptions(this WebApplication webApplication)
        {
            webApplication.UseMiddleware<HandleExceptionsMiddleware> ();

            return webApplication;
        }
    }
}
