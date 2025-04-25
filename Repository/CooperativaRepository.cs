
using Reciicer.Data;
using Reciicer.Models.Entities;
using Reciicer.Repository.Interface;

namespace Reciicer.Repository
{
    public class CooperativaRepository : ICooperativaRepository
    {

        private readonly AppDbContext _context;

        public CooperativaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Cooperativa> ListarCooperativa()
        {
            return _context.Cooperativa.ToList();
        }


        public Cooperativa ObterCooperativaPorId(int id)
        {
            return _context.Cooperativa.Find(id)!;
        }

        public void RegistrarCooperativa(Cooperativa cooperativa)
        {
            _context.Cooperativa.Add(cooperativa);
            _context.SaveChanges();
        }

        public void AtualizarCooperativa(Cooperativa cooperativa)
        {
            var cooperativaBd = _context.Cooperativa.Find(cooperativa.Id);

            if (cooperativaBd != null)
            {

                cooperativaBd.Nome = cooperativa.Nome;
                cooperativaBd.Email = cooperativa.Email;
                cooperativaBd.CNPJ = cooperativa.CNPJ;

                _context.Cooperativa.Update(cooperativaBd);
                _context.SaveChanges();
            }
        }

        public void ExcluirCooperativa(int id)
        {
            var cooperativaExcluir = _context.Cooperativa.Find(id);

            if (cooperativaExcluir != null)
            {
                _context.Cooperativa.Remove(cooperativaExcluir);
                _context.SaveChanges();
            }
        }
    }
}