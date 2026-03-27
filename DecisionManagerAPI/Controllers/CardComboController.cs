using DecisionManagerAPI.Data.Repository;

using Microsoft.AspNetCore.Mvc;

namespace DecisionManagerAPI.Triggers;

[ApiController]
[Route("api/combos")]
public class CardComboController(ICardComboRepository cardComboRepository) : ControllerBase
{
  private readonly ICardComboRepository _cardComboRepository = cardComboRepository;

  [HttpGet]
  public async Task<IActionResult> GetAll([FromQuery] string locale = "fr")
  {
    if (locale != "fr" && locale != "en")
    {
      return BadRequest("Invalid locale. Supported values are 'fr' and 'en'.");
    }

    var cards = await _cardComboRepository.GetAllAsync(locale);

    return Ok(cards);
  }
}
