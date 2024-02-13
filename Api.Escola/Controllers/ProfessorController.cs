using Escola.Application.Interfaces;
using Escola.Application.Services;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;

namespace Api_Escola.Controllers
{
    [ApiController]
    [Route("api/professor")]
    public class ProfessorController : ControllerBase
    {
        private readonly IProfessorService _professorService;
        private readonly IEnderecoService _enderecoService;
        private readonly IIntegracaoCepService _integracaoCepService;

        public ProfessorController(IProfessorService professorService, IEnderecoService enderecoService,
            IIntegracaoCepService integracaoCepService)
        {
            _professorService = professorService;
            _enderecoService = enderecoService;
            _integracaoCepService = integracaoCepService;
        }

        [HttpGet("")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public IActionResult BuscaProfessores()
        {

            var Professores = _professorService.RetornarProfessor();

            return Ok(Professores);
        }

        [HttpGet("cpf")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public IActionResult BuscaProfessores(string cpf)
        {

            var retornoProfessor = _professorService.RetornarProfessorPorId(cpf);

            return Ok(retornoProfessor);
        }

        [HttpPost("")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public IActionResult SalvarProfessor(string nome, string cpf, string dataNascimento, string disciplina,
            string numeroCasa, string cep)
        {
            var meuCep = _integracaoCepService.RetornaCep(cep);

            if (meuCep == null)
            {
                return BadRequest("CEP não váliddo!");

            }
            meuCep.Numero = numeroCasa;
            meuCep.Cpf = cpf;

            _professorService.InserindoDadosProfessor(nome, cpf, dataNascimento, disciplina);
            _enderecoService.InserindoDadosEnderecoProfessor(meuCep);

            return StatusCode(StatusCodes.Status201Created, meuCep);
        }
    }


}
