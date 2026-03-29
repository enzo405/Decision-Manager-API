using DecisionManagerAPI.Data.Configurations;

using Microsoft.EntityFrameworkCore;

namespace DecisionManagerAPI.Models;


[EntityTypeConfiguration(typeof(DefeatConditionsEntityConfiguration))]
public class DefeatConditions
{
  public int Id { get; set; }
  public required int StressMin { get; set; } = 0;
  public required int StressMax { get; set; } = 85;
  public required int TurnoverMin { get; set; } = 0;
  public required int TurnoverMax { get; set; } = 80;
  public required int PerformanceMin { get; set; } = 15;
  public required int PerformanceMax { get; set; } = 100;
  public required int MotivationMin { get; set; } = 0;
  public required int MotivationMax { get; set; } = 100;
}
