namespace DecisionManagerAPI.Models;

public class Event
{
  public int Id { get; set; }
  public string EventName { get; set; } = string.Empty;
  public string Message { get; set; } = string.Empty;
  public float Chance { get; set; }
  public int WeekRangeMin { get; set; }
  public int WeekRangeMax { get; set; }
  public int MotivationDelta { get; set; }
  public int StressDelta { get; set; }
  public int PerformanceDelta { get; set; }
  public int TurnoverDelta { get; set; }
  public int CardId { get; set; }
  public Card Card { get; set; } = null!;
}
