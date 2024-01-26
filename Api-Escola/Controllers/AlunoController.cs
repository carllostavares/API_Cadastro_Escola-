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
        [HttpGet("consultar_aluno")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public IActionResult BuscaAlunos(string nome, string cpf, DateTime dataNascimento)
        {
            AlunoService nomeQualquer = new AlunoService();

          // var aluno = nomeQualquer.BuscandoDadosAluno(nome, cpf, dataNascimento);

            return Ok();
        }

        [HttpPost("salvar_aluno")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public IActionResult SalvarAluno(string nome, string cpf, DateTime dataNascimento)
        {
            AlunoService nomeQualquer = new AlunoService();

            nomeQualquer.InserindoDadosAluno(nome, cpf, dataNascimento);

            return Ok();
        }
    }


}
