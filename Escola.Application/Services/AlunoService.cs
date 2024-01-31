using Escola.Application.Interfaces;
using Escola.Domain.Entities;
using Escola.Infraestrutura;



namespace Escola.Application.Services
{

    public class AlunoService : IAlunoService
    {
        public List<Alunos> RetornarAluno()
        {
            try
            {
                AlunoRepositorio alunoRepositorio = new AlunoRepositorio();
                var alunos = alunoRepositorio.BuscarAluno();
                return alunos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }

        }

        public Alunos RetornarAlunoPorId(string cpf)
        {
            try
            {
                AlunoRepositorio alunoRepositorio = new AlunoRepositorio();
                var aluno = alunoRepositorio.BuscarAlunoPorId(cpf);
                return aluno;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }

        }

        public void InserindoDadosAluno(string cpf, string nome, string dataNascimento)
        {
            try
            {
                AlunoRepositorio alunoRepositorio = new AlunoRepositorio();
                alunoRepositorio.SalvarAluno(cpf, nome, dataNascimento);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }

        }

    }
}

