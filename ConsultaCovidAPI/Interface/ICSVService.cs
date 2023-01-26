namespace ConsultaCovidAPI.Interface
{
    public interface ICSVService
    {
        public IEnumerable<T> ReadCSV<T>();
    }
}
