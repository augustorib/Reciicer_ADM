using Reciicer.Models.ClienteViewModels;
using Reciicer.Repository.Interface;
using Reciicer.Service.Cliente;
using Reciicer.Service.ClientePremiacao;
using Entities = Reciicer.Models.Entities;

namespace Reciicer.Service.Premiacao
{
    public class PremiacaoService
    {
        private readonly IPremiacaoRepository _premiacaoRepository;
        private readonly ClienteService _clienteService;
        private readonly ClientePremiacaoService _clientePremiacaoService;
        

        public PremiacaoService(IPremiacaoRepository premiacaoRepository, ClienteService clienteService, ClientePremiacaoService clientePremiacaoService)
        {
            _premiacaoRepository = premiacaoRepository;
            _clienteService = clienteService;
            _clientePremiacaoService = clientePremiacaoService;
        }

        public IEnumerable<Entities.Premiacao> ListarPremiacao()
        {
            return _premiacaoRepository.ListarPremiacao();
        }  

        public Entities.Premiacao ObterPremiacaoPorId(int id)
        {
            return _premiacaoRepository.ObterPremiacaoPorId(id);
        }

        public void RegistrarPremiacao(Entities.Premiacao premiacao)
        {
            _premiacaoRepository.RegistrarPremiacao(premiacao);
        }
        public void AtualizarPremiacao(Entities.Premiacao premiacao)
        {
            _premiacaoRepository.AtualizarPremiacao(premiacao);
        }
        public void ExcluirPremiacao(int id)
        {
            _premiacaoRepository.ExcluirPremiacao(id);
        }
        

        public  ClientePremiacaoViewModel MontarViewModelPremiarCliente(int? premiacaoId)
        {
            var premiosDisponiveis = ListarPremiacao()  
                        .Where(p => p.Ativo == true)
                        .ToList();

            var model = new ClientePremiacaoViewModel{
                Clientes = new List<Entities.Cliente>(),
                Premiacoes = premiosDisponiveis,
                Premiacao = new Entities.Premiacao(),
                PremiacaoId = premiacaoId ?? 0
            };

           if(premiacaoId.HasValue) 
           {
                model.Premiacao = ObterPremiacaoPorId(premiacaoId.Value);

                model.Clientes = _clienteService.ListarCliente()
                                 .Where(c => c.PontuacaoTotal >= model.Premiacao.PontuacaoRequerida)
                                 .ToList();

                model.Premiacoes = premiosDisponiveis;
           }

           return model;
        }

        public bool RealizarPremiacao(int premiacaoId, int clienteId)
        {
            try
            {
                var premiacao = ObterPremiacaoPorId(premiacaoId);
                var cliente = _clienteService.ObterClientePorId(clienteId);

                var clientePremiacao = new Entities.ClientePremiacao
                {
                    ClienteId = cliente.Id,
                    PremiacaoId = premiacao.Id,
                    DataOperacao = DateTime.Now
                };

                _clientePremiacaoService.RegistrarClientePremiacao(clientePremiacao);

                cliente.PontuacaoTotal -= premiacao.PontuacaoRequerida;
                _clienteService.AtualizarCliente(cliente);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}