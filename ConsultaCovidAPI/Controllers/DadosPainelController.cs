using ConsultaCovidAPI.Model;
using ConsultaCovidAPI.Services;
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

        public async Task<IActionResult> GetDadosCSV() 
        {
            string path = @"C:\Users\manoel.bizerra\source\repos\ConsultaCovidAPI\ConsultaCovidAPI\Content\Files\HIST_PAINEL_COVIDBR_2020_Parte2_16jan2023test.csv";
            var dados = _csvService.ReadCSV<DadosPainel>(path);
           
            return Ok(dados);
        }

    }
}
