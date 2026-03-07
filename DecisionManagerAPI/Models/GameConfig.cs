namespace DecisionManagerAPI.Models;

public class GameConfig
{
  public int Id { get; set; }
  public int BaseXP { get; set; } = 2000;
  public float Exponent { get; set; } = 2.0f;
  public int XPPerTurn { get; set; } = 50;
  public int XPBonusGoodDecision { get; set; } = 25;
  public int MaxLevel { get; set; } = 20;
}
