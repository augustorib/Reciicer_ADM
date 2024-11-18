using Reciicer.Repository.Interface;
using Entities = Reciicer.Models.Entities;

namespace Reciicer.Service.Endereco
{
    public class EnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoService(IEnderecoRepository enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }

        public IEnumerable<Entities.Endereco> ListarEndereco()
        {
            return _enderecoRepository.ListarEndereco();
        }

        public Entities.Endereco ObterEnderecoPorId(int id)
        {
            return _enderecoRepository.ObterEnderecoPorId(id);
        }

        public void RegistrarEndereco(Entities.Endereco endereco)
        {
            _enderecoRepository.RegistrarEndereco(endereco);
        }

        public void AtualizarEndereco(Entities.Endereco endereco)
        {
            _enderecoRepository.AtualizarEndereco(endereco);
        }

        public void ExcluirEndereco(int id)
        {
            _enderecoRepository.ExcluirEndereco(id);
        }

    }
}