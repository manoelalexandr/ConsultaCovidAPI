using ConsultaCovidAPI.DTO;
using ConsultaCovidAPI.Model;
using LINQtoCSV;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsultaCovidAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DadosPainelController : ControllerBase
    {
        private readonly ILogger<DadosPainelController> _logger;

        public DadosPainelController(ILogger<DadosPainelController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<DadosPainel> BuscaTodosOsDados()
        {
             var dados = DadosPainelDTO.ReadCsvFile();
            return dados;
        }
    }
}
