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
            services.AddScoped<IEnderecoService, EnderecoService>();
            services.AddScoped<IIntegracaoCepService, IntegreacaoCepService>();
            services.AddScoped<IMateriaService,MateriaService>();
            services.AddScoped<IEnderecoService, EnderecoService>();

        }

        private static void RegisterRepositories(IServiceCollection services)
        {

            services.AddScoped<IAlunoRepositorio, AlunoRepositorio>();
            services.AddScoped<IProfessorRepositorio, ProfessorRepositorio>();
            services.AddScoped<IEnderecoRepositorio, EnderecoRepositorio>();
            services.AddScoped<IIntegracaoCepRepositorio, IntegracaoCepRepositorio>();
            services.AddScoped<IMateriaRepositorio, MateriaRepositorio>();
            services.AddScoped<IEnderecoRepositorio, EnderecoRepositorio>();
            services.AddScoped<IClasseRepositorio, ClasseRepositorio>();
        }
    }
}
