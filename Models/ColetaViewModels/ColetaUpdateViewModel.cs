
using Reciicer.Models.Entities;

namespace Reciicer.Models.ColetaViewModels
{
    public class ColetaUpdateViewModel
    {
        public Coleta? Coleta { get; set; }
        public IEnumerable<Material_Coleta>? Material_Coletas { get; set; }
        public IEnumerable<TipoMaterial>? TipoMateriais { get; set; }  

        
        //Request Post Form 
        public int MaterialId { get; set; }
        public int ColetaId { get; set; }
        public int Peso { get; set; }
        public int Quantidade { get; set; }
            
    }
}