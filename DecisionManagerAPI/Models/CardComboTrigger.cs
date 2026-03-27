namespace DecisionManagerAPI.Models;

public class CardComboTrigger
{
  public required Guid Id { get; set; }
  public required Guid CardComboId { get; set; }
  public required CardCombo CardCombo { get; set; }
  public required string CardSlug { get; set; }
  public required Card Card { get; set; }
}
