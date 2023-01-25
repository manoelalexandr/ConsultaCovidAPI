using ConsultaCovidAPI.Model;
using ConsultaCovidAPI.Services;
using LINQtoCSV;
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

        public DadosPainelController(ICSVService csvService)
        {
            _csvService = csvService;
        }

        [HttpGet("read-employees-csv")]
        //public async Task<IActionResult> GetDadosCSV([FromForm] IFormFileCollection file)
        //{
        //    var dados = _csvService.ReadCSV<DadosPainel>(file[0].OpenReadStream());

        //   return Ok(dados);
        //}

        public async Task<IActionResult> GetDadosCSV() 
        {
            
            var dados = _csvService.ReadCSV<DadosPainel>(@".. \Content\Files\HIST_PAINEL_COVIDBR_2020_Parte2_16jan2023test.csv");

            return Ok(dados);
        }

    }
}
