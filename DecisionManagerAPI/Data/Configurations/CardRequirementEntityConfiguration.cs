using DecisionManagerAPI.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DecisionManagerAPI.Data.Configurations;

internal class CardRequirementEntityConfiguration : IEntityTypeConfiguration<CardRequirement>
{
  public void Configure(EntityTypeBuilder<CardRequirement> builder)
  {
    builder.ToTable("CardRequirements", "decision_manager");

    builder
      .HasOne(r => r.Card)
      .WithMany(c => c.Requirements)
      .HasForeignKey(r => r.CardId);

    builder
      .HasOne(r => r.RequiredCard)
      .WithMany()
      .HasForeignKey(r => r.RequiredCardSlug)
      .HasPrincipalKey(c => c.Slug);
  }
}
