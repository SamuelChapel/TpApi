using Microsoft.EntityFrameworkCore;
using TpApi.Entities;
using TpApi.Entities.Common;

namespace TpApi.Repository.Database.Contexts;

public sealed class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        ChangeTracker
            .Entries()
            .Where(e => e.Entity is IDated && e.State is EntityState.Added or EntityState.Modified)
            .ToList()
            .ForEach(e =>
            {
                if (e.State is EntityState.Added)
                {
                    ((IDated)e.Entity).CreatedAt = DateTime.UtcNow;
                }

                ((IDated)e.Entity).UpdatedAt = DateTime.UtcNow;
            });

        return base.SaveChangesAsync(cancellationToken);
    }
}
