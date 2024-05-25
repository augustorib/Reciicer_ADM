using Microsoft.EntityFrameworkCore;
using Reciicer.Data;
using Reciicer.Models.Entities;
using Reciicer.Models.TipoMaterialViewModels;
using Reciicer.Repository.Interface;

namespace Reciicer.Repository
{
    public class TipoMaterialRepository : ITipoMaterialRepository
    {

        private readonly AppDbContext _context;

        public TipoMaterialRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<TipoMaterial> ListarTipoMaterial()
        {
            return _context.TipoMaterial.Include(t => t.Material).ToList();
        }

        public void RegistrarTipoMaterial(TipoMaterial tipoMaterial)
        {
            _context.TipoMaterial.Add(tipoMaterial);
            _context.SaveChanges();
        }

        public TipoMaterial ObterTipoMaterialPorId(int id)
        {
            return _context.TipoMaterial.Include(t => t.Material).FirstOrDefault(t => t.Id == id);
        }

        public void AtualizarTipoMaterial(TipoMaterialCreateView tipoMaterialCreateView)
        {
            var tipoMaterialDB = _context.TipoMaterial.Find(tipoMaterialCreateView.TipoMaterial.Id);
             

             Console.WriteLine(1);
             Console.WriteLine(tipoMaterialCreateView.TipoMaterial.Id);
             Console.WriteLine(2);

            if(tipoMaterialDB != null)
            {
                tipoMaterialDB.MaterialId = tipoMaterialCreateView.TipoMaterial.MaterialId;
                tipoMaterialDB.Nome = tipoMaterialCreateView.TipoMaterial.Nome;
                tipoMaterialDB.Descricao = tipoMaterialCreateView.TipoMaterial.Descricao;
                tipoMaterialDB.TempoDegradacao = tipoMaterialCreateView.TipoMaterial.TempoDegradacao;
               
               _context.TipoMaterial.Update(tipoMaterialDB);
               _context.SaveChanges();

            }
        }

        public void ExcluirTipoMaterial(int id)
        {
            var tipoMaterial = _context.TipoMaterial.Find(id);

            if(tipoMaterial is not null)
            {
                _context.TipoMaterial.Remove(tipoMaterial);
                _context.SaveChanges();
            }
        }


    }
}