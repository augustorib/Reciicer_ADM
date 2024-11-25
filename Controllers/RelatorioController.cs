using Microsoft.AspNetCore.Mvc;
using Reciicer.Service.Cliente;
using FastReport;
using FastReport.Export.PdfSimple;



namespace Reciicer.Controllers
{
    public class RelatorioController : Controller
    {
        private readonly ClienteService _clienteService;

        public RelatorioController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }
        
        public IActionResult Report()
        {
            // Carregar o relatório
            var clientes = _clienteService.ListarCliente();

            var report = new Report();
            var reportsPath = Path.Combine(Directory.GetCurrentDirectory(), "Reports", "ClientePontuacao.frx");

            report.Load(reportsPath);
            report.RegisterData(clientes, "Clientes");
            // Configurar a fonte de dados
            report.Report.Save(reportsPath);
            
            
            //como carregar o relaotiro com informaççoe do negocio por ler o arquivo e passar para o report
            return Ok("Relatório gerado com sucesso");
            

            // // Preparar o relatório
            // report.Prepare();

            // // Exportar para PDF
            // using (var stream = new MemoryStream())
            // {
            //     var pdfExport = new PDFSimpleExport();
            //     report.Export(pdfExport, stream);
            //     stream.Position = 0;
            //     return File(stream.ToArray(), "application/pdf", "ClentePontuacao.pdf");
            // }


        }
    }

}