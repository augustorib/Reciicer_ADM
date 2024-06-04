using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Reciicer.Models.Entities
{
    public class Nivel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Nível")]
        public string? Descricao { get; set; }

        [DisplayName("Pontuação Necessária")]
        public int PontuacaoNecessario { get; set; }

        [DisplayName("Penalidade")]
        public int PontosPerdaFrequencia { get; set; }

        public ICollection<Cliente>? Clientes { get; set; } // Navigation
        public Premiacao Premiacao { get; set; } // Navigation
    }
}