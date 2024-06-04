using Reciicer.Models.Entities;

namespace Reciicer.Models.PremiacaoViewModels
{
    public class PremiacaoCreateView
    {
        public IEnumerable<Nivel> Nivel { get; set; }

        public Premiacao Premiacao { get; set; }
    }
}