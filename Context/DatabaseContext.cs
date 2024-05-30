using Cwiczenia10.Model;
using Microsoft.EntityFrameworkCore;

namespace Cwiczenia10.Context;

public class DatabaseContext : DbContext
{
    public DbSet<Role> Roles { get; set; }
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}