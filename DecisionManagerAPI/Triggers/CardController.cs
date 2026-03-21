using DecisionManagerAPI.Data.Repository;

using Microsoft.AspNetCore.Mvc;

namespace DecisionManagerAPI.Triggers;

[ApiController]
[Route("api/cards")]
public class CardController(ICardRepository cardRepository) : ControllerBase
{
  private readonly ICardRepository _cardRepository = cardRepository;

  [HttpGet]
  public async Task<IActionResult> GetAll([FromQuery] string locale = "fr")
  {
    if (locale != "fr" && locale != "en")
    {
      return BadRequest("Invalid locale. Supported values are 'fr' and 'en'.");
    }

    var cards = await _cardRepository.GetAllAsync(locale);

    return Ok(cards);
  }
}
