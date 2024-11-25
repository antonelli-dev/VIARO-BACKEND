using System.Net;

namespace VIARO.Application.Exceptions
{
    public class NotFoundException : AppException
    {
        public NotFoundException(string message, HttpStatusCode statusCode = HttpStatusCode.NotFound) : base(message, statusCode)
        {
        }
    }
}
