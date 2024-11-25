using Microsoft.AspNetCore.Http;
using VIARO.Application.Exceptions;

namespace VIARO.Application.Middlewares
{
    public class HandleExceptionsMiddleware
    {
        private readonly RequestDelegate _next;

        public HandleExceptionsMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (AppException ex)
            {
                await HandleExceptionAsync(context, ex.Message, (int) ex.StatusCode);
            }

         }

        private Task HandleExceptionAsync(HttpContext context, string message, int statusCode)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = statusCode;

            var response = new
            {
                error = message,
                status = statusCode
            };

            return context.Response.WriteAsJsonAsync(response);
        }
    }
}
