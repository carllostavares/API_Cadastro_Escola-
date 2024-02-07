using Escola.Domain.Entities;

namespace Escola.Infraestrutura.Interfaces
{
    public interface IIntegracaoCepRepositorio
    {
        public  Endereco BuscarCep(string cep);
    }
}
