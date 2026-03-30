using DecisionManagerAPI.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DecisionManagerAPI.Data.Configurations;

internal class CardRiskStatThresholdEntityConfiguration : IEntityTypeConfiguration<CardRiskStatThreshold>
{
  public void Configure(EntityTypeBuilder<CardRiskStatThreshold> builder)
  {
    builder.ToTable("CardRiskStatThresholds", "decision_manager");

    builder
      .HasOne(t => t.Card)
      .WithMany(c => c.StatThresholdsRisk)
      .HasForeignKey(t => t.CardId)
      .OnDelete(DeleteBehavior.Cascade);

    builder
        .Property(t => t.PenaltyAmount)
        .HasPrecision(18, 2);

    builder
        .Property(t => t.StatName)
        .HasConversion<int>();

    builder
        .Property(t => t.Condition)
        .HasConversion<int>();
  }
}
