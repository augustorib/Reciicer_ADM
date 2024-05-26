using Reciicer.Models.Entities;

namespace Reciicer.Models.PontuacaoMaterialViewModels
{
    public class PontuacaoMaterialCreateViewModel
    {
        public IEnumerable<TipoMaterial> TipoMaterial { get; set; }

        public PontuacaoMaterial PontuacaoMaterial { get; set; }
    }
}