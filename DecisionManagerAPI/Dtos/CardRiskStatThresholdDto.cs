namespace DecisionManagerAPI.Dtos;

public record CardRiskStatThresholdDto(string StatName, string Condition, int Threshold, decimal PenaltyAmount);
