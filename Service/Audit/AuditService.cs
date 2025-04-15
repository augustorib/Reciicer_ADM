using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;
using Reciicer.Models.Entities;

using System.Security.Claims;

namespace Reciicer.Service.Audit
{
    public class AuditService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AuditService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void AplicarInformacoesAudit(ChangeTracker changeTracker)
        {
            var entries = changeTracker.Entries<EntidadeBase>();

            foreach (var entry in entries)
            {
                var userName = _httpContextAccessor?.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "Sistema";

                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedBy = userName;
                    entry.Entity.CreatedAt = DateTime.Now;
                }
                else if (entry.State == EntityState.Modified)
                {
                    entry.Entity.UpdatedBy = userName;
                    entry.Entity.UpdatedAt = DateTime.Now;
                }
            }
        }

        public void AuditInformacoesLog(ChangeTracker changeTracker, DbSet<AuditLog> auditLogs)
        {
            var logs = new List<AuditLog>();
            var entries = changeTracker.Entries<EntidadeBase>();

            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Deleted)
                {
                    var tableName = entry.Entity.GetType().Name;
                    var recordId = entry.Properties.FirstOrDefault(p => p.Metadata.IsPrimaryKey())?.CurrentValue?.ToString();
                    var userName = _httpContextAccessor?.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "System";
                    
                    var changes = new Dictionary<string, object>();
                    
                    foreach (var property in entry.Properties)
                    {
                        if (entry.State == EntityState.Deleted)
                        {
                            changes[property.Metadata.Name] = new { OldValue = property.OriginalValue };
                        }
                    }

                    logs.Add(new AuditLog {
                        Tabela = tableName,
                        Acao = "DELETE",
                        RegistroId = recordId!.ToString(),
                        Changes = JsonConvert.SerializeObject(changes),
                        ModificadoPor = userName,
                        ModificadoEm = DateTime.Now
                    });
                }
            }

            auditLogs.AddRange(logs);
        }
    }
}