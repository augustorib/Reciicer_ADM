

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Reciicer.Models.Entities
{
    public class Reciclagem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Data Realizada")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime DataOperacao { get; set;}

        [Required]
        [DisplayName("Pontuação")]
        public int PontuacaoGanha { get; set; }

        public int ClienteId { get; set; }

        //Navigation
        public Cliente? Cliente { get; set; } 

        public ICollection<Material_Reciclagem>? Material_Reciclagems { get; set; }
    }
}