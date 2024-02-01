using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace Escola.CrossCutting.Assemblies;

[ExcludeFromCodeCoverage]
public class AssemblyUtil
{
    public static IEnumerable<Assembly> GetCurrentAssemblies()
    {
        return new Assembly[]
        {
            Assembly.Load("Api.Escola"),
            Assembly.Load("Escola.Application"),
            Assembly.Load("Escola.CrossCutting"),
            Assembly.Load("Escola.Domain"),
            Assembly.Load("Escola.Infraestrutura"),

        };

    }
}
