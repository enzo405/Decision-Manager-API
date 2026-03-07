using DecisionManagerAPI.Models.Enum;

namespace DecisionManagerAPI.Dtos;

public record CardDto(string Slug, string DisplayName, string Description, int RequiredLevel, float SuccessProbability, int MotivationEffect, int StressEffect, int PerformanceEffect,
    int TurnoverEffect, int MotivationEffectOnFailure, int StressEffectOnFailure, int PerformanceEffectOnFailure,
    int TurnoverEffectOnFailure, RiskLevel RiskLevel, string SuccessMessage, string FailureMessage, List<EventDto> Events);
