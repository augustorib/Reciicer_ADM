using Reciicer.Models.Entities;

namespace Reciicer.Models.HomeViewModels
{
    public class HomeIndexViewModel
    {
        public int TotalCliente { get; set; }
        
        public int TotalColeta { get; set; }   
        public string? DataUltimaColeta { get; set; }
        public int[] ultimosAnos { get; set; } = { 2023, 2024, 2025 };
        public int AnoSelecionado { get; set; }
        public IEnumerable<TipoMaterialQuantidadeChart>? TipoMaterialQuantidadeCharts { get; set; }
        public IEnumerable<ClientePorMes>? ClientePorMes { get; set; }
        public IEnumerable<ColetasPorMes>? ColetasPorMes { get; set; }
        public IEnumerable<Cliente>? Top10Clientes { get; set; }

        

    }
}