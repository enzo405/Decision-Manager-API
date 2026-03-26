using DecisionManagerAPI.Models.Enum;

namespace DecisionManagerAPI.Models;

public class Card
{
  public int Id { get; set; }
  public required string Slug { get; set; }
  public required string DisplayNameEn { get; set; }
  public required string DisplayNameFr { get; set; }
  public required string DescriptionEn { get; set; }
  public required string DescriptionFr { get; set; }
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
  public required string SuccessMessageEn { get; set; }
  public required string SuccessMessageFr { get; set; }
  public required string FailureMessageEn { get; set; }
  public required string FailureMessageFr { get; set; }
  public required List<Event> Events { get; set; }
  public List<CardStatThreshold> StatThresholds { get; set; } = new();
}
