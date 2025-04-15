
namespace Reciicer.Models.Entities
{
    public class AuditLog
    {
        public int Id { get; set; }
        public string? Tabela { get; set; }
        public string? Acao { get; set; } 
        public string? RegistroId { get; set; }
        public string? Changes { get; set; }
        public string? ModificadoPor { get; set; }
        public DateTime ModificadoEm { get; set; }
    }
}