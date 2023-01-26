using ConsultaCovidAPI.Interface;
using ConsultaCovidAPI.Map;
using ConsultaCovidAPI.Model;
using CsvHelper;
using CsvHelper.Configuration;
using System.Formats.Asn1;
using System.Globalization;

namespace ConsultaCovidAPI.Services
{
    public class CSVService : ICSVService
    {
        public IEnumerable<DadosPainel> ReadCSV<DadosPainel>()
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";",
                HeaderValidated = null,
                Comment = '%'
            };

            string path = @"C:\Users\manoel.bizerra\source\repos\ConsultaCovidAPI\ConsultaCovidAPI\Content\Files\HIST_PAINEL_COVIDBR_2020_Parte2_16jan2023test2.csv";
            var reader = new StreamReader(path);
            var csv = new CsvReader(reader, config);

            csv.Context.RegisterClassMap<DadosMap>();

            var records = csv.GetRecords<DadosPainel>();

            return records;
        }
    }
}
