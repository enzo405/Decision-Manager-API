using System.Diagnostics;

using DecisionManagerAPI.Attributes;

namespace DecisionManagerAPI.Triggers.Middleware;

public class ApiMiddleware(RequestDelegate next, IConfiguration configuration)
{
  private const string ApiKeyHeader = "X-Api-Key";
  private const string AdminApiKeyHeader = "X-Admin-Key";
  private readonly IConfiguration _configuration = configuration;

  public async Task InvokeAsync(HttpContext context)
  {
    // Health check toujours accessible
    if (context.Request.Path == "/health")
    {
      await next(context);
      return;
    }

    // Vérification API Key sur toutes les requêtes
    if (!context.Request.Headers.TryGetValue(ApiKeyHeader, out var apiKey) ||
        apiKey != _configuration["API_KEY"])
    {
      context.Response.StatusCode = StatusCodes.Status401Unauthorized;
      await context.Response.WriteAsJsonAsync(new { error = "Unauthorized." });
      return;
    }

    // Vérifie l'Admin Key sur les endpoints protégés
    var endpoint = context.GetEndpoint();
    var isAdminOnly = endpoint?.Metadata.GetMetadata<AdminOnlyAttribute>() != null;
    if (isAdminOnly)
    {
      if (!context.Request.Headers.TryGetValue(AdminApiKeyHeader, out var adminKey) ||
          adminKey != _configuration["ADMIN_API_KEY"])
      {
        context.Response.StatusCode = StatusCodes.Status401Unauthorized;
        await context.Response.WriteAsJsonAsync(new { error = "Unauthorized." });
        return;
      }
    }

    await next(context);
  }
}
