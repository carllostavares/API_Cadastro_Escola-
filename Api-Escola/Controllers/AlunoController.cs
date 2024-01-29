using Api_Escola.Application.Services;

using Api_Escola.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System;

namespace Api_Escola.Controllers
{
    [ApiController]
    [Route("api/escola")]
    public class EscolaController : ControllerBase
    {
        [HttpGet("aluno")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public IActionResult BuscaAlunos()
        {
            AlunoService aluno = new AlunoService();

            var alunos = aluno.RetornarAluno();

            return Ok(alunos);
        }

        [HttpGet("aluno/id")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public IActionResult BuscaAlunos(string cpf)
        {
            AlunoService aluno = new AlunoService();

            var retornoAluno =aluno.RetornarAlunoPorId(cpf);

            return Ok(retornoAluno);
        }

        [HttpPost("aluno")]
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
