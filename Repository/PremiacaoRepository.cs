using Reciicer.Data;
using Reciicer.Models.Entities;
using Reciicer.Repository.Interface;

namespace Reciicer.Repository
{
    public class PremiacaoRepository : IPremiacaoRepository
    {

        private readonly AppDbContext _context;

        public PremiacaoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Premiacao> ListarPremiacao()
        {
            return _context.Premiacao.ToList();
        }
        public void RegistrarPremiacao(Premiacao premiacao)
        {
            _context.Premiacao.Add(premiacao);
            _context.SaveChanges();
        }
        public Premiacao ObterPremiacaoPorId(int id)
        {
            return _context.Premiacao.FirstOrDefault(p => p.Id == id);
        }

        public void AtualizarPremiacao(Premiacao premiacao)
        {
            var premiacaoBd = _context.Premiacao.Find(premiacao.Id);

            if(premiacaoBd != null)
            {
                premiacaoBd.Nome = premiacao.Nome;
                premiacaoBd.Descricao = premiacao.Descricao;
                premiacaoBd.Ativo = premiacao.Ativo;
                premiacaoBd.PontuacaoRequerida = premiacao.PontuacaoRequerida;
                
                _context.Premiacao.Update(premiacaoBd);
                _context.SaveChanges();
            }

        }

        public void ExcluirPremiacao(int id)
        {
            var premiacaoBD = _context.Premiacao.Find(id);

            if(premiacaoBD != null)
            {
                _context.Premiacao.Remove(premiacaoBD);
                _context.SaveChanges();
            }
        }


    }
}