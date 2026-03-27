using DecisionManagerAPI.Attributes;
using DecisionManagerAPI.Data.Repository;
using DecisionManagerAPI.Dtos;

using Microsoft.AspNetCore.Mvc;

namespace DecisionManagerAPI.Triggers;

[ApiController]
[Route("api/config")]
public class GameConfigController(IGameConfigRepository gameConfigRepository) : ControllerBase
{
  private readonly IGameConfigRepository _gameConfigRepository = gameConfigRepository;

  [HttpGet("thresholds")]
  public async Task<IActionResult> GetThresholds()
  {
    var thresholds = await _gameConfigRepository.GetThresholdsAsync();
    return Ok(thresholds);
  }

  [HttpPut("thresholds")]
  [AdminOnly]
  public async Task<IActionResult> UpdateThresholds([FromBody] ThresholdsDto dto)
  {
    await _gameConfigRepository.UpdateThresholdsAsync(dto);
    return NoContent();
  }

  [HttpGet("defeat-conditions")]
  public async Task<IActionResult> GetDefeatConditions()
  {
    var defeatConditions = await _gameConfigRepository.GetDefeatConditionAsync();
    return Ok(defeatConditions);
  }

  [HttpPut("defeat-conditions")]
  [AdminOnly]
  public async Task<IActionResult> UpdateDefeatConditions([FromBody] DefeatConditionDto dto)
  {
    await _gameConfigRepository.UpdateDefeatConditionAsync(dto);
    return NoContent();
  }

  [HttpGet("initial-stats")]
  public async Task<IActionResult> GetStatsInit()
  {
    var statsInit = await _gameConfigRepository.GetStatsInitAsync();
    return Ok(statsInit);
  }

  [HttpPut("initial-stats")]
  [AdminOnly]
  public async Task<IActionResult> UpdateStatsInit([FromBody] StatsInitDto dto)
  {
    await _gameConfigRepository.UpdateStatsInitAsync(dto);
    return NoContent();
  }
}
