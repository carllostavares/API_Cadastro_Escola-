using Escola.Application.Interfaces;
using Escola.Domain.Entities;
using Escola.Infraestrutura;
using Escola.Infraestrutura.Interfaces;



namespace Escola.Application.Services
{

    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepositorio _alunoRepositorio;

        public AlunoService(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }

        public List<Alunos> RetornarAluno()
        {
            try
            {
                //AlunoRepositorio alunoRepositorio = new AlunoRepositorio();
                //var alunos = alunoRepositorio.BuscarAluno();

                var alunos = _alunoRepositorio.BuscarAluno();
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
                //AlunoRepositorio alunoRepositorio = new AlunoRepositorio();
                //var aluno = alunoRepositorio.BuscarAlunoPorId(cpf);

                var aluno = _alunoRepositorio.BuscarAlunoPorId(cpf);
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
                //AlunoRepositorio alunoRepositorio = new AlunoRepositorio();
                //alunoRepositorio.SalvarAluno(cpf, nome, dataNascimento);

                _alunoRepositorio.SalvarAluno(cpf,nome , dataNascimento);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }

        }

    }
}

