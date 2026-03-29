using DecisionManagerAPI.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DecisionManagerAPI.Data.Configurations;

internal class CardComboTriggerEntityConfiguration : IEntityTypeConfiguration<CardComboTrigger>
{
  public void Configure(EntityTypeBuilder<CardComboTrigger> builder)
  {
    builder.ToTable("CardComboTriggers", "decision_manager");

    builder
      .HasOne(t => t.CardCombo)
      .WithMany(c => c.Triggers)
      .HasForeignKey(t => t.CardComboId);

    builder
      .HasOne(t => t.Card)
      .WithMany()
      .HasForeignKey(t => t.CardSlug)
      .HasPrincipalKey(c => c.Slug);
  }
}
