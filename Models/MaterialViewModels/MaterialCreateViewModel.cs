using Reciicer.Models.Entities;

namespace Reciicer.Models.MaterialViewModels
{
    public class MaterialCreateViewModel
    {
        public IEnumerable<TipoMaterial>? TipoMateriais { get; set; }
        public Material? Material { get; set; }

    }
}