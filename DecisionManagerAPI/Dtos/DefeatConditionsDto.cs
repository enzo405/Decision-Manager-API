namespace DecisionManagerAPI.Dtos;

public record DefeatConditionDto((int Min, int Max) Stress, (int Min, int Max) Turnover, (int Min, int Max) Performance, (int Min, int Max) Motivation);
