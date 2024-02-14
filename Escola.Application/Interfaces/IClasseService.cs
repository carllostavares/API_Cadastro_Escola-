using Escola.Domain.Entities;

namespace Escola.Application.Interfaces
{
    public interface IClasseService
    {
        void InserirClass(string sala, int idMateria, string cpfAluno);

        List<string> RetornaClassePorSala(string sala);
    }
}
