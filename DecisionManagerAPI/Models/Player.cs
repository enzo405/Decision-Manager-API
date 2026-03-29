using DecisionManagerAPI.Data.Configurations;

using Microsoft.EntityFrameworkCore;

namespace DecisionManagerAPI.Models;


[EntityTypeConfiguration(typeof(PlayerEntityConfiguration))]
public class Player
{
  public int Id { get; set; }
  public required string DeviceId { get; set; } = string.Empty;
  public DateTime CreatedAt { get; set; }

  public virtual required Progression Progression { get; set; } = null!;
}
