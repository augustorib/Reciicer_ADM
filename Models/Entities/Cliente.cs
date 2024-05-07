using System.ComponentModel.DataAnnotations;


namespace Reciicer.Models.Entities
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Nome { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Telefone { get; set; }

        [Required]
        public string? CPF { get; set; }

        
        public int NivelId { get; set; }
        public Nivel? Nivel { get; set; }// Navigation
    }
}