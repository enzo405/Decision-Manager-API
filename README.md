# DecisionManager API

REST API for the [Decision Manager](https://github.com/enzo405/Decision-Manager) serious game — a mobile management simulation game built with Unity.

Handles player progression, card configuration, game settings and random events. Designed to allow remote configuration of game mechanics without requiring a game update.

---

## Tech Stack

- **Framework** : ASP.NET Core 9
- **Database** : PostgreSQL
- **ORM** : Entity Framework Core
- **Containerization** : Docker / Docker Compose

---


## Endpoints

### Player Endpoints
| Method | Endpoint | Description | Request Body | Response |
|---|---|---|---|---|
| `POST` | `/api/players` | Créer un joueur | `{ deviceId: string }` | `PlayerDTO` |
| `GET` | `/api/players/{deviceId}` | Récupérer un joueur | — | `PlayerDTO` |
| `PUT` | `/api/players/{deviceId}/progression` | Mettre à jour XP et niveau | `UpdateProgressionDTO` | `ProgressionDTO` |

### Cards Endpoints
| Method | Endpoint | Description | Request Body | Response |
|---|---|---|---|---|
| `GET` | `/api/cards` | Récupérer toutes les cartes | — | `CardDTO[]` |

### Game Config Endpoints
| Method | Endpoint | Description | Request Body | Response |
|---|---|---|---|---|
| `GET` | `/api/config/thresholds` | Récupérer les seuils | — | `ThresholdsDTO` |
| `PUT` | `/api/config/thresholds` | Modifier les seuils | `ThresholdsDTO` | `ThresholdsDTO` |
| `GET` | `/api/config/defeat-conditions` | Récupérer les conditions de défaite | — | `DefeatConditionsDTO` |
| `PUT` | `/api/config/defeat-conditions` | Modifier les conditions de défaite | `DefeatConditionsDTO` | `DefeatConditionsDTO` |
| `GET` | `/api/config/initial-stats` | Récupérer les statistiques initial | — | `StatsInitDTO` |
| `PUT` | `/api/config/initial-stats` | Modifier les statistiques initial | `StatsInitDTO` | `StatsInitDTO` |

---

## DTOs

### PlayerDTO
```json
{
  "deviceId": "string",
  "createdAt": "datetime",
  "progression": ProgressionDTO
}
```

### ProgressionDTO
```json
{
  "deviceId": "string",
  "currentXP": 0,
  "currentLevel": 1
}
```

### UpdateProgressionDTO
```json
{
  "currentXP": 0,
  "currentLevel": 1
}
```

### CardDTO
```json
{
  "slug": "string",
  "displayName": "string",
  "description": "string",
  "requiredLevel": 1,
  "successProbability": 0.75,
  "motivationEffect": 0,
  "stressEffect": 0,
  "performanceEffect": 0,
  "turnoverEffect": 0,
  "motivationEffectOnFailure": 0,
  "stressEffectOnFailure": 0,
  "performanceEffectOnFailure": 0,
  "turnoverEffectOnFailure": 0,
  "riskLevel": "Low",
  "successMessage": "string",
  "failureMessage": "string",
  "events": EventDto[],
  "statThresholds": CardStatThreshold[]
}
```

### EventDto
```json
{
  "name": "string",
  "weekrange": { "min": 1, "max": 3 },
  "message": "string",
  "chance": 0.2,
  "motivationDelta": 0,
  "stressDelta": 0,
  "performanceDelta": 0,
  "turnoverDelta": 0
}
```

### CardStatThreshold
```json
{
  "statName": "Motivation",
  "condition": Above, // enum Above, Below
  "threshold": 60,
  "penaltyAmount": 0.15
}
```


### ThresholdsDTO
```json
{
  "baseXP": 2000,
  "exponent": 2.0,
  "xpPerTurn": 50,
  "xpBonusGoodDecision": 25,
  "maxLevel": 20
}
```

### DefeatConditionsDTO
```json
{
  "stress": { "min": 0, "max": 85 },
  "turnover": { "min": 0, "max": 80 },
  "performance": { "min": 15, "max": 100 },
  "motivation": { "min": 0, "max": 100 }
}
```

### StatsInitDTO
```json
{
  "InitialMotivation": 50,
  "InitialStress": 30,
  "InitialPerformance": 40,
  "InitialTurnover": 20
}
```

---

## Authentication

All endpoints (other than the /health) are protected by an API Key passed in the request header to restrict the api being available in the web browser.

Admin endpoints are protected by an API Key passed in the request header.

---

## Known Limitations

- `SystemInfo.deviceUniqueIdentifier` on Android 10+ resets on app reinstall — player progression is lost if the app is uninstalled
- No real authentication for players — device ID only
