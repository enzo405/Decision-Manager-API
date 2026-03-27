namespace DecisionManagerAPI.Models;

public class CardRequirement
{
  public required Guid Id { get; set; }
  public required int CardId { get; set; }
  public required Card Card { get; set; }
  public required string RequiredCardSlug { get; set; }
  public required Card RequiredCard { get; set; }
}
