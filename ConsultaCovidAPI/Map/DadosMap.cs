using ConsultaCovidAPI.Model;
using CsvHelper.Configuration;

namespace ConsultaCovidAPI.Map
{
    public class DadosMap : ClassMap<DadosPainel>
    {
        public DadosMap()
        {
            Map(p => p.Regiao).Index(0);
            Map(p => p.Estado).Index(1);
            Map(p => p.Municipio).Index(2);
            Map(p => p.Coduf).Index(3);
            Map(p => p.Codmun).Index(4);
            Map(p => p.CodRegiaoSaude).Index(5);
            Map(p => p.NomeRegiaoSaude).Index(6);
            Map(p => p.Data).Index(7);
            Map(p => p.SemanaEpi).Index(8);
            Map(p => p.PopulacaoTCU2019).Index(9);
            Map(p => p.CasosAcumulado).Index(10);
            Map(p => p.CasosNovos).Index(11);
            Map(p => p.ObitosAcumulado).Index(12);
            Map(p => p.ObitosNovos).Index(13);
            Map(p => p.Recuperadosnovos).Index(14);
            Map(p => p.EmAcompanhamentoNovos).Index(15);
            Map(p => p.InteriorMetropolitana).Index(16);
        }
    }
}
