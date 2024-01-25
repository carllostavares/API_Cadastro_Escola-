using Api_Escola.Application.Services;

using Api_Escola.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System;

namespace Api_Escola.Controllers
{
    [ApiController]
    [Route("Api/escola/alunos")]
    public class ProdutoController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public ActionResult<IEnumerable<Aluno>> BuscaAlunos()
        {
            AcessandoBanco.BuscandoDadosAluno();
            return Ok();
        }

    }


 }
