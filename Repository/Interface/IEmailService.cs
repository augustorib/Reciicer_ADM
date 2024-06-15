

namespace Reciicer.Repository.Interface
{
    public interface IEmailService
    {
        bool EnviarEmail(string email, string assunto, string mensagem);
    }
}