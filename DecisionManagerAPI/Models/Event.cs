namespace DecisionManagerAPI.Models;

public class Event
{
  public int Id { get; set; }
  public string EventNameEn { get; set; } = string.Empty;
  public string EventNameFr { get; set; } = string.Empty;
  public string MessageEn { get; set; } = string.Empty;
  public string MessageFr { get; set; } = string.Empty;
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
