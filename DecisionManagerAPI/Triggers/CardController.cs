using DecisionManagerAPI.Data.Repository;

using Microsoft.AspNetCore.Mvc;

namespace DecisionManagerAPI.Triggers;

[ApiController]
[Route("api/cards")]
public class CardController(ICardRepository cardRepository) : ControllerBase
{
  private readonly ICardRepository _cardRepository = cardRepository;

  [HttpGet]
  public async Task<IActionResult> GetAll()
  {
    var cards = await _cardRepository.GetAllAsync();

    return Ok(cards);
  }
}
