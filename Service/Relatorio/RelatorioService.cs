using Microsoft.EntityFrameworkCore;
using Reciicer.Data;
using Reciicer.Models.RelatorioViewModels;

namespace Reciicer.Service.Relatorio
{
    public class RelatorioService
    {
        private readonly AppDbContext _context;
    
        public RelatorioService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<RecolhimentoReport> RelatorioRecolhimento()
        {

            var query = @"
                        Select 
                            PC.Nome, R.DataRecolhimento, M.Descricao, REM.Peso, REM.Quantidade
                        From 
                            Recolhimento R
                            JOIN RecolhimentoEstoqueMaterial REM ON R.id = REM.RecolhimentoId
                            JOIN EstoqueMaterial EM ON REM.EstoqueMaterialId = EM.Id
                            JOIN Estoque E ON  E.Id = EM.EstoqueId
                            JOIN PontoColeta PC ON PC.id = E.PontoColetaId
                            JOIN Material M ON M.id = EM.MaterialId";

            return _context.Database.SqlQueryRaw<RecolhimentoReport>(query).ToList();
        }
    }
}