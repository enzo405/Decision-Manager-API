using DecisionManagerAPI.Data.Configurations;

using Microsoft.EntityFrameworkCore;

namespace DecisionManagerAPI.Models;


[EntityTypeConfiguration(typeof(CardRequirementEntityConfiguration))]
public class CardRequirement
{
  public required Guid Id { get; set; }
  public required int CardId { get; set; }
  public required string RequiredCardSlug { get; set; }

  public virtual required Card Card { get; set; } = null!;
  public virtual required Card RequiredCard { get; set; } = null!;
}
