using Microsoft.AspNetCore.Mvc;
using Reciicer.Service.Cliente;
using FastReport;
using FastReport.Export.PdfSimple;
using Reciicer.Service.Coleta;
using Reciicer.Service.Premiacao;


namespace Reciicer.Controllers
{
    public class RelatorioController : Controller
    {
        private readonly ClienteService _clienteService;
        private readonly ColetaService _coletaService;
        private readonly PremiacaoService _premiacaoService;

        public RelatorioController(ClienteService clienteService,  ColetaService coletaService, PremiacaoService premiacaoService)
        {
            _clienteService = clienteService;
            _coletaService = coletaService;
            _premiacaoService = premiacaoService;
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
            
            var clientes =_clienteService.ListarCliente();
            var coletas = _coletaService.ListarColeta();
            var premiacoes = _premiacaoService.ListarPremiacao();

            var reportsPath = Path.Combine(Directory.GetCurrentDirectory(), "Reports", "RelatorioRecolhimento.frx");
            var report = new Report();

            report.Load(reportsPath);

            report.Dictionary.RegisterData(clientes, "DS_Clientes", true);
            report.Dictionary.RegisterData(coletas, "DS_Coletas", true);
            report.Dictionary.RegisterData(premiacoes, "DS_Premiacoes", true);

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