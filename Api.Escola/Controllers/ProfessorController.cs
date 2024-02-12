using Escola.Application.Interfaces;
using Escola.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api_Escola.Controllers
{
    [ApiController]
    [Route("api/professor")]
    public class ProfessorController : ControllerBase
    {
        private readonly IProfessorService _professorService;

        public ProfessorController(IProfessorService professorService)
        {
            _professorService = professorService;
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
        public IActionResult SalvarProfessor(string nome, string cpf, string dataNascimento, string disciplina)
        {

            _professorService.InserindoDadosProfessor(nome, cpf, dataNascimento, disciplina);

            return StatusCode(StatusCodes.Status201Created);
        }
    }


}
