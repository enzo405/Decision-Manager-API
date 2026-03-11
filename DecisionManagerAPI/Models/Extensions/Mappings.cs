using DecisionManagerAPI.Dtos;

namespace DecisionManagerAPI.Models.Extentions;

public static class CardMappings
{
  public static CardDto ToDTO(this Card card) => new(
    card.Slug,
    card.DisplayName,
    card.Description,
    card.RequiredLevel,
    card.SuccessProbability,
    card.MotivationEffect,
    card.StressEffect,
    card.PerformanceEffect,
    card.TurnoverEffect,
    card.MotivationEffectOnFailure,
    card.StressEffectOnFailure,
    card.PerformanceEffectOnFailure,
    card.TurnoverEffectOnFailure,
    card.RiskLevel,
    card.SuccessMessage,
    card.FailureMessage,
    card.Events.Select(ToDTO).ToList() ?? []
  );

  public static EventDto ToDTO(this Event ev) => new(
    ev.EventName,
    new WeekRangeDto(ev.WeekRangeMin, ev.WeekRangeMax),
    ev.Message,
    ev.Chance,
    ev.MotivationDelta,
    ev.StressDelta,
    ev.PerformanceDelta,
    ev.TurnoverDelta,
    ev.Card.Slug);

  public static ThresholdsDto ToDTO(this GameConfig gameConfig) => new(
    gameConfig.BaseXP,
    gameConfig.Exponent,
    gameConfig.XPPerTurn,
    gameConfig.XPBonusGoodDecision,
    gameConfig.MaxLevel
  );

  public static DefeatConditionDto ToDTO(this DefeatConditions defeatConditions) => new(
    (defeatConditions.StressMin, defeatConditions.StressMax),
    (defeatConditions.TurnoverMin, defeatConditions.TurnoverMax),
    (defeatConditions.PerformanceMin, defeatConditions.PerformanceMax),
    (defeatConditions.MotivationMin, defeatConditions.MotivationMax)
  );

  public static ProgressionDto ToDTO(this Progression progression) => new(
    progression.Player.DeviceId, progression.CurrentXP, progression.CurrentLevel
  );

  public static PlayerDto ToDTO(this Player player) => new(
    player.DeviceId, player.CreatedAt, player.Progression.ToDTO()
  );
}
