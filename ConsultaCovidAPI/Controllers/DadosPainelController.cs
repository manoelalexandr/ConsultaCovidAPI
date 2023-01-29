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
        private readonly ICSVService _csvService;
        private readonly IDadosService _dadosService;

        public DadosPainelController(IDadosService dadosService)
        {
            _dadosService = dadosService;
        }

        [HttpGet("read-employees-csv")]

        public async Task<IActionResult> GetDadosCSV() 
        {
            var dados = _csvService.ReadCSV<DadosPainel>();
            return Ok(dados);
        }

        [HttpGet("GetMaisObtos")]
        public async Task<IActionResult> GetMaisObtos(string UF)
        {
            var dados = _dadosService.MaisObtos<DadosPainel>(UF);
            return Ok(dados);
        }

    }
}
