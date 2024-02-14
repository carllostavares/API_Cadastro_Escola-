using Escola.Domain.Entities;

namespace Escola.Application.Interfaces
{
    public interface IMateriaService
    {
        public void InserirMateria(int id, string nome, int cargaHoraria, string cpf);
        public List<Materia> RetornaMateria();
    }
}
