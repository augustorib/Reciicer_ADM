

namespace Reciicer.Models.RelatorioViewModels
{
    public class RecolhimentoReport
    {
        public string Nome { get; set; }
        public DateTime DataRecolhimento { get; set; }
        public string Descricao { get; set; }
        public int Peso { get; set; }
        public int Quantidade { get; set; }
    }
}