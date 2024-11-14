using Reciicer.Repository.Interface;
using Reciicer.Models.ColetaViewModels;
using Entities = Reciicer.Models.Entities;
using Reciicer.Service.Cliente;
using Reciicer.Service.Material;
using Reciicer.Service.TipoMaterial;
using Reciicer.Models.Entities;
using Reciicer.Service.Material_Coleta;
using Reciicer.Controllers;

namespace Reciicer.Service.Coleta
{
    public class ColetaService
    {
        private readonly IColetaRepository _coletaRepository;

        private readonly ClienteService _clienteService;
        private readonly TipoMaterialService _tipoMaterialService;

        private readonly Material_ColetaService _material_ColetaService;

        public ColetaService(IColetaRepository coletaRepository, ClienteService clienteService, TipoMaterialService tipoMaterialService,
                             Material_ColetaService material_ColetaService)
        {
            _coletaRepository = coletaRepository;
            _material_ColetaService = material_ColetaService;
            _clienteService = clienteService;
            _tipoMaterialService = tipoMaterialService;
        }

        
        public void EfetuarColetaCliente(ColetaCreateViewModel coletaCreateViewModel)
        {

            var coleta = new Entities.Coleta
            {
                ClienteId = coletaCreateViewModel.ClienteId,
                //DataOperacao = DateTime.Now,
                DataOperacao = coletaCreateViewModel.Coleta.DataOperacao,
                PontuacaoGanha = 0 //Procedure Update UpdateReciclagemPontuacaoGanha
            };

            _coletaRepository.RegistrarColeta(coleta);
        }

        
        public void EfetuarMaterialColeta(ColetaCreateViewModel coletaCreateViewModel)
        {
            var reciclagemCliente =_coletaRepository.ObterClienteUltimaColeta(coletaCreateViewModel.ClienteId);
            var pesoColeta = coletaCreateViewModel.Peso;
            var quantidadeColeta = coletaCreateViewModel.Quantidade;
            var materialId = coletaCreateViewModel.MaterialId;
            var tipoMaterialId = coletaCreateViewModel.TipoMaterialId;

            SalvarMaterialColeta(reciclagemCliente.Id, materialId, tipoMaterialId, pesoColeta, quantidadeColeta);
        }

        public void SalvarMaterialColeta(int coletaId, int materialId, int tipoMaterialId, int peso, int quantidade)
        {
            // var materialColeta = new Material_Coleta{
            //     MaterialId = materialId,
            //     ColetaId = coletaId,
            //     TipoMaterialId = tipoMaterialId,
            //     Peso = peso,
            //     Quantidade = quantidade
            // };

            //_material_ColetaRepository.RegistrarMaterialColeta(materialColeta);
        }


        //Método Para calcular a quantidade de pontos que foi feita na recilagem
        public void CalcularPontuacaoColeta(int coletaId)
        {
            var pontuacaoGanha =  _material_ColetaService
                                    .ListarMaterialColetaPorColetaId(coletaId)
                                    .Sum(mc => (mc.Material.PontuacaoPeso * mc.Peso) 
                                        + (mc.Quantidade * mc.Material.PontuacaoUnidade)
                                        );
                                        
            var coleta = ObterColetaPorId(coletaId);
            coleta.PontuacaoGanha = pontuacaoGanha;
            
            AtualizarColeta(coleta)                                 ;
        }

    

        public int ObterTotalMaterialColeta()
        {
            //eturn _material_ReciclagemRepository.ListarMaterialReciclagem().Count();
            return 22;
        }

        public DateTime ObterDataUltimaReciclagem()
        {
            return _coletaRepository.ListarColeta().Max(r => r.DataOperacao);
           
        }

        
        public IEnumerable<Entities.Coleta> ListarColeta()
        {
            return _coletaRepository.ListarColeta();
        }  
        public Entities.Coleta ObterColetaPorId(int id)
        {
            return _coletaRepository.ObterColetaPorId(id);
        } 
        public void RegistrarColeta(Entities.Coleta coleta)
        {
            _coletaRepository.RegistrarColeta(coleta);
        }
        public void AtualizarColeta(Entities.Coleta coleta)
        {
            _coletaRepository.AtualizarColeta(coleta);
        }
        public void ExcluirColeta(int id)
        {
            _coletaRepository.ExcluirColeta(id);
        }
        public Entities.Coleta ObterClienteUltimaColeta(int clienteId)
        {
            return _coletaRepository.ObterClienteUltimaColeta(clienteId);
        }


        public ColetaCreateViewModel ObterColetaCreateViewModel()
        {
            var clientes = _clienteService.ListarCliente();
            var tipoMateriais = _tipoMaterialService.ListarTipoMaterial();
          
            var coletaCreate = new ColetaCreateViewModel{
                Clientes = clientes,
                TipoMateriais = tipoMateriais
               
            };

            return coletaCreate;
        }

        public ColetaCreateViewModel ObterColetaCreateViewModelComUltimaColeta(int clienteId)
        {
                var coletaCreateView = ObterColetaCreateViewModel();

                coletaCreateView.Coleta = ObterClienteUltimaColeta(clienteId);

                coletaCreateView.ColetaId = coletaCreateView.Coleta.Id;

            return coletaCreateView;
        }

        public ColetaCreateViewModel ObterColetaCreateViewModelComMaterialColeta(int clienteId, Entities.Material_Coleta? materialColeta = null)
        {
            var viewColetaMateriasColeta = ObterColetaCreateViewModelComUltimaColeta(clienteId);
            
            if(materialColeta != null)
                _material_ColetaService.RegistrarMaterialColeta(materialColeta);

            //TODO:
            //coletaCreateViewModel.Material_coleta = _material_coletaRepository.ListarMaterialColetaPorcoletaId(coletaCliente.Id);
            viewColetaMateriasColeta.Material_Coletas = _material_ColetaService.ListarMaterialColetaPorColetaId(viewColetaMateriasColeta.ColetaId);

            return viewColetaMateriasColeta;
        }
    }
}