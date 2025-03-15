using System.ComponentModel;
using Reciicer.Models.Entities;


namespace Reciicer.Models.ColetaViewModels
{
    public class ColetaCreateViewModel
    {
        public IEnumerable<Cliente>? Clientes { get; set; }
        public Coleta? Coleta { get; set; }
        public IEnumerable<Material>? Materiais { get; set; }  
        public IEnumerable<TipoMaterial>? TipoMateriais { get; set; }  

        public IEnumerable<Material_Coleta>? Material_Coletas { get; set; }  

        public int QtdMateriais { get; set; } = 1;
        public int ClienteId { get; set; }
        [DisplayName("Peso(g)")]
        public int Peso { get; set; }
        public int Quantidade { get; set; }
        public int MaterialId { get; set; }
        public int TipoMaterialId { get; set; }
        public int ColetaId { get; set; }
    

    }
}