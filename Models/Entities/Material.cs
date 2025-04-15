using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Reciicer.Models.Entities
{
    public class Material : EntidadeBase
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Material")]
        public string? Nome { get; set; }

        [DisplayName("Descrição")]
        public string? Descricao { get; set; }

        [DisplayName("Degradação")]
        public int? TempoDegradacao { get; set; }
       
        [DisplayName("Pontos/peso(g)")]
        public int PontuacaoPeso { get; set; } = 0;
        [DisplayName("Pontos/unidade")]
        public int PontuacaoUnidade { get; set; } = 0;

        public int TipoMaterialId { get; set; }

        //Navigation
        public TipoMaterial? TipoMaterial { get; set; }
        public ICollection<Material_Coleta>? Material_Coletas { get; set; }
        public ICollection<EstoqueMaterial>? EstoqueMateriais { get; set; }

    }
}