using DecisionManagerAPI.Dtos;

using Microsoft.EntityFrameworkCore;

namespace DecisionManagerAPI.Data.Repository;

public interface IProgressionRepository
{
  Task UpdateAsync(string deviceId, UpdateProgressionDto progressionDto);
}

public class ProgressionRepository(DecisionManagerDbContext context) : IProgressionRepository
{
  private readonly DecisionManagerDbContext _context = context;

  public async Task UpdateAsync(string deviceId, UpdateProgressionDto progressionDto)
  {
    var entity = await _context.Progressions
      .Include(p => p.Player)
      .Where(p => p.Player.DeviceId == deviceId)
      .FirstAsync();

    entity.CurrentLevel = progressionDto.CurrentLevel;
    entity.CurrentXP = progressionDto.CurrentXp;

    await _context.SaveChangesAsync();
  }
}
