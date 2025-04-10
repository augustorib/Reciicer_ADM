using System.ComponentModel.DataAnnotations;


namespace Reciicer.Models.Entities
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Nome deve ser informado")]
        [MinLength(3, ErrorMessage ="Nome deve ter no mínimo 3 caracteres")]
        public string? Nome { get; set; }

        [Display(Name = "E-mail:")]
        [Required(ErrorMessage ="E-mail deve ser informado")]
        public string? Email { get; set; }

        [Required(ErrorMessage ="Telefone deve ser informado")]
        public string? Telefone { get; set; }
        
        public string? CPF { get; set; } = default!;
        
        public string? CNPJ { get; set; } = default!;

        [Display(Name ="Pontuação")]
        public int PontuacaoTotal { get; set; }
        public DateTime DataCadastro { get; set; }

        //Navigation
        public ICollection<ClientePremiacao>? ClientePremiacoes { get; set; }
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