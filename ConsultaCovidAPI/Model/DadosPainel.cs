using LINQtoCSV;

namespace ConsultaCovidAPI.Model
{
    [Serializable]
    public class DadosPainel
    {
        [CsvColumn(Name ="regiao")]
        public string? Regiao { get; set; }

        [CsvColumn(Name = "estado")]
        public string? Estado { get; set; }

        [CsvColumn(Name = "municipio")]
        public string? Municipio { get; set; }

        [CsvColumn(Name = "coduf")]
        public int Coduf { get; set; }

        [CsvColumn(Name = "codmun")]
        public int Codmun { get; set; }

        [CsvColumn(Name = "codRegiaoSaude")]
        public int CodRegiaoSaude { get; set; }

        [CsvColumn(Name = "nomeRegiaoSaude")]
        public string? NomeRegiaoSaude { get; set; }

        [CsvColumn(Name = "data", OutputFormat = "dd-MM-yyyy")]
        public DateTime Data { get; set; }

        [CsvColumn(Name = "semanaEpi")]
        public int SemanaEpi { get; set; }

        [CsvColumn(Name = "populacaoTCU2019")]
        public int PopulacaoTCU2019 { get; set; }

        [CsvColumn(Name = "casosAcumulado")]
        public int CasosAcumulado { get; set; }

        [CsvColumn(Name = "casosNovos")]
        public int CasosNovos { get; set; }

        [CsvColumn(Name = "obitosAcumulado")]
        public int ObitosAcumulado { get; set; }

        [CsvColumn(Name = "obitosNovos")]
        public int ObitosNovos { get; set; }

        [CsvColumn(Name = "recuperadosnovos")]
        public int Recuperadosnovos { get; set; }

        [CsvColumn(Name = "emAcompanhamentoNovos")]
        public int EmAcompanhamentoNovos { get; set; }

        [CsvColumn(Name = "interior/metropolitana")]
        public byte InteriorMetropolitana { get; set; }

}
    
}
