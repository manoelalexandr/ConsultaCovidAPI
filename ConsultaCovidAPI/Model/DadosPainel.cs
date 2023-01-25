
namespace ConsultaCovidAPI.Model
{
    [Serializable]
    public class DadosPainel
    {
        public string? Regiao { get; set; }

        public string? Estado { get; set; }

        public string? Municipio { get; set; }

        public int Coduf { get; set; }

        public int Codmun { get; set; }

        public int CodRegiaoSaude { get; set; }

        public string? NomeRegiaoSaude { get; set; }

        public DateTime Data { get; set; }

        public int SemanaEpi { get; set; }

        public int PopulacaoTCU2019 { get; set; }

        public int CasosAcumulado { get; set; }

        public int CasosNovos { get; set; }

        public int ObitosAcumulado { get; set; }

        public int ObitosNovos { get; set; }

        public int Recuperadosnovos { get; set; }

        public int EmAcompanhamentoNovos { get; set; }

        public byte InteriorMetropolitana { get; set; }

}
    
}
