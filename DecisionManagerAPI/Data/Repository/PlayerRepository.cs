using DecisionManagerAPI.Dtos;
using DecisionManagerAPI.Models;
using DecisionManagerAPI.Models.Extentions;

using Microsoft.EntityFrameworkCore;

namespace DecisionManagerAPI.Data.Repository;

public interface IPlayerRepository
{
  Task<PlayerDto> CreateAsync(CreatePlayerDto playerDto);
  Task<PlayerDto?> GetByDeviceIdAsync(string deviceId);
}

public class PlayerRepository(DecisionManagerDbContext context) : IPlayerRepository
{
  private readonly DecisionManagerDbContext _context = context;

  public async Task<PlayerDto> CreateAsync(CreatePlayerDto playerDto)
  {
    Player entity = new()
    {
      DeviceId = playerDto.DeviceId,
      Progression = new Progression
      {
        CurrentLevel = 1,
        CurrentXP = 0,
      }
    };

    _context.Players.Add(entity);

    // Also saves the Progression and assign the generated Id to the Player
    await _context.SaveChangesAsync();

    return entity.ToDTO();
  }

  public async Task<PlayerDto?> GetByDeviceIdAsync(string deviceId)
  {
    return await _context.Players
      .Include(p => p.Progression)
      .Where(p => p.DeviceId == deviceId)
      .Select(p => p.ToDTO())
      .FirstOrDefaultAsync();
  }
}
