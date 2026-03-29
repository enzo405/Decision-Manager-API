using DecisionManagerAPI.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DecisionManagerAPI.Data.Configurations;

internal class DefeatConditionsEntityConfiguration : IEntityTypeConfiguration<DefeatConditions>
{
  public void Configure(EntityTypeBuilder<DefeatConditions> builder)
  {
    builder.ToTable("DefeatConditions", "decision_manager");

    builder
      .HasData(new DefeatConditions
      {
        Id = 1,
        StressMin = 0,
        StressMax = 85,
        TurnoverMin = 0,
        TurnoverMax = 80,
        PerformanceMin = 15,
        PerformanceMax = 100,
        MotivationMin = 0,
        MotivationMax = 100
      });
  }
}
