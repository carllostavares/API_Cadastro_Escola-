using Api_Escola.Domain.Entities;
using Api_Escola.Infra.Data;
using Api_Escola.Infra.Data.SqlDataBase;
using MySql.Data.MySqlClient;


namespace Api_Escola.Application.Services
{

    public class AlunoService
    {
        
        public List<Aluno> RetornarAluno()
        {
            AlunoRepositorio alunoRepositorio = new AlunoRepositorio();
            var alunos = alunoRepositorio.BuscarAluno();
            return alunos;
        }
        public Aluno RetornarAlunoPorId(string cpf)
        {
            AlunoRepositorio alunoRepositorio = new AlunoRepositorio();
            var aluno = alunoRepositorio.BuscarAlunoPorId(cpf);
            return aluno;
        }

        public void InserindoDadosAluno(string nome, string cpf, DateTime dataNascimento)
        {
            AlunoRepositorio alunoRepositorio = new AlunoRepositorio();
            alunoRepositorio.SalvarAluno(nome, cpf, dataNascimento);
        }

    }
}

