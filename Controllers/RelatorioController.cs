using Microsoft.AspNetCore.Mvc;
using Reciicer.Service.Cliente;
using FastReport;
using FastReport.Export.PdfSimple;
using Reciicer.Service.Coleta;
using Reciicer.Service.Premiacao;
using Microsoft.AspNetCore.Authorization;
using Reciicer.Service.PontoColeta;
using Reciicer.Service.Material_Coleta;
using Reciicer.Service.Material;


namespace Reciicer.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RelatorioController : Controller
    {
        private readonly ClienteService _clienteService;
        private readonly ColetaService _coletaService;
        private readonly PremiacaoService _premiacaoService;
        private readonly PontoColetaService _pontoColetaService;
        private readonly Material_ColetaService _material_Coleta;
        private readonly MaterialService _materialService;

        public RelatorioController(ClienteService clienteService,  ColetaService coletaService, PremiacaoService premiacaoService, PontoColetaService pontoColetaService,
                                   Material_ColetaService material_Coleta, MaterialService materialService)
        {
            _clienteService = clienteService;
            _coletaService = coletaService;
            _premiacaoService = premiacaoService;
            _pontoColetaService = pontoColetaService;
            _material_Coleta = material_Coleta;
            _materialService = materialService;
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
        // public IActionResult RelatorioRecolhimento()
        // {
            
        //     var clientes =_clienteService.ListarCliente();
        //     var coletas = _coletaService.ListarColeta();
        //     var premiacoes = _premiacaoService.ListarPremiacao();

        //     var reportsPath = Path.Combine(Directory.GetCurrentDirectory(), "Reports", "RelatorioRecolhimento.frx");
        //     var report = new Report();

        //     report.Load(reportsPath);

        //     report.Dictionary.RegisterData(clientes, "DS_Clientes", true);
        //     report.Dictionary.RegisterData(coletas, "DS_Coletas", true);
        //     report.Dictionary.RegisterData(premiacoes, "DS_Premiacoes", true);

        //     report.Prepare();
        
        //     using (var stream = new MemoryStream())
        //     {
        //         var pdfExport = new PDFSimpleExport();
        //         report.Export(pdfExport, stream);
        //         stream.Position = 0;
        //         stream.Flush();
        //         return File(stream.ToArray(), "application/pdf");
        //     }
        
        // }

        public IActionResult RelatorioRecolhimento()
        {
            
	        var pontoColetas = _pontoColetaService.ListarPontoColeta();
            //TODO: Verificar true = coleta recolhida
            //var coletas = _coletaService.ListarColeta().Where(c => c.Ativo = true);
            var coletas = _coletaService.ListarColeta();
            var materiaisColeta = _material_Coleta.ListarMaterialColeta();
            var materiais = _materialService.ListarMaterial();

            var reportsPath = Path.Combine(Directory.GetCurrentDirectory(), "Reports", "RecolhimentoTeste.frx");
            var report = new Report();
            
            report.Load(reportsPath);

            report.Dictionary.RegisterData(pontoColetas, "DS_PontoColeta",  true);
            report.Dictionary.RegisterData(coletas, "DS_Coleta",  true);
            report.Dictionary.RegisterData(materiaisColeta, "DS_MaterialColeta",  true);
            report.Dictionary.RegisterData(materiais, "DS_Material",  true);

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