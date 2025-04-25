using Reciicer.Data;
using Reciicer.Models.Entities;
using Reciicer.Repository.Interface;

namespace Reciicer.Repository
{
    public class MaterialRepository : IMaterialRepository
    {

        private readonly AppDbContext _context;

        public MaterialRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Material> ListarMaterial()
        {
            return _context.Material.ToList();
        }

        public Material ObterMaterialPorId(int id)
        {
            return _context.Material.FirstOrDefault(m => m.Id == id)!;
        }

        public void RegistrarMaterial(Material material)
        {
            _context.Material.Add(material);
            _context.SaveChanges();
        }

        public void AtualizarMaterial(Material material)
        {
            var materialBd = _context.Material.Find(material.Id);

            if(materialBd != null)
            {
                materialBd.Nome = material.Nome;
                materialBd.Descricao = material.Descricao;
                materialBd.TempoDegradacao = material.TempoDegradacao;
                materialBd.PontuacaoPeso = material.PontuacaoPeso;
                materialBd.PontuacaoUnidade = material.PontuacaoUnidade;

                _context.Material.Update(materialBd);
                _context.SaveChanges();
            }
        }

        public void ExcluirMaterial(int id)
        {
            var materialBd = _context.Material.Find(id);

            if(materialBd is not null)
            {
                _context.Material.Remove(materialBd);
                _context.SaveChanges();
            }
        }

    }
}