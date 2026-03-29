using DecisionManagerAPI.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DecisionManagerAPI.Data.Configurations;

internal class ProgressionEntityConfiguration : IEntityTypeConfiguration<Progression>
{
  public void Configure(EntityTypeBuilder<Progression> builder)
  {
    builder.ToTable("Progressions", "decision_manager");
  }
}
