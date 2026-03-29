using DecisionManagerAPI.Models;
using DecisionManagerAPI.Models.Enum;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DecisionManagerAPI.Data.Configurations;

internal class CardEntityConfiguration : IEntityTypeConfiguration<Card>
{
  public void Configure(EntityTypeBuilder<Card> builder)
  {
    builder.ToTable("Cards", "decision_manager");

    builder
      .HasMany(c => c.Events)
      .WithOne(e => e.Card)
      .HasForeignKey(e => e.CardId);

    builder
      .HasIndex(c => c.Slug)
      .IsUnique();

    builder
      .Property(e => e.Type)
      .HasConversion(
          v => v.ToString(),
          v => Enum.Parse<CardType>(v));
  }
}
