

namespace Reciicer.Repository.Interface
{
    public interface IEmailService
    {
        bool EnviarEmail(string email, string assunto, string mensagem);
        Task<bool> EnviarEmailAsync(string email, string assunto, string mensagem);
        string MontarEmailBody();
    }
}