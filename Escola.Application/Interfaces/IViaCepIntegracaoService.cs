using Escola.Domain.Entities;
namespace Escola.Application.Interfaces
{
    public interface IViaCepIntegracaoService
    {
        Task<Endereco> RetornarDadosViaCep(string cep);
    }
}
