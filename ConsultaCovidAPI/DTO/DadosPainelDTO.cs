using LINQtoCSV;
using ConsultaCovidAPI.Model;
using ConsultaCovidAPI.DTO;


namespace ConsultaCovidAPI.DTO
{
    public class DadosPainelDTO
    {

        public static List<DadosPainel> ReadCsvFile()
        {
            var csvFileDescription = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                IgnoreUnknownColumns = true,
                SeparatorChar = ';',
                UseFieldIndexForReadingData = false
            };

            var csvContext = new CsvContext();

            var dadosPainel = csvContext.Read<DadosPainel>(@"C:\HIST_PAINEL_COVIDBR_2020_Parte1_16jan2023.csv", csvFileDescription).ToList(); 
            return (List<DadosPainel>)dadosPainel;
        }
    }
}
