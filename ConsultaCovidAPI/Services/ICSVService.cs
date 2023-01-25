namespace ConsultaCovidAPI.Services
{
    public interface ICSVService
    {
        public IEnumerable<T> ReadCSV<T>(string file);
    }
}
