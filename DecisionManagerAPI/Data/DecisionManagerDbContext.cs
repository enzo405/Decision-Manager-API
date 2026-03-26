using DecisionManagerAPI.Models;

using Microsoft.EntityFrameworkCore;

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


  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Player>()
      .HasIndex(p => p.DeviceId)
      .IsUnique();

    modelBuilder.Entity<Player>()
      .HasOne(p => p.Progression)
      .WithOne(pr => pr.Player)
      .HasForeignKey<Progression>(pr => pr.PlayerId);

    modelBuilder.Entity<Card>()
      .HasMany(c => c.Events)
      .WithOne(e => e.Card)
      .HasForeignKey(e => e.CardId);

    modelBuilder.Entity<Card>()
      .HasIndex(c => c.Slug)
      .IsUnique();

    modelBuilder.Entity<CardStatThreshold>()
      .HasOne(t => t.Card)
      .WithMany(c => c.StatThresholds)
      .HasForeignKey(t => t.CardId)
      .OnDelete(DeleteBehavior.Cascade);

    modelBuilder.Entity<CardStatThreshold>()
        .Property(t => t.PenaltyAmount)
        .HasPrecision(18, 2);

    modelBuilder.Entity<CardStatThreshold>()
        .Property(t => t.StatName)
        .HasConversion<int>();

    modelBuilder.Entity<CardStatThreshold>()
        .Property(t => t.Condition)
        .HasConversion<int>();

    modelBuilder.Entity<GameConfig>()
      .HasData(new GameConfig
      {
        Id = 1,
        BaseXP = 2000,
        Exponent = 2.0f,
        XPPerTurn = 50,
        XPBonusGoodDecision = 25,
        MaxLevel = 20
      });

    modelBuilder.Entity<StatsInit>()
      .HasData(new StatsInit
      {
        Id = 1,
        InitialMotivation = 50,
        InitialPerformance = 40,
        InitialTurnover = 20,
        InitialStress = 30,
      });

    modelBuilder.Entity<DefeatConditions>()
      .HasData(new DefeatConditions
      {
        Id = 1,
        StressMin = 0,
        StressMax = 85,
        TurnoverMin = 0,
        TurnoverMax = 80,
        PerformanceMin = 15,
        PerformanceMax = 100,
        MotivationMin = 0,
        MotivationMax = 100
      });
  }
}
