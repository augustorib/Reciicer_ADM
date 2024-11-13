using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Reciicer.Models.Entities
{
    public class Material
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Material")]
        public string? Nome { get; set; }

        [DisplayName("Descrição")]
        public string? Descricao { get; set; }

        [DisplayName("Tempo Degradação")]
        public int? TempoDegradacao { get; set; }
       
        public int PontuacaoPeso { get; set; } = 0;
        public int PontuacaoUnidade { get; set; } = 0;

    }
}