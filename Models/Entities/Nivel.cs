using System;
using System.Collections.Generic;
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
        public string? Descricao { get; set; }

        public int PontuacaoNecessario { get; set; }

        public int PontosPerdaFrequencia { get; set; }

        public ICollection<Cliente>? Clientes { get; set; } // Navigation
    }
}