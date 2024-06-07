
using System.ComponentModel.DataAnnotations;

namespace Reciicer.Models.HomeViewModels
{
    public class HomeIndexViewModel
    {
        public int TotalCliente { get; set; }

        public int TotalReciclagem { get; set; }

        public IEnumerable<string> MateriaisNome { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime DataUltimaReciclagem { get; set; }
    }
}