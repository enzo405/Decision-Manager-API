using DecisionManagerAPI.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DecisionManagerAPI.Data.Configurations;

internal class CardComboEntityConfiguration : IEntityTypeConfiguration<CardCombo>
{
  public void Configure(EntityTypeBuilder<CardCombo> builder)
  {
    builder.ToTable("CardCombos", "decision_manager");

    builder.HasKey(e => e.Id);
  }
}
