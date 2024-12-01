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
        public DateTime DataOperacao { get; set;}

        [Required]
        [DisplayName("Pontuação")]
        public int PontuacaoGanha { get; set; }

        public int ClienteId { get; set; }
        public int PontoColetaId { get; set; }
            
        //Navigation
        public Cliente? Cliente { get; set; } 
        public PontoColeta? PontoColeta { get; set; }
        public ICollection<Material_Coleta>? Material_Coletas { get; set; }

        
    }
}