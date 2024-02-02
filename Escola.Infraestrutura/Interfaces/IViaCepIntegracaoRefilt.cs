using Escola.Domain.Entities;
using Refit;
namespace Escola.Infraestrutura.Interfaces
{
    public interface IViaCepIntegracaoRefilt
    {
        [Get("/ws/{cep}/json")]
        Task<ApiResponse<Endereco>> ObterDadosViaCep(string Cep);

    }
}
