using Reciicer.Models.Entities;

namespace Reciicer.Models.ClienteViewModels
{
    public class ClienteNivelPremiacaoViewModel
    {
        public IEnumerable<Cliente>? Clientes { get; set;}

        public IEnumerable<Nivel>? Niveis { get; set; }

        public Cliente? Cliente { get; set; }

        public int NivelId { get; set; }
    }
}