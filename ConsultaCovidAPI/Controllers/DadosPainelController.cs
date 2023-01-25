using ConsultaCovidAPI.Model;
using ConsultaCovidAPI.Services;
using LINQtoCSV;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        [HttpPost("read-employees-csv")]
        public async Task<IActionResult> GetDadosCSV([FromForm] IFormFileCollection file)
        {
            var dados = _csvService.ReadCSV<DadosPainel>(file[0].OpenReadStream());

            return Ok(dados);
        }
    }
}
