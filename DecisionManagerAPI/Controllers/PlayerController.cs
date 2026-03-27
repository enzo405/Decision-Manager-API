using DecisionManagerAPI.Data.Repository;
using DecisionManagerAPI.Dtos;

using Microsoft.AspNetCore.Mvc;

namespace DecisionManagerAPI.Triggers;


[ApiController]
[Route("api/players")]
public class PlayerController(IPlayerRepository playerRepository, IProgressionRepository progressionRepository) : ControllerBase
{
  private readonly IPlayerRepository _playerRepository = playerRepository;
  private readonly IProgressionRepository _progressionRepository = progressionRepository;


  [HttpPost]
  public async Task<IActionResult> Create([FromBody] CreatePlayerDto dto)
  {
    var player = await _playerRepository.CreateAsync(dto);
    return CreatedAtAction(nameof(GetByDeviceId), new { deviceId = player.DeviceId }, player);
  }

  [HttpGet("{deviceId}")]
  public async Task<IActionResult> GetByDeviceId(string deviceId)
  {
    try
    {
      var player = await _playerRepository.GetByDeviceIdAsync(deviceId);

      return player == null ? NotFound($"Player with deviceId '{deviceId}' not found.") : Ok(player);
    }
    catch (KeyNotFoundException e)
    {
      return NotFound(e.Message);
    }
  }

  [HttpPut("{deviceId}/progression")]
  public async Task<IActionResult> UpdateProgression(string deviceId, [FromBody] UpdateProgressionDto dto)
  {
    try
    {
      await _progressionRepository.UpdateAsync(deviceId, dto);
      return NoContent();
    }
    catch (KeyNotFoundException e)
    {
      return NotFound(e.Message);
    }
  }
}
