using Escola.Application.Interfaces;
using Escola.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace api.Escola.Controllers
{
    [ApiController]
    [Route("api/materia")]
    public class MateriaController : ControllerBase
    {
        private readonly IMateriaService _materiaService;

        public MateriaController(IMateriaService materiaService)
        {
            _materiaService = materiaService;
        }

        [HttpPost("")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public IActionResult AdicionarMateria(int id, string nome, int cargaHoraria, string cpf)
        {
            _materiaService.InserirMateria(id, nome, cargaHoraria, cpf);

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpGet("")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public IActionResult BuscarMateria()
        {
            var materias = _materiaService.RetornaMateria();

            return Ok(materias);
        }
    }
}
