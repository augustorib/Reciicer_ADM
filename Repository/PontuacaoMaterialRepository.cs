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

        public void RegistrarPontuacaoMaterial(PontuacaoMaterial pontuacaoMaterial)
        {
            _context.PontuacaoMaterial.Add(pontuacaoMaterial);
            _context.SaveChanges();
        }

        public void AtualizarPontuacaoMaterial(PontuacaoMaterial pontuacaoMaterial)
        {
            var pontuacaoMaterialDB = _context.PontuacaoMaterial.Find(pontuacaoMaterial.Id);

            Console.WriteLine(pontuacaoMaterialDB);

            if(pontuacaoMaterialDB != null)
            {
                pontuacaoMaterialDB.TipoMaterialId = pontuacaoMaterial.TipoMaterialId;
                pontuacaoMaterialDB.PontuacaoPeso = pontuacaoMaterial.PontuacaoPeso;
                pontuacaoMaterialDB.PontuacaoUnidade = pontuacaoMaterial.PontuacaoUnidade;

                _context.PontuacaoMaterial.Update(pontuacaoMaterialDB);
                _context.SaveChanges();
            }
        }

        public void ExcluirPontuacaoMaterial(int id)
        {
            var pontuacaoMaterialDB = _context.PontuacaoMaterial.Find(id);

            if(pontuacaoMaterialDB != null)
            {
                _context.PontuacaoMaterial.Remove(pontuacaoMaterialDB);
                _context.SaveChanges();
            }
        }






    }
}