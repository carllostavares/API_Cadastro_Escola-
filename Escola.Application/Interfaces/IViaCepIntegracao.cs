using Escola.Domain.Entities;
namespace Escola.Application.Interfaces
{
    public interface IViaCepIntegracao
    {
        Task<Endereco> ObterDadosViaCep(string cep);
    }
}
