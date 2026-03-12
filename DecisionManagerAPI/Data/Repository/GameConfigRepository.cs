using DecisionManagerAPI.Dtos;
using DecisionManagerAPI.Models.Extentions;

using Microsoft.EntityFrameworkCore;

namespace DecisionManagerAPI.Data.Repository;

public interface IGameConfigRepository
{
  Task<ThresholdsDto> GetThresholdsAsync();
  Task<DefeatConditionDto> GetDefeatConditionAsync();
  Task<StatsInitDto> GetStatsInitAsync();
  Task UpdateThresholdsAsync(ThresholdsDto thresholdsDto);
  Task UpdateDefeatConditionAsync(DefeatConditionDto defeatConditionDto);
  Task UpdateStatsInitAsync(StatsInitDto statsInitDto);
}


public class GameConfigRepository(DecisionManagerDbContext context) : IGameConfigRepository
{
  private readonly DecisionManagerDbContext _context = context;

  public async Task<DefeatConditionDto> GetDefeatConditionAsync()
  {
    return await _context.DefeatConditions
      .Select(dc => dc.ToDTO())
      .FirstAsync();
  }

  public async Task<ThresholdsDto> GetThresholdsAsync()
  {
    return await _context.GameConfigs
      .Select(c => c.ToDTO())
      .FirstAsync();
  }

  public async Task<StatsInitDto> GetStatsInitAsync()
  {
    return await _context.StatsInits
      .Select(s => s.ToDTO())
      .FirstAsync();
  }

  public async Task UpdateDefeatConditionAsync(DefeatConditionDto defeatConditionDto)
  {
    var entity = await _context.DefeatConditions.FirstAsync();

    entity.StressMin = defeatConditionDto.Stress.Min;
    entity.StressMax = defeatConditionDto.Stress.Max;
    entity.MotivationMin = defeatConditionDto.Motivation.Min;
    entity.MotivationMax = defeatConditionDto.Motivation.Max;
    entity.TurnoverMin = defeatConditionDto.Turnover.Min;
    entity.TurnoverMax = defeatConditionDto.Turnover.Max;
    entity.PerformanceMin = defeatConditionDto.Performance.Min;
    entity.PerformanceMax = defeatConditionDto.Performance.Max;

    await _context.SaveChangesAsync();
  }

  public async Task UpdateThresholdsAsync(ThresholdsDto thresholdsDto)
  {
    var entity = await _context.GameConfigs.FirstAsync();

    entity.BaseXP = thresholdsDto.BaseXp;
    entity.Exponent = thresholdsDto.Exponent;
    entity.XPPerTurn = thresholdsDto.XpPerTurn;
    entity.XPBonusGoodDecision = thresholdsDto.XpBonusGoodDecision;
    entity.MaxLevel = thresholdsDto.MaxLevel;

    await _context.SaveChangesAsync();
  }

  public async Task UpdateStatsInitAsync(StatsInitDto statsInitDto)
  {
    var entity = await _context.StatsInits.FirstAsync();

    entity.InitialMotivation = statsInitDto.InitialMotivation;
    entity.InitialPerformance = statsInitDto.InitialPerformance;
    entity.InitialStress = statsInitDto.InitialStress;
    entity.InitialTurnover = statsInitDto.InitialTurnover;

    await _context.SaveChangesAsync();
  }
}
