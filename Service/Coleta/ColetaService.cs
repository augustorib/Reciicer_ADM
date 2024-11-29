using Reciicer.Repository.Interface;
using Reciicer.Models.ColetaViewModels;
using Entities = Reciicer.Models.Entities;
using Reciicer.Service.Cliente;
using Reciicer.Service.TipoMaterial;
using Reciicer.Service.Material_Coleta;

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
                DataOperacao = coletaCreateViewModel.Coleta.DataOperacao,
                PontuacaoGanha = 0
            };

            _coletaRepository.RegistrarColeta(coleta);
        }

        public int ObterTotalMaterialColeta()
        {
            return _material_ColetaService.ListarMaterialColeta().Count();
        }

        public DateTime ObterDataUltimaColeta()
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

            viewColetaMateriasColeta.Material_Coletas = _material_ColetaService.ListarMaterialColetaPorColetaId(viewColetaMateriasColeta.ColetaId);

            viewColetaMateriasColeta.ClienteId = clienteId;

            return viewColetaMateriasColeta;
        }

        public ColetaReadViewModel ObterColetaReadViewModel(int coletaId)
        {
            var coletaReadViewModel = new ColetaReadViewModel{
                Coleta = ObterColetaPorId(coletaId),
                Material_Coletas = _material_ColetaService.ListarMaterialColetaPorColetaId(coletaId)
            };

            return coletaReadViewModel;
        }

        public ColetaUpdateViewModel ObterUpdateViewModel(int coletaId)
        {
            var updateView = new ColetaUpdateViewModel{
                Coleta = ObterColetaPorId(coletaId),
                TipoMateriais = _tipoMaterialService.ListarTipoMaterial(),
                Material_Coletas = _material_ColetaService.ListarMaterialColetaPorColetaId(coletaId)
            };

            return updateView;
        }
        
        //Método Para calcular a quantidade de pontos que foi feita na Coleta
        public void CalcularPontuacaoColeta(int coletaId)
        {
            var coleta = ObterColetaPorId(coletaId);
            
            var pontuacaoColeta =  _material_ColetaService
                                    .ListarMaterialColetaPorColetaId(coleta.Id)
                                    .Sum(mc => (mc.Material.PontuacaoPeso * mc.Peso) 
                                        + (mc.Quantidade * mc.Material.PontuacaoUnidade)
                                        );

            var diferencaPontuacao = pontuacaoColeta - coleta.PontuacaoGanha;

            coleta.PontuacaoGanha = pontuacaoColeta;
            AtualizarColeta(coleta);

            
            CalcularClientePontuacaoTotalColeta(coleta.Id, diferencaPontuacao);                            
        }

        public void CalcularClientePontuacaoTotalColeta(int coletaId, int diferencaPontuacao)
        {       
            var coleta = _coletaRepository.ObterColetaPorId(coletaId);
            var cliente = _clienteService.ObterClientePorId(coleta.ClienteId);     
            
            if(coleta.PontuacaoGanha != 0)
            {
                cliente.PontuacaoTotal += diferencaPontuacao;
                
                _clienteService.AtualizarCliente(cliente);
            }

        }
    }
}