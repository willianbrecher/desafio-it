using DesafioIt.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;

namespace DesafioIt.EntityFramework;

public class DesafioItContext : DbContext
{
    public DbSet<ItemEntity> Items { get; set; }

    public DbSet<ItemValueEntity> ItemValues { get; set; }

    public DesafioItContext(DbContextOptions<DesafioItContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("application");
        base.OnModelCreating(modelBuilder);
    }
}

