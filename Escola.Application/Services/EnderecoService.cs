using Escola.Application.Interfaces;
using Escola.Domain.Entities;
using Escola.Infraestrutura.Interfaces;

namespace Escola.Application.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepositorio _enderecoRepositorio;

        public EnderecoService(IEnderecoRepositorio enderecoRepositorio)
        {
            _enderecoRepositorio = enderecoRepositorio;
        }

        public void InserindoDadosEnderecoAluno(Endereco endereco)
        {
            try{ 
         
              _enderecoRepositorio.SalvarEnderecoAluno(endereco);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }

        }

        public void InserindoDadosEnderecoProfessor(Endereco endereco)
        {
            try
            {

                _enderecoRepositorio.SalvarEnderecoProfessor(endereco);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }

        }

        public Endereco RetornaEnderecoPorCpf(string cpf)
        {
            try
            {
                Endereco endereco = _enderecoRepositorio.BuscarEnderecoPorCpf(cpf);

                return endereco;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
