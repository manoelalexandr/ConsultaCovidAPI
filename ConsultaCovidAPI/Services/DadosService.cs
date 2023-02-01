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

        public IEnumerable<T> MaiorIndiceMortalidade<T>(string UF, string data)
        {
            var records = _csvService.ReadCSV<DadosPainel>();

            //var query = (from record in records
            //            orderby record.IndiceMortalidade descending
            //            where record.Estado == UF && Convert.ToDateTime(record.Data) == Convert.ToDateTime(data)
            //             && record.Municipio != ""
            //             select record).Take(10);

            var query2 = records
                .Where(x => x.Estado == UF && Convert.ToDateTime(x.Data) == Convert.ToDateTime(data) && x.Municipio != "")
                .OrderByDescending(x => x.IndiceMortalidade)
                //.Select(x => x.IndiceMortalidade)
                .Take(10);

            return (IEnumerable<T>)query2;
        }
        public IEnumerable<T> MaisCasos<T>(string UF, string data)
        {
            var records = _csvService.ReadCSV<DadosPainel>();

            var query = (from record in records
                         orderby record.CasosAcumulado descending
                         where record.Estado == UF && Convert.ToDateTime(record.Data) == Convert.ToDateTime(data)
                         && record.Municipio != ""
                         select record).Take(10);

            return (IEnumerable<T>)query;
        }
        IEnumerable<T> IDadosService.MaisObtos<T>(string UF, string data)
        {

            var records = _csvService.ReadCSV<DadosPainel>();

            var query = (from record in records
                        orderby record.ObitosAcumulado descending
                        where record.Estado == UF && Convert.ToDateTime(record.Data) == Convert.ToDateTime(data) 
                        && record.Municipio != ""                
                        select record).Take(10);

            return (IEnumerable<T>)query;

        }
    }
}
