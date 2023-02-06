namespace ConsultaCovidAPI.Services
{
    public class ImportarCSV
    {
//        using System;
//using System.IO;
//using Covid.Api.Contexts;
//using Covid.Api.Services.Interfaces;
//using Covid.Api.Services.Jobs.Interfaces;
//using Microsoft.Extensions.Logging;
//using PuppeteerSharp;

//namespace Covid.Api.Services.Jobs
//    {
//        public class DownloadDatabaseJob : IDownloadDatabaseJob
//        {
//            private readonly ILogger<DownloadDatabaseJob> logger;
//            private readonly PostgresContext context;
//            private readonly IDatabaseService databaseService;
//            private string filePath = "./tmp";

//            public DownloadDatabaseJob(ILogger<DownloadDatabaseJob> logger,
//            PostgresContext context,
//            IDatabaseService databaseService)
//            {
//                this.logger = logger;
//                this.context = context;
//                this.databaseService = databaseService;
//            }

//            public void Execute()
//            {
//                logger.LogInformation("Baixando o Chromium...");

//                // Baixa o executável do Chrome.
//                var revision = new BrowserFetcher()
//                .DownloadAsync(BrowserFetcher.DefaultRevision).Result;

//                if (!Directory.Exists(filePath))
//                    Directory.CreateDirectory(filePath);

//                logger.LogInformation("Removendo arquivos temporários antigos...");
//                this.CleanDownloadDirectory();

//                var browser = Puppeteer.LaunchAsync(
//                    new LaunchOptions
//                    {
//                        Headless = true,
//                        ExecutablePath = revision.ExecutablePath,
//                        Args = new string[] { "--no-sandbox" }
//                    })
//                .Result;

//                logger.LogInformation("Acessando o painel do Governo Federal...");
//                var page = ((browser.PagesAsync().Result)[0]);

//                page.Client.SendAsync("Page.setDownloadBehavior", new
//                {
//                    behavior = "allow",
//                    downloadPath = filePath,
//                }).Wait();

//                logger.LogInformation("Realizando o download da base de dados..");
//                page.GoToAsync("https://covid.saude.gov.br").Wait();
//                page.ClickAsync("ion-button.btn-outline").Wait();

//                page.WaitForTimeoutAsync(15000).Wait();

//                browser.CloseAsync().Wait();

//                logger.LogInformation("Download concluído! Solicitando o processamento...");
//                databaseService.ProcessDatabase();
//            }

//            public void CleanDownloadDirectory()
//            {
//                foreach (var file in Directory.EnumerateFiles(filePath))
//                {
//                    File.Delete(file);
//                }
//            }
//        }
//    }
 }
}
