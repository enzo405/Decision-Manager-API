namespace DecisionManagerAPI.Dtos;


public record EventDto(string Name, WeekRangeDto WeekRange, string Message, float Chance, int MotivationDelta, int StressDelta, int PerformanceDelta, int TurnoverDelta, string CardSlug);


public record WeekRangeDto(int Min, int Max);
