using ConsultaCovidAPI.Interface;
using ConsultaCovidAPI.Map;
using ConsultaCovidAPI.Model;
using CsvHelper.Configuration;
using CsvHelper;
using Newtonsoft.Json;
using System.Globalization;

namespace ConsultaCovidAPI.Services
{
    public class DadosService : IDadosService
    {
        private readonly ICSVService _csvService;

        public DadosService(ICSVService csvService)
        {
            _csvService = csvService;
        }


        public IEnumerable<T> MaiorIndiceMortalidade<T>(string municipio, DateTime data)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<T> MaisCasos<T>(string municipio, DateTime data)
        {
            throw new NotImplementedException();
        }
        IEnumerable<T> IDadosService.MaisObtos<T>(string UF)
        {

              var records = _csvService.ReadCSV<DadosPainel>();

            var registros = new List<DadosPainel>();

            var query = from record in records
                        where record.Estado == UF && record.ObitosAcumulado > 10000                      
                        select record;

            foreach (var item in query)
            {
                registros.Add(item);
            }

            return (IEnumerable<T>)registros;

        }
    }
}
