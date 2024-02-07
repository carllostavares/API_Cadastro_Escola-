﻿using Escola.Application.Interfaces;
using Escola.Application.Services;
using Escola.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace api.Escola.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly IIntegracaoCepService _integracaoCepService;
        private readonly IEnderecoService _enderecoService;

        public EnderecoController(IIntegracaoCepService integracaoCepService,IEnderecoService enderecoService)
        {
            _integracaoCepService = integracaoCepService;
            _enderecoService = enderecoService;
        }

        [HttpPost("{cep}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public IActionResult SalvarEndereco(string cep,int numero)
        {

            var meuCep =  _integracaoCepService.RetornaCep(cep);

            if(meuCep == null)
            {
                return BadRequest("CEP não váliddo!");

            }
            meuCep.Numero = numero;
            _enderecoService.InserindoDadosEndereco(meuCep);

            return StatusCode(StatusCodes.Status201Created,meuCep);


        }

       /* [HttpGet("{cep}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Buscarndereco(string cep)
        {
            return Ok();

        }*/

    }
}
