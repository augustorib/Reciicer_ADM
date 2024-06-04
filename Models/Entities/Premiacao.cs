using System.ComponentModel.DataAnnotations;

namespace Reciicer.Models.Entities
{
    public class Premiacao
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }
        
        public bool Ativo { get; set; }

        public int NivelId { get; set; }

        public Nivel Nivel { get; set; }

    }
}