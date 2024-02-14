using Escola.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api.Escola.Controllers
{
    [ApiController]
    [Route("/api/classe")]
    public class ClasseController : ControllerBase
    {
        private readonly IClasseService _classeService;

        public ClasseController(IClasseService classeService)
        {
            _classeService = classeService;
        }

        [HttpPost("/classe")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public IActionResult AdicionaClasse(string sala, int idMateria, string cpfAluno) 

        {
            _classeService.InserirClass(sala, idMateria, cpfAluno);

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpGet("/classe")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public IActionResult RetornaAlunosDaClassePorSala(string sala)
        {
            var alunosDaClasse = _classeService.RetornaClassePorSala(sala);

            return Ok(alunosDaClasse);
        }
    }
}
