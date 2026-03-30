using DecisionManagerAPI.Dtos;

namespace DecisionManagerAPI.Models.Extentions;

public static class CardMappings
{
  public static CardDto ToDTO(this Card card, string locale = "fr") => new(
    card.Slug,
    card.Type,
    locale == "fr" ? card.DisplayNameFr : card.DisplayNameEn,
    locale == "fr" ? card.DescriptionFr : card.DescriptionEn,
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
    locale == "fr" ? card.SuccessMessageFr : card.SuccessMessageEn,
    locale == "fr" ? card.FailureMessageFr : card.FailureMessageEn,
    card.Events.Select(ev => ev.ToDTO(locale)).ToList() ?? [],
    card.StatThresholdsRisk.Select(ToDto).ToList() ?? [],
    card.StatThresholdsUnlock.Select(ToDto).ToList() ?? [],
    card.Requirements.Select(e => e.RequiredCardSlug).ToList() ?? []
  );

  public static EventDto ToDTO(this Event ev, string locale) => new(
    locale == "fr" ? ev.EventNameFr : ev.EventNameEn,
    new(ev.WeekRangeMin, ev.WeekRangeMax),
    locale == "fr" ? ev.MessageFr : ev.MessageEn,
    ev.Chance,
    ev.MotivationDelta,
    ev.StressDelta,
    ev.PerformanceDelta,
    ev.TurnoverDelta,
    ev.Card.Slug);

  public static CardRiskStatThresholdDto ToDto(this CardRiskStatThreshold cardRiskStatThreshold) => new(
    cardRiskStatThreshold.StatName.ToString(),
    cardRiskStatThreshold.Condition.ToString(),
    cardRiskStatThreshold.Threshold,
    cardRiskStatThreshold.PenaltyAmount
  );

  public static CardUnlockStatThresholdDto ToDto(this CardUnlockStatThreshold cardUnlockStatThreshold) => new(
    cardUnlockStatThreshold.StatName.ToString(),
    cardUnlockStatThreshold.Condition.ToString(),
    cardUnlockStatThreshold.Threshold
  );

  public static CardComboDto ToDto(this CardCombo cardCombo, string locale) => new(
    cardCombo.Id,
    locale == "fr" ? cardCombo.NameFr : cardCombo.NameEn,
    locale == "fr" ? cardCombo.MessageFr : cardCombo.MessageEn,
    cardCombo.MotivationDelta,
    cardCombo.StressDelta,
    cardCombo.PerformanceDelta,
    cardCombo.TurnoverDelta,
    cardCombo.Triggers.Select(t => t.CardSlug).ToList()
  );

  public static ThresholdsDto ToDTO(this GameConfig gameConfig) => new(
    gameConfig.BaseXP,
    gameConfig.Exponent,
    gameConfig.XPPerTurn,
    gameConfig.XPBonusGoodDecision,
    gameConfig.MaxLevel
  );

  public static DefeatConditionDto ToDTO(this DefeatConditions defeatConditions) => new(
    new(defeatConditions.StressMin, defeatConditions.StressMax),
    new(defeatConditions.TurnoverMin, defeatConditions.TurnoverMax),
    new(defeatConditions.PerformanceMin, defeatConditions.PerformanceMax),
    new(defeatConditions.MotivationMin, defeatConditions.MotivationMax)
  );

  public static ProgressionDto ToDTO(this Progression progression) => new(
    progression.Player.DeviceId, progression.CurrentXP, progression.CurrentLevel
  );

  public static PlayerDto ToDTO(this Player player) => new(
    player.DeviceId, player.CreatedAt, player.Progression.ToDTO()
  );

  public static StatsInitDto ToDTO(this StatsInit statsInit) => new(
    statsInit.InitialMotivation,
    statsInit.InitialStress,
    statsInit.InitialPerformance,
    statsInit.InitialTurnover
  );
}
