using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DecisionManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialisationDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Slug = table.Column<string>(type: "text", nullable: false),
                    DisplayName = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    RequiredLevel = table.Column<int>(type: "integer", nullable: false),
                    SuccessProbability = table.Column<float>(type: "real", nullable: false),
                    MotivationEffect = table.Column<int>(type: "integer", nullable: false),
                    StressEffect = table.Column<int>(type: "integer", nullable: false),
                    PerformanceEffect = table.Column<int>(type: "integer", nullable: false),
                    TurnoverEffect = table.Column<int>(type: "integer", nullable: false),
                    MotivationEffectOnFailure = table.Column<int>(type: "integer", nullable: false),
                    StressEffectOnFailure = table.Column<int>(type: "integer", nullable: false),
                    PerformanceEffectOnFailure = table.Column<int>(type: "integer", nullable: false),
                    TurnoverEffectOnFailure = table.Column<int>(type: "integer", nullable: false),
                    RiskLevel = table.Column<int>(type: "integer", nullable: false),
                    SuccessMessage = table.Column<string>(type: "text", nullable: false),
                    FailureMessage = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DefeatConditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StressMin = table.Column<int>(type: "integer", nullable: false),
                    StressMax = table.Column<int>(type: "integer", nullable: false),
                    TurnoverMin = table.Column<int>(type: "integer", nullable: false),
                    TurnoverMax = table.Column<int>(type: "integer", nullable: false),
                    PerformanceMin = table.Column<int>(type: "integer", nullable: false),
                    PerformanceMax = table.Column<int>(type: "integer", nullable: false),
                    MotivationMin = table.Column<int>(type: "integer", nullable: false),
                    MotivationMax = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefeatConditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameConfigs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BaseXP = table.Column<int>(type: "integer", nullable: false),
                    Exponent = table.Column<float>(type: "real", nullable: false),
                    XPPerTurn = table.Column<int>(type: "integer", nullable: false),
                    XPBonusGoodDecision = table.Column<int>(type: "integer", nullable: false),
                    MaxLevel = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameConfigs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DeviceId = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EventName = table.Column<string>(type: "text", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: false),
                    Chance = table.Column<float>(type: "real", nullable: false),
                    WeekRangeMin = table.Column<int>(type: "integer", nullable: false),
                    WeekRangeMax = table.Column<int>(type: "integer", nullable: false),
                    MotivationDelta = table.Column<int>(type: "integer", nullable: false),
                    StressDelta = table.Column<int>(type: "integer", nullable: false),
                    PerformanceDelta = table.Column<int>(type: "integer", nullable: false),
                    TurnoverDelta = table.Column<int>(type: "integer", nullable: false),
                    CardId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Progressions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CurrentXP = table.Column<int>(type: "integer", nullable: false),
                    CurrentLevel = table.Column<int>(type: "integer", nullable: false),
                    PlayerId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Progressions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Progressions_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DefeatConditions",
                columns: new[] { "Id", "MotivationMax", "MotivationMin", "PerformanceMax", "PerformanceMin", "StressMax", "StressMin", "TurnoverMax", "TurnoverMin" },
                values: new object[] { 1, 100, 0, 100, 15, 85, 0, 80, 0 });

            migrationBuilder.InsertData(
                table: "GameConfigs",
                columns: new[] { "Id", "BaseXP", "Exponent", "MaxLevel", "XPBonusGoodDecision", "XPPerTurn" },
                values: new object[] { 1, 2000, 2f, 20, 25, 50 });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_Slug",
                table: "Cards",
                column: "Slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_CardId",
                table: "Events",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_DeviceId",
                table: "Players",
                column: "DeviceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Progressions_PlayerId",
                table: "Progressions",
                column: "PlayerId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DefeatConditions");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "GameConfigs");

            migrationBuilder.DropTable(
                name: "Progressions");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
