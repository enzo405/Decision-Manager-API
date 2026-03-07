using DecisionManagerAPI.Models.Enum;

namespace DecisionManagerAPI.Models;

public class Card
{
  public int Id { get; set; }
  public string Slug { get; set; } = string.Empty;
  public string DisplayName { get; set; } = string.Empty;
  public string Description { get; set; } = string.Empty;
  public int RequiredLevel { get; set; }
  public float SuccessProbability { get; set; }
  public int MotivationEffect { get; set; }
  public int StressEffect { get; set; }
  public int PerformanceEffect { get; set; }
  public int TurnoverEffect { get; set; }
  public int MotivationEffectOnFailure { get; set; }
  public int StressEffectOnFailure { get; set; }
  public int PerformanceEffectOnFailure { get; set; }
  public int TurnoverEffectOnFailure { get; set; }
  public RiskLevel RiskLevel { get; set; }
  public string SuccessMessage { get; set; } = string.Empty;
  public string FailureMessage { get; set; } = string.Empty;
  public List<Event> Events { get; set; } = new();
}
