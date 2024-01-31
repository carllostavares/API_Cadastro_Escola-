using Escola.Domain.Entities;

namespace Escola.Application.Interfaces
{

    public interface IProfessorService
    {
        List<Professor> RetornarProfessor();

        Professor RetornarProfessorPorId(string cpf);

        void InserindoDadosProfessor(string nome, string cpf, string dataNascimento, string disciplina);


    }
}
