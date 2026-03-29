using DecisionManagerAPI.Data.Configurations;

using Microsoft.EntityFrameworkCore;

namespace DecisionManagerAPI.Models;


[EntityTypeConfiguration(typeof(StatsInitEntityConfiguration))]
public class StatsInit
{
  public int Id { get; set; }
  public required int InitialMotivation { get; set; }
  public required int InitialStress { get; set; }
  public required int InitialPerformance { get; set; }
  public required int InitialTurnover { get; set; }
}
