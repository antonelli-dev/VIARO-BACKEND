using System.Reflection;

namespace VIARO.Infrastructure
{
    public class AssemblyReference
    {
        public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;
    }
}
