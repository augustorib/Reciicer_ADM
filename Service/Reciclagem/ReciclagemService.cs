
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
                //PontuacaoGanha = 2// TODO:Obter pontuação dinamicamente 
                PontuacaoGanha = 0// TODO:Obter pontuação dinamicamente 
            };

            _reciclagemRepository.RegistrarReciclagem(reciclagem);
        }

        
        public void EfetuarReciclagemMaterial(ReciclagemCreateViewModel reciclagemCreateViewModel)
        {
            var reciclagemCliente =_reciclagemRepository.ObterClienteUltimaReciclagem(reciclagemCreateViewModel.ClienteId);
            var pesoReciclagem = reciclagemCreateViewModel.Peso;
            var quantidadeReciclagem = reciclagemCreateViewModel.Quantidade;
            var materialId = reciclagemCreateViewModel.MaterialId;

            SalvarMaterialReciclagem(reciclagemCliente.Id, materialId, pesoReciclagem, quantidadeReciclagem);
        }

        public void SalvarMaterialReciclagem(int reciclagemId, int materialId, int peso, int quantidade)
        {
            var materialReciclagem = new Material_Reciclagem{
                MaterialId = materialId,
                ReciclagemId = reciclagemId,
                Peso = peso,
                Quantidade = quantidade
            };

            _material_ReciclagemRepository.RegistrarMaterialReciclagem(materialReciclagem);
        }
        // public void EfetuarRecilagem(ReciclagemViewModel reciclagemViewModel)
        // {

        //     var reciclagem = new Models.Entities.Reciclagem
        //     {
        //         ClienteId = reciclagemViewModel.ClienteId,
        //         DataOperacao = DateTime.Now,
        //         //PontuacaoGanha = 2// TODO:Obter pontuação dinamicamente 
        //         PontuacaoGanha = 2// TODO:Obter pontuação dinamicamente 
        //     };

        //     _reciclagemRepository.RegistrarReciclagem(reciclagem);

        //     var materialReciclagem = new Material_Reciclagem
        //     {
        //         MaterialId = reciclagemViewModel.MaterialId,
        //         ReciclagemId = reciclagem.Id,
        //         Peso = reciclagemViewModel.Material_Reciclagem.Peso,
        //         Quantidade = reciclagemViewModel.Material_Reciclagem.Quantidade
        //     };

        //     _material_ReciclagemRepository.RegistrarMaterialReciclagem(materialReciclagem);

        // }
        
        // public void EfetuarRecilagemMuitosMateriais(ReciclagemCreateViewModel reciclagemCreateViewModel)
        // {

        //     var reciclagem = new Models.Entities.Reciclagem
        //     {
        //         ClienteId = reciclagemCreateViewModel.ClienteId,
        //         DataOperacao = DateTime.Now,
        //         PontuacaoGanha = 2// TODO:Obter pontuação dinamicamente 
        //     };

        //     _reciclagemRepository.RegistrarReciclagem(reciclagem);

        //     foreach(var item in reciclagemCreateViewModel.Material_Reciclagem)
        //     {
        //         var materialReciclagem = new Material_Reciclagem
        //         {
        //             MaterialId = item.MaterialId,
        //             ReciclagemId = item.ReciclagemId,
        //             Peso = item.Peso,
        //             Quantidade = item.Quantidade
        //         };

        //         _material_ReciclagemRepository.RegistrarMaterialReciclagem(materialReciclagem);
        //     }

        // }


        //Método Para calcular a quantidade de pontos que foi feita na recilagem
        public void CalcularPontuacaoReciclagem(int reciclagemId)
        {
            _reciclagemRepository.CalcularPontuacaoReciclagem(reciclagemId);
        }

        public Models.Entities.Reciclagem ObterClienteUltimaReciclagem(int clienteId)
        {
            return _reciclagemRepository.ObterClienteUltimaReciclagem(clienteId);
        }
    }
}