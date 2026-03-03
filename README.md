# DecisionManager API

REST API for the [Decision Manager](https://github.com/your-username/DecisionManager) serious game — a mobile management simulation game built with Unity.

Handles player progression, card configuration, game settings and random events. Designed to allow remote configuration of game mechanics without requiring a game update.

---

## Tech Stack

- **Framework** : ASP.NET Core 9
- **Database** : PostgreSQL
- **ORM** : Entity Framework Core
- **Admin UI** : Blazor Server
- **Containerization** : Docker / Docker Compose

---


## Endpoints

### Player Endpoints
| Method | Endpoint | Description | Request Body | Response |
|---|---|---|---|---|
| `POST` | `/api/players` | Créer un joueur | `{ deviceId: string }` | `PlayerDTO` |
| `GET` | `/api/players/{deviceId}` | Récupérer un joueur | — | `PlayerDTO` |
| `GET` | `/api/players/{deviceId}/progression` | Récupérer XP et niveau | — | `ProgressionDTO` |
| `PUT` | `/api/players/{deviceId}/progression` | Mettre à jour XP et niveau | `UpdateProgressionDTO` | `ProgressionDTO` |

### Cards Endpoints
| Method | Endpoint | Description | Request Body | Response |
|---|---|---|---|---|
| `GET` | `/api/cards` | Récupérer toutes les cartes | — | `CardDTO[]` |
| `GET` | `/api/cards?level={userLevel}` | Récupérer les cartes débloquées | — | `CardDTO[]` |

### Game Config Endpoints
| Method | Endpoint | Description | Request Body | Response |
|---|---|---|---|---|
| `GET` | `/api/config/thresholds` | Récupérer les seuils | — | `ThresholdsDTO` |
| `PUT` | `/api/config/thresholds` | Modifier les seuils | `ThresholdsDTO` | `ThresholdsDTO` |
| `GET` | `/api/config/defeat-conditions` | Récupérer les conditions de défaite | — | `DefeatConditionsDTO` |
| `PUT` | `/api/config/defeat-conditions` | Modifier les conditions de défaite | `DefeatConditionsDTO` | `DefeatConditionsDTO` |
| `GET` | `/api/config/level/title?level={userLevel}` | Récupérer le titre du niveau | — | `string` |

### Random Events Endpoints
| Method | Endpoint | Description | Request Body | Response |
|---|---|---|---|---|
| `GET` | `/api/events/roll?level={userLevel}` | Tirer un événement aléatoire | — | `RandomEventDTO?` |
| `GET` | `/api/events` | Récupérer tous les événements | — | `RandomEventDTO[]` |

---

## DTOs

### PlayerDTO
```json
{
  "deviceId": "string",
  "createdAt": "datetime"
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
  "name": "string",
  "cardName": "string",
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
  "failureMessage": "string"
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

### RandomEventDTO
```json
{
  "message": "string",
  "motivationDelta": 0,
  "stressDelta": 0,
  "performanceDelta": 0,
  "turnoverDelta": 0
}
```

---

## Authentication

Admin endpoints (`PUT`) are protected by an API Key passed in the request header :

```
X-Admin-Key: your-secret-admin-key
```

Unity client endpoints (`GET`, `POST`) are public.

---

## Known Limitations

- `SystemInfo.deviceUniqueIdentifier` on Android 10+ resets on app reinstall — player progression is lost if the app is uninstalled
- No real authentication for players — device ID only
- Admin UI requires direct network access to the API