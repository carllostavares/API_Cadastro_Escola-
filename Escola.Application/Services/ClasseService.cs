using Escola.Application.Interfaces;
using Escola.Domain.Entities;
using Escola.Infraestrutura.Interfaces;

namespace Escola.Application.Services
{
    public class ClasseService : IClasseService
    {
        private readonly IClasseRepositorio _classeRepositorio;

        public ClasseService(IClasseRepositorio classeRepositorio)
        {
            _classeRepositorio = classeRepositorio;
        }

        public void InserirClass(string sala, int idMateria, string cpfAluno)
        {
            try
            {
                Classe classe = new Classe();
                classe.Sala = sala;
                classe.IdMateria = idMateria;
                classe.CpfAluno = cpfAluno;

                _classeRepositorio.SalvarClasse(classe);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
        }

        public Classe RetornaClassePorSala(string sala)
        {
            try
            {
               var alunosDaSala = _classeRepositorio.BuscarClassePorSala(sala);
               return alunosDaSala;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
        }
    }
}
