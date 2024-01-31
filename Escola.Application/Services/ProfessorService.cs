using Escola.Application.Interfaces;
using Escola.Domain.Entities;
using Escola.Infraestrutura;



namespace Escola.Application.Services
{

    public class ProfessorService : IProfessorService
    {
        public List<Professor> RetornarProfessor()
        {
            try
            {
                ProfessorRepositorio ProfessorRepositorio = new ProfessorRepositorio();
                var professores = ProfessorRepositorio.BuscarProfessor();
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
                ProfessorRepositorio professorRepositorio = new ProfessorRepositorio();
                var professor = professorRepositorio.BuscarProfessorPorId(cpf);
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
                ProfessorRepositorio professorRepositorio = new ProfessorRepositorio();
                professorRepositorio.SalvarProfessor(nome, cpf, dataNascimento, disciplina);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }

        }

    }
}

