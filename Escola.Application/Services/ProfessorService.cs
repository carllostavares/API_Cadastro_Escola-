using Escola.Application.Interfaces;
using Escola.Domain.Entities;
using Escola.Infraestrutura.Interfaces;
using Escola.Infraestrutura.Repositorios;



namespace Escola.Application.Services
{

    public class ProfessorService : IProfessorService
    {
        private readonly IProfessorRepositorio _professorRepositorio;

        public ProfessorService(IProfessorRepositorio professorRepositorio)
        {
            _professorRepositorio = professorRepositorio;
        }

        public List<Professor> RetornarProfessor()
        {
            try
            {
                var professores = _professorRepositorio.BuscarProfessor();
                return professores;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }

        }

        public Professor RetornarProfessorPorId(string cpf)
        {
            try
            {
                var professor = _professorRepositorio.BuscarProfessorPorId(cpf);
                return professor;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }

        }

        public void InserindoDadosProfessor(string nome, string cpf, string dataNascimento, string disciplina)
        {
            try
            {
                _professorRepositorio.SalvarProfessor(cpf, nome, dataNascimento, disciplina);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }

        }

    }
}

