using ConsultaCovidAPI.Interface;

namespace ConsultaCovidAPI.Services
{
    public class DadosService : IDadosService
    {

        public IEnumerable<T> MaiorIndiceMortalidade<T>(string municipio, DateTime data)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> MaisCasos<T>(string municipio, DateTime data)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> MaisObtos<T>(string municipio, DateTime data)
        {
            throw new NotImplementedException();
        }
    }
}
