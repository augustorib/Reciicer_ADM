using Microsoft.AspNetCore.Mvc;
using Reciicer.Service.Cliente;
using FastReport;
using FastReport.Export.PdfSimple;
using Microsoft.AspNetCore.Authorization;
using Reciicer.Service.Relatorio;



namespace Reciicer.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RelatorioController : Controller
    {
        private readonly ClienteService _clienteService;
        private readonly RelatorioService _relatorioService;

        
        public RelatorioController(ClienteService clienteService, RelatorioService relatorioService)
        {
            _clienteService = clienteService;
            _relatorioService = relatorioService;
            
        }
        
        public IActionResult RelatorioPontuacao()
        {
            var clientes =_clienteService.ListarCliente();
        
            var reportsPath = Path.Combine(Directory.GetCurrentDirectory(), "Reports", "ClientePontuacao.frx");
            var report = new Report();

            report.Load(reportsPath);

            report.Dictionary.RegisterData(clientes, "Clientes", true);

            report.Prepare();
        
            using (var stream = new MemoryStream())
            {
                var pdfExport = new PDFSimpleExport();
                report.Export(pdfExport, stream);
                stream.Position = 0;
                
                return File(stream.ToArray(), "application/pdf");
            }
        
        }

        public IActionResult RelatorioRecolhimento()
        {
        
            var dadosRelatorio = _relatorioService.RelatorioRecolhimento();

            var reportsPath = Path.Combine(Directory.GetCurrentDirectory(), "Reports", "RecolhimentoNovo.frx");
            var report = new Report();
            
            report.Load(reportsPath);

            report.Dictionary.RegisterData(dadosRelatorio, "DS_Recolhimento",  true);

            report.Prepare();

            using (var stream = new MemoryStream())
            {
                var pdfExport = new PDFSimpleExport();
                report.Export(pdfExport, stream);
                stream.Position = 0;
                stream.Flush();
                return File(stream.ToArray(), "application/pdf");
            }

        }

    }

}