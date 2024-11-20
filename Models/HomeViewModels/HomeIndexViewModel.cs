using Reciicer.Models.Entities;

namespace Reciicer.Models.HomeViewModels
{
    public class HomeIndexViewModel
    {
        public int TotalCliente { get; set; }
        
        public int TotalColeta { get; set; }   
        public string? DataUltimaColeta { get; set; }

        public IEnumerable<TipoMaterialQuantidadeChart>? TipoMaterialQuantidadeCharts { get; set; }

        public IEnumerable<Cliente>? Top10Clientes { get; set; }

    }
}