using Microsoft.EntityFrameworkCore;

namespace RegistrosWasm.Server.DAL
{
    public class PrioridadContext : DbContext
    {
        public PrioridadContext(DbContextOptions<PrioridadContext> options)
            :base(options) { }

        public DbSet<PrioridadContext> PrioridadContexts { get; set; }
    }
}
