
using Microsoft.EntityFrameworkCore;
using Reciicer.Data;
using Reciicer.Models.Entities;
using Reciicer.Repository.Interface;

namespace Reciicer.Repository
{
    public class NivelRepository : INivelRepository
    {
        private readonly AppDbContext _context;

        public NivelRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Nivel> ListarNivel()
        {
            return _context.Nivel.ToList();
        }

        public Nivel ObterNivelPorId(int id)
        {
           return _context.Nivel.Find(id);
        }

        public void RegistrarNivel(Nivel nivel)
        {
            _context.Nivel.Add(nivel);
            _context.SaveChanges();

        }

        public void AtualizarNivel(Nivel nivel)
        {
            var nivelBD = _context.Nivel.Find(nivel.Id);

            if(nivel is not null)
            {
               nivelBD.Descricao = nivel.Descricao;   
               nivelBD.PontuacaoNecessario = nivel.PontuacaoNecessario;   
               nivelBD.PontosPerdaFrequencia = nivel.PontosPerdaFrequencia;
               nivelBD.Cor = nivel.Cor;

               _context.Nivel.Update(nivelBD);
               _context.SaveChanges(); 
            }

        }

        public void ExcluirNivel(int id)
        {
            var nivelBD = _context.Nivel.Find(id);

            if(nivelBD is not null)
            {
                _context.Nivel.Remove(nivelBD);
                _context.SaveChanges();
            }
        }

    }
}