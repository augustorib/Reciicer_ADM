using Reciicer.Models.Entities;


namespace Reciicer.Models
{
    public class ReciclagemCreateViewModel
    {
        public IEnumerable<Cliente>? Clientes { get; set; }
        public Reciclagem? Reciclagem { get; set; }
        public IEnumerable<Material>? Materiais { get; set; }  
        public List<Material_Reciclagem>? Material_Reciclagem { get; set; } = new List<Material_Reciclagem>();

        public int QtdMateriais { get; set; } = 1;
        public int ClienteId { get; set; }

        public int Peso { get; set; }

        public int Quantidade { get; set; }
        public int MaterialId { get; set; }
    }
}