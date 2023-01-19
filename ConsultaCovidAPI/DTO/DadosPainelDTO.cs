using LINQtoCSV;
using ConsultaCovidAPI.Model;
using ConsultaCovidAPI.DTO;

namespace ConsultaCovidAPI.DTO
{
    public class DadosPainelDTO
    {

        public static void ReadCsvFile()
        {
            var csvFileDescription = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                IgnoreUnknownColumns = true,
                SeparatorChar = ';',
                UseFieldIndexForReadingData = false
            };

            var csvContext = new CsvContext();
            var dadosPainel = csvContext.Read<DadosPainel>("HIST_PAINEL_COVIDBR_2020_Parte1_16jan2023.csv", csvFileDescription);
        }
    }
}
