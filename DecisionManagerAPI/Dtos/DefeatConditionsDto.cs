namespace DecisionManagerAPI.Dtos;

public record DefeatConditionDto(MinMaxDto Stress, MinMaxDto Turnover, MinMaxDto Performance, MinMaxDto Motivation);

public record MinMaxDto(int Min, int Max);
