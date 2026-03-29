using DecisionManagerAPI.Data.Configurations;

using Microsoft.EntityFrameworkCore;

namespace DecisionManagerAPI.Models;


[EntityTypeConfiguration(typeof(EventEntityConfiguration))]
public class Event
{
  public int Id { get; set; }
  public required string EventNameEn { get; set; } = string.Empty;
  public required string EventNameFr { get; set; } = string.Empty;
  public required string MessageEn { get; set; } = string.Empty;
  public required string MessageFr { get; set; } = string.Empty;
  public required float Chance { get; set; }
  public required int WeekRangeMin { get; set; }
  public required int WeekRangeMax { get; set; }
  public required int MotivationDelta { get; set; }
  public required int StressDelta { get; set; }
  public required int PerformanceDelta { get; set; }
  public required int TurnoverDelta { get; set; }
  public required int CardId { get; set; }

  public virtual required Card Card { get; set; } = null!;
}
