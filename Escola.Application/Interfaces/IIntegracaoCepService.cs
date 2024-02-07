using Escola.Domain.Entities;
namespace Escola.Application.Interfaces
{
    public interface IIntegracaoCepService
    {
        public Endereco RetornaCep(string cep);
    }
}
