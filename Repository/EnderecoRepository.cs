using Reciicer.Data;
using Reciicer.Repository.Interface;
using Entities = Reciicer.Models.Entities;

namespace Reciicer.Repository
{
    public class EnderecoRepository: IEnderecoRepository
    {
        private readonly AppDbContext _context;

        public EnderecoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Entities.Endereco> ListarEndereco()
        {
            return _context.Endereco.ToList();
        }

        public Entities.Endereco ObterEnderecoPorId(int id)
        {
            return _context.Endereco.Find(id)!;
        }

        public void RegistrarEndereco(Entities.Endereco endereco)
        {
            _context.Endereco.Add(endereco);
            _context.SaveChanges();
        }

        public void AtualizarEndereco(Entities.Endereco endereco)
        {
            var enderecoBD = _context.Endereco.Find(endereco.Id);

            if(enderecoBD != null)
            {
                enderecoBD.Rua = endereco.Rua;
                enderecoBD.Bairro = endereco.Bairro;
                enderecoBD.Numero = endereco.Numero;
                enderecoBD.Cidade = endereco.Cidade;
                enderecoBD.Estado = endereco.Estado;
                enderecoBD.Cep = endereco.Cep;
                
                _context.Endereco.Update(enderecoBD);
                _context.SaveChanges();
            }
        }

        public void ExcluirEndereco(int id)
        {
            var enderecoBD = ObterEnderecoPorId(id);

            if(enderecoBD != null)
            {
                _context.Endereco.Remove(enderecoBD);
                _context.SaveChanges();
            }
        }
    }
}