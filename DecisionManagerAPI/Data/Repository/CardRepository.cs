using DecisionManagerAPI.Dtos;
using DecisionManagerAPI.Models.Extentions;

using Microsoft.EntityFrameworkCore;

namespace DecisionManagerAPI.Data.Repository;

public interface ICardRepository
{
  Task<List<CardDto>> GetAllAsync();
  Task<List<CardDto>> GetCardByLevelAsync(int level);
}


public class CardRepository(DecisionManagerDbContext context) : ICardRepository
{
  private readonly DecisionManagerDbContext _context = context;

  public async Task<List<CardDto>> GetAllAsync()
  {
    return await _context.Cards
      .Include(c => c.Events)
      .Select(c => c.ToDTO())
      .ToListAsync();
  }

  public async Task<List<CardDto>> GetCardByLevelAsync(int level)
  {
    return await _context.Cards
      .Where(c => c.RequiredLevel <= level)
      .Include(c => c.Events)
      .Select(c => c.ToDTO())
      .ToListAsync();
  }
}
