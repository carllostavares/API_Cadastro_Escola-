using Escola.Domain.Entities;

namespace Escola.Application.Interfaces
{
    public interface IEnderecoService
    {
        void InserindoDadosEnderecoAluno(Endereco endereco);
        void InserindoDadosEnderecoProfessor(Endereco endereco);

        Endereco RetornaEnderecoPorCpf(string cpf);

    }
}
