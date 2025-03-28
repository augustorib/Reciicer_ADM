using System.Net;


namespace Reciicer.Service.Error
{
    public class ErrorHandlingService
    {

        public int ErrorStatusCode(Exception ex)
        {
            return ex switch
            {
                ArgumentException => (int)HttpStatusCode.BadRequest,
                UnauthorizedAccessException => (int)HttpStatusCode.Unauthorized,
                KeyNotFoundException => (int)HttpStatusCode.NotFound,
                NullReferenceException => (int)HttpStatusCode.UnprocessableEntity,
                _ => (int)HttpStatusCode.InternalServerError
            };
        }

        public string ErrorMessage(Exception ex)
        {
            return ex switch
            {
                ArgumentException => ex.Message,
                UnauthorizedAccessException => "Acesso não autorizado.",
                KeyNotFoundException => "Recurso não encontrado.",
                NullReferenceException => "Erro interno do servidor.",
                _ => "Erro interno do servidor."
            };


        }
  
    }
}