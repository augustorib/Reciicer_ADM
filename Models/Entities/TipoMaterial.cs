using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Reciicer.Models.Entities
{
    public class TipoMaterial
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Tipo Material")]
        public string? Nome { get; set; }

        [DisplayName("Descrição")]
        public string? Descricao { get; set; }

        [DisplayName("Tempo Degradação")]
        public int? TempoDegradacao { get; set; }

        public int MaterialId { get; set; }

        //Navigation
        public Material? Material { get; set; }

        public PontuacaoMaterial? PontuacaoMaterial { get; set; }

    }
}