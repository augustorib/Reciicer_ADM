using System.ComponentModel.DataAnnotations;

namespace Reciicer.Models.Entities
{
    public class Premiacao
    {   
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; } = default!;

        [Required]
        public string Descricao { get; set; } = default!;
        public int PontuacaoRequerida { get; set; }
    
        public bool Ativo { get; set; }

        //Navigation
        public ICollection<ClientePremiacao>? ClientePremiacaos {get; set;} 


    }
}