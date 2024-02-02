using Escola.Application.Interfaces;
using Escola.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace api.Escola.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly IViaCepIntegracaoService _viaCepIntegracao;
        private readonly IEnderecoService _enderecoService;
        public EnderecoController(IViaCepIntegracaoService viaCepIntegracao,IEnderecoService enderecoService)
        {
             _viaCepIntegracao = viaCepIntegracao;
            _enderecoService = enderecoService;
        }

        [HttpPost("{cep}")]
        public async Task<ActionResult<Endereco>> RetornaEndereco(string cep)
        {

            var meuCep = await _viaCepIntegracao.RetornarDadosViaCep(cep);
            if(meuCep == null)
            {
                return BadRequest("CEP não váliddo!");

            }

            _enderecoService.InserindoDadosEndereco(meuCep);

            return StatusCode(StatusCodes.Status201Created,meuCep);

            //return (meuCep);

        }

    }
}
