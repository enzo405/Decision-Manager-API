using DecisionManagerAPI.Models;
using DecisionManagerAPI.Models.Enum;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DecisionManagerAPI.Data;


public class DecisionManagerDbContext : DbContext
{
  public DecisionManagerDbContext(DbContextOptions<DecisionManagerDbContext> options) : base(options) { }

  public DbSet<Player> Players { get; set; }
  public DbSet<Progression> Progressions { get; set; }
  public DbSet<Card> Cards { get; set; }
  public DbSet<Event> Events { get; set; }
  public DbSet<GameConfig> GameConfigs { get; set; }
  public DbSet<DefeatConditions> DefeatConditions { get; set; }
  public DbSet<StatsInit> StatsInits { get; set; }
  public DbSet<CardRiskStatThreshold> CardRiskStatThreshold { get; set; }
  public DbSet<CardRequirement> CardRequirement { get; set; }
  public DbSet<CardComboTrigger> CardComboTrigger { get; set; }
  public DbSet<CardCombo> CardCombo { get; set; }


  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    modelBuilder.HasDefaultSchema("decision_manager");
  }
}
