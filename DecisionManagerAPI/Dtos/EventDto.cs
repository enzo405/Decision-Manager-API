namespace DecisionManagerAPI.Dtos;


public record EventDto(string Name, (int Min, int Max) WeekRange, string Message, float Chance, int MotivationDelta, int StressDelta, int PerformanceDelta, int TurnoverDelta);
