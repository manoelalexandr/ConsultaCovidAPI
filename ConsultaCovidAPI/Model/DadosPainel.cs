
using CsvHelper.Configuration.Attributes;

namespace ConsultaCovidAPI.Model
{
    [Serializable]
    public class DadosPainel
    {
        [Index(0)]
        public string? Regiao { get; set; }
        [Index(1)]
        public string? Estado { get; set; }
        [Index(2)]
        public string? Municipio { get; set; }
        [Index(3)]
        public int? Coduf { get; set; }
        [Index(4)]
        public int? Codmun { get; set; }
        [Index(5)]
        public int? CodRegiaoSaude { get; set; }
        [Index(6)]
        public string? NomeRegiaoSaude { get; set; }
        [Index(7)]
        public string? Data { get; set; }
        [Index(8)]
        public int? SemanaEpi { get; set; }
        [Index(9)]
        public int? PopulacaoTCU2019 { get; set; }
        [Index(10)]
        public double CasosAcumulado { get; set; }
        [Index(11)]
        public int? CasosNovos { get; set; }
        [Index(12)]
        public int? ObitosAcumulado { get; set; }
        [Index(13)]
        public int? ObitosNovos { get; set; }
        [Index(14)]
        public int? Recuperadosnovos { get; set; }
        [Index(15)]
        public int? EmAcompanhamentoNovos { get; set; }
        [Index(16)]
        public int? InteriorMetropolitana { get; set; }

}
    
}
