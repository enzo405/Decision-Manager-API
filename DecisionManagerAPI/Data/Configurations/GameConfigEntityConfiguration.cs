using DecisionManagerAPI.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DecisionManagerAPI.Data.Configurations;

internal class GameConfigEntityConfiguration : IEntityTypeConfiguration<GameConfig>
{
  public void Configure(EntityTypeBuilder<GameConfig> builder)
  {
    builder.ToTable("GameConfigs", "decision_manager");

    builder
      .HasData(new GameConfig
      {
        Id = 1,
        BaseXP = 2000,
        Exponent = 2.0f,
        XPPerTurn = 50,
        XPBonusGoodDecision = 25,
        MaxLevel = 20
      });
  }
}
