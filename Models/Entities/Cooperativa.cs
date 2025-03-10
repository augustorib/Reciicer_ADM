using System.ComponentModel.DataAnnotations;


namespace Reciicer.Models.Entities
{
    public class Cooperativa
    {
        [Key]
        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Email { get; set; }

        public string? CNPJ { get; set; }

        public ICollection<Recolhimento>? Recolhimentos { get; set; }
    }
}