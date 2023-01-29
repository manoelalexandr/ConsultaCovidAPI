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

            //Chama todos os dados de um CSV, precisa aprimorar pra chamar de todos os 5
            string path = @"C:\Users\manoe\source\repos\manoelalexandr\ConsultaCovidAPI\ConsultaCovidAPI\Content\Files\HIST_PAINEL_COVIDBR_2023_Parte1_16jan2023.csv";
            var reader = new StreamReader(path);
            var csv = new CsvReader(reader, config);

            csv.Context.RegisterClassMap<DadosMap>();

            var records = csv.GetRecords<DadosPainel>().ToList();

            return records;
        }
    }


}
