using Microsoft.EntityFrameworkCore;
using MetalUniverse.Models;
namespace MetalUniverse.Data;

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base(options)
	{ }

	public DbSet<User> Users { get; set; }
	public DbSet<Product> Products { get; set; }
	public DbSet<UpcomingEvent> UpcomingEvents { get; set; }
	public DbSet<Order> Orders { get; set; }
	public DbSet<OrderItem> OrderItems { get; set; }
}
