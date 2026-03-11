using DecisionManagerAPI.Dtos;
using DecisionManagerAPI.Models.Extentions;

using Microsoft.EntityFrameworkCore;

namespace DecisionManagerAPI.Data.Repository;

public interface ICardRepository
{
  Task<List<CardDto>> GetAllAsync();
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
}
