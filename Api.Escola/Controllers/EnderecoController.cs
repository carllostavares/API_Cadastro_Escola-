using Escola.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api.Escola.Controllers
{
    [Route("api/endereco")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly IIntegracaoCepService _integracaoCepService;
        private readonly IEnderecoService _enderecoService;

        public EnderecoController(IIntegracaoCepService integracaoCepService,IEnderecoService enderecoService)
        {
            _integracaoCepService = integracaoCepService;
            _enderecoService = enderecoService;
        }

       /* [HttpPost("aluno")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public IActionResult SalvarEnderecoAluno(string cep,string numero,string cpf)
        {

            var meuCep =  _integracaoCepService.RetornaCep(cep);

            if(meuCep == null)
            {
                return BadRequest("CEP não váliddo!");

            }

            meuCep.Numero = numero;
            meuCep.Cpf = cpf;
            _enderecoService.InserindoDadosEnderecoAluno(meuCep);

            return StatusCode(StatusCodes.Status201Created,meuCep);


        }*/

        [HttpPost("professor")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public IActionResult SalvarEnderecoProfessor(string cep, string numero, string cpf)
        {

            var meuCep = _integracaoCepService.RetornaCep(cep);

            if (meuCep == null)
            {
                return BadRequest("CEP não váliddo!");

            }
            meuCep.Numero = numero;
            meuCep.Cpf = cpf;
            _enderecoService.InserindoDadosEnderecoProfessor(meuCep);

            return StatusCode(StatusCodes.Status201Created, meuCep);


        }

        [HttpGet("cpf")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult BuscarEnderecoPorCpf(string cpf)
        {

            var endereco = _enderecoService.RetornaEnderecoPorCpf(cpf);

            return Ok(endereco);
        }

    }
}
