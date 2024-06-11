using System.ComponentModel.DataAnnotations;
using Reciicer.Models.Entities;

namespace Reciicer.Models.HomeViewModels
{
    public class HomeIndexViewModel
    {
        public int TotalCliente { get; set; }

        public int TotalReciclagem { get; set; }

        public IEnumerable<string> MateriaisNome { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime DataUltimaReciclagem { get; set; }

        public IEnumerable<MaterialQuantidadeChart> chartMaterials { get; set; }

        public IEnumerable<Cliente> Clientes { get; set; }
    }
}