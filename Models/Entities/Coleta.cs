using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Reciicer.Models.Entities
{
    public class Coleta
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Data Operação")]
        // [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime DataOperacao { get; set;}

        [Required]
        [DisplayName("Pontuação")]
        public int PontuacaoGanha { get; set; }

        public int ClienteId { get; set; }

        //Navigation
        public Cliente? Cliente { get; set; } 

        
    }
}