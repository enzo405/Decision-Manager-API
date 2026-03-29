using DecisionManagerAPI.Data.Configurations;

using Microsoft.EntityFrameworkCore;

namespace DecisionManagerAPI.Models;


[EntityTypeConfiguration(typeof(ProgressionEntityConfiguration))]
public class Progression
{
  public int Id { get; set; }
  public required int CurrentXP { get; set; } = 0;
  public required int CurrentLevel { get; set; } = 1;

  public int PlayerId { get; set; }
  public virtual Player Player { get; set; } = null!;
}
