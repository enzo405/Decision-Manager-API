using DecisionManagerAPI.Dtos;
using DecisionManagerAPI.Models.Extentions;

using Microsoft.EntityFrameworkCore;

namespace DecisionManagerAPI.Data.Repository;

public interface ICardComboRepository
{
  Task<List<CardComboDto>> GetAllAsync(string locale);
}


public class CardComboRepository(DecisionManagerDbContext context) : ICardComboRepository
{
  private readonly DecisionManagerDbContext _context = context;

  public async Task<List<CardComboDto>> GetAllAsync(string locale)
  {
    return await _context.CardCombo
      .Include(c => c.Triggers)
      .Select(c => c.ToDto(locale))
      .ToListAsync();
  }
}
