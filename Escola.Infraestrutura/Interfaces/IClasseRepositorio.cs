using Escola.Domain.Entities;

namespace Escola.Infraestrutura.Interfaces
{
    public interface IClasseRepositorio
    {
         void SalvarClasse(Classe classe);
         List<string> BuscarClassePorSala(string sala);
    }
}
