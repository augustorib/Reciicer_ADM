using System.ComponentModel.DataAnnotations;

namespace Reciicer.Models.HomeViewModels
{
    public class HomeIndexViewModel
    {
        public int TotalCliente { get; set; }
        public int TotalColeta { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime DataUltimaColeta { get; set; }

    }
}