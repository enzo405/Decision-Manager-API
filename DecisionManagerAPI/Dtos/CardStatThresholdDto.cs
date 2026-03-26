namespace DecisionManagerAPI.Dtos;

public record CardStatThresholdDto(string StatName, string Condition, int Threshold, decimal PenaltyAmount);
