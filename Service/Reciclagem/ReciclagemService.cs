using Microsoft.EntityFrameworkCore;
using Reciicer.Data;
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


        public void EfetuarRecilagem(ReciclagemViewModel reciclagemViewModel)
        {

            var reciclagem = new Models.Entities.Reciclagem
            {
                ClienteId = reciclagemViewModel.ClienteId,
                DataOperacao = DateTime.Now,
                PontuacaoGanha = 2// TODO:Obter pontuação dinamicamente 
            };

            _reciclagemRepository.RegistrarReciclagem(reciclagem);

            var materialReciclagem = new Material_Reciclagem
            {
                MaterialId = reciclagemViewModel.MaterialId,
                ReciclagemId = reciclagem.Id,
                Peso = reciclagemViewModel.Material_Reciclagem.Peso,
                Quantidade = reciclagemViewModel.Material_Reciclagem.Quantidade
            };

            _material_ReciclagemRepository.RegistrarMaterialReciclagem(materialReciclagem);

        }
        
        public void EfetuarRecilagemMuitosMateriais(ReciclagemCreateViewModel reciclagemCreateViewModel)
        {

            var reciclagem = new Models.Entities.Reciclagem
            {
                ClienteId = reciclagemCreateViewModel.ClienteId,
                DataOperacao = DateTime.Now,
                PontuacaoGanha = 2// TODO:Obter pontuação dinamicamente 
            };

            _reciclagemRepository.RegistrarReciclagem(reciclagem);

            foreach(var item in reciclagemCreateViewModel.Material_Reciclagem)
            {
                var materialReciclagem = new Material_Reciclagem
                {
                    MaterialId = item.MaterialId,
                    ReciclagemId = item.ReciclagemId,
                    Peso = item.Peso,
                    Quantidade = item.Quantidade
                };

                _material_ReciclagemRepository.RegistrarMaterialReciclagem(materialReciclagem);
            }

        }


    }
}