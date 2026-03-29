using DecisionManagerAPI.Data.Configurations;

using Microsoft.EntityFrameworkCore;

namespace DecisionManagerAPI.Models;


[EntityTypeConfiguration(typeof(GameConfigEntityConfiguration))]
public class GameConfig
{
  public int Id { get; set; }
  public required int BaseXP { get; set; } = 2000;
  public required float Exponent { get; set; } = 2.0f;
  public required int XPPerTurn { get; set; } = 50;
  public required int XPBonusGoodDecision { get; set; } = 25;
  public required int MaxLevel { get; set; } = 20;
}
