using System.Net;
using System.Net.Mail;
using Reciicer.Repository.Interface;

namespace Reciicer.Service.Email
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<EmailService> _logger;

        public EmailService(IConfiguration configuration, ILogger<EmailService> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public bool EnviarEmail(string email, string assunto, string mensagem)
        {
            try
            {
                string host = _configuration.GetValue<string>("SMTP:Host");
                string nome = _configuration.GetValue<string>("SMTP:Nome");
                string username = _configuration.GetValue<string>("SMTP:UserName");
                string senha = _configuration.GetValue<string>("SMTP:Senha");
                int porta = _configuration.GetValue<int>("SMTP:Porta");


                MailMessage mail = new MailMessage(){From = new MailAddress(username, nome)};

                mail.To.Add(email);
                mail.Subject = assunto;
                mail.Body = mensagem;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;

                using (SmtpClient smtp = new SmtpClient(host, 1))
                {
                    smtp.Credentials = new NetworkCredential(username, senha);
                    smtp.EnableSsl = true;
                    smtp.Timeout = 5000;

                    smtp.Send(mail);

                    _logger.LogInformation("Email enviado com sucesso para {Email}", email);
                    return true;
                }

            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Erro ao enviar email para {Email}", email);
                return false;
            }
        }

        public async Task<bool> EnviarEmailAsync(string email, string assunto, string mensagem)
        {
            try
            {
                string host = _configuration.GetValue<string>("SMTP:Host");
                string nome = _configuration.GetValue<string>("SMTP:Nome");
                string username = _configuration.GetValue<string>("SMTP:UserName");
                string senha = _configuration.GetValue<string>("SMTP:Senha");
                int porta = _configuration.GetValue<int>("SMTP:Porta");

                MailMessage mail = new MailMessage(){From = new MailAddress(username, nome)};

                mail.To.Add(email);
                mail.Subject = assunto;
                mail.Body = mensagem;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;

                using (SmtpClient smtp = new SmtpClient(host, 1))
                {
                    smtp.Credentials = new NetworkCredential(username, senha);
                    smtp.EnableSsl = true;
                    smtp.Timeout = 5000;

                    await smtp.SendMailAsync(mail);

                    _logger.LogInformation("Email enviado com sucesso para {Email}", email);
                    return true;
                }

            }
            catch(Exception ex)
            {
                 _logger.LogError(ex, "Erro ao enviar email para {Email}", email);
                return false;
            }
        }

        public string MontarEmailBody()
        {
            var mensagem =  @"
                            <!DOCTYPE html>
                            <html>
                            <head>
                                <meta charset='utf-8' />
                                <title>Reciicer</title>
                            </head>
                            <body>
                                <h1>Reciicer: Sistema WEB de Recilagem</h1>
                                <p>Olá {Cliente} sua premiação {descrição} está disponível para ser retirada na loja!</p>
                                <br>
                                <p>Atenciosamente,</p>
                                <p>Reciicer: Sistema WEB de Reciclagem</p>
                            </body>
                            </html>";

            return mensagem;
        }
    }
}