namespace DecisionManagerAPI.Models;

public class Progression
{
  public int Id { get; set; }
  public int CurrentXP { get; set; } = 0;
  public int CurrentLevel { get; set; } = 1;
  public int PlayerId { get; set; }
  public Player Player { get; set; } = null!;
}
