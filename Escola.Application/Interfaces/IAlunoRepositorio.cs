using Escola.Domain.Entities;

namespace Api.Escola.Application.Interfaces
{
    public interface IAlunoRepositorio
    {
        List<Alunos> BuscarAluno();

        Alunos BuscarAlunoPorId(string cpf);

        void SalvarAluno(string nome, string cpf, DateTime dataNascimento);

    }
}
