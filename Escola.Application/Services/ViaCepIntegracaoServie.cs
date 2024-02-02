using Escola.Application.Interfaces;
using Escola.Domain.Entities;
using Escola.Infraestrutura.Interfaces;

namespace Escola.Application.Services
{
    public class ViaCepIntegracaoServie : IViaCepIntegracaoService
    {
        private readonly IViaCepIntegracaoRefilt _viaCepIntegracaoRefilt;
        public ViaCepIntegracaoServie(IViaCepIntegracaoRefilt viaCepIntegracaoRefilt)
        {
            _viaCepIntegracaoRefilt = viaCepIntegracaoRefilt;
        }

        public async Task<Endereco> RetornarDadosViaCep(string cep)
        {
           var responseData = await _viaCepIntegracaoRefilt.ObterDadosViaCep(cep);

            if (responseData != null && responseData.IsSuccessStatusCode)
            {
                return responseData.Content;
            }

            return null;
        }
    }
}
