namespace DecisionManagerAPI.Models;

public class CardCombo
{
  public required Guid Id { get; set; }
  public required string NameFr { get; set; }
  public required string NameEn { get; set; }
  public required string MessageFr { get; set; }
  public required string MessageEn { get; set; }

  public required int MotivationDelta { get; set; }
  public required int StressDelta { get; set; }
  public required int PerformanceDelta { get; set; }
  public required int TurnoverDelta { get; set; }

  // Les cartes qui déclenchent ce combo
  public required List<CardComboTrigger> Triggers { get; set; } = new();
}
