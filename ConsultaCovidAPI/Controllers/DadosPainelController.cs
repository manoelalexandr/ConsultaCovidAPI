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

        public DadosPainelController(ICSVService csvService)
        {
            _csvService = csvService;
        }

        [HttpGet("read-employees-csv")]

        public async Task<IActionResult> GetDadosCSV() 
        {
               
            return Ok(_csvService.ReadCSV<DadosPainel>());
        }

    }
}
