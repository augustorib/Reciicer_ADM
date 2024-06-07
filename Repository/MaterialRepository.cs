using Reciicer.Data;
using Reciicer.Models.Entities;
using Reciicer.Models.HomeViewModels;
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
            return _context.Material.Find(id);
        }

        public void RegistrarMaterial(Material material)
        {
            _context.Material.Add(material);
            _context.SaveChanges();
        }

        public void AtualizarMaterial(Material material)
        {
            var materialDB = _context.Material.Find(material.Id);

            if(materialDB != null)
            {
                materialDB.Nome = material.Nome;
                materialDB.Descricao = material.Descricao;
                materialDB.Ativo = material.Ativo;

                _context.Material.Update(materialDB);
                _context.SaveChanges();
            }
        }

        public void ExcluirMaterial(int id)
        {
            var materialDB = _context.Material.Find(id);

            if(materialDB != null)
            {
                _context.Material.Remove(materialDB);
                _context.SaveChanges();
            }

        }

        public MaterialChart ObterNomeeQuantidadeMateriaisGrafico
//         Select 
// 	M.Nome, Count(Mr.Id) AS Quantidade
// FROM 
// 	Material M
// 	left JOIN Material_Reciclagem mr ON mr.MaterialId = m.id
// GROUP BY
// 	M.Nome, M.id
// ORDER BY 
// 	M.id

    }
}