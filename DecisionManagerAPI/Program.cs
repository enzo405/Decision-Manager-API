using DecisionManagerAPI.Data;
using DecisionManagerAPI.Data.Repository;
using DecisionManagerAPI.Triggers.Middleware;

using DotNetEnv;

using Microsoft.EntityFrameworkCore;

Env.Load(".env");

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Database
builder.Services.AddDbContext<DecisionManagerDbContext>(options =>
    options.UseNpgsql(Environment.GetEnvironmentVariable("POSTGRES_CONNECTION")));

// Repositories
builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();
builder.Services.AddScoped<IProgressionRepository, ProgressionRepository>();
builder.Services.AddScoped<ICardRepository, CardRepository>();
builder.Services.AddScoped<IGameConfigRepository, GameConfigRepository>();
builder.Services.AddScoped<ICardComboRepository, CardComboRepository>();

var app = builder.Build();
app.MapGet("/health", () => Results.Ok(new { status = "healthy" }));

// Auto migrate on startup
using (var scope = app.Services.CreateScope())
{
  var db = scope.ServiceProvider.GetRequiredService<DecisionManagerDbContext>();
  await db.Database.MigrateAsync();
}

app.UseMiddleware<ApiMiddleware>();
app.MapControllers();
await app.RunAsync();
