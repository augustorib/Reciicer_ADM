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

            var pesoExcedente = 0;
            var quantidadeExcedente = 0;

            var PesoParaArmazenar = material_Coleta.Peso;
            var QuantidadeParaArmazenar = material_Coleta.Quantidade;

            foreach ( var estoque in estoques)
            {
                if(estoque.PesoArmazenado + estoque.QuantidadeArmazenada >= estoque.Capacidade)
                   continue;

                var estoqueMaterial = new Entities.EstoqueMaterial
                {
                    MaterialId = material_Coleta.MaterialId,
                };
                
                if(PesoParaArmazenar > 0)
                {
                    estoque.PesoArmazenado += PesoParaArmazenar;
                    estoqueMaterial.Peso += PesoParaArmazenar;
                    pesoExcedente = VerificarExcedente(estoque.PesoArmazenado, estoque.Capacidade);

                    if(pesoExcedente > 0)
                    {
                        estoque.PesoArmazenado -= pesoExcedente;
                        estoqueMaterial.Peso -= pesoExcedente;
                        PesoParaArmazenar = pesoExcedente;
                    }
                }
                
                if(QuantidadeParaArmazenar > 0)
                {
                    estoque.QuantidadeArmazenada += QuantidadeParaArmazenar;
                    estoqueMaterial.Quantidade += QuantidadeParaArmazenar;
                    quantidadeExcedente = VerificarExcedente(estoque.QuantidadeArmazenada, estoque.Capacidade);

                    if(quantidadeExcedente > 0)
                    {
                        estoque.QuantidadeArmazenada -= quantidadeExcedente;
                        estoqueMaterial.Quantidade -= quantidadeExcedente;
                        QuantidadeParaArmazenar = quantidadeExcedente;
                    }
                }

                estoqueMaterial.EstoqueId = estoque.Id;

                _estoqueMaterialRepository.RegistrarEstoqueMaterial(estoqueMaterial);
                
                AtualizarEstoque(estoque);
            }
                
            if (pesoExcedente > 0 || quantidadeExcedente > 0)
            {
              //Console.WriteLine("Não há capacidade suficiente para armazenar todo o material coletado.");

              throw new InvalidOperationException("Não há capacidade suficiente para armazenar todo o material coletado.");
            }
        }

        public int VerificarExcedente(int armazenagem, int capacidade)
        {
            return armazenagem - capacidade > 0 ? armazenagem - capacidade : 0;
        }

        public void RemoverMaterialEstoque (int materialColetaId)
        {
            var materialColeta = _material_ColetaRepository.ObterMaterialColetaPorId(materialColetaId);

            var estoques = ListarEstoquesPorPontoColetaId(materialColeta.Coleta!.PontoColetaId);

            var pesoDiferenca = 0;
            var quantidadeDiferenca = 0;

            var PesoParaRemover = materialColeta.Peso;
            var QuantidadeParaRemover = materialColeta.Quantidade;

            foreach (var estoque in estoques)
            {
                if (PesoParaRemover == 0 && QuantidadeParaRemover == 0)
                   break;
          
                if (PesoParaRemover > 0 )
                {
                    estoque.PesoArmazenado -= PesoParaRemover;
                    pesoDiferenca = VerificarDiferenca(estoque.PesoArmazenado);
                    
                    var armazenagem = PesoParaRemover + pesoDiferenca;
                    var estoqueMaterial = _estoqueMaterialRepository.ObterEstoqueMaterialPorMaterialEstoqueArmazenagem(estoque.Id, materialColeta.MaterialId, armazenagem);
                    _estoqueMaterialRepository.ExcluirEstoqueMaterial(estoqueMaterial.Id);

                    if (pesoDiferenca < 0)
                    {
                        estoque.PesoArmazenado = 0;
                        PesoParaRemover = Math.Abs(pesoDiferenca);
                    }
                }

                if (QuantidadeParaRemover > 0)
                {
                    estoque.QuantidadeArmazenada -= QuantidadeParaRemover;
                    quantidadeDiferenca = VerificarDiferenca(estoque.QuantidadeArmazenada);

                    var armazenagem = QuantidadeParaRemover + quantidadeDiferenca;
                    var estoqueMaterial = _estoqueMaterialRepository.ObterEstoqueMaterialPorMaterialEstoqueArmazenagem(estoque.Id, materialColeta.MaterialId, armazenagem);
                    _estoqueMaterialRepository.ExcluirEstoqueMaterial(estoqueMaterial.Id);

                    if (quantidadeDiferenca < 0)
                    { 
                        estoque.QuantidadeArmazenada = 0;
                        QuantidadeParaRemover = Math.Abs(quantidadeDiferenca);
                    }
                }

                AtualizarEstoque(estoque);
            }

        }


        public int VerificarDiferenca(int armazenagem)
        {
            return armazenagem  < 0 ? armazenagem  : 0;
        }

    }
}