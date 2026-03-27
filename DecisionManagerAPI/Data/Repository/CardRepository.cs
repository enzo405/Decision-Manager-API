using DecisionManagerAPI.Dtos;
using DecisionManagerAPI.Models.Extentions;

using Microsoft.EntityFrameworkCore;

namespace DecisionManagerAPI.Data.Repository;

public interface ICardRepository
{
  Task<List<CardDto>> GetAllAsync(string locale);
}


public class CardRepository(DecisionManagerDbContext context) : ICardRepository
{
  private readonly DecisionManagerDbContext _context = context;

  public async Task<List<CardDto>> GetAllAsync(string locale)
  {
    return await _context.Cards
      .Include(c => c.Events)
      .Include(c => c.Requirements)
      .Include(c => c.StatThresholds)
      .Select(c => c.ToDTO(locale))
      .ToListAsync();
  }
}
