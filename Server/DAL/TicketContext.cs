using Microsoft.EntityFrameworkCore;
using RegistrosWasm.Shared.Models;

namespace RegistrosWasm.Server.DAL;

public class TicketContext : DbContext
{
	public TicketContext(DbContextOptions<TicketContext> Options)
		: base(Options) { }

	public DbSet<Tickets> Tickets { get; set; }
}



