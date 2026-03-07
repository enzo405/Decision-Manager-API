using DecisionManagerAPI.Dtos;

using Microsoft.EntityFrameworkCore;

namespace DecisionManagerAPI.Data.Repository;

public interface IProgressionRepository
{
  Task UpdateAsync(ProgressionDto progressionDto);
}

public class ProgressionRepository(DecisionManagerDbContext context) : IProgressionRepository
{
  private readonly DecisionManagerDbContext _context = context;

  public async Task UpdateAsync(ProgressionDto progressionDto)
  {
    var entity = await _context.Progressions
      .Include(p => p.Player)
      .Where(p => p.Player.DeviceId == progressionDto.DeviceId)
      .FirstAsync();

    entity.CurrentLevel = progressionDto.CurrentLevel;
    entity.CurrentXP = progressionDto.CurrentXP;

    await _context.SaveChangesAsync();
  }
}
