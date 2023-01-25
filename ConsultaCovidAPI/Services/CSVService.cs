using ConsultaCovidAPI.Map;
using CsvHelper;
using CsvHelper.Configuration;
using System.Formats.Asn1;
using System.Globalization;

namespace ConsultaCovidAPI.Services
{
    public class CSVService : ICSVService
    {
        public IEnumerable<T> ReadCSV<T>(string file)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";",
                HeaderValidated = null,
                Comment = '%'
            };

            var reader = new StreamReader(file);
            var csv = new CsvReader(reader, config);

            csv.Context.RegisterClassMap<DadosMap>();

            var records = csv.GetRecords<T>();
            return records;
        }
    }
}
