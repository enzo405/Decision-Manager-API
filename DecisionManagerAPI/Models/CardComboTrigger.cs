using DecisionManagerAPI.Data.Configurations;

using Microsoft.EntityFrameworkCore;

namespace DecisionManagerAPI.Models;

[EntityTypeConfiguration(typeof(CardComboTriggerEntityConfiguration))]
public class CardComboTrigger
{
  public required Guid Id { get; set; }
  public required Guid CardComboId { get; set; }
  public required string CardSlug { get; set; }

  public virtual required CardCombo CardCombo { get; set; } = null!;
  public virtual required Card Card { get; set; } = null!;
}
