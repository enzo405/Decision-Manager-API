using DecisionManagerAPI.Models.Enum;

namespace DecisionManagerAPI.Models;


public class CardStatThreshold
{
  public required Guid Id { get; set; }
  public required int CardId { get; set; }
  public required Indicator StatName { get; set; }
  public required ConditionTreshold Condition { get; set; }
  public required int Threshold { get; set; }
  public required decimal PenaltyAmount { get; set; }
  public required Card Card { get; set; }
}
