using Api.Escola.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api_Escola.Controllers
{
    [ApiController]
    [Route("api/aluno")]
    public class EscolaController : ControllerBase
    {
        [HttpGet("buscar")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public IActionResult BuscaAlunos()
        {
            AlunoService aluno = new AlunoService();

            var alunos = aluno.RetornarAluno();

            return Ok(alunos);
        }

        [HttpGet("buscar/cpf")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public IActionResult BuscaAlunos(string cpf)
        {
            AlunoService aluno = new AlunoService();

            var retornoAluno =aluno.RetornarAlunoPorId(cpf);

            return Ok(retornoAluno);
        }

        [HttpPost("buscar")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public IActionResult SalvarAluno(string nome, string cpf, DateTime dataNascimento)
        {
            AlunoService novoAluno = new AlunoService();

            novoAluno.InserindoDadosAluno(nome, cpf, dataNascimento);

            return Ok();
        }
    }


}
