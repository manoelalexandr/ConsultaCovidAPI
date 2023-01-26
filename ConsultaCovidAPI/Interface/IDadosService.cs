namespace ConsultaCovidAPI.Interface
{
    public interface IDadosService
    {
        public IEnumerable<T> MaisCasos<T> (String municipio, DateTime data);
        public IEnumerable<T> MaisObtos<T>(String municipio, DateTime data);
        public IEnumerable<T> MaiorIndiceMortalidade<T>(String municipio, DateTime data);

    }
}
