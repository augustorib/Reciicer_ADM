using System.ComponentModel.DataAnnotations;
using Reciicer.Models.Entities;

namespace Reciicer.Models.TipoMaterialViewModels
{
    public class TipoMaterialCreateView
    {
        public IEnumerable<Material> Material { get; set; }
        [Required]
        public TipoMaterial TipoMaterial { get; set; }
    }
}