using Microsoft.EntityFrameworkCore;
using Reciicer.Data;
using Reciicer.Models.Entities;
using Reciicer.Models.HomeViewModels;
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
            return _context.TipoMaterial.ToList();
        }
        public TipoMaterial ObterTipoMaterialPorId(int id)
        {
            return _context.TipoMaterial.Find(id);
        }

        public void RegistrarTipoMaterial(TipoMaterial tipoMaterial)
        {
            _context.TipoMaterial.Add(tipoMaterial) ;
            _context.SaveChanges();
        }

        public void AtualizarTipoMaterial(TipoMaterial tipoMaterial)
        {
            var tipoMaterialBd = _context.TipoMaterial.Find(tipoMaterial.Id);

            if(tipoMaterialBd != null)
            {
                tipoMaterialBd.Nome = tipoMaterial.Nome;
                tipoMaterialBd.Descricao = tipoMaterial.Descricao;
                tipoMaterialBd.Ativo = tipoMaterial.Ativo;

                _context.TipoMaterial.Update(tipoMaterialBd);
                _context.SaveChanges();
            }
        }

        public void ExcluirTipoMaterial(int id)
        {
            var tipoMaterialBd = _context.TipoMaterial.Find(id);

            if(tipoMaterialBd != null)
            {
                _context.TipoMaterial.Remove(tipoMaterialBd);
                _context.SaveChanges();
            }
        }

        public IEnumerable<TipoMaterialQuantidadeChart> ObterNomeQuantidadeTipoMaterialGrafico()
        {
            var sql = @"Select 
                            TM.Id, TM.Nome AS TipoMaterialNome, Count(MC.Id) AS Quantidade
                        FROM 
                            Material_Coleta MC
                            left JOIN Material M ON Mc.MaterialId = M.Id
                            left JOIN TipoMaterial TM ON tm.Id = M.TipoMaterialId
                        GROUP BY
                            TM.Nome, TM.id
                        ORDER BY 
                            TM.id";

            var result = _context.Database.SqlQueryRaw<TipoMaterialQuantidadeChart>(sql).ToList();
            
            return result;
        }

    }
}