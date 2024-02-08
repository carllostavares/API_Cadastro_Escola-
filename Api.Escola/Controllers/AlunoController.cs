using Escola.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_Escola.Controllers
{
    [ApiController]
    [Route("api/aluno")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _alunoService;

        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }


        [HttpGet("")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public IActionResult BuscaAlunos()
        {
            //AlunoService aluno = new AlunoService();
            //var alunos = aluno.RetornarAluno();

            var alunos = _alunoService.RetornarAluno();
            return Ok(alunos);
        }

        [HttpGet("cpf")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public IActionResult BuscaAlunos(string cpf)
        {
            //AlunoService aluno = new AlunoService();
            //var retornoAluno =aluno.RetornarAlunoPorId(cpf);
            var retornoAluno = _alunoService.RetornarAlunoPorId(cpf);
            return Ok(retornoAluno);
        }

        [HttpPost("")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public IActionResult SalvarAluno( string cpf, string nome, string dataNascimento)
        {
            //AlunoService novoAluno = new AlunoService();
            //novoAluno.InserindoDadosAluno(cpf, nome, dataNascimento);
            
            _alunoService.InserindoDadosAluno(cpf, nome, dataNascimento);

            return StatusCode(StatusCodes.Status201Created);
        }
    }


}
