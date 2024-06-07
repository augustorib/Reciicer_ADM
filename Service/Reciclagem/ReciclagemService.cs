
using Reciicer.Models;
using Reciicer.Models.Entities;
using Reciicer.Repository.Interface;

namespace Reciicer.Service.Reciclagem
{
    public class ReciclagemService
    {
        private readonly IReciclagemRepository _reciclagemRepository;
        private readonly IMaterial_ReciclagemRepository _material_ReciclagemRepository;

        public ReciclagemService(IReciclagemRepository reciclagemRepository,
                                 IMaterial_ReciclagemRepository material_ReciclagemRepository)
        {
            _reciclagemRepository = reciclagemRepository;
            _material_ReciclagemRepository = material_ReciclagemRepository;
        }

        public void EfetuarRecilagemCliente(ReciclagemCreateViewModel reciclagemCreateViewModel)
        {

            var reciclagem = new Models.Entities.Reciclagem
            {
                ClienteId = reciclagemCreateViewModel.ClienteId,
                DataOperacao = DateTime.Now,
                PontuacaoGanha = 0 //Procedure Update UpdateReciclagemPontuacaoGanha
            };

            _reciclagemRepository.RegistrarReciclagem(reciclagem);
        }

        
        public void EfetuarReciclagemMaterial(ReciclagemCreateViewModel reciclagemCreateViewModel)
        {
            var reciclagemCliente =_reciclagemRepository.ObterClienteUltimaReciclagem(reciclagemCreateViewModel.ClienteId);
            var pesoReciclagem = reciclagemCreateViewModel.Peso;
            var quantidadeReciclagem = reciclagemCreateViewModel.Quantidade;
            var materialId = reciclagemCreateViewModel.MaterialId;
            var tipoMaterialId = reciclagemCreateViewModel.TipoMaterialId;

            SalvarMaterialReciclagem(reciclagemCliente.Id, materialId, tipoMaterialId, pesoReciclagem, quantidadeReciclagem);
        }

        public void SalvarMaterialReciclagem(int reciclagemId, int materialId, int tipoMaterialId, int peso, int quantidade)
        {
            var materialReciclagem = new Material_Reciclagem{
                MaterialId = materialId,
                ReciclagemId = reciclagemId,
                TipoMaterialId = tipoMaterialId,
                Peso = peso,
                Quantidade = quantidade
            };

            _material_ReciclagemRepository.RegistrarMaterialReciclagem(materialReciclagem);
        }


        //Método Para calcular a quantidade de pontos que foi feita na recilagem
        public void CalcularPontuacaoReciclagem(int reciclagemId)
        {
            _reciclagemRepository.CalcularPontuacaoReciclagem(reciclagemId);
        }

        public Models.Entities.Reciclagem ObterClienteUltimaReciclagem(int clienteId)
        {
            return _reciclagemRepository.ObterClienteUltimaReciclagem(clienteId);
        }

        public int ObterTotalMaterialReciclagem()
        {
            return _material_ReciclagemRepository.ListarMaterialReciclagem().Count();
        }

        public DateTime ObterDataUltimaReciclagem()
        {
            return _reciclagemRepository.ListarReciclagem().Max(r => r.DataOperacao);
           
        }

        


    }
}