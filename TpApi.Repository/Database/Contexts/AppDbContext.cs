using Bogus;
using Microsoft.EntityFrameworkCore;
using TpApi.Entities;
using TpApi.Entities.Common;

namespace TpApi.Repository.Database.Contexts;

public sealed class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Game> Games { get; set; } = null!;

    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        //var users = GetRandomUsers();
        //modelBuilder.Entity<User>().HasData(users);
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

    private List<Game> GetRandomGames(int count = 100)
    {
        return Enumerable.Range(0, count).Select(i => new Faker<Game>()
            .RuleFor(g => g.Id, Guid.NewGuid())
            .RuleFor(g => g.Name, f => f.Random.Words(2))
            .RuleFor(g => g.CreatedAt, f => f.Date.Past(2))
            .RuleFor(g => g.UpdatedAt, f => f.Date.Past(1))
            .Generate()).ToList();
    }

    public List<User> GetRandomUsers(int count = 30)
    {
        return Enumerable.Range(0, count).Select(i => new Faker<User>()
            .RuleFor(u => u.Id, Guid.NewGuid())
            .RuleFor(u => u.FirstName, f => f.Person.FirstName)
            .RuleFor(u => u.LastName, f => f.Person.LastName)
            .RuleFor(u => u.Email, f => f.Person.Email)
            .RuleFor(u => u.CreatedAt, f => f.Date.Past(2))
            .RuleFor(u => u.UpdatedAt, f => f.Date.Past(1))
            .Generate()).ToList();
    }
}
