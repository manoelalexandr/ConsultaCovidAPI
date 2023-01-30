using ConsultaCovidAPI.Interface;
using ConsultaCovidAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ConsultaCovidAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DadosPainelController : ControllerBase
    {
        private readonly IDadosService _dadosService;

        public DadosPainelController(IDadosService dadosService)
        {
            _dadosService = dadosService;
        }
        [HttpGet("10-CIDADES-MAIS-OBTOS")]
        public async Task<IActionResult> GetMaisObtos(string UF, string data)
        {
            var dados = _dadosService.MaisObtos<DadosPainel>(UF, data);
            return Ok(dados);
        }

        [HttpGet("10-CIDADES-MAIS-CASOS")]
        public async Task<IActionResult> GetMaisCasos(string UF, string data)
        {
            var dados = _dadosService.MaisCasos<DadosPainel>(UF, data);
            return Ok(dados);
        }

        [HttpGet("10-CIDADES-MAIOR-MORTALIDADE")]
        public async Task<IActionResult> GetMaisMortalidade(string UF, string data)
        {
            var dados = _dadosService.MaiorIndiceMortalidade<DadosPainel>(UF, data);
            return Ok(dados);
        }

    }
}
