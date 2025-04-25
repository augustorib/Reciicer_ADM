using Reciicer.Data;
using Reciicer.Models.Entities;
using Reciicer.Repository.Interface;

namespace Reciicer.Repository
{
    public class PontoColetaRepository : IPontoColetaRepository
    {
        private readonly AppDbContext _context;

        public PontoColetaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<PontoColeta> ListarPontoColeta()
        {
            return _context.PontoColeta.ToList();
        }
        public PontoColeta ObterPontoColetaPorId(int id)
        {
            return _context.PontoColeta.FirstOrDefault(pc => pc.Id == id)!;
        }
        
        public void RegistrarPontoColeta(PontoColeta pontoColeta)
        {
            _context.PontoColeta.Add(pontoColeta);
            _context.SaveChanges();
        }

        public void AtualizarPontoColeta(PontoColeta pontoColeta)
        {       
            var pontoColetaBD = _context.PontoColeta.Find(pontoColeta.Id);

            if(pontoColetaBD != null)
            {
                pontoColetaBD.Nome = pontoColeta.Nome;     
                
                _context.PontoColeta.Update(pontoColetaBD);
                _context.SaveChanges();
            }
        }
        public void ExcluirPontoColeta(int id)
        {
            var pontoColeta = _context.PontoColeta.Find(id);

            if(pontoColeta is not null)
            {
                _context.PontoColeta.Remove(pontoColeta);
                _context.SaveChanges();
            }
        }

    }
}