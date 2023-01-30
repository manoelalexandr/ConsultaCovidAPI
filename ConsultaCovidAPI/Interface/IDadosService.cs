namespace ConsultaCovidAPI.Interface
{
    public interface IDadosService
    {
        public IEnumerable<T> MaisCasos<T> (String UF, string data);
        public IEnumerable<T> MaisObtos<T>(string UF, string data);
        public IEnumerable<T> MaiorIndiceMortalidade<T>(String municipio, DateTime data);

    }
}
