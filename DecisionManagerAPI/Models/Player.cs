namespace DecisionManagerAPI.Models;

public class Player
{
  public int Id { get; set; }
  public string DeviceId { get; set; } = string.Empty;
  public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
  public Progression Progression { get; set; } = null!;
}
