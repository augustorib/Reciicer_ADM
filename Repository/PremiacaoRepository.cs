using Microsoft.EntityFrameworkCore;
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
            return _context.Premiacao.Include(p => p.Nivel).ToList();
        }

        public void RegistrarPremiacao(Premiacao premiacao)
        {
            _context.Premiacao.Add(premiacao);
            _context.SaveChanges();
        }


        public Premiacao ObterPremiacaoPorId(int id)
        {
            return _context.Premiacao.Include(p => p.Nivel).FirstOrDefault(p => p.Id == id);
        }

        public void AtualizarPremiacao(Premiacao premiacao)
        {
            var premiacaoBD = _context.Premiacao.Find(premiacao.Id);

            if(premiacaoBD != null)
            {
                premiacaoBD.Nome = premiacao.Nome;
                premiacaoBD.Descricao = premiacao.Descricao;
                premiacaoBD.Ativo = premiacao.Ativo;
                premiacao.NivelId = premiacao.NivelId;
                premiacaoBD.DataInicial = premiacao.DataInicial;
                premiacaoBD.DataFinal = premiacao.DataFinal;


                _context.Premiacao.Update(premiacaoBD);
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