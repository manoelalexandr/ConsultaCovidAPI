﻿using ConsultaCovidAPI.Interface;
using ConsultaCovidAPI.Map;
using ConsultaCovidAPI.Model;
using CsvHelper.Configuration;
using CsvHelper;
using Newtonsoft.Json;
using System.Globalization;

namespace ConsultaCovidAPI.Services
{
    public class DadosService : IDadosService
    {
        private readonly ICSVService _csvService;

        public DadosService(ICSVService csvService)
        {
            _csvService = csvService;
        }

        public IEnumerable<T> MaiorIndiceMortalidade<T>(string UF, string data)
        {
            var records = _csvService.ReadCSV<DadosPainel>();

            var registros = new List<DadosPainel>();

            var query = (from record in records         
                         where record.Estado == UF && Convert.ToDateTime(record.Data) == Convert.ToDateTime(data)
                         && record.Municipio != ""
                         orderby (record.ObitosAcumulado / record.PopulacaoTCU2019) * 100000 descending
                         select record).Take(10);

            foreach (var item in query)
            {
                registros.Add(item);
            }

            return (IEnumerable<T>)registros;
        }
        public IEnumerable<T> MaisCasos<T>(string UF, string data)
        {
            var records = _csvService.ReadCSV<DadosPainel>();

            var registros = new List<DadosPainel>();

            var query = (from record in records
                         orderby record.CasosAcumulado descending
                         where record.Estado == UF && Convert.ToDateTime(record.Data) == Convert.ToDateTime(data)
                         && record.Municipio != ""
                         select record).Take(10);

            foreach (var item in query)
            {
                registros.Add(item);
            }

            return (IEnumerable<T>)registros;
        }
        IEnumerable<T> IDadosService.MaisObtos<T>(string UF, string data)
        {

            var records = _csvService.ReadCSV<DadosPainel>();

            var registros = new List<DadosPainel>();

            var query = (from record in records
                        orderby record.ObitosAcumulado descending
                        where record.Estado == UF && Convert.ToDateTime(record.Data) == Convert.ToDateTime(data) 
                        && record.Municipio != ""                
                        select record).Take(10);

            foreach (var item in query)
            {
                registros.Add(item);
            }

            return (IEnumerable<T>)registros;

        }
    }
}
