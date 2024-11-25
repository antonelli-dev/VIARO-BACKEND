using System.Net;

namespace VIARO.Application.Exceptions
{
    public class AppException : Exception
    {
        public HttpStatusCode StatusCode { get; set; }

        public AppException(string message, HttpStatusCode statusCode) : base(message)
        {
            StatusCode = statusCode;
        }
    }
}
