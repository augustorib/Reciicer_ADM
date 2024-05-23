

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Reciicer.Models.Entities
{
    public class Material
    {   

        [Key]
        public int Id { get; set; }

        [DisplayName("Material")]
        [Required]
        public string? Nome { get; set; }

        [Required]
        public string? Descricao { get; set; }

        public bool Ativo { get; set; } = true;

        //Navigation
        public ICollection<Material_Reciclagem>? Material_Reciclagems { get; set; }
    }
}