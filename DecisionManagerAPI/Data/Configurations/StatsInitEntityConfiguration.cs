using DecisionManagerAPI.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DecisionManagerAPI.Data.Configurations;

internal class StatsInitEntityConfiguration : IEntityTypeConfiguration<StatsInit>
{
  public void Configure(EntityTypeBuilder<StatsInit> builder)
  {
    builder.ToTable("StatsInits", "decision_manager");

    builder
      .HasData(new StatsInit
      {
        Id = 1,
        InitialMotivation = 50,
        InitialPerformance = 40,
        InitialTurnover = 20,
        InitialStress = 30,
      });
  }
}
