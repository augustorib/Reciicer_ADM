using Reciicer.Repository.Interface;
using Entities = Reciicer.Models.Entities;

namespace Reciicer.Service.Estoque
{
    public class EstoqueService
    {
        private readonly IEstoqueRepository _estoqueRepository;
        private readonly IEstoqueMaterialRepository _estoqueMaterialRepository;

        private readonly IMaterial_ColetaRepository _material_ColetaRepository;

        public EstoqueService(IEstoqueRepository estoqueRepository, IEstoqueMaterialRepository estoqueMaterialRepository
        , IMaterial_ColetaRepository material_ColetaRepository)
        {
            _estoqueRepository = estoqueRepository;
            _estoqueMaterialRepository = estoqueMaterialRepository;
            _material_ColetaRepository = material_ColetaRepository;
        }

        public IEnumerable<Entities.Estoque> ListarEstoque()
        {
            return _estoqueRepository.ListarEstoque();
        }

        public Entities.Estoque ObterEstoquePorId(int id)
        {
            return _estoqueRepository.ObterEstoquePorId(id);
        }

        public void RegistrarEstoque(Entities.Estoque Estoque)
        {
            _estoqueRepository.RegistrarEstoque(Estoque);
        }
        public void AtualizarEstoque(Entities.Estoque Estoque)
        {
            _estoqueRepository.AtualizarEstoque(Estoque);
        }
        
        public void ExcluirEstoque(int id)
        {
            _estoqueRepository.ExcluirEstoque(id);
        }

        public IEnumerable<Entities.Estoque> ListarEstoquesPorPontoColetaId(int pontoColetaId)
        {
            return _estoqueRepository.ListarEstoquePorPontoColetaId(pontoColetaId);

        }
        
        public void AdicionarMaterialEstoque(Entities.Material_Coleta material_Coleta, int pontoColetaId) 
        {
            var estoques = ListarEstoquesPorPontoColetaId(pontoColetaId);

            var PesoParaArmazenar = material_Coleta.Peso;
            var QuantidadeParaArmazenar = material_Coleta.Quantidade;

            foreach ( var estoque in estoques)
            {
                var espacoDisponivelNoEstoque = estoque.Capacidade - (estoque.PesoArmazenado + estoque.QuantidadeArmazenada);
                
                if(espacoDisponivelNoEstoque <= 0)
                   continue;

                var estoqueMaterial = new Entities.EstoqueMaterial
                {
                    MaterialId = material_Coleta.MaterialId,
                    EstoqueId = estoque.Id
                };
                
                if(PesoParaArmazenar > 0)
                {
                    var pesoParaAdicionarNoEstoque = Math.Min(PesoParaArmazenar, espacoDisponivelNoEstoque);
                    estoque.PesoArmazenado += pesoParaAdicionarNoEstoque;
                    estoqueMaterial.Peso += pesoParaAdicionarNoEstoque;
                    
                    PesoParaArmazenar -= pesoParaAdicionarNoEstoque;
                    espacoDisponivelNoEstoque -= pesoParaAdicionarNoEstoque;
                }
                
                if(QuantidadeParaArmazenar > 0)
                {
                    var quantidadeParaAdicionarNoEstoque = Math.Min(QuantidadeParaArmazenar, espacoDisponivelNoEstoque);
                    estoque.QuantidadeArmazenada += quantidadeParaAdicionarNoEstoque;
                    estoqueMaterial.Quantidade += quantidadeParaAdicionarNoEstoque;
                    
                    QuantidadeParaArmazenar -= quantidadeParaAdicionarNoEstoque;
                    espacoDisponivelNoEstoque -= quantidadeParaAdicionarNoEstoque;

                }

                _estoqueMaterialRepository.RegistrarEstoqueMaterial(estoqueMaterial);
                
                AtualizarEstoque(estoque);

                if(PesoParaArmazenar == 0 && QuantidadeParaArmazenar == 0)
                   break;
            }
                
        }

        public void RemoverMaterialEstoque (int materialColetaId)
        {
            var materialColeta = _material_ColetaRepository.ObterMaterialColetaPorId(materialColetaId);

            var estoques = ListarEstoquesPorPontoColetaId(materialColeta.Coleta!.PontoColetaId);

            GerenciarRemocaoEstoque(estoques.ToList(), materialColeta.MaterialId, materialColeta.Peso, materialColeta.Quantidade);
        }

      
        public void RemoverMaterialEstoque (IList<Entities.RecolhimentoEstoqueMaterial> recolhimentoEstoqueMateriais)
        {   
            foreach(var recolhimentoEstoqueMaterial in recolhimentoEstoqueMateriais)
            {
                var estoqueMaterial = _estoqueMaterialRepository.ObterEstoqueMaterialPorId(recolhimentoEstoqueMaterial.EstoqueMaterialId);

                var estoques = _estoqueRepository.ListarEstoquePorPontoColetaId(estoqueMaterial.Estoque.PontoColetaId);

                GerenciarRemocaoEstoque(estoques.ToList(), estoqueMaterial.MaterialId, recolhimentoEstoqueMaterial.Peso, recolhimentoEstoqueMaterial.Quantidade);
            }
        }

        public void GerenciarRemocaoEstoque(IList<Entities.Estoque> estoques, int materialId, int peso, int quantidade )
        {
            var pesoParaRemover = peso;
            var quantidadeParaRemover = quantidade;

            foreach (var estoque in estoques)
            {
                if (pesoParaRemover == 0 && quantidadeParaRemover == 0)
                   break;
          
                var estoquesMateriais = _estoqueMaterialRepository.ObterEstoqueMaterialPorMaterialEstoque(estoque.Id, materialId).OrderByDescending(em => em.Id);

                foreach (var estoqueMaterial in estoquesMateriais)
                {
                    if (pesoParaRemover == 0 && quantidadeParaRemover == 0)
                    break;

                    if (pesoParaRemover > 0 )
                    {
                        var pesoParaRemoverDoEstoqueMaterial = Math.Min(estoqueMaterial.Peso, pesoParaRemover);

                        estoqueMaterial.Peso -= pesoParaRemoverDoEstoqueMaterial;
                        estoque.PesoArmazenado -= pesoParaRemoverDoEstoqueMaterial;
                        pesoParaRemover -= pesoParaRemoverDoEstoqueMaterial;
                    
                    }

                    if (quantidadeParaRemover > 0)
                    {
                        var quantidadeParaRemoverDoEstoqueMaterial = Math.Min(estoqueMaterial.Quantidade, quantidadeParaRemover);

                        estoqueMaterial.Quantidade -= quantidadeParaRemoverDoEstoqueMaterial;
                        estoque.QuantidadeArmazenada -= quantidadeParaRemoverDoEstoqueMaterial;
                        quantidadeParaRemover -= quantidadeParaRemoverDoEstoqueMaterial;
                        
                    }

                    // if(estoqueMaterial.Quantidade == 0 && estoqueMaterial.Peso == 0)
                    //     _estoqueMaterialRepository.ExcluirEstoqueMaterial(estoqueMaterial.Id);
                    // else
                        _estoqueMaterialRepository.AtualizarEstoqueMaterial(estoqueMaterial);
    
                }
                AtualizarEstoque(estoque);
            }
        }

        public void ExcluirMateriaisEstoquePorColetaId(int coletaId)
        {
           var materiaisColetaDaColeta = _material_ColetaRepository.ListarMaterialColetaPorColetaId(coletaId).OrderBy(mc => mc.Id);

           foreach (var materialColeta in materiaisColetaDaColeta)
           {
               RemoverMaterialEstoque(materialColeta.Id);
           }
        }

    }
}