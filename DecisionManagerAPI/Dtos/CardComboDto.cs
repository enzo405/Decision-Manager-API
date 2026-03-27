namespace DecisionManagerAPI.Dtos;


public record CardComboDto(
  Guid Id,
  string Name,
  string Message,
  int MotivationDelta,
  int StressDelta,
  int PerformanceDelta,
  int TurnoverDelta,
  List<string> TriggerSlugs
);
