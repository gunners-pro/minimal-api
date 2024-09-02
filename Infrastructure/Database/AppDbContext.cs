using Microsoft.EntityFrameworkCore;
using minimal_api.Domain.Entities;

namespace minimal_api.Infrastructure.Database;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Administrator> Administrators { get; set; }
}
