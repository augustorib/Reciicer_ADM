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
        
        public string? CPF { get; set; } = default!;
        
        public string? CNPJ { get; set; } = default!;

        [DisplayName("Pontuação")]
        public int PontuacaoTotal { get; set; }

        public ICollection<Premiacao>? Premios { get; set; }
        public ICollection<Coleta>? Coletas { get; set; }


        public Cliente()
        {
            
        }
        
        public Cliente(string nome, string email, string telefone, string cpf = default!, string cnpj = default!)
        {
            Nome= nome;
            Email = email;
            Telefone = telefone;
            CPF = cpf;
            CNPJ = cnpj;
        }
    }
}