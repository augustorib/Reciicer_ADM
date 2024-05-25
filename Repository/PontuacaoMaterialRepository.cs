using Microsoft.EntityFrameworkCore;
using Reciicer.Data;
using Reciicer.Models.Entities;
using Reciicer.Repository.Interface;

namespace Reciicer.Repository
{
    public class PontuacaoMaterialRepository : IPontuacaoMaterialRepository
    {

        private readonly AppDbContext _context;

        public PontuacaoMaterialRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<PontuacaoMaterial> ListarPontuacaoMaterial()
        {
            return _context.PontuacaoMaterial.Include( p => p.TipoMaterial).ToList();
        }

        public PontuacaoMaterial ObterPontuacaoMaterialPorId(int id)
        {
            return _context.PontuacaoMaterial.Include(p => p.TipoMaterial).FirstOrDefault( p => p.Id == id);
        }

        public void AtualizarPontuacaoMaterial(PontuacaoMaterial PontuacaoMaterial)
        {
            throw new NotImplementedException();
        }

        public void ExcluirPontuacaoMaterial(int id)
        {
            throw new NotImplementedException();
        }



        public void RegistrarPontuacaoMaterial(PontuacaoMaterial PontuacaoMaterial)
        {
            throw new NotImplementedException();
        }


    }
}