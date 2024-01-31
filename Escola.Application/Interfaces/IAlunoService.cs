using Escola.Domain.Entities;

namespace Escola.Application.Interfaces
{

    public interface IAlunoService
    {
        List<Alunos> RetornarAluno();

        Alunos RetornarAlunoPorId(string cpf);

        void InserindoDadosAluno(string nome, string cpf, string dataNascimento);


    }
}
