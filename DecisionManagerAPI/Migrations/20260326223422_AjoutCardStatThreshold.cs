using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DecisionManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class AjoutCardStatThreshold : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardStatThreshold",
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
                    table.PrimaryKey("PK_CardStatThreshold", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardStatThreshold_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardStatThreshold_CardId",
                table: "CardStatThreshold",
                column: "CardId");

            #region Seeding

            migrationBuilder.Sql(
"""

INSERT INTO "CardStatThreshold" ("Id", "CardId", "StatName", "Condition", "Threshold", "PenaltyAmount") 
VALUES 
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'team-meeting'), 0, 0, 65, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'team-meeting'), 1, 1, 25, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'ambitious-goals'), 0, 0, 70, 0.20),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'ambitious-goals'), 3, 1, 25, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'professional-training'), 2, 0, 55, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'professional-training'), 1, 1, 20, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'exceptional-bonus'), 3, 1, 30, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'exceptional-bonus'), 2, 0, 65, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'conflict-mediation'), 0, 0, 75, 0.20),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'conflict-mediation'), 1, 1, 20, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'flexible-remote-work'), 2, 0, 60, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'flexible-remote-work'), 0, 0, 70, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'team-restructuring'), 1, 1, 30, 0.20),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'team-restructuring'), 2, 0, 55, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'team-restructuring'), 0, 0, 65, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'individual-feedback'), 0, 0, 70, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'individual-feedback'), 1, 1, 25, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'collective-break'), 3, 1, 20, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'crisis-management'), 0, 0, 80, 0.20),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'crisis-management'), 1, 1, 20, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'crisis-management'), 2, 0, 70, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'quick-wins'), 1, 1, 25, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'quick-wins'), 0, 0, 75, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'one-on-one'), 0, 0, 75, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'skills-audit'), 1, 1, 25, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'skills-audit'), 2, 0, 60, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'team-charter'), 2, 0, 55, 0.20),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'team-charter'), 1, 1, 30, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'recognition-program'), 3, 1, 25, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'recognition-program'), 0, 0, 70, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'mentoring-session'), 2, 0, 60, 0.20),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'mentoring-session'), 1, 1, 20, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'workspace-reorganization'), 0, 0, 65, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'workspace-reorganization'), 1, 1, 25, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'performance-review'), 0, 0, 70, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'performance-review'), 2, 0, 60, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'cross-team-project'), 1, 1, 30, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'cross-team-project'), 2, 0, 55, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'wellness-program'), 0, 0, 85, 0.20),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'job-rotation'), 2, 0, 60, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'job-rotation'), 1, 1, 25, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'internal-communication'), 0, 0, 70, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'internal-communication'), 2, 0, 65, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'delegation-plan'), 3, 1, 30, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'delegation-plan'), 0, 0, 70, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'team-retrospective'), 1, 1, 20, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'team-retrospective'), 0, 0, 75, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'peer-review'), 2, 0, 55, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'peer-review'), 0, 0, 70, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'succession-planning'), 2, 0, 65, 0.20),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'succession-planning'), 1, 1, 25, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'agile-transformation'), 0, 0, 60, 0.20),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'agile-transformation'), 1, 1, 35, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'agile-transformation'), 2, 0, 50, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'talent-retention-plan'), 2, 0, 70, 0.25),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'talent-retention-plan'), 1, 1, 20, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'strategic-retreat'), 0, 0, 75, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'strategic-retreat'), 3, 1, 20, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'process-optimization'), 1, 1, 30, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'process-optimization'), 0, 0, 65, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'leadership-development'), 2, 0, 60, 0.20),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'leadership-development'), 1, 1, 25, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'merger-integration'), 0, 0, 60, 0.20),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'merger-integration'), 2, 0, 55, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'merger-integration'), 1, 1, 30, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'remote-first-policy'), 2, 0, 60, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'remote-first-policy'), 0, 0, 70, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'culture-revamp'), 1, 1, 25, 0.20),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'culture-revamp'), 2, 0, 65, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'culture-revamp'), 0, 0, 70, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'innovation-lab'), 1, 1, 35, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'innovation-lab'), 3, 1, 30, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'executive-coaching'), 2, 0, 65, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'executive-coaching'), 0, 0, 75, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'zero-tolerance'), 1, 1, 30, 0.20),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'zero-tolerance'), 0, 0, 70, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'autonomy-framework'), 3, 1, 30, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'autonomy-framework'), 1, 1, 25, 0.10),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'purpose-driven-strategy'), 1, 1, 25, 0.20),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'purpose-driven-strategy'), 3, 1, 25, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'predictive-analytics'), 0, 0, 70, 0.15),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'predictive-analytics'), 2, 0, 60, 0.10);
"""
            );

            #endregion
            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardStatThreshold");
        }
    }
}
