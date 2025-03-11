
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Reciicer.Models.Entities
{
    public class PontoColeta
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Local ")]
        public string? Nome { get; set; }
        
        public int EnderecoId { get; set; }

        //Navigation
        public Endereco? Endereco { get; set; }
        public ICollection<Recolhimento>? Recolhimentos { get; set; }
        public ICollection<UsuarioIdentity>? UsuarioIdentities { get; set; }
        public ICollection<Coleta>? Coletas { get; set; }

    }
}