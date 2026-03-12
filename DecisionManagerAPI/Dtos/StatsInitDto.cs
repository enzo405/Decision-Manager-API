namespace DecisionManagerAPI.Dtos;

public record StatsInitDto(
  int InitialMotivation,
  int InitialStress,
  int InitialPerformance,
  int InitialTurnover
);
