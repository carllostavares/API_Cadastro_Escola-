using Escola.Application.Interfaces;
using Escola.Application.Services;
using Escola.Infraestrutura.Interfaces;
using Escola.Infraestrutura.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace Escola.CrossCutting.loC
{
    [ExcludeFromCodeCoverage]
    public static class DependencyResolver
    {
        public static void AddDependencyResolver(this IServiceCollection services)
        {
            RegisterApplications(services);
            RegisterRepositories(services);

        }

        private static void RegisterApplications(IServiceCollection services)
        {
            services.AddScoped<IAlunoService, AlunoService>();
            services.AddScoped<IProfessorService, ProfessorService>();
            services.AddScoped<IViaCepIntegracaoService, ViaCepIntegracaoServie>();
            services.AddScoped<IEnderecoService, EnderecoService>();


        }

        private static void RegisterRepositories(IServiceCollection services)
        {

            services.AddScoped<IAlunoRepositorio, AlunoRepositorio>();
            services.AddScoped<IProfessorRepositorio, ProfessorRepositorio>();
            services.AddScoped<IEnderecoRepositorio, EnderecoRepositorio>();
        }
    }
}
