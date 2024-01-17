using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TpApi.Entities;

namespace TpApi.Repository.Database.Configurations;

public class GameConfigurations : IEntityTypeConfiguration<Game>
{
    public void Configure(EntityTypeBuilder<Game> builder)
    {
        builder.ToTable(nameof(Game));

        builder.HasKey(g => g.Id);

        builder.Property(g => g.Id)
               .ValueGeneratedNever();

        builder.Property(g => g.Name)
               .HasMaxLength(100)
               .IsRequired();

        builder.HasOne(g => g.User)
               .WithMany(u => u.Games)
               .HasForeignKey(g => g.UserId);
    }
}
