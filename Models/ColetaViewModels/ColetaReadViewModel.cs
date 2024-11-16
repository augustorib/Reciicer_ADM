using Reciicer.Models.Entities;

namespace Reciicer.Models.ColetaViewModels
{
    public class ColetaReadViewModel
    {
      public Coleta? Coleta { get; set; }
      public IEnumerable<Material_Coleta>? Material_Coletas { get; set; }

    }
}