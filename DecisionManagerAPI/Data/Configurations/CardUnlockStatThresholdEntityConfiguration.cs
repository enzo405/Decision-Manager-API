using DecisionManagerAPI.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DecisionManagerAPI.Data.Configurations;

internal class CardUnlockStatThresholdEntityConfiguration : IEntityTypeConfiguration<CardUnlockStatThreshold>
{
  public void Configure(EntityTypeBuilder<CardUnlockStatThreshold> builder)
  {
    builder.ToTable("CardUnlockStatThresholds", "decision_manager");

    builder
      .HasOne(t => t.Card)
      .WithMany(c => c.StatThresholdsUnlock)
      .HasForeignKey(t => t.CardId)
      .OnDelete(DeleteBehavior.Cascade);

    builder
        .Property(t => t.StatName)
        .HasConversion<int>();

    builder
        .Property(t => t.Condition)
        .HasConversion<int>();
  }
}
