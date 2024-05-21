using Reciicer.Models.Entities;


namespace Reciicer.Models
{
    public class ReciclagemViewModel
    {
        public IEnumerable<Cliente>? Clientes { get; set; }
        public Reciclagem? Reciclagem { get; set; }
        public IEnumerable<Material>? Materiais { get; set; }  
        public Material_Reciclagem? Material_Reciclagem { get; set; }

        //Usar no asp-for dos selects
        public int ClienteId { get; set; }
        public int MaterialId { get; set; }
    }
}