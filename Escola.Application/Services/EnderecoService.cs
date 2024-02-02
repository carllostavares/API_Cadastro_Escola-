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

        public void InserindoDadosEndereco(Endereco endereco)
        {
            try{ 
         
              _enderecoRepositorio.SalvarEndereco(endereco);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }

        }
    }
}
