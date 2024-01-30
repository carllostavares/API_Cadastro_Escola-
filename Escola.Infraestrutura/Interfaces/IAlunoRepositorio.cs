using Api.Escola.Domain.Entities;

namespace Escola.Infraestrutura.Interfaces
{
    public interface IAlunoRepositorio
    {
        List<Alunos> BuscarAluno();

        Alunos BuscarAlunoPorId(string cpf);

        void SalvarAluno(string nome, string cpf, DateTime dataNascimento);

    }
}
