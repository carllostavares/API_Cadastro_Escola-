using Escola.Domain.Entities;

namespace Escola.Infraestrutura.Interfaces
{
    public interface IEnderecoRepositorio
    {
        void SalvarEnderecoAluno(Endereco endereco);
        void SalvarEnderecoProfessor(Endereco endereco);
        Endereco BuscarEnderecoPorCpf(string cpf);
    }
}
