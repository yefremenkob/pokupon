using Microsoft.EntityFrameworkCore;
using Pokupon.Models;

namespace Pokupon.DataAccess;
public sealed class DatabaseContext : DbContext
{
    public DbSet<Deal> Deals { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;

    public DatabaseContext() 
    {
		Database.EnsureCreated();
	}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Lite.db");
    }
}
