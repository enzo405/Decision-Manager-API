using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DecisionManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class RenameStatThresholdAndAddUnlockStatThreshold : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardRiskStatThresholds",
                schema: "decision_manager",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CardId = table.Column<int>(type: "integer", nullable: false),
                    StatName = table.Column<int>(type: "integer", nullable: false),
                    Condition = table.Column<int>(type: "integer", nullable: false),
                    Threshold = table.Column<int>(type: "integer", nullable: false),
                    PenaltyAmount = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardRiskStatThresholds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardRiskStatThresholds_Cards_CardId",
                        column: x => x.CardId,
                        principalSchema: "decision_manager",
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            
            migrationBuilder.CreateIndex(
                name: "IX_CardRiskStatThresholds_CardId",
                schema: "decision_manager",
                table: "CardRiskStatThresholds",
                column: "CardId");

            migrationBuilder.Sql(
"""

INSERT INTO "decision_manager"."CardRiskStatThresholds" ("Id", "CardId", "StatName", "Condition", "Threshold", "PenaltyAmount")
SELECT "Id", "CardId", "StatName", "Condition", "Threshold", "PenaltyAmount" FROM "decision_manager"."CardStatThresholds";

"""
            );

            migrationBuilder.DropTable(
                name: "CardStatThresholds",
                schema: "decision_manager");

            migrationBuilder.CreateTable(
                name: "CardUnlockStatThresholds",
                schema: "decision_manager",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CardId = table.Column<int>(type: "integer", nullable: false),
                    StatName = table.Column<int>(type: "integer", nullable: false),
                    Condition = table.Column<int>(type: "integer", nullable: false),
                    Threshold = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardUnlockStatThresholds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardUnlockStatThresholds_Cards_CardId",
                        column: x => x.CardId,
                        principalSchema: "decision_manager",
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardUnlockStatThresholds_CardId",
                schema: "decision_manager",
                table: "CardUnlockStatThresholds",
                column: "CardId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardRiskStatThresholds",
                schema: "decision_manager");

            migrationBuilder.DropTable(
                name: "CardUnlockStatThresholds",
                schema: "decision_manager");

            migrationBuilder.CreateTable(
                name: "CardStatThresholds",
                schema: "decision_manager",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CardId = table.Column<int>(type: "integer", nullable: false),
                    Condition = table.Column<int>(type: "integer", nullable: false),
                    PenaltyAmount = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    StatName = table.Column<int>(type: "integer", nullable: false),
                    Threshold = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardStatThresholds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardStatThresholds_Cards_CardId",
                        column: x => x.CardId,
                        principalSchema: "decision_manager",
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardStatThresholds_CardId",
                schema: "decision_manager",
                table: "CardStatThresholds",
                column: "CardId");
        }
    }
}
