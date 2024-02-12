using Escola.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_Escola.Controllers
{
    [ApiController]
    [Route("api/aluno")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _alunoService;
        private readonly IIntegracaoCepService _integracaoCepService;
        private readonly IEnderecoService _enderecoService;

        public AlunoController(IAlunoService alunoService, IIntegracaoCepService integracaoCepService,
            IEnderecoService enderecoService)
        {
            _alunoService = alunoService;
            _enderecoService = enderecoService;
            _integracaoCepService = integracaoCepService;
        }


        [HttpGet("")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public IActionResult BuscarAlunos()
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
        public IActionResult BuscarAlunosPorCpf(string cpf)
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
        public IActionResult SalvarAluno( string cpf, string nome, string dataNascimento, string cep, string numeroCasa)
        {
            //AlunoService novoAluno = new AlunoService();
            //novoAluno.InserindoDadosAluno(cpf, nome, dataNascimento);

            var meuCep = _integracaoCepService.RetornaCep(cep);

            if(meuCep == null)
            {
                return BadRequest("Cep inválido!");
            }

            meuCep.Cpf = cpf;
            meuCep.Numero = numeroCasa;
            
            _alunoService.InserindoDadosAluno(cpf, nome, dataNascimento);
            _enderecoService.InserindoDadosEnderecoAluno(meuCep);


            return StatusCode(StatusCodes.Status201Created);
        }
    }


}
