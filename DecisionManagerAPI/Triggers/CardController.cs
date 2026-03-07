using DecisionManagerAPI.Data.Repository;

using Microsoft.AspNetCore.Mvc;

namespace DecisionManagerAPI.Triggers;

[ApiController]
[Route("api/cards")]
public class CardController(ICardRepository cardRepository) : ControllerBase
{
  private readonly ICardRepository _cardRepository = cardRepository;

  [HttpGet]
  public async Task<IActionResult> GetAll([FromQuery] int? level)
  {
    var cards = level.HasValue
        ? await _cardRepository.GetCardByLevelAsync(level.Value)
        : await _cardRepository.GetAllAsync();

    return Ok(cards);
  }
}
