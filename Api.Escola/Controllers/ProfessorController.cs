using Escola.Application.Interfaces;
using Escola.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api_Escola.Controllers
{
    [ApiController]
    [Route("api/professor")]
    public class ProfessorController : ControllerBase
    {
        [HttpGet("")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public IActionResult BuscaProfessores()
        {
            ProfessorService professor = new ProfessorService();

            var Professores = professor.RetornarProfessor();

            return Ok(Professores);
        }

        [HttpGet("cpf")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public IActionResult BuscaProfessores(string cpf)
        {
            ProfessorService professor = new ProfessorService();

            var retornoProfessor = professor.RetornarProfessorPorId(cpf);

            return Ok(retornoProfessor);
        }

        [HttpPost("")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public IActionResult SalvarProfessor(string nome, string cpf, string dataNascimento, string disciplina)
        {
            ProfessorService novoProfessor = new ProfessorService();

            novoProfessor.InserindoDadosProfessor(nome, cpf, dataNascimento, disciplina);

            return StatusCode(StatusCodes.Status201Created);
        }
    }


}
