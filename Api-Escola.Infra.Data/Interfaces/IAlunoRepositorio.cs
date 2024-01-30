using Api.Escola.Domain.Entities;

namespace Api.Escola.Infra.Data.Interfaces
{
    public interface IAlunoRepositorio
    {
        List<Alunos> BuscarAluno();

        Alunos BuscarAlunoPorId(string cpf);

        void SalvarAluno(string nome, string cpf, DateTime dataNascimento);

    }
}
