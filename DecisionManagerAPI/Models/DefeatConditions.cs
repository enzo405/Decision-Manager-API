namespace DecisionManagerAPI.Models;

public class DefeatConditions
{
  public int Id { get; set; }
  public int StressMin { get; set; } = 0;
  public int StressMax { get; set; } = 85;
  public int TurnoverMin { get; set; } = 0;
  public int TurnoverMax { get; set; } = 80;
  public int PerformanceMin { get; set; } = 15;
  public int PerformanceMax { get; set; } = 100;
  public int MotivationMin { get; set; } = 0;
  public int MotivationMax { get; set; } = 100;
}
