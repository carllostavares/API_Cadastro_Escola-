using Escola.Application.Interfaces;
using Escola.Domain.Entities;
using Escola.Infraestrutura.Interfaces;

namespace Escola.Application.Services
{
    public class IntegreacaoCepService : IIntegracaoCepService
    {
        private readonly IIntegracaoCepRepositorio  _integracaoCepRepositorio;

            public IntegreacaoCepService(IIntegracaoCepRepositorio integracaoCepRepositorio)
        {
            _integracaoCepRepositorio = integracaoCepRepositorio;
        }
        public  Endereco RetornaCep(string cep)
        {
            try
            {
                var novoCep = _integracaoCepRepositorio.BuscarCep(cep);
                return novoCep;

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
        }
    }
}
