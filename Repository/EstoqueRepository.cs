using Microsoft.EntityFrameworkCore;
using Reciicer.Data;
using Reciicer.Models.Entities;
using Reciicer.Repository.Interface;

namespace Reciicer.Repository
{
    public class EstoqueRepository : IEstoqueRepository
    {
        private readonly AppDbContext _context;

        public EstoqueRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Estoque> ListarEstoque()
        {
            return _context.Estoque.Include(e => e.PontoColeta).ToList();
        }

        public Estoque ObterEstoquePorId(int id)
        {
            return _context.Estoque.Include(e => e.PontoColeta).FirstOrDefault(e => e.Id == id);
        }

        public void RegistrarEstoque(Estoque estoque)
        {
            _context.Estoque.Add(estoque);
            _context.SaveChanges();
        }

        public void AtualizarEstoque(Estoque estoque)
        {
            var estoqueBd = _context.Estoque.Find(estoque.Id);

            if (estoqueBd is not null)
            {
                estoqueBd.Codigo = estoque.Codigo;
                estoqueBd.Tipo = estoque.Tipo;
                estoqueBd.PesoArmazenado = estoque.PesoArmazenado;
                estoqueBd.QuantidadeArmazenada = estoque.QuantidadeArmazenada;
                estoqueBd.Capacidade = estoque.Capacidade;
                estoqueBd.PontoColetaId = estoque.PontoColetaId;

                _context.Estoque.Update(estoqueBd);
                _context.SaveChanges();
            }

        }

        public void ExcluirEstoque(int id)
        {
            var estoqueBd = _context.Estoque.Find(id);

            if (estoqueBd is not null)
            {
                _context.Estoque.Remove(estoqueBd);
                _context.SaveChanges();
            }   
        }

        public IEnumerable<Estoque> ListarEstoquePorPontoColetaId(int pontoColetaId)
        {
            return _context.Estoque.Where(e => e.PontoColetaId == pontoColetaId).ToList();
        }
    }
}