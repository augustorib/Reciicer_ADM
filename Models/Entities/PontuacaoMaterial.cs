using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Reciicer.Migrations;


namespace Reciicer.Models.Entities
{
    public class PontuacaoMaterial
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Pontos por Peso")]
        public int PontuacaoPeso { get; set; }

        [DisplayName("Pontos por Unidade")]
        public int PontuacaoUnidade { get; set; }

        public int TipoMaterialId { get; set; }


        //Navigation
        public  TipoMaterial? TipoMaterial { get; set; }
    }
}