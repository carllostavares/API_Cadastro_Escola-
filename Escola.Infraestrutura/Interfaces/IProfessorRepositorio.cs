using Escola.Domain.Entities;

namespace Escola.Infraestrutura.Interfaces
{
    public interface IProfessorRepositorio
    {
        List<Professor> BuscarProfessor();

        Professor BuscarProfessorPorId(string cpf);

        void SalvarProfessor(string nome, string cpf, string dataNascimento, string disciplina);

    }
}
