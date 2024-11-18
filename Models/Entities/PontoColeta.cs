
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Reciicer.Models.Entities
{
    public class PontoColeta
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Local: ")]
        public string? Nome { get; set; }
        

        //Navigation
        public ICollection<Coleta> Coletas { get; set; }

    }
}