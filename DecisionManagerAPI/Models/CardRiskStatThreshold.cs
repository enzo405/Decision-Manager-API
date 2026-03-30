using DecisionManagerAPI.Data.Configurations;
using DecisionManagerAPI.Models.Enum;

using Microsoft.EntityFrameworkCore;

namespace DecisionManagerAPI.Models;


[EntityTypeConfiguration(typeof(CardRiskStatThresholdEntityConfiguration))]
public class CardRiskStatThreshold
{
  public required Guid Id { get; set; }
  public required int CardId { get; set; }
  public required Indicator StatName { get; set; }
  public required ConditionThreshold Condition { get; set; }
  public required int Threshold { get; set; }
  public required decimal PenaltyAmount { get; set; }

  public virtual required Card Card { get; set; } = null!;
}
