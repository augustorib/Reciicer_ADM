using System.ComponentModel.DataAnnotations;


namespace Reciicer.Models.Entities
{
    public class Estoque
    {
        [Key]
        public int Id { get; set; }

        public string? Codigo { get; set; }

        public string? Tipo { get; set; }

        public int QuantidadeArmazenada { get; set; }
        public int PesoArmazenado { get; set; }
        
        public int Capacidade { get; set; }

        public int PontoColetaId { get; set; }


        public PontoColeta? PontoColeta { get; set; }

        public ICollection<EstoqueMaterial>? EstoqueMateriais { get; set; }

    }
}