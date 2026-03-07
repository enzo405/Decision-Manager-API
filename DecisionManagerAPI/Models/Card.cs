using DecisionManagerAPI.Models.Enum;

namespace DecisionManagerAPI.Models;

public class Card
{
  public int Id { get; set; }
  public required string Slug { get; set; }
  public required string DisplayName { get; set; }
  public required string Description { get; set; }
  public required int RequiredLevel { get; set; }
  public required float SuccessProbability { get; set; }
  public required int MotivationEffect { get; set; }
  public required int StressEffect { get; set; }
  public required int PerformanceEffect { get; set; }
  public required int TurnoverEffect { get; set; }
  public required int MotivationEffectOnFailure { get; set; }
  public required int StressEffectOnFailure { get; set; }
  public required int PerformanceEffectOnFailure { get; set; }
  public required int TurnoverEffectOnFailure { get; set; }
  public required RiskLevel RiskLevel { get; set; }
  public required string SuccessMessage { get; set; }
  public required string FailureMessage { get; set; }
  public required List<Event> Events { get; set; }
}
