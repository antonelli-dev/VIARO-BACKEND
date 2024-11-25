using System.Diagnostics.CodeAnalysis;
using VIARO.Application.Exceptions;

namespace VIARO.Application.Utils
{
    public static class EnsureService
    {
        public static void ThrowNotFoundIfIsNull([NotNull] object value, string message)
        {
            if( value is null )
            {
                throw new NotFoundException(message);
            }
        }
    }
}
