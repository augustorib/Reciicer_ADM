

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Reciicer.Models.Entities
{
    public class Endereco
    {
        [Key]
        public int Id { get; set; }
        public string? Rua { get; set; }

        [Required]
        public string? Bairro { get; set; }

        [Required]
        [DisplayName("nº")]
        public int Numero { get; set; }
        public string? Cidade { get; set; }
        public string Estado { get; set; }

        [DisplayName("CEP ")]
        public string Cep { get; set; }

        
    }
}