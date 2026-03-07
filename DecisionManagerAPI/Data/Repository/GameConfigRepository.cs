using DecisionManagerAPI.Dtos;
using DecisionManagerAPI.Models.Extentions;

using Microsoft.EntityFrameworkCore;

namespace DecisionManagerAPI.Data.Repository;

public interface IGameConfigRepository
{
  Task<ThresholdsDto> GetThresholdsAsync();
  Task<DefeatConditionDto> GetDefeatConditionAsync();
  Task UpdateThresholdsAsync(ThresholdsDto thresholdsDto);
  Task UpdateDefeatConditionAsync(DefeatConditionDto defeatConditionDto);
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
}
