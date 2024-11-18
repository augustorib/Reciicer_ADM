using Reciicer.Models.Entities;

namespace Reciicer.Repository.Interface
{
    public interface IEnderecoRepository
    {
        IEnumerable<Endereco> ListarEndereco();  
        Endereco ObterEnderecoPorId(int id);  
        void RegistrarEndereco(Endereco endereco); 
        void AtualizarEndereco(Endereco endereco);
        void ExcluirEndereco(int id);
    }
}