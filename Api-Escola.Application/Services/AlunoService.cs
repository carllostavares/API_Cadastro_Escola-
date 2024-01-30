using Api.Escola.Application.Interfaces;
using Api.Escola.Domain.Entities;
using Escola.Infraestrutura;



namespace Api.Escola.Application.Services
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

        public void InserindoDadosAluno(string nome, string cpf, DateTime dataNascimento)
        {
            try
            {
                AlunoRepositorio alunoRepositorio = new AlunoRepositorio();
                alunoRepositorio.SalvarAluno(nome, cpf, dataNascimento);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }

        }

    }
}

