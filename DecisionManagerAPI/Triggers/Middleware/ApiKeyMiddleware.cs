using DecisionManagerAPI.Attributes;

namespace DecisionManagerAPI.Triggers.Middleware;

public class ApiKeyMiddleware(RequestDelegate next, IConfiguration configuration)
{
  private const string ApiKeyHeader = "X-Admin-Key";
  private readonly IConfiguration _configuration = configuration;

  public async Task InvokeAsync(HttpContext context)
  {
    var endpoint = context.GetEndpoint();
    var isAdminOnly = endpoint?.Metadata.GetMetadata<AdminOnlyAttribute>() != null;

    if (isAdminOnly)
    {
      if (!context.Request.Headers.TryGetValue(ApiKeyHeader, out var key) ||
          key != _configuration["AdminApiKey"])
      {
        context.Response.StatusCode = StatusCodes.Status401Unauthorized;
        await context.Response.WriteAsJsonAsync(new { error = "Unauthorized." });
        return;
      }
    }

    await next(context);
  }
}
