using DecisionManagerAPI.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DecisionManagerAPI.Data.Configurations;

internal class PlayerEntityConfiguration : IEntityTypeConfiguration<Player>
{
  public void Configure(EntityTypeBuilder<Player> builder)
  {
    builder.ToTable("Players", "decision_manager");

    builder
      .HasIndex(p => p.DeviceId)
      .IsUnique();

    builder
      .HasOne(p => p.Progression)
      .WithOne(pr => pr.Player)
      .HasForeignKey<Progression>(pr => pr.PlayerId);

    builder
      .Property(p => p.CreatedAt)
      .HasDefaultValueSql("CURRENT_TIMESTAMP")
      .ValueGeneratedOnAdd();
  }
}
