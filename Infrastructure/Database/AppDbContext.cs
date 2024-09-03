using Microsoft.EntityFrameworkCore;
using minimal_api.Domain.Entities;

namespace minimal_api.Infrastructure.Database;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Administrator> Administrators { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administrator>().HasData(
            new Administrator
            {
                Id = 1,
                Email = "administrador@teste.com",
                Password = "123456",
                Profile = "admin"
            }
        );
    }
}
