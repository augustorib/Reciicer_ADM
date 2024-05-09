using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
    }
}