using System.ComponentModel;
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

        [DisplayName("Pontuação")]
        public int PontuacaoTotal { get; set; }
        public int NivelId { get; set; }
        public Nivel? Nivel { get; set; }// Navigation
        public ICollection<Reciclagem>? Reciclagems { get; set; }// Navigation

        public Cliente()
        {
            
        }
        
        public Cliente(string nome, string email, string telefone, string cpf, int nivelId = 1)
        {
            Nome= nome;
            Email = email;
            Telefone = telefone;
            CPF = cpf;
            NivelId = nivelId;
        }
    }
}