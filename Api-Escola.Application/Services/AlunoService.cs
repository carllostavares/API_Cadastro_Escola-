using Api_Escola.Infra.Data;
using Api_Escola.Infra.Data.SqlDataBase;
using MySql.Data.MySqlClient;


namespace Api_Escola.Application.Services
{

    public class AlunoService
    {
        
        public void BuscandoDadosAluno(string nome, string cpf, DateTime dataNascimento)
        {
            AlunoRepositorio alunoRepositorio = new AlunoRepositorio();



            alunoRepositorio.BuscarAluno(nome, cpf, dataNascimento);
        }

        public void InserindoDadosAluno(string nome, string cpf, DateTime dataNascimento)
        {
            AlunoRepositorio alunoRepositorio = new AlunoRepositorio();
            alunoRepositorio.SalvarAluno(nome, cpf, dataNascimento);
        }

    }
}

