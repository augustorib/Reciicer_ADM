using Reciicer.Models.RecolhimentoViewModels;
using Reciicer.Repository.Interface;
using Entities = Reciicer.Models.Entities;

namespace Reciicer.Service.Material_Coleta
{
    public class Material_ColetaService
    {
        private readonly IMaterial_ColetaRepository _Material_ColetaRepository;

        public Material_ColetaService(IMaterial_ColetaRepository Material_ColetaRepository)
        {
            _Material_ColetaRepository = Material_ColetaRepository;
        }

        public IEnumerable<Entities.Material_Coleta> ListarMaterialColeta()
        {
            return _Material_ColetaRepository.ListarMaterialColeta();
        }

        public IEnumerable<Entities.Material_Coleta> ListarMaterialColetaPorColetaId(int ColetaId)
        {
            return _Material_ColetaRepository.ListarMaterialColetaPorColetaId(ColetaId);
        }
        public Entities.Material_Coleta ObterMaterialColetaPorId(int id)
        {
            return _Material_ColetaRepository.ObterMaterialColetaPorId(id);
        } 

        public void RegistrarMaterialColeta(Entities.Material_Coleta materialColeta)
        {
             _Material_ColetaRepository.RegistrarMaterialColeta(materialColeta);
        }
        public void ExcluirMaterialColeta(int id)
        {
             _Material_ColetaRepository.ExcluirMaterialColeta(id);
        }

        public IEnumerable<MaterialTotais> ObterTotaisMaterial()
        {

           var materialTotais = _Material_ColetaRepository.ListarMaterialColetaMaterial()
                                      .AsQueryable()
                                      .GroupBy(mc => new {mc.Material.Id, mc.Material.Nome})
                                      .Select(g => new MaterialTotais()
                                        {
                                            MaterialId = g.Key.Id,
                                            Material = g.Key.Nome,
                                            QuantidadeTotal = g.Sum(mc => mc.Quantidade),
                                            PesoTotal = g.Sum(mc => mc.Peso)
                                        }).ToList();

            return materialTotais;
                   
        }
    }
}