

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
        public DateTime DataOperacao { get; set;}

        [Required]
        [DisplayName("Pontuação")]
        public int PontuacaoGanha { get; set; }

        public int ClienteId { get; set; }

        public Cliente? Cliente { get; set; }
    }
}