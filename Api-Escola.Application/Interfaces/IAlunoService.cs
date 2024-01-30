using Api.Escola.Domain.Entities;


namespace Api.Escola.Application.Interfaces
{

    public interface IAlunoService
    {
        List<Alunos> RetornarAluno();

        Alunos RetornarAlunoPorId(string cpf);

        void InserindoDadosAluno(string nome, string cpf, DateTime dataNascimento);


    }
}
