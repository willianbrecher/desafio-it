using DesafioIt.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;

namespace DesafioIt.EntityFramework;

public class DesafioItContext : DbContext
{
    public DbSet<DishEntity> Dishes { get; set; }

    public DesafioItContext(DbContextOptions<DesafioItContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("application");
        base.OnModelCreating(modelBuilder);
    }
}

